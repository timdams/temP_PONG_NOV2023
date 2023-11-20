namespace fors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu

            //start het spel
            bool isGameOver = false;
            const int FRAME_TIME = 1000; //ms
            Console.CursorVisible = false;
            int teller = 1;

            //Start gameloop
            while (!isGameOver)
            {
                //1.verwerk invoer (toetsenbord)

                //2.update game(state)

                //3.render (naar console)

                //4.wachten
                System.Threading.Thread.Sleep(FRAME_TIME);
                Console.Clear();

            }

        }
    }
}