# Quantum Social - A rede social de TI

Este projeto está sendo desenvolvida em .NET Core e OracleSQL, projetada como um rede social ao nicho de tecnologia.

## Configuração

Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) e o [SQL Oracle](https://www.oracle.com/br/database/sqldeveloper/) instalado em sua máquina.

1. Clone este repositório:

   ```
   git clone https://github.com/tallesvini/Quantum_Rede_Social.git
   ```

2. Acesse o diretório do projeto:

   ```
   cd nome-do-repositorio
   ```

3. Abra o arquivo `appsettings.json` dentro do projeto `SocialQuantum.API` e configure as informações de conexão com o seu banco de dados Oracle:

   ```json
      "ConnectionStrings": {
          "DefaultConnectionApi": "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XEPDB1)));User Id=_YOUR_USER_DB_;Password=_YOUR_PASS_DB_;"
      },
   ```

4. Execute as migrações para criar as tabelas no banco de dados:

    - Abra o `Console do Gerenciador de Pacotes`.
    - No campo `Projeto padrão`, selecione o projeto `SocialQuantum.Infra.Data`.
    - Por fim, execute o comando abaixo:
        ```
        dotnet ef database update
        ```

5. Inicie o servidor:

    - No [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/), rode localmente seu projeto (seja ele via IIS ou HTTP)

A API estará disponível em `http://localhost:44307` e com o Swagger em `http://localhost:44307/swagger/index.html`

## Endpoints:

### USERS:

1. Criação de novo Usuários:   
`POST - /api/v1/UserProfile`

2. Consultas de Usuários:
`GET - GetAll - /api/v1/UserProfile`   
`GET - GetById - /api/v1/UserProfile/{id}`

3. Atualizar Usuário:
`PUT - /api/v1/UserProfile/{id}`

4. Deletar Usuário:
`DELETE - /api/v1/UserProfile/{id}`

### STATUS ACCOUNT:

1. Criação de novo Status:   
`POST - /api/v1/StatusAccount`

2. Consultas de Status:
`GET - GetAll - /api/v1/StatusAccount`  
`GET - GetById - /api/v1/StatusAccount/{id}`

3. Atualizar Status:
`PUT - /api/v1/StatusAccount/{id}`

4. Deletar Status:
`DELETE - /api/v1/StatusAccount/{id}`

### FOLLOW:

1. Criação de novo Follow (Novo seguidor):   
`POST - /api/v1/Follow`

2. Consultar Follows:
`GET - GetAll - /api/v1/Follow`  
`GET - Puxar por quem segue - /api/v1/Follow/Follower/{id}`  
`GET - Puxar por quem é seguido - /api/v1/Follow/Following/{id}`

3. Deletar Follow:
`DELETE - /api/v1/Follow/{id}`

### VISIBILITY:

1. Consultar Visibility (Visibilidade de publicações):
`GET - GetAll - /api/v1/Visibility`  
`GET - GetById - /api/v1/Visibility/{id}`


## Requisitos de Sistema

- .NET Core SDK 6 ou superior.

## Como Contribuir

Se você deseja contribuir para este projeto, siga as etapas abaixo:

1. Faça um fork deste repositório e clone-o em sua máquina local.
2. Crie um novo branch para suas alterações: `git checkout -b minha-branch`.
3. Realize as alterações desejadas e commit-as: `git commit -m 'Minhas alterações'`.
4. Envie suas alterações para o branch principal do repositório forkado: `git push origin minha-branch`.
5. Abra um pull request no repositório original, descrevendo as alterações propostas.

## Licença

Este projeto está licenciado sob a **MIT License**.
