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
                    return new IPiece();
                case 2:
                    return new OPiece();
                case 3:
                    return new TPiece();
                case 4:
                    return new SPiece();
                case 5:
                    return new ZPiece();
                case 6:
                    return new JPiece();
                case 7:
                    return new LPiece();
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

        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveDown();
        public abstract void Rotate();
        public abstract void CheckCollisions();
        public abstract void Place();
    }
    public sealed class IPiece : Tetromino
    {

    }
    public sealed class OPiece : Tetromino
    {

    }
    public sealed class TPiece : Tetromino
    {

    }
    public sealed class SPiece : Tetromino
    {

    }
    public sealed class ZPiece : Tetromino
    {

    }
    public sealed class JPiece : Tetromino
    {

    }
    public sealed class LPiece : Tetromino
    {

    }
}
