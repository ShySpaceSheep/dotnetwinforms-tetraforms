using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Using_WinForms
{
    public static class Utils
    {
        public static int RandomIntRange(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
