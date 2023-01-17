double distM, distPol;

System.Console.WriteLine("Olá, usuário ! Vamos converter uma distância, em polegadas, para metros ?");
System.Console.WriteLine("Informe a distância, em polegadas, para conversão:");
distPol = double.Parse(Console.ReadLine());

distM = distPol * 0.0254;

System.Console.WriteLine("A distância " + distPol + " pol " + " se torna " + distM + " m após a conversão.");