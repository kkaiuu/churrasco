int adultosComAlcool , adultosSemAlcool , criancas , adultos , pessoas;
double carne , acompanhamentos , cerveja , refrigerantes , agua;

Console.WriteLine("---Churrasco---\n");

Console.Write (" adultos (que  consome bebidas alcoolicas)...:");
adultosComAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write (" adultos (que nao consome bebidas alcoolicas)...:");
adultosSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças");
criancas = Convert.ToInt32(Console.ReadLine());

adultos = adultosComAlcool = adultosSemAlcool;
pessoas = adultos = criancas;

carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cerveja =2 * adultosComAlcool;
refrigerantes = 0.5* (adultosSemAlcool + criancas);
agua = 0.4 * pessoas;

Console.WriteLine();

Console.WriteLine($"carne{carne:N1}kg");
Console.WriteLine($"Acompanhamentos{acompanhamentos:N1}kg");
Console.WriteLine($"cervejas{cerveja:N1}1");
Console.WriteLine($"Refrigerantes{refrigerantes:N1}1");
Console.WriteLine($"Aguaa{agua:N1}1");







