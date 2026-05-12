const baseUrl = 'http://localhost:5000/api'; // Ajuste se a porta for diferente (ex: https://localhost:5001/api)

async function fazerLogin() {
    const usuario = document.getElementById('usuario').value;
    const senha = document.getElementById('senha').value;
    const errorMsg = document.getElementById('loginError');
    
    errorMsg.innerText = "";

    try {
        const response = await fetch('/api/Auth/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ usuario: usuario, senha: senha })
        });

        if (response.ok) {
            const data = await response.json();
            // Salva o token no localStorage
            localStorage.setItem('token', data.token);
            
            // Alterna a tela
            document.getElementById('loginSection').classList.add('hidden');
            document.getElementById('alunosSection').classList.remove('hidden');
            
            // Busca a lista logo após o login
            buscarAlunos();
        } else {
            const error = await response.json();
            errorMsg.innerText = error.erro || "Falha no login!";
        }
    } catch (e) {
        errorMsg.innerText = "Erro ao conectar com a API.";
    }
}

function fazerLogout() {
    localStorage.removeItem('token');
    document.getElementById('loginSection').classList.remove('hidden');
    document.getElementById('alunosSection').classList.add('hidden');
    document.querySelector('#tabelaAlunos tbody').innerHTML = ""; // Limpa a tabela
}

async function buscarAlunos() {
    const token = localStorage.getItem('token');
    if (!token) return;

    try {
        const response = await fetch('/api/Aluno', {
            method: 'GET',
            headers: {
                'Authorization': `Bearer ${token}`
            }
        });

        if (response.ok) {
            const alunos = await response.json();
            renderizarTabela(alunos);
        } else if (response.status === 401) {
            alert('Sessão expirada. Faça login novamente.');
            fazerLogout();
        }
    } catch (e) {
        console.error("Erro ao buscar alunos", e);
    }
}

function renderizarTabela(alunos) {
    const tbody = document.querySelector('#tabelaAlunos tbody');
    tbody.innerHTML = '';

    alunos.forEach(aluno => {
        const tr = document.createElement('tr');
        tr.innerHTML = `
            <td>${aluno.idAluno || '-'}</td>
            <td>${aluno.nome}</td>
            <td>${aluno.cpf}</td>
            <td>${aluno.telefone}</td>
            <td>${aluno.cidade}</td>
        `;
        tbody.appendChild(tr);
    });
}

// Verifica se já está logado ao abrir a página
window.onload = () => {
    if (localStorage.getItem('token')) {
        document.getElementById('loginSection').classList.add('hidden');
        document.getElementById('alunosSection').classList.remove('hidden');
        buscarAlunos();
    }
};