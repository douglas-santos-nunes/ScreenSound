class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome} ");
        Console.WriteLine($"Artista: {artista} ");
        Console.WriteLine($"Duração: {duracao} ");
        if (disponivel)
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
        Console.WriteLine($"Nome da Música / Artista: {nome} - {artista}");
    }
}