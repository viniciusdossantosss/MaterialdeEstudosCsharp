using ScreenSound;

Musica musica1 = new Musica(ThePolice, "Roxane");
musica1.Nome = "Roxane";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);


Musica musica2 = new Musica(U2, "Vertigo");

musica2.Duracao = 367;
musica2.Disponivel = false;

Album albumDoQueen = new Album("A night at the Opera");


Banda queen =  new Banda("Queen");
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

Musica musica3 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica4 = new Musica(queen, "Bohemian Rhapsody");
musica4.Duracao = 354;

albumDoQueen.AdicionarMusica(musica3);
albumDoQueen.AdicionarMusica(musica4);

albumDoQueen.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

