using Empresa;

Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");

funcionario.InformacoesFuncionario();
funcionario.Promover("Assistente Administrativo"); // Tentativa inválida
funcionario.Promover("Analista de Projetos");       // Promoção válida

funcionario.InformacoesFuncionario();