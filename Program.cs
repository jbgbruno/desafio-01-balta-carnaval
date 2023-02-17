Console.WriteLine("Digite um texto:");

var Texto = Console.ReadLine();

int NumCaracteres = Texto.Length;
int NumPalavras = NumCaracteres > 0 ? Texto.Split(" ").Length : 0;

Console.WriteLine($"{NumCaracteres} caracteres, {NumPalavras} palavras");
Console.ReadKey();