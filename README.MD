# Quantum Social - A rede social de TI

Este projeto está sendo desenvolvida em .NET Core e OracleSQL, projetada como um rede social ao nicho de tecnologia.

## Configuração

Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

1. Clone este repositório:

   ```
   git clone https://github.com/tallesvini/Quantum_Rede_Social.git
   ```

2. Acesse o diretório do projeto:

   ```
   cd nome-do-repositorio
   ```

3. Abra o arquivo `program.cs` e configure as informações de conexão com o banco de dados MySQL:

   ```json
      "ConnectionStrings": {
          "DefaultConnectionApi": ...
      },
   ```

4. Execute as migrações para criar as tabelas no banco de dados:

   ```
   dotnet ef database update
   ```

5. Inicie o servidor:

   ```
   dotnet run
   ```

A API estará disponível em `http://localhost:5000`.

## Requisitos de Sistema

- .NET Core SDK 3.1 ou superior.

## Como Contribuir

Se você deseja contribuir para este projeto, siga as etapas abaixo:

1. Faça um fork deste repositório e clone-o em sua máquina local.
2. Crie um novo branch para suas alterações: `git checkout -b minha-branch`.
3. Realize as alterações desejadas e commit-as: `git commit -m 'Minhas alterações'`.
4. Envie suas alterações para o branch principal do repositório forkado: `git push origin minha-branch`.
5. Abra um pull request no repositório original, descrevendo as alterações propostas.

## Licença

Este projeto está licenciado sob a **MIT License**.
