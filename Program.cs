string frasedigitada, fraseDislalia;
Console.WriteLine("Digite uma flase: ");

frasedigitada = Console.ReadLine()!;

fraseDislalia = frasedigitada
    .Replace("r", "l")
    .Replace("R", "L");


Console.WriteLine(fraseDislalia);
