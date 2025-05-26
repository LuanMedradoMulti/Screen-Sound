namespace ScreenSound.Modelos;
class Album
{

    private List<Musica> musicalist = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;    
    }

    public string Nome { get;}
    public int DuracaoTotal => musicalist.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicalist.Add(musica);

    }

    public void ExibirMscsAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}\n");
        foreach (var musica in musicalist)
        {
            Console.WriteLine($"Nome: {musica.Nome}");
            
            
        }
        Console.WriteLine($"Para ouvir este album inteiro voce precisa de {DuracaoTotal} Milissegundos\n");
    }
}
