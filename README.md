# Carro Bem Guardado

Sistema web para gerenciamento de estacionamento, permitindo registrar entrada e saída de veículos, calcular automaticamente o valor a ser pago e visualizar o histórico de permanência dos veículos.

## Sobre o Projeto

O **Carro Bem Guardado** é uma aplicação desenvolvida em ASP.NET Core MVC que simula o controle de um estacionamento. O sistema registra veículos, controla horários de entrada e saída e calcula o valor da estadia com base em uma tabela de preços configurada.

## Funcionalidades

* Cadastro de entrada de veículos;
* Registro de saída de veículos;
* Controle de horário de entrada e saída;
* Cálculo automático do valor a pagar;
* Visualização da duração da permanência;
* Persistência de dados utilizando SQLite;
* Interface web utilizando Bootstrap.

## Tecnologias Utilizadas

* C#
* ASP.NET Core MVC
* Entity Framework Core
* SQLite
* Razor Pages / Razor Views
* Bootstrap 5
* HTML5
* CSS3

## Estrutura do Projeto

```text
CarroBemGuardado/
│
├── Controllers/
├── Data/
├── Models/
├── Services/
├── Views/
├── wwwroot/
├── Program.cs
├── appsettings.json
└── CarroBemGuardado.csproj
```

## Pré-requisitos

Antes de executar o projeto, certifique-se de possuir instalado:

* .NET SDK 10.0 (ou versão compatível)
* Git

## Como Executar o Projeto

### 1. Clonar o repositório

```bash
git clone https://github.com/BernardoNicoletti/Carro_bem_guardado.git
```

### 2. Acessar a pasta do projeto

```bash
cd CarroBemGuardado
```

### 3. Restaurar dependências

```bash
dotnet restore
```

### 4. Compilar o projeto

```bash
dotnet build
```

### 5. Executar a aplicação

```bash
dotnet run
```

### 6. Acessar no navegador

Normalmente:

```text
http://localhost:5256
```

ou a porta exibida pelo terminal após executar o comando `dotnet run`.

## Banco de Dados

O projeto utiliza SQLite como banco de dados local.

O projeto irá gerar automaticamente o arquivo do banco de dados após executar o comando `dotnet run`.

> OBS: Irei deixar o arquivo `.db` previamente criado.

Arquivo gerado:

```text
estacionamento.db
```

## Regras de Negócio

* O horário de entrada é registrado automaticamente.
* O horário de saída é registrado automaticamente.
* O valor da permanência é calculado com base na tabela de preços vigente.
* O sistema exibe:

  * Horário de entrada;
  * Horário de saída;
  * Duração da permanência;
  * Tempo cobrado;
  * Valor pago.

## Exemplo de Uso

1. Clique em **Registrar Entrada**;
2. Informe a placa do veículo;
3. Salve o registro;
4. O veículo aparecerá na listagem principal;
5. Observe no canto superior direito o botão **Tabelas de Preço**;
6. Adicione uma nova tabela de preço, informando o valor desejado para a cobrança de **Hora Inicial** e **Hora Adicional**;
7. Clique em **Salvar**;
8. Observe no canto superior direito o botão **Veículos**;
9. Agora sim, podemos clicar no botão **Registrar Saída**, quando desejar finalizar a estadia;
10. O sistema calculará automaticamente o valor devido.

## .gitignore

Este projeto utiliza um arquivo `.gitignore` para evitar o versionamento de arquivos temporários e artefatos de compilação, como:

```gitignore
bin/
obj/
*.user
*.suo
.vs/
estacionamento.db
```

## Autor

Desenvolvido por Bernardo Nicoletti de Oliveira.

## Challenge

> This is a challenge by [Coodesh](https://coodesh.com/)