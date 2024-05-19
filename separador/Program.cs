using System.Text.RegularExpressions;
// string dados = "Ana, 89,78, Maria, 45.8, 27, 56, Paula Pereira, 978, A, VIVA, 35, 125, 8999";

// ---Caso queira digiar as palavras---
Console.Write("Digite as palavras desejadas e separadas por ' ': ");
string dados = Console.ReadLine();
// ------------------------------------

// Chamando a função para separar os dados
var resultado = SepararDados(dados);

// Exibindo os resultados
Console.WriteLine("Nomes: " + string.Join(", ", resultado.Letras));
Console.WriteLine("Números: " + string.Join(", ", resultado.Numeros));

// Criando uma função em forma de tupla
static (List<string> Letras, List<string> Numeros) SepararDados(string texto)
{
    // Padrão para encontrar palavras (nomes)
    string padraoNomes = @"\b[A-Za-z]+\b";

    // Padrão para encontrar números (inteiros ou decimais)
    string padraoNumeros = @"\b\d+(\.\d+)?\b";

    // Inicializando listas para armazenar nomes e números
    List<string> letras = new List<string>();
    List<string> numeros = new List<string>();

    // Encontrar todas as correspondências de letras
    MatchCollection procuraLetras = Regex.Matches(texto, padraoNomes);
    foreach (Match match in procuraLetras)
    {
        letras.Add(match.Value);
    }

    // Encontrar todas as correspondências de números
    MatchCollection procuraNumeros = Regex.Matches(texto, padraoNumeros);
    foreach (Match match in procuraNumeros)
    {
        numeros.Add(match.Value);
    }
    // Retornar os resultados
        return (letras, numeros);
}