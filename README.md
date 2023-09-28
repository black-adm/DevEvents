### CRUD com Aspnet Core 7.0 
# AwesomeDevEvents

<p align="center">
<img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white" />
<img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
<img src="https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white" />
<img src="https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white" />
<img src="https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white" />
</p>
<br>

Esse projeto foi desenvolvido com base nos estudos da playlist de **Api Rest**, presente no canal do youtube do professor [@LuisDev](https://www.youtube.com/@luisdev).

Todo *mérito* e *agradecimentos* por esse baita profissional e pelos excelentes conteúdos gratuitos produzidos para a comunidade C#.

<img src="https://i.ibb.co/xff66DT/Captura-de-tela-de-2023-09-27-20-25-48.png" />
</br>

> Como testar o projeto na sua máquina
- Clone o projeto com o comando `git clone https://github.com/black-adm/DevEvents`.

- Instale as dependências do projeto e gere as migrations do banco com o comando `dotnet ef migrations add NOME_DA_MIGRATION -o Persistence/Migrations`.

- Certifique-se de ajustar a sua `connectionString` no arquivo `appsettings.json`. Estou utilizando o `SqlServer` com o docker, você pode utilizar da maneira que achar melhor no seu ambiente.

- A aplicação lista eventos, cadastra novos eventos, cadastrar palestrantes, edita, busca e deleta eventos por **Id**.
