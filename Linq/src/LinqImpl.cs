using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqImpl
{
    public class LinqImpl
    {
        public string[] values;

        public LinqImpl()
        {
            values = new[]
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
            return values
                .Where(value => value.Contains(element))
                .OrderBy(value => value)
                .ToArray();
        }
    }
}
