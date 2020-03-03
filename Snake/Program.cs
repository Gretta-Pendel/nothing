using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Point p = new Point(4,5,'*');
            //Snake snake = new Snake(p, 4, Direction.RIGHT);

            //snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p1 = new Point(4, 5, '*');
            Figure fSnake = new Snake(p1, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;


            while (true)
            {
                if ( walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);

                }
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
                Thread.Sleep(300);
                snake.Move();
           }

            Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
