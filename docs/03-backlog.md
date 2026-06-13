# GestorPro ERP — Backlog do Produto

## Épico 1 — Autenticação e Segurança

### US001 — Login de usuário

Como usuário do sistema, quero acessar o ERP com e-mail e senha para utilizar as funcionalidades permitidas.

### US002 — Logout

Como usuário autenticado, quero sair do sistema com segurança.

### US003 — Perfis de acesso

Como administrador, quero criar perfis de acesso para controlar permissões dos usuários.

### US004 — Usuários

Como administrador, quero cadastrar, editar, listar e desativar usuários.

---

## Épico 2 — Dashboard

### US005 — Indicadores principais

Como gestor, quero visualizar indicadores no dashboard para acompanhar a situação da empresa.

Indicadores iniciais:

* Total de clientes
* Total de produtos
* Vendas do mês
* Contas a receber
* Contas a pagar
* Produtos com estoque baixo

---

## Épico 3 — Clientes

### US006 — Cadastro de clientes

Como usuário autorizado, quero cadastrar clientes para registrar informações comerciais.

### US007 — Listagem de clientes

Como usuário autorizado, quero listar clientes cadastrados.

### US008 — Edição de clientes

Como usuário autorizado, quero editar dados de clientes.

### US009 — Inativação de clientes

Como usuário autorizado, quero inativar clientes sem excluir o histórico.

---

## Épico 4 — Fornecedores

### US010 — Cadastro de fornecedores

Como usuário autorizado, quero cadastrar fornecedores.

### US011 — Gestão de fornecedores

Como usuário autorizado, quero listar, editar e inativar fornecedores.

---

## Épico 5 — Produtos e Categorias

### US012 — Cadastro de categorias

Como usuário autorizado, quero cadastrar categorias de produtos.

### US013 — Cadastro de produtos

Como usuário autorizado, quero cadastrar produtos com preço, estoque e categoria.

### US014 — Edição de produtos

Como usuário autorizado, quero editar produtos cadastrados.

### US015 — Produto inativo

Como usuário autorizado, quero inativar produtos que não serão mais vendidos.

---

## Épico 6 — Estoque

### US016 — Entrada de estoque

Como estoquista, quero registrar entradas de produtos no estoque.

### US017 — Saída de estoque

Como estoquista, quero registrar saídas de produtos no estoque.

### US018 — Estoque baixo

Como gestor, quero visualizar produtos com estoque baixo.

### US019 — Histórico de movimentações

Como gestor, quero consultar o histórico de movimentações de estoque.

---

## Épico 7 — Compras

### US020 — Registro de compras

Como usuário autorizado, quero registrar compras feitas com fornecedores.

### US021 — Itens da compra

Como usuário autorizado, quero informar os produtos e quantidades compradas.

### US022 — Atualização automática do estoque

Como sistema, quero atualizar o estoque após uma compra confirmada.

---

## Épico 8 — Vendas

### US023 — Registro de vendas

Como vendedor, quero registrar vendas para clientes.

### US024 — Itens da venda

Como vendedor, quero adicionar produtos e quantidades à venda.

### US025 — Baixa automática no estoque

Como sistema, quero reduzir o estoque após uma venda confirmada.

### US026 — Bloqueio de venda sem estoque

Como sistema, não devo permitir venda de produto sem estoque disponível.

---

## Épico 9 — Financeiro

### US027 — Contas a receber

Como financeiro, quero registrar contas a receber.

### US028 — Contas a pagar

Como financeiro, quero registrar contas a pagar.

### US029 — Baixa de pagamento

Como financeiro, quero marcar contas como pagas ou recebidas.

### US030 — Resumo financeiro

Como gestor, quero visualizar resumo financeiro por período.

---

## Épico 10 — Relatórios

### US031 — Relatório de clientes

Como gestor, quero gerar relatório de clientes cadastrados.

### US032 — Relatório de produtos

Como gestor, quero gerar relatório de produtos cadastrados.

### US033 — Relatório de estoque baixo

Como gestor, quero gerar relatório de produtos com estoque baixo.

### US034 — Relatório de vendas

Como gestor, quero gerar relatório de vendas por período.

### US035 — Exportação em PDF

Como usuário autorizado, quero exportar relatórios em PDF.

### US036 — Exportação em Excel

Como usuário autorizado, quero exportar relatórios em Excel.

---

## Épico 11 — Configurações

### US037 — Dados da empresa

Como administrador, quero configurar os dados da empresa.

### US038 — Logotipo da empresa

Como administrador, quero cadastrar o logotipo da empresa.

---

## Épico 12 — API REST

### US039 — API de clientes

Como sistema externo, quero consultar clientes pela API.

### US040 — API de produtos

Como sistema externo, quero consultar produtos pela API.

### US041 — API de vendas

Como sistema externo, quero registrar vendas pela API.
