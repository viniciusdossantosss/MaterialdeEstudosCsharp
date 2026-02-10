using PlataformaCursos;

Instrutor instrutor1 = new Instrutor("Carla", "Back-end");
ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);
 
Instrutor instrutor2 = new Instrutor("Felipe", "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);
 
curso1.ValidarConteudo();
curso1.PublicarCurso();
 
curso2.ValidarConteudo();
curso2.PublicarCurso();