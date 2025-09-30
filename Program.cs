Album albumDoQUeen = new Album();
albumDoQUeen.Nome = "A night at the opera";

Musica musica1 =new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 =new Musica();
musica2.Nome = "Bohemia Rhapsody";
musica2.Duracao = 354;


albumDoQUeen.AdicionarMusica(musica1);
albumDoQUeen.AdicionarMusica(musica2);

Banda queen = new Banda();  
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQUeen);
queen.ExibirDiscografia();
