namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> albums = new List<Album>();
    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get;}

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album); // Lista add(metodo) (parametro album)

    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Exibindo discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} e duracao de {album.DuracaoTotal} ");
        }
    }
}
