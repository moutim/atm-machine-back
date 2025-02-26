# 💳 Caixa Eletrônico - Back-end

Bem-vindo ao back-end do projeto de Caixa Eletrônico! Desenvolvido para o teste técnico do Itaú e agora refatorado para atender aos conceitos do SOLID e com tecnologias melhores, este sistema simula as funcionalidades de um caixa eletrônico, permitindo saques, depósitos, transferências, consulta de extrato, e gerenciamento de contas corrente e poupança.

## 👋 Endpoints

- **Login**  
  - **Rota:** /login
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "string",
    "password": "string"
  }
  ```

- **Registro**  
  - **Rota:** /registrar
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "number",
    "primeiroNome": "string",
    "ultimoNome": "string",
    "email": "string",
    "password": "string"
  }
  ```

- **Trocar senha**  
  - **Rota:** /trocar-senha
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "senhaAntiga": "string",
    "novaSenha": "string"
  }
  ```

- **Busca CPF**  
  - **Rota:** /busca-cpf
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "number"
  }
  ```

- **Depósito**  
  - **Rota:** /deposito
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "number",
    "valor": "decimal"
  }
  ```

- **Transferência**  
  - **Rota:** /transferir
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpfOrigem": "number",
    "cpfDestino": "number",
    "valor": "decimal"
  }
  ```

- **Extrato**  
  - **Rota:** /extrato/{cpf}
  - **Método:** GET
  - **Path Parameters:**  
  ```json
  cpf
  ```

- **Conta Poupança - Depósito**  
  - **Rota:** /pounpanca/deposito
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "number",
    "valor": "decimal"
  }
  ```

- **Conta Poupança - Saque**  
  - **Rota:** /pounpanca/saque
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "number",
    "valor": "decimal"
  }
  ```

- **Saque**  
  - **Rota:** /saque
  - **Método:** POST
  - **Body:**  
  ```json
  {
    "cpf": "number",
    "valor": "decimal"
  }
  ```

## 🛠️ Tecnologias Utilizadas

- **ASP.NET**: Framework para desenvolvimento do back-end.
- **C#**: Linguagem de programação utilizada no back-end.
- **Entity Framework**: ORM para gerenciamento do banco de dados.
- **JWT**: Implementação de autenticação e autorização.
- **MediatR**: Implementa padrão Mediator para reduzir acoplamento entre componentes.
- **HATEOAS Link**: Utilizado para adicionar links de navegação entre recursos na API.

## 📊 Modelagem do Banco de Dados

![image](https://github.com/user-attachments/assets/511765e3-3121-4fbd-8eed-7ab43d4dcc42)

