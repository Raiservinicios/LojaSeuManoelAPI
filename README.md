# 🕹️ LojaSeuManoelAPI

API desenvolvida em .NET Core para automatizar o empacotamento de pedidos da loja online do Seu Manoel. A aplicação recebe uma lista de produtos com dimensões e retorna, de forma otimizada, quais caixas usar e quais produtos colocar em cada uma.

---

## 🚀 Tecnologias Utilizadas

- .NET 8
- Entity Framework Core
- SQL Server
- Docker & Docker Compose
- Swagger (OpenAPI)
- Autenticação via API Key

---

## 📦 Funcionalidades

- Receber pedidos com produtos e dimensões
- Calcular a melhor forma de empacotar produtos nas caixas disponíveis
- Retornar as caixas usadas e a alocação dos produtos
- Proteger os endpoints via autenticação com API Key

---

## 📁 Estrutura de Diretórios

📦LojaSeuManoelAPI
 ┣ 📂Controllers
 ┣ 📂Data
 ┣ 📂Models
 ┣ 📂Services
 ┣ 📂Middlewares
 ┣ 📜Program.cs
 ┣ 📜docker-compose.yml
 ┣ 📜README.md

---

## ✅ Pré-requisitos

- Docker instalado e funcionando na máquina
- Docker Compose (já incluído no Docker Desktop)

---

## ⚙️ Como Executar

1. Clone o repositório:
   git clone https://github.com/seu-usuario/LojaSeuManoelAPI.git
   cd LojaSeuManoelAPI

2. Execute com Docker Compose:
   docker-compose up --build

3. Acesse a API no navegador:
   http://localhost:5000/swagger

---

## 🔐 Autenticação

A API está protegida com API Key.

- Header: Authorization
- Valor: ApiKey 123456

Você pode inserir a chave diretamente no Swagger clicando em "Authorize".

---

## 🧪 Testes

- Swagger habilitado em ambiente de desenvolvimento
- Exemplo de uso no Swagger com requisição JSON e resposta formatada

---

## 🐳 docker-compose.yml

O arquivo docker-compose.yml sobe dois containers:
- API .NET
- SQL Server com volume persistente

---

## ✍️ Observações

- O campo "observacao" nas respostas só aparece quando há alguma observação (como itens que não cabem em nenhuma caixa).
- Todos os dados são armazenados em SQL Server dentro do container.

---

## 📫 Contato

Desenvolvido por Vinícios Raiser para avaliação técnica .NET - Loja Seu Manoel.
