class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    private List<Episodio> episodios = new();

    public string Nome { get; }
    public string Host {  get; }
    //public int TotalEpisodios { get; set; }
    public int TotalEpisodios => episodios.Count;
    
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} - Apresentado por {Host}\n");
        Console.WriteLine($"Lista de Episodios: \n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"{episodio.Resumo} \n");

        }
        Console.WriteLine($"Numero de Episodios: {TotalEpisodios}");
    }

}