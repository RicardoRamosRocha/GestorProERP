# Veltis ERP — Modelagem do Banco de Dados

## Objetivo

Este documento define a modelagem inicial do banco de dados do Veltis ERP.

A modelagem servirá como base para:

* Entity Framework Core
* SQL Server
* Migrations
* Desenvolvimento dos módulos
* API REST
* Relatórios

---

# Estrutura Modular

## Segurança

* Usuario
* Perfil
* Permissao
* PerfilPermissao

## Cadastros

* Empresa
* Cliente
* Fornecedor
* Categoria
* Produto

## Estoque

* MovimentacaoEstoque

## Compras

* Compra
* CompraItem

## Vendas

* Venda
* VendaItem

## Financeiro

* ContaPagar
* ContaReceber

---

# Usuario

Representa os usuários do sistema.

| Campo         | Tipo        |
| ------------- | ----------- |
| Id            | int         |
| Nome          | string(150) |
| Email         | string(150) |
| SenhaHash     | string      |
| PerfilId      | int         |
| Ativo         | bool        |
| DataCadastro  | datetime    |
| DataAlteracao | datetime?   |

Relacionamento:

* Perfil 1:N Usuario

---

# Perfil

Representa os perfis de acesso.

| Campo        | Tipo        |
| ------------ | ----------- |
| Id           | int         |
| Nome         | string(100) |
| Descricao    | string(255) |
| Ativo        | bool        |
| DataCadastro | datetime    |

Exemplos:

* Administrador
* Gerente
* Vendedor
* Estoquista
* Financeiro

---

# Permissao

Representa permissões individuais.

| Campo     | Tipo        |
| --------- | ----------- |
| Id        | int         |
| Nome      | string(150) |
| Codigo    | string(100) |
| Descricao | string(255) |

Exemplos:

* CLIENTE_CRIAR
* CLIENTE_EDITAR
* PRODUTO_VISUALIZAR
* VENDA_CRIAR

---

# PerfilPermissao

Relacionamento N:N.

| Campo       | Tipo |
| ----------- | ---- |
| PerfilId    | int  |
| PermissaoId | int  |

---

# Empresa

Dados da empresa.

| Campo        | Tipo        |
| ------------ | ----------- |
| Id           | int         |
| NomeFantasia | string(200) |
| RazaoSocial  | string(200) |
| Cnpj         | string(18)  |
| Email        | string(150) |
| Telefone     | string(20)  |
| Endereco     | string(255) |
| Cidade       | string(100) |
| Estado       | string(2)   |
| Cep          | string(10)  |
| LogoUrl      | string(255) |

---

# Cliente

Representa clientes.

| Campo           | Tipo        |
| --------------- | ----------- |
| Id              | int         |
| NomeRazaoSocial | string(200) |
| Documento       | string(20)  |
| Email           | string(150) |
| Telefone        | string(20)  |
| Endereco        | string(255) |
| Cidade          | string(100) |
| Estado          | string(2)   |
| Cep             | string(10)  |
| Ativo           | bool        |
| DataCadastro    | datetime    |
| DataAlteracao   | datetime?   |

Relacionamento:

* Cliente 1:N Venda
* Cliente 1:N ContaReceber

---

# Fornecedor

Representa fornecedores.

| Campo           | Tipo        |
| --------------- | ----------- |
| Id              | int         |
| NomeRazaoSocial | string(200) |
| Documento       | string(20)  |
| Email           | string(150) |
| Telefone        | string(20)  |
| Endereco        | string(255) |
| Cidade          | string(100) |
| Estado          | string(2)   |
| Cep             | string(10)  |
| Ativo           | bool        |
| DataCadastro    | datetime    |
| DataAlteracao   | datetime?   |

Relacionamento:

* Fornecedor 1:N Compra
* Fornecedor 1:N ContaPagar

---

# Categoria

| Campo        | Tipo        |
| ------------ | ----------- |
| Id           | int         |
| Nome         | string(100) |
| Descricao    | string(255) |
| Ativo        | bool        |
| DataCadastro | datetime    |

Relacionamento:

* Categoria 1:N Produto

---

# Produto

| Campo         | Tipo          |
| ------------- | ------------- |
| Id            | int           |
| Nome          | string(200)   |
| CodigoSku     | string(50)    |
| Descricao     | string        |
| CategoriaId   | int           |
| PrecoCusto    | decimal(18,2) |
| PrecoVenda    | decimal(18,2) |
| EstoqueAtual  | int           |
| EstoqueMinimo | int           |
| Ativo         | bool          |
| DataCadastro  | datetime      |
| DataAlteracao | datetime?     |

