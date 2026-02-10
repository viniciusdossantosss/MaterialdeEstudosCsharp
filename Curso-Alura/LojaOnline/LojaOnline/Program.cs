using LojaOnline;

PagamentoCredito cliente1 = new PagamentoCredito("André", "andre@email.com");
PagamentoBoleto cliente2 = new PagamentoBoleto("Juliana", "juliana@email.com");

cliente1.ProcessarPagamento();
cliente2.ProcessarPagamento();