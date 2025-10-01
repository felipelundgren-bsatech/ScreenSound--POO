Banda queen = new Banda("Queen");  


Album albumDoQUeen = new Album("A night at the opera");


Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};


Musica musica2 = new Musica(queen, "Bohemia Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};


albumDoQUeen.AdicionarMusica(musica1);
albumDoQUeen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQUeen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQUeen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Console.ReadLine();
