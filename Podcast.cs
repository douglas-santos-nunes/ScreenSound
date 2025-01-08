class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    private List<Episodio> episodios = new List<Episodio>();

    public string Nome { get; }
    public string Host {  get; }
    public int TotalEpisodios { get; set; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodio.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} - {Host}");
    }

}