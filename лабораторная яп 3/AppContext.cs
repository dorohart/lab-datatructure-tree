using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабораторная_яп_3
{
    public class AppContext
    {
        public static DichotomyTree tree { get; } = new DichotomyTree();
        public static DichotomyTree tree_new { get; } = new DichotomyTree();
        public static Form1 MainForm { get; set; }
    }
}
