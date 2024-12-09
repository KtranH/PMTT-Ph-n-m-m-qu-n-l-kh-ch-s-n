from llm_axe import OnlineAgent, OllamaChat, Agent

llm = OllamaChat(model="llama3.2:3b")
online_agent = OnlineAgent(llm)

agent = Agent(llm, custom_system_prompt="Hãy trả lời câu hỏi của tôi một cách rõ ràng và chính xác.")

prompt = "Who is the President of Vietnam 2024?"
resp = online_agent.search(prompt)
#resp = agent.ask(prompt)

print("Raw Response: ", resp)
