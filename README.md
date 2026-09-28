# Hello World xUnit

## 📖 Explicação da Solução

Este projeto demonstra a criação de uma aplicação simples em .NET 10 com testes unitários utilizando o framework xUnit.

A solução contém dois projetos:
- **MeuPrimeiroTeste.App**: Projeto de aplicação que contém a classe `OlaMundo` com o método `ObterMensagem()`, que retorna a string "Hello, World!".
- **MeuPrimeiroTeste.Tests**: Projeto de testes unitários que valida o comportamento do método `ObterMensagem()` utilizando xUnit e o assert `Assert.Equal()`.

## 🛠️ Tecnologias Utilizadas

- **.NET 10** – Plataforma de desenvolvimento
- **xUnit** – Framework de testes unitários
- **Git & GitHub** – Versionamento e hospedagem do código

## 🚀 Comandos para Rodar

### Executar a aplicação:
```bash
dotnet run --project MeuPrimeiroTeste.App
