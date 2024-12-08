Console.WriteLine("inserire il numero del giorno della settimana 1 - 7");

bool valore = int.TryParse(Console.ReadLine(), out int input);

switch (input)
{
    case 1:
        GiornoSettimana("lunedi");
            break;
    case 2:
        GiornoSettimana("martedi");
        break;
    case 3:
        GiornoSettimana("Mercoledi");
        break;
    case 4:
        GiornoSettimana("giovedi");
        break;
    case 5:
        GiornoSettimana("venerdi");
        break;
    case 6:
        GiornoSettimana("sabato");
        break;
    case 7:
        GiornoSettimana("domenica");
        break;
    default:
        Console.WriteLine("giorno non valido");
        break;
}

Console.ReadKey();


//string giorno diventa il valore stringa inserito tra le parentesi dello switch
void GiornoSettimana(string giorno)
{
    Console.WriteLine($"oggi è {giorno}");
}
