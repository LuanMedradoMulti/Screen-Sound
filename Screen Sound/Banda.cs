class Banda
{
    private List<Album> albums = new List<Album>();
    public string? Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album); // Lista add(metodo) (parametro album)

    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Exibindo discorgrafia da banda {Nome}");
        foreach (Album album in albums) {
            Console.WriteLine($"Album: {album.Nome} e duracao de {album.DuracaoTotal} ");
    }
}