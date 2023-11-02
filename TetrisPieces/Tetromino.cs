using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Using_WinForms
{
    public class TetrominoGenerator
    {
        public Tetromino GenerateTetromino()
        {
            switch(Utils.RandomIntRange(1, 8))
            {
                case 1:
                    return new TetrisPieces.IPiece();
                case 2:
                    return new TetrisPieces.OPiece();
                case 3:
                    return new TetrisPieces.TPiece();
                case 4:
                    return new TetrisPieces.SPiece();
                case 5:
                    return new TetrisPieces.ZPiece();
                case 6:
                    return new TetrisPieces.JPiece();
                case 7:
                    return new TetrisPieces.LPiece();
                default:
                    return null;
            }
        }
    }
    public abstract class Tetromino
    {
        // Per Tetris Wiki definition of each rotation states:
        enum Rotation
        {
            POINT_UP,
            POINT_LEFT,
            POINT_DOWN,
            POINT_RIGHT
        }

        private int maxWidth;
        private int maxHeight;
        MatrixSquare[,] hitbox;
        private Rotation currentRotation;

        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveDown();
        public abstract void Rotate();
        public abstract void CheckCollisions();
        public abstract void Place();
        protected int MaxWidth
        {
            get { return this.maxWidth; }
            set { this.maxWidth = value; }
        }
        protected int MaxHeight
        {
            get { return this.maxHeight; }
            set { this.maxHeight = value; }
        }
    }
}