Relacionamento:

* Produto 1:N MovimentacaoEstoque
* Produto 1:N CompraItem
* Produto 1:N VendaItem

---

# MovimentacaoEstoque

| Campo            | Tipo        |
| ---------------- | ----------- |
| Id               | int         |
| ProdutoId        | int         |
| Tipo             | string(20)  |
| Quantidade       | int         |
| Observacao       | string(255) |
| UsuarioId        | int         |
| DataMovimentacao | datetime    |

Tipos:

* Entrada
* Saida
* Ajuste
* Compra
* Venda

---

# Compra

| Campo        | Tipo          |
| ------------ | ------------- |
| Id           | int           |
| FornecedorId | int           |
| DataCompra   | datetime      |
| ValorTotal   | decimal(18,2) |
| Status       | string(30)    |
| Observacao   | string(255)   |

Status:

* Aberta
* Confirmada
* Cancelada

Relacionamento:

* Compra 1:N CompraItem

---

# CompraItem

| Campo         | Tipo          |
| ------------- | ------------- |
| Id            | int           |
| CompraId      | int           |
| ProdutoId     | int           |
| Quantidade    | int           |
| PrecoUnitario | decimal(18,2) |
| Subtotal      | decimal(18,2) |

---

# Venda

| Campo      | Tipo          |
| ---------- | ------------- |
| Id         | int           |
| ClienteId  | int           |
| DataVenda  | datetime      |
| ValorTotal | decimal(18,2) |
| Status     | string(30)    |
| Observacao | string(255)   |

Status:

* Aberta
* Confirmada
* Cancelada

Relacionamento:

* Venda 1:N VendaItem

---

# VendaItem

| Campo         | Tipo          |
| ------------- | ------------- |
| Id            | int           |
| VendaId       | int           |
| ProdutoId     | int           |
| Quantidade    | int           |
| PrecoUnitario | decimal(18,2) |
| Subtotal      | decimal(18,2) |

---

# ContaPagar

| Campo          | Tipo          |
| -------------- | ------------- |
| Id             | int           |
| Descricao      | string(200)   |
| FornecedorId   | int           |
| CompraId       | int           |
| Valor          | decimal(18,2) |
| DataVencimento | datetime      |
| DataPagamento  | datetime?     |
| Status         | string(30)    |
| Observacao     | string(255)   |

Status:

* Aberta
* Paga
* Cancelada

---

# ContaReceber

| Campo           | Tipo          |
| --------------- | ------------- |
| Id              | int           |
| Descricao       | string(200)   |
| ClienteId       | int           |
| VendaId         | int           |
| Valor           | decimal(18,2) |
| DataVencimento  | datetime      |
| DataRecebimento | datetime?     |
| Status          | string(30)    |
| Observacao      | string(255)   |

Status:

* Aberta
* Recebida
* Cancelada

---

# Relacionamentos Principais

Perfil 1:N Usuario

Perfil N:N Permissao

Categoria 1:N Produto

Fornecedor 1:N Compra

Compra 1:N CompraItem

Produto 1:N CompraItem

Cliente 1:N Venda

Venda 1:N VendaItem

Produto 1:N VendaItem

Produto 1:N MovimentacaoEstoque

Fornecedor 1:N ContaPagar

Cliente 1:N ContaReceber

Compra 1:1 ContaPagar

Venda 1:1 ContaReceber

---

# Regras de Negócio

## Produtos

* Todo produto deve possuir categoria.
* Todo produto deve possuir SKU.
* Produto inativo não pode ser vendido.

## Estoque

* Compra confirmada aumenta estoque.
* Venda confirmada reduz estoque.
* Toda movimentação deve ser registrada.
* Não permitir estoque negativo.

## Vendas

* Venda deve possuir pelo menos um item.
* Venda deve possuir cliente.
* Venda confirmada gera conta a receber.

## Compras

* Compra deve possuir fornecedor.
* Compra confirmada gera conta a pagar.

## Financeiro

* Contas possuem status.
* Baixas devem registrar data de pagamento ou recebimento.

## Segurança

* Usuário deve possuir perfil.
* Usuário inativo não pode acessar o sistema.
* Permissões serão controladas por perfil.
