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
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} - {Host}");
        Console.WriteLine($"Lista de Episodios: \n");
        foreach (var episodio in episodios)
        {
            Console.WriteLine($"Ordem : {episodio.Ordem} \n");
            Console.WriteLine($"Título : {episodio.Titulo} \n");
            Console.WriteLine($"Duração : {episodio.Duracao} \n");
            Console.WriteLine($"Resumo : {episodio.Resumo} \n");
            Console.WriteLine("-----------------------------------------------");

        }
        Console.WriteLine($"Numero de Episodios: {episodios.Count()}");
    }

}