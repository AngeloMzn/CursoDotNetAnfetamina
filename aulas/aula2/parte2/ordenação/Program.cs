int a, b, c;

System.Console.WriteLine("Olá, usuário! Vamos verificar e ordenar 3 números em ordem crescente ?");
System.Console.WriteLine("Digite qualquer número e ordem para desafiar o progama !");

System.Console.WriteLine("Digite o primeiro número:");
a = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Digite o segundo número:");
b = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Digite o terceiro número:");
c = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("O programa vai ordenar os números " + a + " " + b + " " + c);
System.Console.WriteLine("Loading.");
System.Console.WriteLine("Loading..");
System.Console.WriteLine("Loading...");
System.Console.WriteLine("A ordem dos números é: ");

if (c < a & a > b)
{
    if (b > c)
    {
        System.Console.WriteLine($"{c} {b} {a}");
    }
    else
    {
        System.Console.WriteLine($"{b} {c} {a}");
    }

}
if(c < b & b > a)
{
    if(a > c)
    {
        System.Console.WriteLine($"{c} {a} {b}");
    }
    else
    {
        System.Console.WriteLine($"{a} {c} {b}");
    }
}
if(a < c & c > b)
{
    if(a > b)
    {
        System.Console.WriteLine($"{b} {a} {c}");
    }
    else
    {
        System.Console.WriteLine($"{a} {b} {c}");
    }

}