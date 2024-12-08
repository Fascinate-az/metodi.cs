Console.WriteLine("inserire una frase");


string frase = Console.ReadLine();

LunghezzaFrase(frase);


bool LunghezzaFrase(string frase)
{
    if (frase.Length > 15)
    {
        Console.WriteLine("vero");
        return true;
    }

    else 
    {
        Console.WriteLine("falso");
        return false;   
    }

    
}

Console.ReadKey();
