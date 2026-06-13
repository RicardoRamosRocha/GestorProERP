# GestorPro ERP — Casos de Uso

## Objetivo

Este documento descreve os principais casos de uso do sistema GestorPro ERP, identificando os atores envolvidos e os fluxos principais de cada funcionalidade.

---

# Atores do Sistema

## Administrador

Possui acesso total ao sistema.

Responsabilidades:

* Gerenciar usuários
* Gerenciar perfis
* Gerenciar permissões
* Acessar todos os módulos
* Configurar o sistema

---

## Gerente

Responsável pela gestão operacional e acompanhamento dos indicadores.

Responsabilidades:

* Consultar dashboard
* Consultar relatórios
* Gerenciar clientes
* Gerenciar fornecedores
* Acompanhar vendas

---

## Vendedor

Responsável pelo relacionamento com clientes e registro de vendas.

Responsabilidades:

* Consultar clientes
* Cadastrar clientes
* Registrar vendas
* Consultar histórico de vendas

---

## Estoquista

Responsável pelo controle de estoque e compras.

Responsabilidades:

* Gerenciar produtos
* Controlar estoque
* Registrar compras
* Registrar movimentações

---

## Financeiro

Responsável pelo controle financeiro da empresa.

Responsabilidades:

* Contas a pagar
* Contas a receber
* Fluxo de caixa
* Relatórios financeiros

---

# UC001 — Realizar Login

## Atores

* Administrador
* Gerente
* Vendedor
* Estoquista
* Financeiro

## Fluxo Principal

1. Usuário acessa a tela de login.
2. Informa e-mail.
3. Informa senha.
4. Clica em Entrar.
5. Sistema valida as credenciais.
6. Sistema concede acesso.

## Resultado Esperado

Usuário autenticado com sucesso.

---

# UC002 — Realizar Logout

## Atores

Todos os usuários.

## Fluxo Principal

1. Usuário clica em Sair.
2. Sistema encerra a sessão.
3. Sistema retorna para a tela de login.

## Resultado Esperado

Sessão encerrada com segurança.

---

# UC003 — Cadastrar Usuário

## Ator

Administrador

## Fluxo Principal

1. Acessa módulo Usuários.
2. Clica em Novo Usuário.
3. Informa os dados.
4. Seleciona perfil.
5. Salva o cadastro.

## Resultado Esperado

Usuário cadastrado.

---

# UC004 — Gerenciar Perfis e Permissões

## Ator

Administrador

## Fluxo Principal

1. Acessa módulo Perfis.
2. Cria ou edita perfil.
3. Define permissões.
4. Salva alterações.

## Resultado Esperado

Perfil atualizado.

---

# UC005 — Cadastrar Cliente

## Atores

* Administrador
* Gerente
* Vendedor

## Fluxo Principal

1. Acessa módulo Clientes.
2. Clica em Novo Cliente.
3. Informa os dados.
4. Salva cadastro.

## Resultado Esperado

Cliente cadastrado.

---

# UC006 — Editar Cliente

## Atores

* Administrador
* Gerente
* Vendedor

## Fluxo Principal

1. Localiza cliente.
2. Edita informações.
3. Salva alterações.

## Resultado Esperado

Cliente atualizado.

---

# UC007 — Cadastrar Fornecedor

## Atores

* Administrador
* Gerente

## Fluxo Principal

1. Acessa módulo Fornecedores.
2. Clica em Novo Fornecedor.
3. Informa os dados.
4. Salva cadastro.

## Resultado Esperado

Fornecedor cadastrado.

---

# UC008 — Cadastrar Categoria

## Atores

* Administrador
* Estoquista

## Fluxo Principal

1. Acessa módulo Categorias.
2. Informa nome e descrição.
3. Salva cadastro.

## Resultado Esperado

Categoria cadastrada.

---

# UC009 — Cadastrar Produto

## Atores

* Administrador
* Estoquista

## Fluxo Principal

1. Acessa módulo Produtos.
2. Informa dados do produto.
3. Seleciona categoria.
4. Define estoque inicial.
5. Salva cadastro.

## Resultado Esperado

Produto cadastrado.

---

# UC010 — Registrar Entrada de Estoque

## Atores

* Administrador
* Estoquista

## Fluxo Principal

1. Seleciona produto.
2. Informa quantidade.
3. Confirma operação.
4. Sistema atualiza estoque.

## Resultado Esperado

Estoque atualizado.

---

# UC011 — Registrar Saída de Estoque

## Atores

* Administrador
* Estoquista

## Fluxo Principal

1. Seleciona produto.
2. Informa quantidade.
3. Confirma operação.
4. Sistema reduz estoque.

## Resultado Esperado

Movimentação registrada.

---

# UC012 — Registrar Compra

## Atores

* Administrador
* Estoquista

## Fluxo Principal

1. Seleciona fornecedor.
2. Adiciona produtos.
3. Informa quantidades.
4. Confirma compra.
5. Sistema atualiza estoque.

## Resultado Esperado

Compra registrada.

---

# UC013 — Registrar Venda

## Atores

* Administrador
* Gerente
* Vendedor

## Fluxo Principal

1. Seleciona cliente.
2. Adiciona produtos.
3. Informa quantidades.
4. Confirma venda.
5. Sistema atualiza estoque.

## Resultado Esperado

Venda registrada.

---

# UC014 — Gerenciar Contas a Receber

## Atores

* Administrador
* Financeiro

## Fluxo Principal

1. Consulta títulos.
2. Seleciona conta.
3. Registra recebimento.
4. Atualiza status.

## Resultado Esperado

Conta recebida.

---

# UC015 — Gerenciar Contas a Pagar

## Atores

* Administrador
* Financeiro

## Fluxo Principal

1. Consulta obrigações.
2. Seleciona conta.
3. Registra pagamento.
4. Atualiza status.

## Resultado Esperado

Conta paga.

---

# UC016 — Consultar Dashboard

## Atores

* Administrador
* Gerente

## Fluxo Principal

1. Acessa Dashboard.
2. Sistema exibe indicadores.
3. Usuário analisa informações.

## Resultado Esperado

Indicadores exibidos corretamente.

---

# UC017 — Gerar Relatórios

## Atores

* Administrador
* Gerente
* Financeiro

## Fluxo Principal

1. Seleciona relatório.
2. Define filtros.
3. Gera relatório.
4. Exporta PDF ou Excel.

## Resultado Esperado

Relatório gerado.

---

# UC018 — Configurar Empresa

## Ator

Administrador

## Fluxo Principal

1. Acessa Configurações.
2. Informa dados da empresa.
3. Salva alterações.

## Resultado Esperado

Configurações atualizadas.

---

# UC019 — Consumir API REST

## Ator

Sistema Externo

## Fluxo Principal

1. Sistema externo realiza requisição.
2. API valida autenticação.
3. API retorna dados solicitados.

## Resultado Esperado

Integração realizada com sucesso.
