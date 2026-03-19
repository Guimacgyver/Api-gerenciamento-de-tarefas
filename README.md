# 🚀 API Gerenciamento de Tarefas - Prova Técnica GRUPOFASTEC

[![.NET](https://img.shields.io/badge/.NET-10-blueviolet)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-orange)](https://dotnet.microsoft.com/apps/aspnet)
[![License: MIT](https://img.shields.io/badge/License-MIT-green)](LICENSE)

## 📋 Descrição
API RESTful completa para **gerenciamento de tarefas** seguindo **todos os requisitos** da prova técnica GRUPOFASTEC:
- ✅ **5 endpoints CRUD** funcionando
- ✅ **DTOs** (não expõe entidade diretamente)  
- ✅ **FluentValidation** com validações
- ✅ **Entity Framework Core + Migrations**
- ✅ **Swagger** documentação automática
- ✅ **Princípios SOLID** aplicados
- ✅ **Async/Await** em todos métodos

## ✨ Funcionalidades
| Endpoint | Método | Descrição |
|----------|--------|-----------|
| `/tarefas` | `GET` | Lista todas tarefas |
| `/tarefas/{id}` | `GET` | Busca tarefa por ID |
| `/tarefas` | `POST` | Cria nova tarefa |
| `/tarefas/{id}` | `PUT` | Atualiza tarefa |
| `/tarefas/{id}` | `DELETE` | Remove tarefa |

## 🛠️ Tecnologias

.NET 10 - ASP.NET Core Web API - EF Core 10 + SQLite - FluentValidation - Swagger - C# 13

text

## 🚀 Como Executar

### Pré-requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Git

### Passo a Passo
```bash
git clone https://github.com/SEU_USUARIO/TarefasApi.git
cd TarefasApi
dotnet restore
dotnet ef database update
dotnet run
```

### Swagger UI
📱 **http://localhost:5140/swagger**
