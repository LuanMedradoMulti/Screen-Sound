namespace ScreenSound.Modelos;
class Musica // Classe
{
    // tipos primitivos
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
  
    }
    public string Nome { get; set; } // Leitura e escrita
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao =>
        $"A musica {Nome} pertenca a banda {Artista}"; //Arrow function que economiza codigo e substitui um get
    

    public void ExibirFichaTec()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Aproveite a música!\n");
        }
        else
        {
            Console.WriteLine("Não disponível em seu plano!");
        }
    }
}

