
//Criação da classe musica e do metodo exibir ficha tecnica
class musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;


    //metodo
    public void ExibirFichaTenica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel == true)
        {
            Console.WriteLine($"A musica está disponivel");
        }
        else
        {
            Console.WriteLine($"Desculpe! a musica não esta disponivel no seu plano");
        }
    }
    public void ExbirNomeEArtista()
    {
        Console.WriteLine($"Nome: {nome} - Artista: {artista}");
    }
}



