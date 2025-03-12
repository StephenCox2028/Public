using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Foes:Spells
    {
        List<string> names = new List<string>{""};
        List<string> Keywords = new List<string> { "Raging","Sturdy","Speedy" };
        (string, string, string, int, int, int, int, string, string, string, string) enemy = ("", "","",0, 0, 0, 0, "", "", "", "");
    }
}
