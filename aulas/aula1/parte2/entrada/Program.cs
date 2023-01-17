double a;
double b;
double x;

string valorA;
string valorB;

System.Console.WriteLine("Informe o primeiro número:");
valorA = System.Console.ReadLine(); // "10"
System.Console.WriteLine("Informe o segundo número:");
valorB = System.Console.ReadLine(); // "20"

// É possivel usar o double.Parse(Console.ReadLine());

a = System.Convert.ToDouble(valorA); // 10
b = System.Convert.ToDouble(valorB); // 20

x = a + b;

System.Console.WriteLine("O resultado da sua soma é: ");
System.Console.WriteLine(x);

/*
    a % b = resto da divisão
    x ++ ou x-- = incremento ou decremento em 1

*/
