int a, b, soma, produto, quociente, resto;


System.Console.WriteLine("Informe o primeiro número para as operações:");
a = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Informe o segundo número para as operações:");
b = int.Parse(System.Console.ReadLine());

soma = a + b;
produto = a * b;
quociente = a / b;
resto = a % b;

System.Console.WriteLine("As operações entre " + a + " e " + b);
System.Console.WriteLine("Soma: " + soma);
System.Console.WriteLine("Produto: " + produto);
System.Console.WriteLine("Quociente: " + quociente);
System.Console.WriteLine("Resto: " + resto);