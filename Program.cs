// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você é maior de idade");
} 
else
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Você é menor de idade.");
}
Console.ResetColor();
Console.WriteLine("Obrigado!");

    



