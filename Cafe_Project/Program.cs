using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Project
{
    public class Program
    {
        //Program file that allows the cafe manager to add, update, and delete, and see all items in the menu list.

        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
            ui.Run();        
        }
    }
}
