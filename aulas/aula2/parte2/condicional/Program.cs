System.Console.WriteLine("Digite X:");
int x = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Digite Y:");
int y = int.Parse(System.Console.ReadLine());

if(x > y)
{
    System.Console.WriteLine("X é o MAIOR");
}
else
{
    if(x == y)
    {
    System.Console.WriteLine("Y é igual ao X");
    }
    else
    {
        System.Console.WriteLine("Y é o MAIOR");
    }
}
