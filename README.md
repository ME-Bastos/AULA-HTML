# AULA-HTML

Projeto: Calculadora Interativa (HTML, CSS e JavaScript), aula 06.

## 🛠️ Tecnologias Utilizadas
- HTML: Estruturação da calculadora utilizando tags semânticas e mapeamento de botões via eventos nativos (`onclick`).
- CSS: Estilização baseada em CSS Grid e Flexbox, criando um tema escuro (*Dark Mode*) com feedbacks visuais ao passar o mouse (`:hover`) e clicar (`:active`).
- JavaScript: Lógica de programação para captura de dados, controle de estado de memória e execução dos cálculos matemáticos.

A inteligência da calculadora foi desenvolvida puramente em JavaScript utilizando uma estrutura baseada em estados:
1. **Captura de Entradas:** Funções capturam os cliques do usuário e atualizam dinamicamente a propriedade `textContent` do display.
2. **Controle de Operadores:** Ao clicar em um operador (+, -, x, /), o número atual é guardado na memória (`valorAnterior`) liberando a tela para a próxima entrada.
3. **Processamento (Switch Case):** A função `calcular()` analisa qual operador foi guardado na memória e executa a operação lógica correspondente usando as regras do C# / JavaScript de ponto flutuante, incluindo uma proteção para não permitir divisão por zero.
---
### ➕ Soma
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/e33e1fba-1bd3-4c1f-8b17-ebe6ce85ae06" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/03d34714-7463-414a-88d3-108de33956ab" />
5+5=10
### ➖ Subtração
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/a2558add-d30f-44f7-9579-31d7c87cfbd1" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/6f5ef22a-e638-4fb8-8c29-a66d9d57f4d6" />
10-7=3

### ✖️ Multiplicação
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/cf6307e2-bf28-4072-9863-d5adb4ba1fc9" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/ecd454af-f46a-492f-a82a-281b4e57d514" />
3*5=15

### ➗ Divisão
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/b146a438-5fda-4e9a-8069-18a10c28fa60" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/2db3300b-1e30-49f3-b10f-9d9cbfa0316e" />
15/7 = 2.142857142857143 (teste se aparece os números quebrados)

