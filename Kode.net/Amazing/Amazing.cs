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

        public static void NextTarget(int total, int num1, int num2, int num3)
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

        public static void ExitCheck(int total, int widthOfMaze, int heightOfMaze)
        {
            if(total == widthOfMaze*heightOfMaze + 1)
                Target = -1;
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

            var foundSuccefulPath = false;
            var pathFoundCheck = false;

            var randomNum = NewRandomNumber(widthOfMaze);

            var total = 1;
            mazeSetupArray[randomNum][1] = total;
            total++;

            var currentHeight = randomNum;
            var currentWidth = 1;

            Target = 10;
            try
            {
                while(Target > 0)
                {
                    switch(Target)
                    {
                        case 10:
                            Start(widthOfMaze, heightOfMaze, ref currentHeight, mazeSetupArray, total, ref currentWidth);
                            break;
                        case 30:
                            if(currentHeight == widthOfMaze)
                                Target = 40;
                            else if(mazeSetupArray[currentHeight + 1][currentWidth] == 0)
                                NextTarget(3, 150, 160, 170);
                            else
                                Target = 40;
                            break;
                        case 40:
                            if(!foundSuccefulPath && currentWidth == heightOfMaze || mazeSetupArray[currentHeight][currentWidth + 1] == 0 && currentWidth != heightOfMaze)
                                NextTarget(3, 150, 160, 180);
                            else
                                NextTarget(2, 150, 160, 0);
                            break;
                        case 50:
                            if(!pathFoundCheck && currentWidth == heightOfMaze)
                            {
                                foundSuccefulPath = true;
                                NextTarget(3, 150, 170, 180);
                            }
                            else if(mazeSetupArray[currentHeight][currentWidth + 1] == 0 && currentWidth != heightOfMaze)
                                NextTarget(3, 150, 170, 180);
                            else
                                NextTarget(2, 150, 170, 0);
                            break;
                        case 70:
                            if(!pathFoundCheck && currentWidth == heightOfMaze)
                            {
                                foundSuccefulPath = true;
                                NextTarget(2, 150, 180, 0);
                            }
                            else if(( pathFoundCheck && currentWidth == heightOfMaze ) || ( mazeSetupArray[currentHeight][currentWidth + 1] != 0 && currentWidth != heightOfMaze ))
                                Target = 150;
                            else
                                NextTarget(2, 150, 180, 0);
                            break;
                        case 100:
                            if(mazeSetupArray[currentHeight][currentWidth - 1] == 0 && currentWidth != 1)
                                if(currentHeight == widthOfMaze)
                                    Target = 110;
                                else if(mazeSetupArray[currentHeight + 1][currentWidth] == 0)
                                {
                                    if(pathFoundCheck && currentWidth == heightOfMaze || mazeSetupArray[currentHeight][currentWidth + 1] != 0 && currentWidth != heightOfMaze)
                                        NextTarget(2, 160, 170, 0);
                                    else
                                        NextTarget(3, 160, 170, 180);
                                }
                                else
                                    Target = 110;
                            else
                            {
                                if(currentHeight == widthOfMaze || mazeSetupArray[currentHeight + 1][currentWidth] != 0)
                                    if(currentWidth == heightOfMaze && pathFoundCheck)
                                        Target = 10;
                                    else if(mazeSetupArray[currentHeight][currentWidth + 1] == 0 || currentWidth == heightOfMaze)
                                        Target = 180;
                                    else
                                        Target = 10;
                                else
                                    Target = 130;
                            }
                            break;
                        case 110:
                            if(( pathFoundCheck && currentWidth == heightOfMaze ) || ( mazeSetupArray[currentHeight][currentWidth + 1] != 0 && currentWidth != heightOfMaze ))
                                Target = 160;
                            else
                                NextTarget(2, 160, 180, 0);
                            break;
                        case 130:
                            if(currentWidth == heightOfMaze)
                            {
                                if(pathFoundCheck)
                                    Target = 170;
                                else
                                    Target = 160;
                            }
                            else if(mazeSetupArray[currentHeight][currentWidth + 1] == 0)
                                NextTarget(2, 170, 180, 0);
                            else
                                Target = 170;
                            break;
                        case 150:
                            currentHeight--;
                            mazeArray[currentHeight][currentWidth] = 2;
                            Target = 155;
                            break;
                        case 155:
                            total++;
                            foundSuccefulPath = false;
                            FoundSuccefulPath(widthOfMaze, heightOfMaze, mazeSetupArray, currentHeight, currentWidth, total);
                            break;
                        case 160:
                            currentWidth--;
                            mazeArray[currentHeight][currentWidth] = 1;
                            Target = 155;
                            break;
                        case 170:
                            if(mazeArray[currentHeight][currentWidth] == 0)
                                mazeArray[currentHeight][currentWidth] = 2;
                            else
                                mazeArray[currentHeight][currentWidth] = 3;

                            currentHeight++;
                            mazeSetupArray[currentHeight][currentWidth] = total;
                            total++;
                            Target = 100;
                            ExitCheck(total, widthOfMaze, heightOfMaze);
                            break;
                        case 180:
                            if(mazeArray[currentHeight][currentWidth] == 0)
                                mazeArray[currentHeight][currentWidth] = 1;
                            else
                                mazeArray[currentHeight][currentWidth] = 3;

                            if(foundSuccefulPath)
                            {
                                pathFoundCheck = true;
                                Target = 10;
                            }
                            else
                            {
                                currentWidth++;
                                total++;
                                FoundSuccefulPath(widthOfMaze, heightOfMaze, mazeSetupArray, currentHeight, currentWidth, total);
                            }
                            break;
                    }
                }
            }
            catch(Exception)
            {
                // ignored
            }

/*                try
                {
                    for(int j = 0; j <= heightOfMaze; j++)
                    {
                        for(int i = 0; i <= widthOfMaze; i++)
                        {
                            Print(" " + mazeSetupArray[i][j].ToString("D3"));
                        }
                        Print("\r\n");
                    }
    
                    for(int j = 0; j <= heightOfMaze; j++)
                    {
                        for(int i = 0; i <= widthOfMaze; i++)
                        {
                            Print(" " + mazeArray[i][j]);
                        }
                        Print("\r\n");
                    }
                }
                catch(Exception)
                {
                    //Ignored
                }*/

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
        
        
        private static void Start(int widthOfMaze, int heightOfMaze, ref int currentHeight, int[][] mazeSetupArray, int total, ref int currentWidth)
        {
            if(currentHeight == widthOfMaze)
            {
                currentHeight = 1;
                if(currentWidth == heightOfMaze)
                    currentWidth = 1;
                else
                    currentWidth++;
            }
            else
                currentHeight++;
            if(mazeSetupArray[currentHeight][currentWidth] == 0)
                Target = 10;
            else
            {
                FoundSuccefulPath(widthOfMaze, heightOfMaze, mazeSetupArray, currentHeight, currentWidth, total);
            }
        }

        private static void FoundSuccefulPath(int widthOfMaze, int heightOfMaze, int[][] mazeSetupArray, int currentHeight, int currentWidth, int total)
        {
            mazeSetupArray[currentHeight][currentWidth] = total;
            if(mazeSetupArray[currentHeight - 1][currentWidth] == 0 && currentHeight != 1)
            {
                if(mazeSetupArray[currentHeight][currentWidth - 1] == 0 && currentWidth != 1)
                    Target = 30;
                else if(currentHeight == widthOfMaze || mazeSetupArray[currentHeight + 1][currentWidth] != 0)
                    Target = 70;
                else
                    Target = 50;
            }
            else
                Target = 100;
            ExitCheck(total, widthOfMaze, heightOfMaze);
        }
    }
}