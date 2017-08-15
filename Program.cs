using System;

namespace gamepiece_freeze
{
    class Program
    {
        class GamePiece
        {
            //properties
            public string Name { get; set; }
            public string Color { get; set; }
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public bool Frozen { get; set; }

            //constructor
            public GamePiece()
            {
                Frozen = false;
                PositionX = 0;
                PositionY = 0;

            }
            public void Move(int newX, int newY)
            {
                if (Frozen == true)
                {
                    Console.WriteLine("You can't move this piece, it is frozen!");
                }
                else
                {
                    PositionX = newX;
                    PositionY = newY;
                }

            }

            public void Freeze() => Frozen = true;
            public void UnFreeze() => Frozen = false;

            public override string ToString() => $"{Color} {Name} is currently at {PositionX}, {PositionY} and frozen is set to {Frozen}";


        }
        static void Main(string[] args)
        {
            var piece1 = new GamePiece();
            piece1.Name = "Knight";
            piece1.Color = "Black";
            Console.WriteLine(piece1);
            
            piece1.Freeze();
            Console.WriteLine(piece1);

            piece1.Move(1,3);
            Console.WriteLine(piece1);

            piece1.UnFreeze();
            Console.WriteLine(piece1);

            piece1.Move(1,3);
            Console.WriteLine(piece1);

        }
    }
}
