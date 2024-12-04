class MemoryManager:
    def __init__(self, max_memory=10):
        self.max_memory = max_memory
        self.chat_memory = []

    def add_message(self, role, message):
        self.chat_memory.append({"role": role, "message": message})
        if len(self.chat_memory) > self.max_memory:
            self.chat_memory.pop(0)

    def get_memory(self):
        return self.chat_memory

    def reset_memory(self):
        self.chat_memory = []
