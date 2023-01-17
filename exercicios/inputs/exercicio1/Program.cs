double a, b, produto;

System.Console.WriteLine("Digite o primeiro número a multiplicar:");
a = double.Parse(System.Console.ReadLine());

System.Console.WriteLine("Digite o primeiro segundo a multiplicar:");
b = double.Parse(System.Console.ReadLine());

produto = a * b;

System.Console.WriteLine("O produto de " + a + " e " + b + " é: " + produto);