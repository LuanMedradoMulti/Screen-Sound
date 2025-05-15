Album albumdoQueen = new Album();
albumdoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Bohemian...";
musica1.Duracao = 423;

Musica musica2 = new Musica();
musica2.Nome = "Dont stop";
musica2.Duracao = 352;

albumdoQueen.AdicionarMusica(musica1);
albumdoQueen.AdicionarMusica(musica2);
albumdoQueen.ExibirMscsAlbum();

Banda queen = new Banda();
queen.AdicionarAlbum(albumdoQueen);
queen.ExibirDiscografia();