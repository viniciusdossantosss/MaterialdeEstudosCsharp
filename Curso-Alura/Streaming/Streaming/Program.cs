using Streaming;

Podcast podcast = new Podcast("Daniel", "Tech Podcast");

Episodio ep1 = new Episodio(45, 1, "Introdução ao C#");
ep1.AdicionarConvidados("Maria");
podcast.AdicionarEpisodio(ep1);

Episodio ep2 = new Episodio(50, 2, "Orientação a Objetos");
ep2.AdicionarConvidados("João");
podcast.AdicionarEpisodio(ep2);

Episodio ep3 = new Episodio(60, 3, "Coleções em C#");
ep3.AdicionarConvidados("Ana");
ep3.AdicionarConvidados("Pedro");
podcast.AdicionarEpisodio(ep3);

Episodio ep4 = new Episodio(40, 4, "LINQ e Lambda");
ep4.AdicionarConvidados("Lucas");
podcast.AdicionarEpisodio(ep4);

Episodio ep5 = new Episodio(55, 5, "Boas Práticas");
ep5.AdicionarConvidados("Carla");
podcast.AdicionarEpisodio(ep5);

podcast.ExibirDetalhes();
