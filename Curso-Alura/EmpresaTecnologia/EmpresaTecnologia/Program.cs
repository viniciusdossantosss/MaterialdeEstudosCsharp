using EmpresaTecnologia;

Funcionario tecnico = new Funcionario("João", "TI");
IServico s1 = new Manutencao("Atualização de servidor", tecnico);

Funcionario analista = new Funcionario("Marina", "Consultoria");
IServico s2 = new Consultoria("Planejamento estratégico", analista);

s1.ExecutarServico();
s2.ExecutarServico();