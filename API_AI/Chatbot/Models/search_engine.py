from googlesearch import search
import requests
from bs4 import BeautifulSoup

def get_page_title_and_description(url):
    try:
        headers = {
            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36"
        }
        response = requests.get(url, headers=headers, verify=False)
        response.raise_for_status()  
        soup = BeautifulSoup(response.content, "html.parser")

        title = soup.title.string if soup.title else "Không có tiêu đề"

        description_tag = soup.find("meta", attrs={"name": "description"})
        description = description_tag["content"] if description_tag else "Không có mô tả"

        return title, description
    except requests.exceptions.RequestException as e:
        print(f"Error fetching URL: {url}, error: {e}")
        return None, None

def get_search_results_descriptions(query, num_results=3):
    results = []
    for url in search(query, num_results=num_results, lang="vi"):
        title, description = get_page_title_and_description(url)
        results.append({"url": url, "title": title, "description": description})
    return results
