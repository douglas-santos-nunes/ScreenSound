class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de Musicas do album {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.nome}");
        }

        Console.WriteLine($"\nVocê precisa de {DuracaoTotal} segundos");
    }
}
