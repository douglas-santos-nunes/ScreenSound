﻿class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome} ");
        Console.WriteLine($"Artista: {Artista} ");
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