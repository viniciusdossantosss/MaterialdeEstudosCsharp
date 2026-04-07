using Escola_media;

Estudante estudante = new Estudante("Lucas Rocha");
estudante.Nota1 = 7.5;
estudante.Nota2 = 5.0;

Console.WriteLine("Estudante: " + estudante.Nome);
Console.WriteLine("Média: " + estudante.Media.ToString("F2"));
Console.WriteLine("Situação: " + estudante.Situacao);