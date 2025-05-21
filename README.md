# MenuAPS

## Descrição do Projeto

Este projeto consiste em um sistema de menu interativo desenvolvido para a disciplina de Estrutura de Dados. O sistema apresenta diversas operações relacionadas a estruturas de dados e permite ao usuário interagir via linha de comando, escolhendo opções do menu para executar diferentes funcionalidades.

## Como Rodar o Sistema (Passo a Passo)

1. **Clone o repositório:**
   ```sh
   git clone https://github.com/misakimaymay/menu-estrutura-dados.git
   ```
2. **Acesse o diretório do projeto:**
   ```sh
   cd menu-estrutura-dados/MenuAPS
   ```
3. **Compile o programa (exemplo para C):**
   ```sh
   gcc main.c -o menuaps
   ```
   > *Substitua `main.c` pelo nome do arquivo principal, se necessário.*

4. **Execute o sistema:**
   ```sh
   ./menuaps
   ```

## Pré-requisitos de Execução

- [ ] GCC ou outro compilador C/C++ (caso o projeto seja em C/C++)
- [ ] Terminal de comandos (Linux, macOS ou Windows com WSL/PowerShell)
- [ ] (Outros, conforme dependências do projeto)

## Exemplos de Uso

```
========= MENU =========
1. Inserir elemento
2. Remover elemento
3. Listar elementos
4. Buscar elemento
5. Sair
========================
Escolha uma opção: 1
Digite o valor a ser inserido: 42
Elemento inserido com sucesso!
```

## Estrutura do Menu e Comandos Disponíveis

- **1. Inserir elemento:** Adiciona um novo valor à estrutura de dados.
- **2. Remover elemento:** Remove um valor existente.
- **3. Listar elementos:** Exibe todos os elementos armazenados.
- **4. Buscar elemento:** Procura um valor específico.
- **5. Sair:** Encerra o programa.
