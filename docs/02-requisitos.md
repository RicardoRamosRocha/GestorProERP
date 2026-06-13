# Veltis ERP — Levantamento Inicial de Requisitos

## 1. Requisitos Funcionais

### RF001 — Autenticação de Usuários

O sistema deverá permitir que usuários façam login com e-mail e senha.

### RF002 — Controle de Acesso

O sistema deverá permitir o controle de acesso por perfis e permissões.

Exemplos de perfis:

* Administrador
* Gerente
* Vendedor
* Financeiro
* Estoquista

### RF003 — Dashboard

O sistema deverá exibir um dashboard com indicadores principais, como:

* Total de clientes
* Total de produtos
* Vendas do mês
* Contas a receber
* Contas a pagar
* Produtos com estoque baixo

### RF004 — Cadastro de Clientes

O sistema deverá permitir cadastrar, editar, listar, visualizar e excluir clientes.

Dados iniciais:

* Nome/Razão Social
* CPF/CNPJ
* E-mail
* Telefone
* Endereço
* Data de cadastro
* Status

### RF005 — Cadastro de Fornecedores

O sistema deverá permitir gerenciar fornecedores.

Dados iniciais:

* Nome/Razão Social
* CPF/CNPJ
* E-mail
* Telefone
* Endereço
* Status

### RF006 — Cadastro de Categorias

O sistema deverá permitir cadastrar categorias de produtos.

Dados iniciais:

* Nome
* Descrição
* Status

### RF007 — Cadastro de Produtos

O sistema deverá permitir gerenciar produtos.

Dados iniciais:

* Nome
* Código/SKU
* Categoria
* Preço de custo
* Preço de venda
* Estoque atual
* Estoque mínimo
* Status

### RF008 — Controle de Estoque

O sistema deverá registrar entradas e saídas de estoque.

Tipos de movimentação:

* Entrada
* Saída
* Ajuste
* Venda
* Compra

### RF009 — Módulo de Compras

O sistema deverá permitir registrar compras realizadas junto aos fornecedores.

### RF010 — Módulo de Vendas

O sistema deverá permitir registrar vendas para clientes.

### RF011 — Módulo Financeiro

O sistema deverá controlar contas a pagar e contas a receber.

### RF012 — Relatórios

O sistema deverá gerar relatórios em tela, PDF e Excel.

Relatórios iniciais:

* Clientes cadastrados
* Produtos cadastrados
* Estoque baixo
* Vendas por período
* Contas a pagar
* Contas a receber

### RF013 — Configurações

O sistema deverá permitir configurar dados básicos da empresa.

Dados iniciais:

* Nome da empresa
* CNPJ
* E-mail
* Telefone
* Endereço
* Logotipo

### RF014 — API REST

O sistema deverá possuir uma API REST para futuras integrações.

## 2. Requisitos Não Funcionais

### RNF001 — Usabilidade

O sistema deverá possuir interface simples, moderna e responsiva.

### RNF002 — Segurança

O sistema deverá proteger áreas internas com autenticação e autorização.

### RNF003 — Organização do Código

O projeto deverá seguir boas práticas, Clean Code e separação em camadas.

### RNF004 — Banco de Dados

O sistema deverá utilizar SQL Server com Entity Framework Core.

### RNF005 — Versionamento

O código deverá ser versionado com Git e hospedado no GitHub.

### RNF006 — Documentação

O projeto deverá possuir documentação técnica e funcional.

### RNF007 — Escalabilidade

A arquitetura deverá permitir crescimento futuro do sistema.

### RNF008 — Manutenibilidade

O código deverá ser fácil de entender, alterar e evoluir.

## 3. Regras de Negócio Iniciais

### RN001 — Produto com Estoque Baixo

Um produto será considerado com estoque baixo quando o estoque atual for menor ou igual ao estoque mínimo.

### RN002 — Venda sem Estoque

O sistema não deverá permitir venda de produto sem estoque disponível.

### RN003 — Usuário Inativo

Usuários inativos não poderão acessar o sistema.

### RN004 — Cliente Inativo

Clientes inativos não deverão ser utilizados em novas vendas.

### RN005 — Produto Inativo

Produtos inativos não deverão aparecer para novas vendas.

### RN006 — Movimentação de Estoque

Toda entrada ou saída de produto deverá gerar uma movimentação de estoque.

## 4. Perfis de Usuário Iniciais

### Administrador

Acesso total ao sistema.

### Gerente

Acesso aos módulos principais, relatórios e dashboard.

### Vendedor

Acesso a clientes, produtos e vendas.

### Estoquista

Acesso a produtos, estoque e compras.

### Financeiro

Acesso a contas a pagar, contas a receber e relatórios financeiros.

## 5. Módulos Prioritários para a Primeira Versão

Para a primeira versão do sistema, os módulos prioritários serão:

1. Login e controle de acesso
2. Dashboard
3. Clientes
4. Fornecedores
5. Categorias
6. Produtos
7. Estoque
8. Vendas
9. Financeiro básico
10. Relatórios básicos
