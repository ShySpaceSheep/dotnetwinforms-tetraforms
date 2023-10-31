using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Using_WinForms
{
    class MatrixSquare
    {
        private Point squareLocation;
        private bool isOccupied;
        private bool isPlayable;

        public MatrixSquare(int xLocation, int yLocation)
        {
            this.squareLocation.X = xLocation;
            this.squareLocation.Y = yLocation;

            this.isOccupied = false;
            this.isPlayable = true;
        }
        public Point Location
        {
            get { return this.squareLocation; }
            set { this.squareLocation = value; }
        }
        public bool Occupied
        {
            get { return this.isOccupied; }
            set { this.isOccupied = value; }
        }
        public bool PLayable
        {
            get { return this.isPlayable; }
            set { this.isPlayable = value; }
        }


    }
}
