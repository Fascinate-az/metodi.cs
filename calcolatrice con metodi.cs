Console.WriteLine("inserire il primo numero");

bool n1 = double.TryParse(Console.ReadLine(),out double numero1);
Console.WriteLine("inserire il secondo numero");
bool n2 = double.TryParse(Console.ReadLine(), out double numero2);
Console.WriteLine("scelgiere l'operazione\n[A]ddizzione\n[S]ottrazione\n[M]oltiplicazione");
string scelta = Console.ReadLine().ToUpper();
Operazione(numero1, numero2);
Console.WriteLine("Premere un tasto qualsiasi per chiudere");
Console.ReadKey();


bool Operazione(double numero1,double numero2)
{
    if (scelta == "S")
    {
        double sottrazione = numero1 - numero2;
        messaggio("moltiplicazione",sottrazione);
        return true;
    }
    else if(scelta == "A")
    {
        double addizione = numero1 + numero2;
        messaggio("moltiplicazione",addizione);
        return true;
    }

    
    else if(scelta == "M") 
    {
        double moltiplicazione = numero1 * numero2;
        messaggio("moltiplicazione",moltiplicazione);
        return true;
    }
    else
    {
        Console.WriteLine("operazione non corretta, inserire un valore corretto e riprovare: A/S o M\nPremere un tasto qualsiasi per chiudere");
        return false;
    }
}

void messaggio(string tipo,double result)
{
    Console.WriteLine($"il risultato della {tipo} è {result}");
}
