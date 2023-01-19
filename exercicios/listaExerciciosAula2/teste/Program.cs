string a;
bool b = true;
while(b)
{
    System.Console.WriteLine("Olá usuário! Vamos escrever uma letra para o computador printar ?");
    System.Console.WriteLine("Escreva uma letra entre A e Z ou a e z:");
    a = System.Console.ReadLine();

    int num = (int) a[0];

    if(a.Length == 1)
    {
        if(65 <= num & num <= 90 ||  97 <= num & num <= 122)
        {

            System.Console.WriteLine("Sua letra é: " + a);
            break;
        }
        else
        {
            System.Console.WriteLine("Você tem que digitar uma letra entra A e Z ou a e z !!");
        }
    }
    else if(a.Length < 1)
    {
        System.Console.WriteLine("Você precisa digitar ao menos 1 número!!");
    }
    else
    {
        System.Console.WriteLine("Você tem que digitar apenas 1 letra!!");
    }
}