from pytube import YouTube
import os
import re

def sanitize_filename(filename):
    return re.sub(r'[<>:"/\\|?*]', '_', filename)

def downloadvideo(url, exitpath):
    try:
        video = YouTube(url)
        stream = video.streams.get_highest_resolution()

        sanitized_title = sanitize_filename(video.title)
        
        if not os.path.exists(exitpath):
            os.makedirs(exitpath)
        
        stream.download(output_path=exitpath, filename=sanitized_title)
        
        return sanitized_title
    
    except Exception as e:
        print(f"Erro: {e}")
        return None
    
def downloadaudio(url, exitpath):
    try:
        video = YouTube(url)
        stream = video.streams.filter(only_audio=True).first()

        # Sanitiza o título do vídeo
        sanitized_title = sanitize_filename(video.title)
        
        if not os.path.exists(exitpath):
            os.makedirs(exitpath)
        
        # Faz o download com o nome do arquivo sanitizado
        stream.download(output_path=exitpath, filename=sanitized_title)
        
        return sanitized_title
    
    except Exception as e:
        print(f"Erro: {e}")
        return None

url = input('URL: ')
exitPath = input('Caminho de saída: ')

video = downloadvideo(url,exitPath)