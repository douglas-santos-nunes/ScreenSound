﻿//Banda teste = new Banda("Matuê");

//Album albumMatue = new Album("333");

//Musica musica1 = new Musica(teste, "Maria")
//{
//    Duracao = 220,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(teste, "Castlevania")
//{
//    Duracao = 220,
//    Disponivel = false,
//};

//albumMatue.AdicionarMusica(musica1);
//albumMatue.AdicionarMusica(musica2);

//teste.AdicionarAlbum(albumMatue);
//teste.ExibirDiscografia();

Episodio ep = new (1,"Teste 1", 45);
ep.AdicionarConvidados("Maria");
//Console.WriteLine(ep.Resumo);

Episodio ep2 = new(2, "Teste 2", 40);
ep2.AdicionarConvidados("João");
//Console.WriteLine(ep.Resumo);

Episodio ep3 = new(3, "Teste 3", 50);
ep3.AdicionarConvidados("Marcelo");
//Console.WriteLine(ep.Resumo);

Podcast podcast = new("Alura Podcast", "Bruno Teste");
podcast.AdicionarEpisodio(ep);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);

podcast.ExibirDetalhes();