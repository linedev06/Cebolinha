// See https://aka.ms/new-console-template for more information
string frasedigitada, frasecebolinha;

Console.Write("Digite uma frase:");
frasedigitada = Console.ReadLine()!;

frasecebolinha = frasedigitada
.Replace("r", "l")
.Replace("R", "L");

Console.Write(frasecebolinha);