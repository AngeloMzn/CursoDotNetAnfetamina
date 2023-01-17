double dist, velMS, velKmH, velMph;
int tH, tM, tS, tempoTotalSegundos;

System.Console.WriteLine("Olá, usuário ! Vamos calcular sua velocidade com base na distância percorrida e o tempo gasto ?");

System.Console.WriteLine("Informe a distância percorrida, em metros:");
dist = double.Parse(Console.ReadLine());

System.Console.WriteLine("Informe o tempo em horas: ");
tH = int.Parse(Console.ReadLine());

System.Console.WriteLine("Informe o tempo em minutos: ");
tM = int.Parse(Console.ReadLine());

System.Console.WriteLine("Informe o tempo em segundos: ");
tS = int.Parse(Console.ReadLine());

tempoTotalSegundos = (tH * 3600) + (tM * 60) + tS; 

velMS = dist / tempoTotalSegundos;  
velKmH = velMS * 3.6;
velMph = velMS * 2.23694;

System.Console.WriteLine("Sua velocidade em metros/segundo é " + velMS);
System.Console.WriteLine("Sua velocidade em quilômetros/hora é " + velKmH);
System.Console.WriteLine("Sua velocidade em milhas/hora é " + velMph);
