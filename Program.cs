Album albumMatue = new Album();

albumMatue.Nome = "333";

Musica musica1 = new Musica();

musica1.nome = "Maria";
musica1.duracao = 220;
musica1.artista = "Matuê";
musica1.disponivel = true;

Musica musica2 = new Musica();

musica2.nome = "Castlevania";
musica2.duracao = 220;
musica2.artista = "Matuê";
musica2.disponivel = true;

albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);

albumMatue.ExibirMusicasDoAlbum();
//musica1.ExibirNomeEArtista();

