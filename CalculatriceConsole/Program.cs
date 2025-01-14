using System;

namespace CalculatriceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer) { 
            
            Console.Clear();
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Soustraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Divison");
            Console.WriteLine("5.Quitter");
            Console.WriteLine("Choissisez entre les numéros 1/2/3/4/5 pour l'opération souhaité ");
            string answer = Console.ReadLine();
                   answer = answer.Trim();

                if (answer == "5") { 
                    continuer = false;
                    Console.WriteLine("Merci d'avoir utilisé la calculatrice !");
                    break;


                }

                int num1 = 0;
            int num2 = 0;
            double resultat = 0;

            Console.WriteLine("Saissisez votre premier numéro:");
            string num1_str = Console.ReadLine();
                   num1_str = num1_str.Trim();

            Console.WriteLine("Saissisez votre second numéro:");
            string num2_str = Console.ReadLine();
                   num2_str = num2_str.Trim();

                try
                {
                    num1 = int.Parse(num1_str);
                    num2 = int.Parse(num2_str);
                }
                catch
                {
                    Console.WriteLine("Erreur, vous devez entrer des chiffres.");
                    continuer = true;
                }

                switch (answer)
                {
                    case "1":
                        resultat = num1 + num2;
                        Console.WriteLine("Le résultat de votre addition " + num1 + " par " + num2 +" votre addition est : " + resultat);
                        break;

                    case "2":
                        resultat = num1 - num2;
                        Console.WriteLine("Le résultat de votre soustraction " + num1 + " par " + num2 +" est : " + resultat);
                        break;

                    case "3":
                        resultat = num1 * num2;
                        Console.WriteLine("Le résultat de votre multiplication " + num1 +" par "+ num2 +" est : " + resultat);
                        break;

                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erreur : Division par zéro impossible.");
                            break;
                        }
                        else
                        {
                            resultat = num1 / num2;
                            Console.WriteLine("Le résultat de votre division" + num1 +" par "+ num2 +" est " + resultat);
                            break;

                    }
                }
                Console.WriteLine("Appuyez sur une touche pour recommencer...");
                Console.ReadKey();
            }
        }
        }
    }
