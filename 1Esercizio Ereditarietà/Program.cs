using System;

namespace _1Esercizio_Ereditarietà
{
    //Classe base
    class Contocorrente
    {
        protected double prelievo;
        protected double versamento;

        public void getprelievo(double prelievoc)
        {
            prelievo = prelievoc;
        }

        public void getversamento(double versamentoc)
        {
            versamento = versamentoc;
        }

        
    }

    class Soldi:Contocorrente
    {
        public double saldo;

        public void getsaldo(double saldoc)
        {
            saldo = saldoc;
        }
        public double Versamento()
        {
            saldo = saldo + versamento;
            return saldo;
        }

        public double Prelievo()
        {
            saldo = saldo - prelievo;
            return saldo;
        }


    }

    


    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i == 0; i++)
            {
                Console.WriteLine("Vuoi il contocorrente Con soldi infiniti? premi 1, Se invece vuoi il conto normale premi 2");
                int scelta;
                scelta = int.Parse(Console.ReadLine());

            

                if (scelta == 1)//CONTOCORRENTE INFINITO
                {
                    Contocorrente c = new Contocorrente();

                    for (int s = 0; s == 0; s++)
                    {
                        int decisione1;
                        Console.WriteLine("Se vuoi prelevare premi 1, se vuoi versare premi 2, invece se vuoi uscire premi 3");
                        decisione1 =int.Parse(Console.ReadLine());

                        if (decisione1 == 1)//PRELIEVO
                        {
                            double prelievo = 0;
                            for (int b = 0; b == 0; b++)
                            {


                                Console.WriteLine("Inserisci quanto vuoi prelevare");//QUANTO VUOI PRELEVARE?
                                try
                                {
                                    prelievo = Convert.ToDouble(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Questo valore non esiste");
                                    b--;
                                }

                            }
                            c.getprelievo(prelievo);

                            Console.WriteLine("Il tuo prelievo è stato effettuato con successo");

                        }else if (decisione1 == 2)//VERSAMENTO
                        {
                            double versamento = 0;

                            for (int g = 0; g == 0; g++)//QUANTO VUOI VERSARE?
                            {
                                Console.WriteLine("Inserisci quanto vuoi versare");
                                try
                                {
                                    versamento = Convert.ToDouble(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Non esiste questo valore");
                                    g--;
                                }

                            }

                            c.getversamento(versamento);

                            Console.WriteLine("Il tuo versamento è stato effettuato con successo");
                        }
                        else if(decisione1==3)//USCITA
                        {

                            Console.WriteLine("BuonagiornAta");
                        }
                        else
                        {
                            Console.WriteLine("Potresti ripetere?");
                            s--;
                        }

                        

                    }

                }
                else if (scelta == 2)//CONTOCORRENTE FINITO/NORMALE
                {
                    Soldi s = new Soldi();

                    double saldo=0;
                    for(int b = 0; b == 0; b++)//INSERISCE SALDO
                    {
                        Console.WriteLine("Quanti soldi tieni picciott?");
                        try
                        {
                            saldo = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserisci valori validi perfavore?");
                            b--;
                        }
                    }

                    s.getsaldo(saldo);

                    for(int r = 0; r == 0; r++)
                    {
                        int decisione2;
                        Console.WriteLine("Se vuoi prelevare premi 1,se vuoi versare premi 2, invece se vuoi uscire premi 3");
                        decisione2 = int.Parse(Console.ReadLine());

                        if (decisione2 == 1)//PRELIEVO
                        {
                            double prelievo1 = 0;
                            
                            for (int f = 0; f == 0; f++)
                            {
                                Console.WriteLine("Inserisci i soldi che vuoi prelevare");
                                try
                                {
                                    prelievo1 = Convert.ToDouble(Console.ReadLine());
                                    if (prelievo1 > 3000)
                                    {
                                        Console.WriteLine("Mi spiace non puoi superare la soglia dei 3000 euri");
                                        f--;
                                    }else if (prelievo1 > saldo)
                                    {
                                        Console.WriteLine("Mi spiace sitto povero");
                                        f--;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Ottimo");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Inserisci valori validi perfavore?");
                                    f--;
                                }

                            }
                            s.getprelievo(prelievo1);

                            Console.WriteLine("Il saldo rimanente è di: {0} euri", s.Prelievo());

                        }
                        else if (decisione2 == 2)//VERSAMENTO
                        {
                            double versamento1 = 0;

                            for (int d = 0; d == 0; d++)
                            {
                                
                                    Console.WriteLine("Inserisci i soldi che vuoi versare?");

                                    try
                                    {
                                        versamento1 = Convert.ToDouble(Console.ReadLine());
                                    if (versamento1 > 3000)
                                    {
                                        Console.WriteLine("Mi spiace ma non puoi superare la soglia dei 3000 euri");
                                        d--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ottimo");
                                    }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inserisci valori validi perfavore?");
                                        d--;
                                    }
                                

                            }

                            s.getversamento(versamento1);

                            Console.WriteLine("Il saldo rimanente è di: {0} euri", s.Versamento());

                        }
                        else if (decisione2 == 3)//USCITA
                        {
                            Console.WriteLine("Buonagiornata");
                        }
                        else
                        {
                            Console.WriteLine("Non ho capito puoi ripetere?");
                            r--;
                        }

                    }

                   
                }
                else//NESSUNA SCELTA
                {
                    Console.WriteLine("Non ho capito la scleta da te fatta potresti cortesemente ripetere perfavore?");
                    i--;
                }

            }

        Console.ReadKey();
           
        }
    }
}
