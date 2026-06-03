
const form = document.getElementById("meuFormulario");
const msgErro = document.getElementById("erro");


form.addEventListener("submit", function(event) {
    
  
    const nome = document.getElementById("nome").value;
    const email = document.getElementById("email").value;
    const idade = document.getElementById("idade").value;

    
    if (nome.trim() === "") {
        event.preventDefault(); // Barra o envio do formulário
        msgErro.style.color = "red";
        msgErro.textContent = "Erro: O nome não pode estar vazio."; 
        return; 
    }

    if (!email.includes("@")) {
        event.preventDefault();
        msgErro.style.color = "red";
        msgErro.textContent = "Erro: O email deve conter um '@'.";
        return;
    }

    if (idade <= 0) {
        event.preventDefault();
        msgErro.style.color = "red";
        msgErro.textContent = "Erro: A idade deve ser maior que zero.";
        return;
    }

    event.preventDefault(); 
    msgErro.style.color = "green";
    msgErro.textContent = "Formulário validado com sucesso!";
});