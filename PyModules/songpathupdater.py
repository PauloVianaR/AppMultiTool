import os
import pymssql

# Função para conectar ao banco de dados
def conectar_banco():
    # Substitua com os dados corretos da sua conexão
    conn = pymssql.connect(server='localhost', 
                           user='root', 
                           password='Relapa123635241987$', 
                           database='appmultitool')
    return conn

# Função principal para renomear os arquivos e atualizar o banco de dados
def renomear_musicas():
    conn = conectar_banco()
    cursor = conn.cursor()

    # Consulta para obter as músicas e seus caminhos
    cursor.execute("SELECT idsong, name_song, path FROM songs")

    # Iterar por todas as músicas no banco
    for row in cursor.fetchall():
        idsong = row[0]
        name_song = row[1]
        path = row[2]

        # Obtém o diretório do arquivo e o novo nome
        directory = os.path.dirname(path)  # Diretório onde o arquivo está
        new_file_name = os.path.join(directory, f"{name_song}{os.path.splitext(path)[1]}")  # Novo caminho completo

        try:
            # Verifica se o arquivo existe
            if os.path.exists(path):
                # Renomeia o arquivo
                os.rename(path, new_file_name)
                print(f"Arquivo renomeado com sucesso: {path} -> {new_file_name}")

                # Atualiza o caminho no banco de dados
                cursor.execute("UPDATE songs SET path = %s WHERE idsong = %d", (new_file_name, idsong))
                conn.commit()
                print(f"Caminho atualizado no banco de dados para {new_file_name}")
            else:
                print(f"Arquivo não encontrado: {path}")
        except Exception as e:
            print(f"Erro ao processar o arquivo {path}: {e}")

    cursor.close()
    conn.close()

# Executar a função
if __name__ == "__main__":
    renomear_musicas()
