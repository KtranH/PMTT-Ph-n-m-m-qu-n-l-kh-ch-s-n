import gradio as gr
from Models.chat_handler import handle_chat, memory


def clear_conversation():
    memory.reset_memory()  
    return [], ""  

with gr.Blocks(theme=gr.themes.Soft()) as demo:
    gr.Markdown("# 🏨 Trợ Lý Khách Sạn")
    gr.Markdown("*Hỗ trợ đặt phòng và dịch vụ 24/7*")

    chatbot = gr.Chatbot(
        label="Trò Chuyện Với Trợ Lý",
        height=800,  
        bubble_full_width=False,  
        layout='bubble',
        type='messages'
    )

    with gr.Row():
        input_text = gr.Textbox(
            placeholder="Nhập câu hỏi của bạn về khách sạn...", 
            container=False,
            scale=8  
        )

        submit = gr.Button(
            "📨 Gửi", 
            variant="primary",
        )

    submit.click(
        fn=handle_chat,
        inputs=[input_text],
        outputs=[chatbot, input_text], 
        api_name="chat"
    )

    input_text.submit(
        fn=handle_chat,
        inputs=[input_text],
        outputs=[chatbot, input_text],
        api_name="chat"
    )

    clear = gr.Button("Bắt Đầu Lại", variant="secondary")
    clear.click(
        fn=clear_conversation, 
        inputs=None, 
        outputs=[chatbot, input_text], 
        queue=False
    )

demo.launch(
    show_error=True, 
    share=False       
)
