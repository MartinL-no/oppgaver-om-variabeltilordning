using System;

namespace oppgaver_om_variabeltilordning
{
    class Program
    {
        int OppgaveEnInt = 1;
        long OppgaveEnLong = 123456789;
        float OppgaveEnFloat = 1.01f;
        decimal OppgaveEnDecimal = 1.000001m;
        double OppgaveEnDouble = 12333323.45;
        string OppgaveEnString = "a string";
        char OppgaveEnChar = 'a';
        bool OppgaveEnBool = true;

        static void Main(string[] args)
        {
            

            Console.Write("Oppgave 2: int a (1) + decimal b (2.99m) = ");
            Console.WriteLine(OppgaveTo());

            Console.WriteLine("Oppgave 2: the variable 'sum' must be decimal");
        }
        static decimal OppgaveTo()
        {
            int a = 1;
            decimal b = 2.99m;
            decimal sum = a + b;

            return sum;
        }
    }
}

