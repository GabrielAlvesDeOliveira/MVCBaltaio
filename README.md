# MVCBaltaio

## Introdução

Programa totalmente inspirado no vídeo do [balta.io](https://www.youtube.com/watch?v=NFQAj5bCgd8)

## Inicialização

Comandos utilizados para inicializar o projeto:

```bash
$ dotnet new mvc --auth Individual -o Baltaio

$ dotnet tool install --global dotnet-aspnet-codegenerator --version 7.0.11

$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

## Scaffold

Logo após a inicialização, foi preciso gerar as views e o controller do programa, além de conexão com o banco de dados, utilizando SQLite;

Comandos utilizados:

```bash
$ dotnet-aspnet-codegenerator controller -name TodoController -dc ApplicationDbContext -m Todo --useDefaultLayout --userSqlite --referenceScriptLibraries

$ dotnet ef migrations add CreateTodoTable

$ dotnet ef database update
```

## Dados

Na estrutura de dados, o usuario foi pego pela autenticação do Identity, que retornava o email, e nas duas datas foi feito utilizado o método $DateTime.Now$

<!--ts-->

* [Id](#Id) - Int
* [User](#User) - String
* [Done](#Done) - Bool
* [CreatedAt](#CreatedAt) - DateTime
* [LastUpdatedAt](#LastUpdatedAt) - DateTime

<!--te-->
