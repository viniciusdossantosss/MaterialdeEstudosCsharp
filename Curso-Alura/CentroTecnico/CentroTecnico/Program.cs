using CentroTecnico;

Processador cpu = new Processador("Intel", "i7-12700K");
PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
Computador pc = new Computador(cpu, mobo);

pc.ExibirConfiguracao();