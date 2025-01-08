Album albumMatue = new Album();

albumMatue.Nome = "333";

Musica musica1 = new Musica();

musica1.Nome = "Maria";
musica1.Duracao = 220;
musica1.Artista = "Matuê";
musica1.Disponivel = true;

Musica musica2 = new Musica();

musica2.Nome = "Castlevania";
musica2.Duracao = 220;
musica2.Artista = "Matuê";
musica2.Disponivel = true;

albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);

//albumMatue.ExibirMusicasDoAlbum();
//musica1.ExibirNomeEArtista();

Banda teste = new Banda();
teste.Nome = "Matuê";
teste.AdicionarAlbum(albumMatue);
teste.ExibirDiscografia();
