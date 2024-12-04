from googlesearch import search

def search_web(query, num_results=5):
    results = []
    for result in search(query, num_results=num_results, lang="vi"):
        results.append(result)

    if len(results) < 2:
        results = ["Không tìm thấy đủ kết quả liên quan."]
        
    return results
