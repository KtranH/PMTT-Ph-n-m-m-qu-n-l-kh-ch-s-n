import json
from decimal import Decimal
from googlesearch import search
from Models.memory_manager import MemoryManager
from Models.database_handler import get_sql_data
from Models.ollama_handler import query_ollama
from Models.search_engine import search_web
from functools import lru_cache
from concurrent.futures import ThreadPoolExecutor

memory = MemoryManager(max_memory=10)

@lru_cache(maxsize=100) 
def search_web_cached(query, num_results=2):
    return search_web(query, num_results)

def decimal_to_float(obj):
    if isinstance(obj, Decimal):
        return float(obj)
    elif isinstance(obj, dict):
        return {key: decimal_to_float(value) for key, value in obj.items()}
    elif isinstance(obj, list):
        return [decimal_to_float(item) for item in obj]
    return obj  

def handle_chat(user_input, is_new_session=False):
    if is_new_session:
        memory.clear_memory()

    memory.add_message("user", user_input)

    conversation_history = memory.get_memory()

    room_keywords = ["phòng", "giá phòng", "đặt phòng", "loại phòng"]
    service_keywords = ["dịch vụ", "giá dịch vụ"]
    search_keywords = ["tìm kiếm", "trên mạng", "xu hướng", "thống kê", "báo cáo"]

    input_data = {"question": user_input}

    if any(keyword in user_input.lower() for keyword in room_keywords):
        if "số lượng phòng của từng loại phòng" in user_input.lower():
            room_data_query = "SELECT DISTINCT LOAIPHONG.TENLOAIPHONG FROM PHONG JOIN LOAIPHONG ON PHONG.LOAIPHONG_ID = LOAIPHONG.ID"
        elif "số lượng phòng" in user_input.lower():
            room_data_query = "SELECT LOAIPHONG.TENLOAIPHONG, COUNT(PHONG.ID) AS so_luong_phong FROM PHONG JOIN LOAIPHONG ON PHONG.LOAIPHONG_ID = LOAIPHONG.ID GROUP BY LOAIPHONG.TENLOAIPHONG"
        elif "tình trạng phòng" in user_input.lower() or "đã thuê" in user_input.lower() or "còn trống" in user_input.lower():
            room_data_query = "SELECT * FROM PHONG WHERE TRANGTHAI = 'Còn trống'"
        elif "giá" in user_input.lower():
            room_data_query = "SELECT TENLOAIPHONG, GIATHUE FROM LOAIPHONG" 
        elif "tiện ích phòng" in user_input.lower():
            room_data_query = "SELECT TENPHONG, TIENICH FROM PHONG WHERE TIENICH LIKE '%wifi%'"
        elif "quy định phòng" in user_input.lower():
            room_data_query = "SELECT TENPHONG, QUYDINH FROM PHONG WHERE QUYDINH LIKE '%Không hút thuốc%'"
        else:
            room_data_query = "SELECT * FROM PHONG JOIN LOAIPHONG ON PHONG.LOAIPHONG_ID = LOAIPHONG.ID"
        
        room_data = get_sql_data(room_data_query)
        input_data["rooms"] = [decimal_to_float(room) for room in room_data]

    if any(keyword in user_input.lower() for keyword in service_keywords):
        service_data_query = "SELECT * FROM DICHVU"
        service_data = get_sql_data(service_data_query)
        input_data["services"] = [decimal_to_float(service) for service in service_data]

    web_results = None
    if any(keyword in user_input.lower() for keyword in search_keywords):
        web_results = search_web_cached(user_input, num_results=2)
        input_data["web_results"] = web_results

    prompt_parts = []
    for msg in conversation_history:
        role = msg["role"]  # user or bot
        content = msg["message"]
        if role == "user":
            prompt_parts.append(f"User: {content}")
        elif role == "bot":
            prompt_parts.append(f"Bot: {content}")

    prompt_parts.append(f"User: {user_input}")
    if "rooms" in input_data:
        prompt_parts.append(f"Dữ liệu phòng: {json.dumps(input_data['rooms'], indent=2, ensure_ascii=False)}")
    if "services" in input_data:
        prompt_parts.append(f"Dữ liệu dịch vụ: {json.dumps(input_data['services'], indent=2, ensure_ascii=False)}")
    if web_results:
        prompt_parts.append(f"Kết quả tìm kiếm: {json.dumps(web_results, indent=2, ensure_ascii=False)}")

    prompt = "\n".join(prompt_parts) + "\nHãy trả lời ngắn gọn và chính xác."

    response = query_ollama("llama3.2:3b", prompt)

    if "Không biết" in response or "Không có thông tin" in response or "Không tìm thấy" in response or "Không tìm thấy đủ kết quả" in response or "Không thể" in response or "Không trả lời được" in response:
        print("Model không trả lời được. Truy cập web...")
        web_results = search_web(user_input, num_results=2)
        input_data["web_results"] = web_results
        prompt = f"Câu hỏi: {user_input}\nKết quả tìm kiếm: {json.dumps(web_results, indent=2, ensure_ascii=False)}\nHãy trả lời ngắn gọn và chính xác."
        response = query_ollama("llama3.2:1b", prompt)

    memory.add_message("bot", response)

    conversation = [
        {"role": "user", "content": msg["message"]} if msg["role"] == "user" 
        else {"role": "assistant", "content": msg["message"]} 
        for msg in memory.get_memory()
    ]

    return conversation, ""


