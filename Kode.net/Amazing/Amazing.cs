/**
 * + The original program is by Jack Hauber, and the source is
 * "Basic Computer Games." Used with permission of David Ahl;
 * see www.SwapMeetDave.com.
 * + This exercise was inspired by Alan Hensel's use of Amazing
 * as a refactoring challenge.
 * + This transliteration to Java was created by Bill Wake, William.Wake@acm.org
 */

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
            Print("Amazing - Copyright by Creative Computing, Morristown, NJ\r\n");

            var mazeArray = new int[widthOfMaze + 1][];
            var verticalArray = new int[widthOfMaze + 1][];

            for(var i = 0; i <= widthOfMaze; i++)
            {
                verticalArray[i] = new int[heightOfMaze + 1];
            }

            for(var i = 0; i <= widthOfMaze; i++)
            {
                mazeArray[i] = new int[heightOfMaze + 1];
            }

            var someVariableThatGetsCheckedOnce = 0;
            var isEqualTo = 0;
            var randomNum = NewRandomNumber(widthOfMaze);

            var total = 1;
            verticalArray[randomNum][1] = total;
            total++;

            var equalToRandomNum = randomNum;
            var someWeirdNum = 1;


            for(var i = 1; i <= widthOfMaze; i++)
            {
                if(i == randomNum)
                    Print(":  ");
                else
                    Print(":--");
            }

            Print(":\r\n");

            Target = 270;

            try
            {
                while(Target > 0)
                {
                    switch(Target)
                    {
                        case 210:
                            if(equalToRandomNum == widthOfMaze)
                            {
                                if(someWeirdNum == heightOfMaze)
                                {
                                    someWeirdNum = 1;
                                }
                                else
                                {
                                    someWeirdNum++;
                                }
                                equalToRandomNum = 1;
                            }
                            else
                            {
                                equalToRandomNum++;
                            }
                            Target = 260;
                            break;
                        case 260:
                            if(verticalArray[equalToRandomNum][someWeirdNum] == 0)
                                Target = 210;
                            else
                                Target = 270;
                            break;
                        case 270:
                            if(verticalArray[equalToRandomNum - 1][someWeirdNum] == 0 && equalToRandomNum != 1)
                            {
                                if(verticalArray[equalToRandomNum][someWeirdNum - 1] == 0 && someWeirdNum != 1)
                                    Target = 310;
                                else if(equalToRandomNum == widthOfMaze || verticalArray[equalToRandomNum + 1][someWeirdNum] != 0)
                                    Target = 530;
                                else
                                    Target = 450;
                            }
                            else
                            {
                                Target = 600;
                            }
                            break;
                        case 310:
                            if(equalToRandomNum == widthOfMaze)
                                Target = 350;
                            else if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                            {
                                NextTotal(3, 940, 980, 1030);
                            }
                            else
                                Target = 350;
                            break;
                        case 350:
                            if(isEqualTo != 1 && someWeirdNum == heightOfMaze || verticalArray[equalToRandomNum][someWeirdNum + 1] == 0 && someWeirdNum != heightOfMaze)
                            {
                                NextTotal(3, 940, 980, 1090);
                            }
                            else
                            {
                                NextTotal(2, 940, 980, 0);
                            }
                            break;
                        case 450:
                            if(isEqualTo != 1 && someWeirdNum == heightOfMaze)
                            {
                                someVariableThatGetsCheckedOnce = 1;
                                Target = 490;
                            }
                            else if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0 && someWeirdNum != heightOfMaze)
                                Target = 490;
                            else
                                NextTotal(2, 940, 1030, 0);
                            break;
                        case 490:
                            NextTotal(3, 940, 1030, 1090);
                            break;
                        case 530:
                            if(isEqualTo == 1 && someWeirdNum == heightOfMaze)
                                Target = 940;
                            else if(isEqualTo != 1 && someWeirdNum == heightOfMaze)
                            {
                                someVariableThatGetsCheckedOnce = 1;
                                Target = 570;
                            }
                            else if(verticalArray[equalToRandomNum][someWeirdNum + 1] != 0 && someWeirdNum != heightOfMaze || isEqualTo == 1 && someWeirdNum == heightOfMaze)
                                Target = 940;
                            else
                                Target = 570;
                            break;
                        case 570:
                            NextTotal(2, 940, 1090, 0);
                            break;
                        case 600:
                            if(verticalArray[equalToRandomNum][someWeirdNum - 1] == 0 && someWeirdNum != 1)
                                if(equalToRandomNum == widthOfMaze)
                                    Target = 720;
                                else
                                {
                                    if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                                    {
                                        if(isEqualTo == 1 && someWeirdNum == heightOfMaze || verticalArray[equalToRandomNum][someWeirdNum + 1] != 0 && someWeirdNum != heightOfMaze)
                                        {
                                            NextTotal(2, 980, 1030, 0);
                                        }
                                        else
                                        {
                                            NextTotal(3, 980, 1030, 1090);
                                        }
                                    }
                                    else
                                        Target = 720;
                                }
                            else
                                Target = 790;
                            break;
                        case 640:
                            break;
                        case 720:
                            if(isEqualTo == 1 && someWeirdNum == heightOfMaze || verticalArray[equalToRandomNum][someWeirdNum + 1] != 0 && someWeirdNum != heightOfMaze)
                                Target = 980;
                            else
                                NextTotal(2, 980, 1090, 0);
                            break;
                        case 790:
                            if(equalToRandomNum == widthOfMaze)
                                Target = 880;
                            else
                            {
                                if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                                    Target = 810;
                                else
                                    Target = 880;
                            }
                            break;
                        case 810:
                            if(someWeirdNum == heightOfMaze)
                            {
                                if(isEqualTo == 1)
                                    Target = 1030;
                                else
                                    Target = 1000;
                            }
                            else
                            {
                                if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                                    NextTotal(2, 1030, 1090, 0);
                                else
                                    Target = 1030;
                            }
                            break;
                        case 880:
                            if(someWeirdNum == heightOfMaze)
                            {
                                if(isEqualTo == 1)
                                    Target = 210;
                                else
                                {
                                    Target = 1090;
                                }
                            }
                            else if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                                Target = 1090;
                            else
                                Target = 210;
                            break;
                        case 940:
                            verticalArray[equalToRandomNum - 1][someWeirdNum] = total;
                            total++;
                            mazeArray[equalToRandomNum - 1][someWeirdNum] = 2;
                            equalToRandomNum--;
                            if(total == widthOfMaze*heightOfMaze + 1)
                                Target = -1;
                            else
                                Target = 270;
                            break;
                        case 980:
                            verticalArray[equalToRandomNum][someWeirdNum - 1] = total;
                            Target = 1000;
                            break;
                        case 1000:
                            total++;
                            mazeArray[equalToRandomNum][someWeirdNum - 1] = 1;
                            someWeirdNum--;
                            if(total == widthOfMaze*heightOfMaze + 1)
                                Target = -1;
                            else
                            {
                                someVariableThatGetsCheckedOnce = 0;
                                Target = 270;
                            }
                            break;
                        case 1030:
                            verticalArray[equalToRandomNum + 1][someWeirdNum] = total;
                            total++;
                            if(mazeArray[equalToRandomNum][someWeirdNum] == 0)
                            {
                                mazeArray[equalToRandomNum][someWeirdNum] = 2;
                            }
                            else
                            {
                                mazeArray[equalToRandomNum][someWeirdNum] = 3;
                            }
                            equalToRandomNum++;
                            if(total == widthOfMaze*heightOfMaze + 1)
                                Target = -1;
                            else
                                Target = 600;
                            break;
                        case 1090:
                            if(someVariableThatGetsCheckedOnce == 1)
                            {
                                isEqualTo = 1;
                                Target = 1160;
                            }
                            else
                                Target = 1100;
                            break;
                        case 1100:
                            verticalArray[equalToRandomNum][someWeirdNum + 1] = total;
                            total++;
                            if(mazeArray[equalToRandomNum][someWeirdNum] == 0)
                            {
                                mazeArray[equalToRandomNum][someWeirdNum] = 1;
                                Target = 1130;
                            }
                            else
                            {
                                mazeArray[equalToRandomNum][someWeirdNum] = 3;
                                Target = 1130;
                            }
                            break;
                        case 1130:
                            someWeirdNum++;
                            if(total == heightOfMaze*widthOfMaze + 1)
                                Target = -1;
                            else
                                Target = 270;
                            break;
                        case 1160:
                            if(mazeArray[equalToRandomNum][someWeirdNum] == 0)
                            {
                                mazeArray[equalToRandomNum][someWeirdNum] = 1;
                                someVariableThatGetsCheckedOnce = 0;
                                equalToRandomNum = 1;
                                someWeirdNum = 1;
                                Target = 260;
                            }
                            else
                            {
                                mazeArray[equalToRandomNum][someWeirdNum] = 3;
                                Target = 210;
                            }
                            break;
                    }
                }
            }
            catch(Exception)
            {
                // ignored
            }

            for(int j = 1; j <= heightOfMaze; j++)
            {
                Print("I");

                for(int i = 1; i <= widthOfMaze; i++)
                {
                    if(mazeArray[i][j] >= 2)
                        Print("   ");
                    else
                        Print("  I");
                }

                Print(" \r\n");

                for(int i = 1; i <= widthOfMaze; i++)
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