using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;

namespace LinqImpl
{
    public class LinqImpl
    {
        public string[] values;

        public LinqImpl()
        {
            values = new []
                     {
                         "avion",
                         "armoire",
                         "étagère",
                         "mère",
                         "chien",
                         "chat",
                         "bière",
                         "C#",
                         "chaine",
                         "maison",
                         "voiture",
                         "train"
                     };
                 }
        
        public string[] Contient(char element)
        {
            var resultat = from value in values
                    where value.Contains(element)
                    orderby value
                    select value;

            resultat = values.Where(value => value.Contains(element))
                .OrderBy(value => value);
            return resultat.ToArray();
        }

        public string PremierElement(char element)
        {
            return values.First(value => value.Contains(element));
        }

        public IEnumerable<char> PremierElementOuNull(char element)
        {
             return values.FirstOrDefault(value => value.Contains(element));
        }

        public IEnumerable<char> SeulElementOuNull(char element)
        {
            return values.SingleOrDefault(value => value.Contains(element));
        }

        public IEnumerable<char> SeulElement(char element)
        {
            return values.Single(value => value.Contains(element));
        }

        public IEnumerable<string> Similaire(string[] strings)
        {
            return from value in values
                join s in strings
                    on value equals s 
                select value;
            return from value in values
                where strings.Contains(value)
                select value;
            return values.Where(value => strings.Contains(value));
        }

        public IEnumerable<char> DernierElement()
        {
           return values.Last();
        }

        public IEnumerable<string> FirstFive()
        {
            return values.Take(5);
        }

        public IEnumerable<string> SkipFiveTakeFive()
        {
            return values.Skip(5).Take(5);
        }

        public int NbElement()
        {
            return values.Count(value => value.Contains('a'));
        }

        public int Somme(List<int> entiers)
        {
            return entiers.Sum();
        }
        
        public int SommeImpair(List<int> entiers)
        {
            return entiers.Where(i => i % 2 == 1).Sum();
        }
    }
}
