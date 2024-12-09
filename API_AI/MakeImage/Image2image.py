import json
import os
import time
import random
import gradio as gr
import numpy as np
import requests

from googletrans import Translator
from PIL import Image

URL = "http://127.0.0.1:8188/prompt"
INPUT_DIR = "D:\\ProjectWinform\\App_TT\\WEB_APP_QLKS\\TT_QLKS\\QLKS\\API_AI\\MakeImage\\Input_AI"
ERROR = "D:\\ProjectWinform\\App_TT\\WEB_APP_QLKS\\TT_QLKS\\QLKS\\API_AI\\img"
OUTPUT_DIR = "D:\\ProjectWinform\\App_TT\\WEB_APP_QLKS\\TT_QLKS\\QLKS\\API_AI\\MakeImage\\Output_AI"

cached_seed = 0
max_time = 5000
elapsed_time = 0

def get_latest_image(folder):
    files = os.listdir(folder)
    image_files = [f for f in files if f.lower().endswith(('.png', '.jpg', '.jpeg'))]
    image_files.sort(key=lambda x: os.path.getmtime(os.path.join(folder, x)))
    latest_image = os.path.join(folder, image_files[-1]) if image_files else None
    return latest_image
def start_queue(prompt_workflow):
    p = {"prompt": prompt_workflow}
    data = json.dumps(p).encode('utf-8')
    requests.post(URL, data=data)
def generate_random_seed():
    return random.randint(10000000000, 99999999999)
def update_seed():
        new_seed = generate_random_seed()
        return new_seed
def check_inputs(prompt, input_image):
    return gr.Button(interactive=True) if prompt and input_image is not None else gr.Button(interactive=False)
def generate_image(input_image, seed_input, width_input, height_input, prompt_text, lora_dropdown):
    error_image_path = os.path.join(ERROR, "error.jpg")
    try:
        with open("Image2Image.json", "r", encoding="utf-8") as file_json:
            prompt = json.load(file_json)

        translator = Translator()
        translated = translator.translate(prompt_text, src='vi', dest='en')

        if(lora_dropdown == "Phòng ngủ"):
            prompt["22"]["inputs"]["lora_name"] = "JJsBedroom_XL.safetensors"
        elif(lora_dropdown == "Phòng tắm"):
            prompt["22"]["inputs"]["lora_name"] = "JJsBathroom_XL.safetensors"
        elif(lora_dropdown == "Phòng khách"):
            prompt["22"]["inputs"]["lora_name"] = "JJsLivingRoom_XL.safetensors"

        prompt["39"]["inputs"]["image"] = os.path.join(INPUT_DIR, "Test_api.png")
        prompt["37"]["inputs"]["file_path"] = OUTPUT_DIR
        prompt["12"]["inputs"]["noise_seed"] = seed_input
        prompt["11"]["inputs"]["width"] = width_input
        prompt["11"]["inputs"]["height"] = height_input
        prompt["30"]["inputs"]["text_a"] = translated.text
            
        image = Image.fromarray(input_image)
        min_side = min(image.size)
        scale_factor = 512 / min_side
        new_size = (round(image.size[0] * scale_factor), round(image.size[1] * scale_factor))
        resized_image = image.resize(new_size)

        resized_image.save(os.path.join(INPUT_DIR, "Test_api.png"))

        previous_image = get_latest_image(OUTPUT_DIR)
        start_queue(prompt)

        global elapsed_time
        while True:
            latest_image = get_latest_image(OUTPUT_DIR)
            if latest_image != previous_image:
                return np.array(Image.open(latest_image))
            elapsed_time += 10
            time.sleep(2)
            if elapsed_time >= max_time:
                return np.array(Image.open(error_image_path))
                
    except Exception as e:
        print("An error occurred:", str(e))
        return np.array(Image.open(error_image_path))

css = """
.markdown-spacing {
    margin-bottom: 20px; 
}
.spacing{
    margin-bottom: 10px;
}
"""

with gr.Blocks(title="Tạo hình ảnh phòng từ gợi ý ảnh phòng của bạn", theme='ParityError/Interstellar', css=css) as demo:
     gr.Markdown("# AI tạo hình ảnh phòng từ gợi ý ảnh phòng của bạn", elem_classes="markdown-spacing")
     
     # Phần thiết kế giao diện
     with gr.Row():
        with gr.Column():
            lora_dropdown = gr.Dropdown(label="Lựa chọn loại phòng", choices=["Phòng ngủ", "Phòng tắm", "Phòng khách"], interactive=True)
            prompt_text = gr.Textbox(label="Mô tả của bạn", placeholder="Một phòng đơn, giường ngủ...", lines=5)
            width_slider = gr.Slider(label="Chiều rộng", value=512, maximum=1024, minimum=256, step=64)
            height_slider = gr.Slider(label="Chiều cao", value=768, maximum=1024, minimum=256, step=64)
            seed_number = gr.Number(label="Seed", value=99123456999)
            random_seed_btn = gr.Button("Tạo seed")
            gr.Markdown("#### Lưu ý: nếu Seed vẫn giữ nguyên thì ảnh tạo ra sẽ giống nhau!", elem_classes="markdown-spacing")
        with gr.Column():
            input_image = gr.Image(label="Tải ảnh lên", type="numpy", height=512, width=768)
     submit_btn = gr.Button("Tạo ảnh", interactive=False)
     with gr.Row():
        output_image = gr.Image(label="Ảnh đầu ra", height=512, width=768)
     gr.Markdown('#### Phát triển bởi Khôi Trần', )
     gr.Markdown("#### Đang trong quá trình phát triển nên vẫn có lỗi!", elem_classes="markdown-spacing")

     # Phần xử lý click
     prompt_text.change(
        fn=check_inputs, 
        inputs=[prompt_text, input_image],
        outputs=submit_btn
     )
     input_image.input(
        fn=check_inputs, 
        inputs=[prompt_text, input_image],
        outputs=submit_btn
     )
     random_seed_btn.click(
        update_seed,
        outputs=seed_number
     )
     
     submit_btn.click(
        fn=generate_image,
        inputs=[input_image, seed_number, width_slider, height_slider, prompt_text, lora_dropdown],
        outputs=output_image
     )
     
if __name__ == "__main__":
    demo.launch(share=False, show_api=False)