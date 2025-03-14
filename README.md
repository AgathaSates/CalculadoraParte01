# Calculadora Tabajara 2025

![Status Desenvolvimento](https://img.shields.io/badge/Status-Em%20Desenvolvimento%20-yellow)

 ### Demonstração
> Uma calculadora de console simples mas poderosa onde pode realizar as quatro operações matemáticas e a tabuada.
>
>![Demonstração do Projeto, gif imgur](https://i.imgur.com/fnIG5hN.gif)



## Índice

- [Introdução](#introducao)
- [Funcionalidades](#funcionalidades)
- [Como Usar](#como-usar)
- [Sobre o Projeto](#sobre-o-projeto)

## Introdução

- Esta é uma calculadora simples onde você pode realizar as principais operações matemáticas e a tabuada.
- A calculadora também possui um histórico de operações acessível no menu principal.
- Basta escolher a operação que deseja no menu principal e você será direcionado a digitar os valores que deseja calcular.
- Ao final de cada operação poderá voltar ao menu principal para realizar uma nova ou consultar outras funcionalidades.

## Funcionalidades

- **Operações Básicas:** Realize somas, subtrações, multiplacações e divisões com facilidade.
- **Suporte a Decimais**: Trabalhe com números que têm até duas casas decimais.
- **Validação de Entrada**: A calculadora garante que apenas opções válidas sejam aceitas.
- **Tratamento de Divisão por Zero**: A calculadora é capaz de validar erros de divisão por zero.
- **Tabuada**: A calculadora é capaz de gerar a tabuada de um número informado.
- **Histórico de Operações**: A calculadora é capaz de armazenar um histórico de operações.

## Como Usar

### Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
Calculdora.ConsoleApp.exe
```
## Sobre o Projeto
Desenvolvido durante o curso Fullstack da [Academia do Programador](https://academiadoprogramador.net) 2025
