using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.STRATEGY
{
    class Figure3: IFigure
    {
        public string[] Kopnięcie()
        {
            return new string[] { "Z wyskoku" };
        }

        public string[] Uderzenie()
        {
            return new string[] { "Uderza kamieniem" };
        }
    }
}
