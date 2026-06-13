# Veltis ERP — Arquitetura da Solução

## Objetivo

Este documento define a arquitetura inicial do Veltis ERP, descrevendo a organização da solução, separação de responsabilidades, padrões utilizados e estrutura das pastas.

---

# Visão Geral

O Veltis ERP será desenvolvido com arquitetura em camadas, separando responsabilidades para facilitar manutenção, testes e evolução do sistema.

A solução será baseada em:

* ASP.NET Core MVC
* Entity Framework Core
* SQL Server
* Bootstrap
* API REST
* Git e GitHub

---

# Estrutura da Solução

A estrutura inicial será:

```text
src/
│
├── VeltisERP.Web
├── VeltisERP.Application
├── VeltisERP.Domain
├── VeltisERP.Infrastructure
└── VeltisERP.API
```

---

# Camadas da Aplicação

## VeltisERP.Domain

Camada responsável pelas regras principais do negócio.

Conteúdo:

* Entidades
* Enums
* Regras de negócio
* Interfaces principais

Exemplos:

* Cliente
* Produto
* Venda
* Compra
* ContaPagar
* ContaReceber

---

## VeltisERP.Application

Camada responsável pelos casos de uso do sistema.

Conteúdo:

* Services
* DTOs
* ViewModels
* Validações
* Regras de aplicação

Exemplos:

* ClienteService
* ProdutoService
* VendaService
* EstoqueService
* FinanceiroService

---

## VeltisERP.Infrastructure

Camada responsável pelo acesso a dados e integrações externas.

Conteúdo:

* AppDbContext
* Migrations
* Repositories
* Configurações do Entity Framework
* Integrações externas

Exemplos:

* ClienteRepository
* ProdutoRepository
* VendaRepository

---

## VeltisERP.Web

Camada responsável pela interface web MVC.

Conteúdo:

* Controllers
* Views
* ViewModels de tela
* Arquivos estáticos
* Layouts
* Partial Views

Exemplos:

* ClientesController
* ProdutosController
* VendasController
* DashboardController

---

## VeltisERP.API

Camada responsável por expor endpoints REST para integrações futuras.

Conteúdo:

* Controllers API
* DTOs de entrada e saída
* Autenticação da API
* Versionamento da API

Exemplos:

* api/clientes
* api/produtos
* api/vendas

---

# Padrões Utilizados

## Arquitetura em Camadas

Separação entre apresentação, aplicação, domínio e infraestrutura.

## MVC

Utilizado na aplicação web principal.

## Repository Pattern

Usado para organizar o acesso aos dados.

## Service Layer

Usado para centralizar regras de aplicação.

## DTO

Usado para transferir dados entre camadas e API.

## ViewModel

Usado para transportar dados específicos das telas MVC.

---

# Fluxo da Aplicação MVC

```text
Usuário
   ↓
Controller
   ↓
Service
   ↓
Repository
   ↓
DbContext
   ↓
SQL Server
```

---

# Fluxo da API

```text
Aplicativo externo
   ↓
API Controller
   ↓
Service
   ↓
Repository
   ↓
DbContext
   ↓
SQL Server
```

---

# Organização Interna das Pastas

## VeltisERP.Domain

```text
VeltisERP.Domain/
│
├── Entities/
├── Enums/
├── Interfaces/
└── Common/
```

---

## VeltisERP.Application

```text
VeltisERP.Application/
│
├── DTOs/
├── Services/
├── Interfaces/
├── ViewModels/
└── Validators/
```

---

## VeltisERP.Infrastructure

```text
VeltisERP.Infrastructure/
│
├── Data/
├── Repositories/
├── Migrations/
└── Configurations/
```

---

## VeltisERP.Web

```text
VeltisERP.Web/
│
├── Controllers/
├── Views/
├── ViewModels/
├── wwwroot/
└── Areas/
```

---

## VeltisERP.API

```text
VeltisERP.API/
│
├── Controllers/
├── DTOs/
└── Configurations/
```

---

# Banco de Dados

O banco de dados será SQL Server.

O acesso será feito por Entity Framework Core usando:

* DbContext
* DbSet
* Migrations
* Fluent API
* Relacionamentos configurados

---

# Segurança

A segurança será baseada em:

* Login de usuários
* Senha criptografada
* Controle por perfil
* Controle por permissões
* Proteção de rotas
* Validação de acesso nos controllers

Futuramente poderá ser utilizado ASP.NET Core Identity.

---

# Interface

A interface será criada com Bootstrap, buscando um visual moderno, limpo e responsivo.

Características:

* Layout administrativo
* Menu lateral
* Dashboard com cards
* Tabelas responsivas
* Formulários simples
* Feedback visual para ações

---

# API REST

A API será criada para permitir integrações futuras com:

* Aplicativos mobile
* Sistemas externos
* Dashboards externos
* Integrações comerciais

A primeira versão da API terá endpoints para:

* Clientes
* Produtos
* Vendas

---

# Boas Práticas

O projeto deverá seguir:

* Nomes claros
* Classes pequenas
* Separação de responsabilidades
* Código limpo
* Baixo acoplamento
* Reutilização de código
* Versionamento frequente no Git
* Commits descritivos

---

# Convenção de Nomes

## Projetos

```text
VeltisERP.Web
VeltisERP.Application
VeltisERP.Domain
VeltisERP.Infrastructure
VeltisERP.API
```

## Entidades

```text
Cliente
Produto
Venda
Compra
ContaPagar
ContaReceber
```

## Services

```text
ClienteService
ProdutoService
VendaService
EstoqueService
FinanceiroService
```

## Repositories

```text
ClienteRepository
ProdutoRepository
VendaRepository
CompraRepository
```

---

# Decisões Arquiteturais

## DA001 — Usar arquitetura em camadas

A solução será organizada em camadas para separar responsabilidades e facilitar manutenção.

## DA002 — Usar SQL Server

O banco de dados principal será SQL Server por ser amplamente utilizado no mercado corporativo.

## DA003 — Usar Entity Framework Core

O EF Core será usado para mapear entidades, criar migrations e acessar o banco de dados.

## DA004 — Criar API separada

A API será mantida em projeto separado para facilitar futuras integrações.

## DA005 — Separar regras de negócio da interface

As regras principais ficarão fora dos controllers, dentro das camadas Domain e Application.

---

# Resultado Esperado

Com essa arquitetura, o Veltis ERP terá uma base organizada, profissional e preparada para crescimento futuro.
