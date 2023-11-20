namespace fors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu

            //start het spel
            bool isGameOver = false;
            const int FRAME_TIME = 100; //ms
            Console.CursorVisible = false;
            int teller = 1;

            Random rng = new Random();

            int posX = rng.Next(1, Console.WindowWidth);  //start positie balletje (x)
            int posY = rng.Next(1, Console.WindowHeight); ;  //start positie balletje (y) 
            int vX = rng.Next(-2, 3);
            int vY = rng.Next(-2, 3);

            if (vX == 0 && vY == 0)
            {
                vX = 1;
                vY = 1;
            }

            //Start gameloop
            while (!isGameOver)
            {
                //1.verwerk invoer (toetsenbord)
                if (Console.KeyAvailable)
                {
                    ConsoleKey input = Console.ReadKey(true).Key;
                    switch(input)
                    {
                        case ConsoleKey.LeftArrow:
                            vX++;
                            break;
                        case ConsoleKey.RightArrow:
                            vX--;
                            break;
                        case ConsoleKey.UpArrow:
                            vY++;
                            break;
                        case ConsoleKey.DownArrow:
                            vY--;
                            break;
                    }
                }
                //2.update game(state)

                if (posX + vX >= Console.WindowWidth || posX + vX < 0)
                {
                    vX = -vX; //vector omkeren
                }
                posX = posX + vX;


                if (posY + vY >= Console.WindowHeight || posY + vY < 0)
                {
                    vY = -vY;
                }
                posY = posY + vY;

                //3.render (naar console)
                Console.SetCursorPosition(posX, posY);
                Console.Write("0");
                //4.wachten
                System.Threading.Thread.Sleep(FRAME_TIME);
                Console.Clear();

            }

        }
    }
}