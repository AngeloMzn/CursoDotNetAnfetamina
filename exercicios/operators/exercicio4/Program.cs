int minutos, anos, dias;

System.Console.WriteLine("Olá, usuário ! Vamos converter um número, em minutos, para anos e dias ?");
System.Console.WriteLine("Informe o número, em minutos, para conversão:");
minutos= int.Parse(Console.ReadLine());

anos = minutos / 525960;
dias = (minutos % 525960) / 1440;

System.Console.WriteLine(minutos + " minutos são: " + anos + " anos e " + dias + " dias."); 
