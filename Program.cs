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
            public int MinX { get; set; }
            public int MinY { get; set; }
            public int MaxX { get; set; }
            public int MaxY { get; set; }
            Random random = new Random();

            //constructor
            public GamePiece()
            {
                Frozen = false;
                PositionX = 0;
                PositionY = 0;
                MinX = 0;
                MaxX = 100;
                MinY = 0;
                MaxY = 500;

            }
            public void Move()
            {
                if (Frozen == true)
                {
                    Console.WriteLine("You can't move this piece, it is frozen!");
                }
                else
                {

                    //by setting a range of values on move we essentially never let them move out of the grid!
                    PositionX = random.Next(0, 100);
                    PositionY = random.Next(0, 500);
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

            piece1.Move();
            Console.WriteLine(piece1);

            piece1.UnFreeze();
            Console.WriteLine(piece1);

            piece1.Move();
            Console.WriteLine(piece1);

            piece1.Move();
            Console.WriteLine(piece1);

        }
    }
}
