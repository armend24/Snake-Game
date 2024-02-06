using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake.Game
{
    internal class Settings //permban variable statike, nuk ka nevoje per krijim te instancave te tyre.
    {                       //Pasi thirren ketu(ne klasen kryesore),keto variabla mund te thirren kudo ne program.
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings() //percaktohen default values
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }

    }
}
