// Variáveis para controlar o estado da calculadora
let valorAtual = "0";      // O número que está sendo digitado
let valorAnterior = "";    // O primeiro número digitado antes do operador
let operador = null;       // Guarda a operação (+, -, *, /)
let reiniciarDisplay = false; // Controla se o próximo número deve limpar a tela

const display = document.getElementById("display");

// Função para atualizar o texto na tela
function atualizarDisplay() {
    display.textContent = valorAtual;
}

// Inserir números e o ponto decimal
function adicionarNumero(numero) {
    if (valorAtual === "0" && numero !== "." || reiniciarDisplay) {
        valorAtual = numero;
        reiniciarDisplay = false;
    } else {
        // Evita colocar mais de um ponto decimal
        if (numero === "." && valorAtual.includes(".")) return;
        valorAtual += numero;
    }
    atualizarDisplay();
}

// Define qual operação matemática será feita
function definirOperador(op) {
    if (operador !== null) calcular(); // Se já tinha uma conta pendente, calcula primeiro
    valorAnterior = valorAtual;
    operador = op;
    reiniciarDisplay = true;
}

// Executa a conta baseada no operador escolhido
function calcular() {
    if (operador === null || reiniciarDisplay) return;

    let resultado;
    const num1 = parseFloat(valorAnterior);
    const num2 = parseFloat(valorAtual);

    // Estrutura condicional para executar as 4 operações exigidas
    switch (operador) {
        case "+":
            resultado = num1 + num2;
            break;
        case "-":
            resultado = num1 - num2;
            break;
        case "*":
            resultado = num1 * num2;
            break;
        case "/":
            if (num2 === 0) {
                resultado = "Erro"; // Evita a divisão por zero
            } else {
                resultado = num1 / num2;
            }
            break;
        default:
            return;
    }

    valorAtual = String(resultado);
    operador = null;
    valorAnterior = "";
    reiniciarDisplay = true;
    atualizarDisplay();
}

// Reseta a calculadora para o estado inicial (Botão C)
function limparTela() {
    valorAtual = "0";
    valorAnterior = "";
    operador = null;
    reiniciarDisplay = false;
    atualizarDisplay();
}