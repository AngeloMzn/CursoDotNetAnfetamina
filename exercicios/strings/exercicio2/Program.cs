string  nome;

System.Console.WriteLine("Digite seu nome para saber o numero de caracteres que ele possui:");
nome = System.Console.ReadLine();

System.Console.WriteLine("O nome " + nome.ToUpper() + " tem " + nome.Length + " caracteres");