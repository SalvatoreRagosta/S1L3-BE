using System;

class ContoCorrente
{
    private bool contoAperto;
    private double saldo;

    public ContoCorrente()
    {
        contoAperto = false;
        saldo = 0;
    }

    
    public void ApriConto(double versamentoIniziale)
    {
        if (!contoAperto && versamentoIniziale >= 1000)
        {
            saldo += versamentoIniziale;
            contoAperto = true;
            Console.WriteLine("Conto aperto con successo. Saldo iniziale: {0} euro.", saldo);
        }
        else
        {
            Console.WriteLine("Impossibile aprire il conto. Assicurati di non aver già aperto il conto e di effettuare un versamento di almeno 1000 euro.");
        }
    }

    public void Versamento(double importo)
    {
        if (contoAperto)
        {
            saldo += importo;
            Console.WriteLine("Versamento di {0} euro effettuato con successo. Saldo attuale: {1} euro.", importo, saldo);
        }
        else
        {
            Console.WriteLine("Il conto non è ancora aperto. Apri il conto prima di effettuare un versamento.");
        }
    }

    public void Prelevamento(double importo)
    {
        if (contoAperto && saldo >= importo)
        {
            saldo -= importo;
            Console.WriteLine("Prelevamento di {0} euro effettuato con successo. Saldo attuale: {1} euro.", importo, saldo);
        }
        else if (contoAperto && saldo < importo)
        {
            Console.WriteLine("Saldo insufficiente per effettuare il prelevamento. Saldo attuale: {0} euro.", saldo);
        }
        else
        {
            Console.WriteLine("Il conto non è ancora aperto. Apri il conto prima di effettuare un prelevamento.");
        }
    }
}

class Program
{
    static void Main()
    {
        ContoCorrente mioConto = new ContoCorrente();

       
        mioConto.ApriConto(1500);

       
        mioConto.Versamento(500);

       
        mioConto.Prelevamento(2000);
    }
}
/////////////////////
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Inserisci il numero di nomi: ");
        int numeroDiNomi = Convert.ToInt32(Console.ReadLine());

        
        string[] nomi = new string[numeroDiNomi];

        for (int i = 0; i < numeroDiNomi; i++)
        {
            Console.Write("Inserisci il nome {0}: ", i + 1);
            nomi[i] = Console.ReadLine();
        }


        Console.Write("Inserisci il nome da cercare: ");
        string nomeDaCercare = Console.ReadLine();


        bool presente = false;
        for (int i = 0; i < numeroDiNomi; i++)
        {
            if (nomi[i].Equals(nomeDaCercare, StringComparison.OrdinalIgnoreCase))
            {
                presente = true;
                break;
            }
        }

        if (presente)
        {
            Console.WriteLine("Il nome {0} è presente nell'array.", nomeDaCercare);
        }
        else
        {
            Console.WriteLine("Il nome {0} non è presente nell'array.", nomeDaCercare);
        }
    }
}
/////////////////////////
using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci la dimensione dell'array: ");
        int dimensioneArray = Convert.ToInt32(Console.ReadLine());

        int[] numeri = new int[dimensioneArray];

        for (int i = 0; i < dimensioneArray; i++)
        {
            Console.Write("Inserisci il numero {0}: ", i + 1);
            numeri[i] = Convert.ToInt32(Console.ReadLine());
        }

        int somma = 0;
        for (int i = 0; i < dimensioneArray; i++)
        {
            somma += numeri[i];
        }

        double media = (double)somma / dimensioneArray;

        Console.WriteLine("Somma di tutti i numeri: {0}", somma);
        Console.WriteLine("Media aritmetica di tutti i numeri: {0}", media);
    }
}
