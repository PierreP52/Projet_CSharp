using System;
using System.Threading;

namespace Machine_à_café
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pourre Pierre
            int choix = 0;
            float RENDU = 0.0f;
            float monnaie = 0.0f;
            float prix = 0.0f;

            Console.WriteLine(" _________________________________");
            Console.WriteLine("|         MACHINE À CAFÉ          |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("|          --> MENU <--           |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("| [1]    : EXPRESSO               |");
            Console.WriteLine("| [2]    : DOUBLE EXPRESSO        |");
            Console.WriteLine("| [3]    : RISTRETTO              |");
            Console.WriteLine("| [4]    : LONG                   |");
            Console.WriteLine("| [5]    : CAFÉ MACCHIATO         |");
            Console.WriteLine("| [6]    : CAFÉ CRÈME             |");
            Console.WriteLine("| [7]    : CAFÉ NOISETTE          |");
            Console.WriteLine("| [8]    : CAPPUCCINO             |");
            Console.WriteLine("| [9]    : CAPPUCCINO ALLÉGÉ      |");
            Console.WriteLine("| [10]   : CAFÉ AMERICAIN         |");
            Console.WriteLine("| [11]   : CAFÉ GLACÉ             |");
            Console.WriteLine("| [12]   : CAFÉ BREVE             |");
            Console.WriteLine("| [13]   : MOCHA BREVE            |");
            Console.WriteLine("| [14]   : MOCHA                  |");
            Console.WriteLine("| [15]   : OEIL AU BEURRE NOIR    |");
            Console.WriteLine("| [16]   : CAFÉ LATTE             |");
            Console.WriteLine("| [17]   : CAFÉ CON LECHE         |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("| Entrez votre choix              |");
            Console.WriteLine("|_________________________________|");
            Console.Write(" ---> ");
            //ENTRÉES : LE CHOIX DE L'UTILISATEUR
            int.TryParse(Console.ReadLine(), out choix);
            if (choix < 1 || choix > 17)
            {
                Console.WriteLine("Choix INVALIDE!");
                Console.WriteLine("Veuillez quitter le programme et refaire votre choix!");
            }
            else { 
                //PRIX DE CHAQUES CAFÉ
                switch (choix)
                {
                case 1:
                    prix = 2;
                    Console.WriteLine("EXPRESSO : "+ prix + "$");
                    break;

                case 2:
                    prix = 4;
                    Console.WriteLine("DOUBLE EXPRESSO : " + prix + "$");
                    break;

                case 3:
                    prix = 2;
                    Console.WriteLine("RISTRETTO : " + prix + "$");
                    break;

                case 4:
                    prix = 5;
                    Console.WriteLine("LONG : " + prix + "$");
                    break;

                case 5:
                    prix = 5;
                    Console.WriteLine("CAFÉ MACCHIATO : " + prix + "$");
                    break;

                case 6:
                    prix = 6;
                    Console.WriteLine("CAFÉ CRÈME : " + prix + "$");
                    break;

                case 7:
                    prix = 6;
                    Console.WriteLine("CAFÉ NOISETTE : " + prix + "$");
                    break;

                case 8:
                    prix = 5;
                    Console.WriteLine("CAPPUCCINO : " + prix + "$");
                    break;

                case 9:
                    prix = 5;
                    Console.WriteLine("CAPPUCCINO ALLÉGÉ : " + prix + "$");
                    
                    break;
                case 10:
                    prix = 5;
                    Console.WriteLine("CAFÉ AMERICAIN : " + prix + "$");
                    
                    break;
                case 11:
                    prix = 4;
                    Console.WriteLine("CAFÉ GLACÉ : " + prix + "$");                   
                    break;

                case 12:
                    prix = 5;
                    Console.WriteLine("CAFÉ BREVE : " + prix + "$");
                    break;

                case 13:
                    prix = 7;
                    Console.WriteLine("MOCHA BREVE : " + prix + "$");
                    break;

                case 14:
                    prix = 6;
                    Console.WriteLine("MOCHA : " + prix + "$");
                    break;

                case 15:
                    prix = 5;
                    Console.WriteLine("OEIL AU BEURRE NOIR : " + prix + "$");
                    break;

                case 16:
                    prix = 5;
                    Console.WriteLine("CAFÉ LATTE : " + prix + "$");
                    break;

                case 17:
                    prix = 7;
                    Console.WriteLine("CAFÉ CON LECHE : " + prix + "$");
                    break;

                
                } 

                //CALCULE DE "RENDU" || AFFICHAGE DE MESSAGE D'ERREUR
                Console.WriteLine("Entrez la monnaie ");
                Console.Write(" ---> ");
                float.TryParse(Console.ReadLine(), out monnaie);
              if (monnaie < prix)
              {
                    Console.WriteLine("MONTANT PERÇU INVALIDE!");
                    Console.Write("Veuillez prendre votre argent et refaire votre demande");
                    
              }
              else
              {
                    RENDU = monnaie - prix;
                

                //PRÉPARATION CAFÉ EN 10 S
                Console.Clear();
                Console.Write("Préparation du café en cours");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(10000);

                //AFFICHER LA MONNAIE RENDUE ET SERVIR CAFÉ
                Console.WriteLine();
                Console.WriteLine(@"ARGENT RENDU : " + RENDU + " $");
                Console.WriteLine(@" __________________");
                Console.WriteLine(@"|Prenez votre Café |");
                Console.WriteLine(@" ******************");
            
                //AFFICHER L'IMAGE CORRESPONDANTE
                switch (choix)
                {
                 case 1:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|EXPRESSO|\");
                    Console.WriteLine(@"|        |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 2:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"| DOUBLE |\");
                    Console.WriteLine(@"|EXPRESSO|/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 3:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|           |");
                    Console.WriteLine(@"| RISTRETTO |\");
                    Console.WriteLine(@"|           |/");
                    Console.WriteLine(@"|___________|");
                    break;

                 case 4:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"| LONG   |\");
                    Console.WriteLine(@"|        |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 5:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|         |");
                    Console.WriteLine(@"| CAFE    |\");
                    Console.WriteLine(@"|MACCHIATO|/");
                    Console.WriteLine(@"|_________|");
                    break;

                 case 6:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"| CAFÉ   |\");
                    Console.WriteLine(@"|CRÈME   |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 7:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"| CAFÉ   |\");
                    Console.WriteLine(@"|NOISETTE|/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 8:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|            |");
                    Console.WriteLine(@"| CAPPUCCINO |\");
                    Console.WriteLine(@"|            |/");
                    Console.WriteLine(@"|____________|");
                    break;

                 case 9:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|          |");
                    Console.WriteLine(@"|CAPPUCCINO|\");
                    Console.WriteLine(@"|ALLÉGÉ    |/");
                    Console.WriteLine(@"|__________|");
                    break;

                 case 10:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|          |");
                    Console.WriteLine(@"|CAFÉ      |\");
                    Console.WriteLine(@"|AMERICAIN |/");
                    Console.WriteLine(@"|__________|");
                    break;

                 case 11:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|CAFÉ    |\");
                    Console.WriteLine(@"|GLACÉ   |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 12:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|CAFÉ    |\");
                    Console.WriteLine(@"|BREVE   |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 13:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|MOCHA   |\");
                    Console.WriteLine(@"|BREVE   |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 14:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|MOCHA   |\");
                    Console.WriteLine(@"|        |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 15:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|OEIL     |");
                    Console.WriteLine(@"|AU BEURRE|\");
                    Console.WriteLine(@"|NOIR     |/");
                    Console.WriteLine(@"|_________|");
                    break;

                 case 16:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|CAFÉ    |\");
                    Console.WriteLine(@"|LATTE   |/");
                    Console.WriteLine(@"|________|");
                    break;

                 case 17:
                    Console.WriteLine(" ( ( (");
                    Console.WriteLine("  ) ) )");
                    Console.WriteLine("|        |");
                    Console.WriteLine(@"|CAFÉ    |\");
                    Console.WriteLine(@"|CON     |/");
                    Console.WriteLine(@"|LECHE___|");
                    break;
                }

              }
            }

            //FIN ACHAT
            Console.WriteLine();
            Console.WriteLine("À LA PROCHAINE !");
            Console.ReadKey();

            


        }

    }
}
