using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{
    class ItalianChef : Chef            // Inheritence
    {
        public override void MakeSpecialDish()
        // Adding the "Override" Keyword will make able to Override this Method in the Inherited Class ( Sub Class)
        {
            Console.WriteLine("The Chef makes chiken parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
