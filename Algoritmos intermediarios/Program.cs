using System.ComponentModel.Design;

int numero1, numero2, numero3;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número: ");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    if (numero1 > numero3)
    {
        Console.WriteLine("O número " + numero1 + " é maior");
    }
}
if (numero2 > numero1)
    {
    if (numero2 > numero3)
        {
            Console.WriteLine("O número " + numero2 + " é maior");
        }
    }
else
    {
    if (numero3 > numero1)
        {
        if (numero3 > numero2)
        {
            Console.WriteLine("O número " + numero3 + " é maior");
        }
    }
}




   
    



