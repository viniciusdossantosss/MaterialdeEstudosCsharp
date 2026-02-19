using Banco2;

ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500M);
conta.Sacar(1500); // inválido
conta.Sacar(800);  // válido