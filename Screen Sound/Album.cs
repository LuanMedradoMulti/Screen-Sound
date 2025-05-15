class Album
{

    private List<Musica> musicalist = new List<Musica>();

    public string? Nome { get; set; }
    public int DuracaoTotal => musicalist.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicalist.Add(musica);

    }

    public void ExibirMscsAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum");
        foreach (var musica in musicalist)
        {
            Console.WriteLine($"Nome: {musica.Nome}");
            
            
        }
        Console.WriteLine($"Para ouvir este album inteiro voce precisa de {DuracaoTotal} Milissegundos");
    }
}
