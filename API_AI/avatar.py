import gradio as gr
import pandas as pd
import numpy as np
import random
from googletrans import Translator
from PIL import Image
import requests
import json
import os

URL = "http://127.0.0.1:8188/prompt"
INPUT_DIR = "F:\ComfyUI_windows_portable\ComfyUI\input"
INPUT_ERROR = "D:\ProjectPHP\GradioApp\img"
OUTPUT_DIR = "F:\ComfyUI_windows_portable\ComfyUI\output"
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

with gr.Blocks(theme=gr.themes.Soft(
    primary_hue="blue",
    secondary_hue="blue",
)) as demo:
    gr.Markdown("# Công cụ tạo ảnh avatar cùng Khách Sạn GTX")
    
    with gr.Row():
        # Cột input
        with gr.Column():
            description_input = gr.Textbox(
                label="Nhập mô tả",
                placeholder="Nhập mô tả cho ảnh của bạn...",
                lines=3
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
    '''generate_btn.click(
        generate_placeholder_image,
        inputs=[
            description_input,
            width_input,
            height_input,
            seed_input
        ],
        outputs=image_output
    )'''

demo.launch()
