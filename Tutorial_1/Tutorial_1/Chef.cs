using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish()       
            // Adding the "Virtual" Keyword will make able to Override this Method in the Inherited Class ( Sub Class)
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
