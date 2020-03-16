using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcultriceDelegate
{
    public class Calculatrice
    {
        private delegate int Operation(int number1, int number2);

        private int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        private int Divise(int number1, int number2)
        {
            return number1 / number2;
        }
        
        private int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        
        private int Soustraction(int number1, int number2)
        {
            return number1 - number2;
        }

        //private int TraiterOperation(Func<int,int,int> operation, params int[] numbers)
        private int TraiterOperation(Operation operation, params int[] numbers)
        {
            int resultat = numbers[0];
            foreach (var number in numbers.Skip(1))
            {
                resultat = operation(resultat, number);
            }
            return resultat;
        } 
        
        public int Equal(string operateur, params int[] number)
        {
            int resultat;
            switch (operateur)
            {
                case "+" :
                    resultat = TraiterOperation(Add, number);
                    break;
                case "/":
                    resultat = TraiterOperation(Divise, number);
                    break;
                case "*":
                    resultat = TraiterOperation(Multiplication, number);
                    break;
                case "-":
                    resultat = TraiterOperation(Soustraction, number);
                    break;
                default :
                    throw new NotSupportedException($"Nous ne supportons pas l'opérateur {operateur}");
            }


            List<string> liste = new List<string>()
            {
                "armoire",
                "lit"
            };
            
            bool Contient(char element)
            {
                return true;
                // contient('a) ==> armoire
                // contient('i') => armoire, lit
                // contient('u') => {}
            }
        }
    }
}
