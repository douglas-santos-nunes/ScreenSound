class Musica
{
    public Musica (Banda artista, string nome) 
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome} ");
        Console.WriteLine($"Artista: {Artista.Nome} ");
        Console.WriteLine($"Duração: {Duracao} ");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no Plano");
        }
        else
        {
            Console.WriteLine("Não disponível no Plano");
        }

    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome da Música / Artista: {Nome} - {Artista}");
    }
}