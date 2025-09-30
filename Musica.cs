class Musica
{
    public string Nome {  get; set; }
    public string Artista {  get; set; }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }

    public string DescricaoResumida 
    { 
        get
        {
            return $"A musica {Nome} pertence a banda {Artista}";
        }
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música {Nome}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano+");
        }
        Console.WriteLine(DescricaoResumida);
    }
}