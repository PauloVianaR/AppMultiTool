import yt_dlp
import os
import re

def sanitize_filename(filename):
    return re.sub(r'[<>:"/\\|?*]', '_', filename)

def downloadvideo(url, exitpath):
    try:
        # Define as opções para o download do vídeo
        ydl_opts = {
            'outtmpl': f'{exitpath}/%(title)s.%(ext)s',  # Define o caminho de saída
            'format': 'bestvideo+bestaudio/best',  # Baixa o melhor vídeo e áudio disponível
        }

        # Inicializa o downloader e extrai informações do vídeo
        with yt_dlp.YoutubeDL(ydl_opts) as ydl:
            info = ydl.extract_info(url, download=False)  # Extrai as informações do vídeo sem baixar
            if isinstance(info, dict) and 'title' in info:
                sanitized_title = sanitize_filename(info['title'])  # Sanitiza o título do vídeo
                ydl_opts['outtmpl'] = f'{exitpath}/{sanitized_title}.%(ext)s'  # Aplica o título sanitizado

                # Faz o download
                ydl.download([url])

                return sanitized_title
            else:
                print(f"Erro: informações do vídeo não foram obtidas corretamente. Info: {info}")
                return None

    except Exception as e:
        print(f"Erro ao baixar vídeo: {e}")
        return None

def downloadaudio(url, exitpath):
    try:
        ydl_opts = {
            'outtmpl': f'{exitpath}/%(title)s.%(ext)s',
            'format': 'bestaudio/best',
            'postprocessors': [{
                'key': 'FFmpegExtractAudio',
                'preferredcodec': 'mp3',
                'preferredquality': '192',
            }],
        }

        with yt_dlp.YoutubeDL(ydl_opts) as ydl:
            info = ydl.extract_info(url, download=False)
            sanitized_title = sanitize_filename(info['title'])
            ydl_opts['outtmpl'] = f'{exitpath}/{sanitized_title}.%(ext)s'

            ydl.download([url])

        return sanitized_title

    except Exception as e:
        print(f"Erro ao baixar áudio: {e}")
        return None

url = input('URL: ')
exitPath = input('Caminho de saída: ')

video = downloadvideo(url,exitPath)