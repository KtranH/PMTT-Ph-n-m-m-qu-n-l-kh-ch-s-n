import gradio as gr
import pandas as pd
import numpy as np
import random
import requests
import json
import os
import time

from googletrans import Translator
from PIL import Image

URL = "http://127.0.0.1:8188/api/prompt"
INPUT_DIR = "D:\ProjectWinform\App_TT\WEB_APP_QLKS\TT_QLKS\QLKS\API_AI\img\AI_img\Input"
INPUT_ERROR = "D:\ProjectWinform\App_TT\WEB_APP_QLKS\TT_QLKS\QLKS\API_AI\img"
OUTPUT_DIR = "D:\ProjectWinform\App_TT\WEB_APP_QLKS\TT_QLKS\QLKS\API_AI\img\AI_img\Output"

cached_seed = 0

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
    return random.randint(1000000000, 9999999999)

def generate_image(Positive_Prompt, Seed, Width, Height):
    try:
        with open("avatar.json", "r", encoding="utf-8") as file_json:
            prompt = json.load(file_json)

            translator = Translator()
            translated = translator.translate(Positive_Prompt, src='vi', dest='en').text

            prompt["22"]["inputs"]["text_a"] = translated
            prompt["25"]["inputs"]["file_path"] = OUTPUT_DIR
            prompt["19"]["inputs"]["noise_seed"] = Seed
            prompt["18"]["inputs"]["width"] = Width
            prompt["18"]["inputs"]["height"] = Height

            previous_image = get_latest_image(OUTPUT_DIR)
            
            start_queue(prompt)

            while True:
                latest_image = get_latest_image(OUTPUT_DIR)
                if latest_image != previous_image:
                    return latest_image
                time.sleep(2)

    except Exception as e:
        error_image_path = os.path.join(INPUT_ERROR, "error.jpg")
        print("An error occurred:", str(e))
        return error_image_path

with gr.Blocks(theme=gr.themes.Base()) as demo:
    gr.Markdown("# Công cụ tạo ảnh avatar cùng Khách Sạn GTX")
    
    with gr.Row():
        # Cột input
        with gr.Column():
            description_input = gr.Textbox(
                label="Nhập mô tả",
                placeholder="Nhập mô tả cho ảnh của bạn...",
                lines=9
            )
            
            with gr.Row():
                width_input = gr.Slider(
                    minimum=100,
                    maximum=900,
                    value=500,
                    step=10,
                    label="Chiều rộng",
                    interactive=True
                )
                height_input = gr.Slider(
                    minimum=100,
                    maximum=900,
                    value=500,
                    step=10,
                    label="Chiều dài",
                    interactive=True
                )
            
            with gr.Row():
                seed_input = gr.Number(
                    label="Seed",
                    value=3228926926,
                    interactive=True
                )
                random_seed_btn = gr.Button("🎲 Random Seed", size="sm")
            
            generate_btn = gr.Button("🎨 Tạo ảnh", variant="primary", size="lg")
                    
        # Cột output
        with gr.Column():
            image_output = gr.Image(
                label="Ảnh được tạo",
                type="pil"
            )

    # Xử lý sự kiện khi nhấn nút random seed
    def update_seed():
        new_seed = generate_random_seed()
        return new_seed
    
    random_seed_btn.click(
        update_seed,
        outputs=seed_input
    )
    
    # Xử lý sự kiện khi nhấn nút tạo ảnh
    generate_btn.click(
        generate_image,
        inputs=[
            description_input,
            seed_input,
            width_input,
            height_input
        ],
        outputs=image_output
    )

demo.launch()
