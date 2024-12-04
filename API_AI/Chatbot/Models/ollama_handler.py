import requests

def query_ollama(model, prompt):
    url = f"http://localhost:11434/api/chat"
    headers = {"Content-Type": "application/json"}
    data = {
        "model": model,
        "messages": [{"role": "user", "content": prompt}],
        "stream": False  
    }
    
    with requests.Session() as session:
        response = session.post(url, headers=headers, json=data)
        
    if response.status_code == 200:
        return response.json()['message']['content']
    else:
        return f"Lỗi kết nối đến Ollama: {response.status_code}"
