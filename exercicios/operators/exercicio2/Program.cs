double tempC, tempF;

System.Console.WriteLine("Olá, usuário ! Vamos converter uma temperatura, em Fahrenheit, para Celsius ?");
System.Console.WriteLine("Informe a temperatura, em Fahrenheit, para conversão:");
tempF = double.Parse(Console.ReadLine());

tempC = (tempF -32) / 1.8;

System.Console.WriteLine("A temperatura " + tempF + " ºF " + " se torna " + tempC + " ºC após a conversão.");

