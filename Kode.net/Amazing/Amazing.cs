using System;
using System.Text;

namespace Kode.net.Amazing
{
    public class Amazing
    {
        private static int Target;
        public static Random Random = new Random();
        public static StringBuilder Result = new StringBuilder();

        public static void Main(string[] args)
        {
            Doit(int.Parse(args[0]), int.Parse(args[1]));
            Console.WriteLine(Result);
        }

        private static void Clear()
        {
            Result = new StringBuilder();
        }

        public static void Print(string text)
        {
            Result.Append(text);
        }

        public static int NewRandomNumber(int count)
        {
            return (int)( count*Random.NextDouble() ) + 1;
        }

        public static void NextTotal(int total, int num1, int num2, int num3)
        {
            switch(NewRandomNumber(total))
            {
                case 1:
                    Target = num1;
                    break;
                case 2:
                    Target = num2;
                    break;
                case 3:
                    Target = num3;
                    break;
            }
        }

        public static void Doit(int widthOfMaze, int heightOfMaze)
        {
            Clear();

            var mazeArray = new int[widthOfMaze + 1][];
            var mazeSetupArray = new int[widthOfMaze + 1][];

            for(var i = 0; i <= widthOfMaze; i++)
            {
                mazeSetupArray[i] = new int[heightOfMaze + 1];
                mazeArray[i] = new int[heightOfMaze + 1];
            }

            var someVariableThatGetsCheckedOnce = 0;
            var isEqualTo = 0;
            var randomNum = NewRandomNumber(widthOfMaze);

            var total = 1;
            mazeSetupArray[randomNum][1] = total;
            total++;

            var currentHeight = randomNum;
            var currentWidth = 1;

            Target = 30;

            try
            {
                while(Target > 0)
                {
                    switch(Target)
                    {
                        case 10:
                            if(currentHeight == widthOfMaze)
                            {
                                if(currentWidth == heightOfMaze)
                                {
                                    currentWidth = 1;
                                }
                                else
                                {
                                    currentWidth++;
                                }
                                currentHeight = 1;
                            }
                            else
                            {
                                currentHeight++;
                            }
                            Target = 20;
                            break;
                        case 20:
                            if(mazeSetupArray[currentHeight][currentWidth] == 0)
                                Target = 10;
                            else
                                Target = 30;
                            break;
                        case 30:
                            if(mazeSetupArray[currentHeight - 1][currentWidth] == 0 && currentHeight != 1)
                            {
                                if(mazeSetupArray[currentHeight][currentWidth - 1] == 0 && currentWidth != 1)
                                    Target = 40;
                                else if(currentHeight == widthOfMaze || mazeSetupArray[currentHeight + 1][currentWidth] != 0)
                                    Target = 80;
                                else
                                    Target = 60;
                            }
                            else
                            {
                                Target = 100;
                            }
                            break;
                        case 40:
                            if(currentHeight == widthOfMaze)
                                Target = 50;
                            else if(mazeSetupArray[currentHeight + 1][currentWidth] == 0)
                            {
                                NextTotal(3, 150, 160, 170);
                            }
                            else
                                Target = 50;
                            break;
                        case 50:
                            if(isEqualTo != 1 && currentWidth == heightOfMaze || mazeSetupArray[currentHeight][currentWidth + 1] == 0 && currentWidth != heightOfMaze)
                            {
                                NextTotal(3, 150, 160, 180);
                            }
                            else
                            {
                                NextTotal(2, 150, 160, 0);
                            }
                            break;
                        case 60:
                            if(isEqualTo != 1 && currentWidth == heightOfMaze)
                            {
                                someVariableThatGetsCheckedOnce = 1;
                                NextTotal(3, 150, 170, 180);
                            }
                            else if(mazeSetupArray[currentHeight][currentWidth + 1] == 0 && currentWidth != heightOfMaze)
                                NextTotal(3, 150, 170, 180);
                            else
                                NextTotal(2, 150, 170, 0);
                            break;
                        case 80:
                            if(isEqualTo == 1 && currentWidth == heightOfMaze)
                                Target = 150;
                            else if(isEqualTo != 1 && currentWidth == heightOfMaze)
                            {
                                someVariableThatGetsCheckedOnce = 1;
                                Target = 90;
                            }
                            else if(mazeSetupArray[currentHeight][currentWidth + 1] != 0 && currentWidth != heightOfMaze || isEqualTo == 1 && currentWidth == heightOfMaze)
                                Target = 150;
                            else
                                Target = 90;
                            break;
                        case 90:
                            NextTotal(2, 150, 180, 0);
                            break;
                        case 100:
                            if(mazeSetupArray[currentHeight][currentWidth - 1] == 0 && currentWidth != 1)
                                if(currentHeight == widthOfMaze)
                                    Target = 110;
                                else if(mazeSetupArray[currentHeight + 1][currentWidth] == 0)
                                {
                                    if(isEqualTo == 1 && currentWidth == heightOfMaze || mazeSetupArray[currentHeight][currentWidth + 1] != 0 && currentWidth != heightOfMaze)
                                    {
                                        NextTotal(2, 160, 170, 0);
                                    }
                                    else
                                    {
                                        NextTotal(3, 160, 170, 180);
                                    }
                                }
                                else
                                    Target = 110;
                            else
                                Target = 120;
                            break;
                        case 110:
                            if(isEqualTo == 1 && currentWidth == heightOfMaze || mazeSetupArray[currentHeight][currentWidth + 1] != 0 && currentWidth != heightOfMaze)
                                Target = 160;
                            else
                                NextTotal(2, 160, 180, 0);
                            break;
                        case 120:
                            if(currentHeight == widthOfMaze || mazeSetupArray[currentHeight + 1][currentWidth] != 0)
                                Target = 140;
                            else
                                Target = 130;
                            break;
                        case 130:
                            if(currentWidth == heightOfMaze)
                            {
                                if(isEqualTo == 1)
                                    Target = 170;
                                else
                                    Target = 160;
                            }
                            else
                            {
                                if(mazeSetupArray[currentHeight][currentWidth + 1] == 0)
                                    NextTotal(2, 170, 180, 0);
                                else
                                    Target = 170;
                            }
                            break;
                        case 140:
                            if(currentWidth == heightOfMaze)
                            {
                                if(isEqualTo == 1)
                                    Target = 10;
                                else
                                {
                                    Target = 180;
                                }
                            }
                            else if(mazeSetupArray[currentHeight][currentWidth + 1] == 0)
                                Target = 180;
                            else
                                Target = 10;
                            break;
                        case 150:
                            mazeSetupArray[currentHeight - 1][currentWidth] = total;
                            total++;
                            mazeArray[currentHeight - 1][currentWidth] = 2;
                            currentHeight--;
                            if(total == widthOfMaze*heightOfMaze + 1)
                                Target = -1;
                            else
                                Target = 30;
                            break;
                        case 160:
                            mazeSetupArray[currentHeight][currentWidth - 1] = total;
                            total++;
                            mazeArray[currentHeight][currentWidth - 1] = 1;
                            currentWidth--;
                            if(total == widthOfMaze*heightOfMaze + 1)
                                Target = -1;
                            else
                            {
                                someVariableThatGetsCheckedOnce = 0;
                                Target = 30;
                            }
                            break;
                        case 170:
                            mazeSetupArray[currentHeight + 1][currentWidth] = total;
                            total++;
                            if(mazeArray[currentHeight][currentWidth] == 0)
                            {
                                mazeArray[currentHeight][currentWidth] = 2;
                            }
                            else
                            {
                                mazeArray[currentHeight][currentWidth] = 3;
                            }
                            currentHeight++;
                            if(total == widthOfMaze*heightOfMaze + 1)
                                Target = -1;
                            else
                                Target = 100;
                            break;
                        case 180:
                            if(someVariableThatGetsCheckedOnce == 1)
                            {
                                isEqualTo = 1;
                                Target = 200;
                            }
                            else
                                Target = 190;
                            break;
                        case 190:
                            mazeSetupArray[currentHeight][currentWidth + 1] = total;
                            total++;
                            if(mazeArray[currentHeight][currentWidth] == 0)
                            {
                                mazeArray[currentHeight][currentWidth] = 1;
                            }
                            else
                            {
                                mazeArray[currentHeight][currentWidth] = 3;
                            }
                            currentWidth++;
                            if(total == heightOfMaze*widthOfMaze + 1)
                                Target = -1;
                            else
                                Target = 30;
                            break;
                        case 200:
                            if(mazeArray[currentHeight][currentWidth] == 0)
                            {
                                mazeArray[currentHeight][currentWidth] = 1;
                                someVariableThatGetsCheckedOnce = 0;
                                currentHeight = 1;
                                currentWidth = 1;
                                Target = 20;
                            }
                            else
                            {
                                mazeArray[currentHeight][currentWidth] = 3;
                                Target = 10;
                            }
                            break;
                    }
                }
            }
            catch(Exception)
            {
                // ignored
            }

            for(var i = 1; i <= widthOfMaze; i++)
            {
                if(i == randomNum)
                    Print(":  ");
                else
                    Print(":--");
            }

            Print(":\r\n");

            for(var j = 1; j <= heightOfMaze; j++)
            {
                Print("I");

                for(var i = 1; i <= widthOfMaze; i++)
                {
                    if(mazeArray[i][j] >= 2)
                        Print("   ");
                    else
                        Print("  I");
                }

                Print("\r\n");

                for(var i = 1; i <= widthOfMaze; i++)
                {
                    if(mazeArray[i][j] == 0 || mazeArray[i][j] == 2)
                        Print(":--");
                    else
                        Print(":  ");
                }

                Print(":\r\n");
            }
        }
    }
}