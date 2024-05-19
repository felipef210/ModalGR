Console.Write("Digite o nome completo com espaços: ");
string frase = Console.ReadLine().ToUpper();

// Dividir a frase usando espaços como delimitador
string[] nomes = frase.Split(' ');
string[] nomesExcluidos = {"DE", "DOS", "DAS", "DO", "DA", "E"};
string ultimoNome = nomes[nomes.Length-1];
Console.Write("Nome no cracha: ");
Console.Write(ultimoNome + ",");

foreach (string nome in nomes.SkipLast(1))
{
    if (!nomesExcluidos.Contains(nome))
    {
        Console.Write(nome[0] + ".");
    }
}