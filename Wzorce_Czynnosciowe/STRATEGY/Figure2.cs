using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.STRATEGY
{
    public class Figure2: IFigure
    {
        public string[] Kopnięcie()
        {
            return new string[] { "Kolanem" };
        }

        public string[] Uderzenie()
        {
            return new string[] { "Uderza łokciem" };
        }
    }
}
