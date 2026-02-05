using Banco;

ContaBancaria conta = new ContaBancaria("78901-2", 1000.00M);
conta.Depositar(500.00M);

conta.ImprimirSaldo();
