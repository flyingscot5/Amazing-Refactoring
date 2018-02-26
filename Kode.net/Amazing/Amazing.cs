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
            switch (NewRandomNumber(total))
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


        public static void Doit(int horizontalNumber, int verticalNumber)
        {
            Clear();
            Print("Amazing - Copyright by Creative Computing, Morristown, NJ\r\n");

            var horizontalArray = new int[horizontalNumber + 1][];
            var verticalArray = new int[horizontalNumber + 1][];

            for(var i = 0; i <= horizontalNumber; i++)
            {
                verticalArray[i] = new int[verticalNumber + 1];
            }

            for(var i = 0; i <= horizontalNumber; i++)
            {
                horizontalArray[i] = new int[verticalNumber + 1];
            }

            var someVariableThatGetsCheckedOnce = 0;
            var z = 0;
            var randomNum = NewRandomNumber(horizontalNumber);

            var total = 1;
            verticalArray[randomNum][1] = total;
            total++;

            var equalToRandomNum = randomNum;
            var someWeirdNum = 1;


            for(var i = 1; i <= horizontalNumber; i++)
            {
                if(i == randomNum)
                    Print(":  ");
                else
                    Print(":--");
            }

            Print(":\r\n");

            Target = 270;

            while(Target > 0)
            {
                switch(Target)
                {
                    case 210:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 220;
                        else
                        {
                            equalToRandomNum++;
                            Target = 260;
                        }
                        break;
                    case 220:
                        if(someWeirdNum == verticalNumber)
                        {
                            equalToRandomNum = 1;
                            someWeirdNum = 1;
                            Target = 260;
                        }
                        else
                        {
                            equalToRandomNum = 1;
                            someWeirdNum++;
                            Target = 260;
                        }
                        break;
                    case 260:
                        if(verticalArray[equalToRandomNum][someWeirdNum] == 0)
                            Target = 210;
                        else
                            Target = 270;
                        break;
                    case 270:
                        if(equalToRandomNum == 1)
                        {
                            Target = 600;
                        }
                        else if(verticalArray[equalToRandomNum - 1][someWeirdNum] == 0)
                        {
                            Target = 290;
                        }
                        else
                        {
                            Target = 600;
                        }
                        break;
                    case 290:
                        if(someWeirdNum == 1)
                            Target = 430;
                        else
                        {
                            if(verticalArray[equalToRandomNum][someWeirdNum - 1] == 0)
                                Target = 310;
                            else
                                Target = 430;
                        }
                        break;
                    case 310:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 350;
                        else if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                        {
                            Target = 340;
                        }
                        else
                            Target = 350;
                        break;
                    case 340:
                        NextTotal(3, 940, 980, 1030);
                        break;
                    case 350:
                        if(someWeirdNum == verticalNumber)
                        {
                            if(z == 1)
                            {
                                Target = 420;
                            }
                            else
                            {
                                Target = 400;
                            }
                        }
                        else
                        {
                            if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            {
                                Target = 400;
                            }
                            else
                            {
                                Target = 420;
                            }
                        }
                        break;
                    case 400:
                        NextTotal(3, 940, 980, 1090);
                        break;
                    case 420:
                        NextTotal(2, 940, 980, 0);
                        break;
                    case 430:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 530;
                        else if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                            Target = 450;
                        else
                            Target = 530;
                        break;
                    case 450:
                        if(someWeirdNum == verticalNumber)
                            Target = 460;
                        else if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 490;
                        else
                            Target = 510;
                        break;
                    case 460:
                        if(z == 1)
                            Target = 510;
                        else
                        {
                            someVariableThatGetsCheckedOnce = 1;
                            Target = 490;
                        }
                        break;
                    case 490:
                        NextTotal(3, 940, 1030, 1090);
                        break;
                    case 510:
                        NextTotal(2, 940, 1030, 0);
                        break;
                    case 530:
                        if(someWeirdNum == verticalNumber)
                            Target = 540;
                        else
                            Target = 560;
                        break;
                    case 540:
                        if(z == 1)
                            Target = 940;
                        else
                        {
                            someVariableThatGetsCheckedOnce = 1;
                            Target = 570;
                        }
                        break;
                    case 560:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 570;
                        else
                            Target = 940;
                        break;
                    case 570:
                        NextTotal(2, 940, 1090, 0);
                        break;
                    case 600:
                        if(someWeirdNum == 1)
                            Target = 790;
                        else
                            Target = 610;
                        break;
                    case 610:
                        if(verticalArray[equalToRandomNum][someWeirdNum - 1] == 0)
                            Target = 620;
                        else
                            Target = 790;
                        break;
                    case 620:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 720;
                        else
                            Target = 630;
                        break;
                    case 630:
                        if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                            Target = 640;
                        else
                            Target = 720;
                        break;
                    case 640:
                        if(someWeirdNum == verticalNumber)
                        {
                            if(z == 1)
                            {
                                Target = 710;
                            }
                            else
                            {
                                someVariableThatGetsCheckedOnce = 1;
                                Target = 690;
                            }
                        }
                        else if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                        {
                            Target = 690;
                        }
                        else
                        {
                            Target = 710;
                        }
                        break;
                    case 690:
                        NextTotal(3, 980, 1030, 1090);
                        break;
                    case 710:
                        NextTotal(2, 980, 1030, 0);
                        break;
                    case 720:
                        if(someWeirdNum == verticalNumber)
                            Target = 730;
                        else
                            Target = 750;
                        break;
                    case 730:
                        if(z == 1)
                            Target = 980;
                        else
                        {
                            Target = 770;
                        }
                        break;
                    case 750:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 770;
                        else
                            Target = 980;
                        break;
                    case 770:
                        NextTotal(2, 980, 1090, 0);
                        break;
                    case 790:
                        if(equalToRandomNum == horizontalNumber)
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
                        if(someWeirdNum == verticalNumber)
                        {
                            if(z == 1)
                                Target = 1030;
                            else
                                Target = 1000;
                        }
                        else
                        {
                            if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                                Target = 860;
                            else
                                Target = 1030;
                        }
                        break;
                    case 860:
                        NextTotal(2, 1030, 1090, 0);
                        break;
                    case 880:
                        if(someWeirdNum == verticalNumber)
                        {
                            if(z == 1)
                                Target = 210;
                            else
                            {
                                someVariableThatGetsCheckedOnce = 1;
                                Target = 1090;
                            }
                        }
                        else
                            Target = 910;
                        break;
                    case 910:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 1090;
                        else
                            Target = 210;
                        break;
                    case 940:
                        verticalArray[equalToRandomNum - 1][someWeirdNum] = total;
                        total++;
                        horizontalArray[equalToRandomNum - 1][someWeirdNum] = 2;
                        equalToRandomNum--;
                        if(total == horizontalNumber*verticalNumber + 1)
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
                        horizontalArray[equalToRandomNum][someWeirdNum - 1] = 1;
                        someWeirdNum--;
                        if(total == horizontalNumber*verticalNumber + 1)
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
                        if(horizontalArray[equalToRandomNum][someWeirdNum] == 0)
                        {
                            horizontalArray[equalToRandomNum][someWeirdNum] = 2;
                        }
                        else
                        {
                            horizontalArray[equalToRandomNum][someWeirdNum] = 3;
                        }
                        equalToRandomNum++;
                        if(total == horizontalNumber*verticalNumber + 1)
                            Target = -1;
                        else
                            Target = 600;
                        break;
                    case 1090:
                        if(someVariableThatGetsCheckedOnce == 1)
                        {
                            z = 1;
                            Target = 1160;
                        }
                        else
                            Target = 1100;
                        break;
                    case 1100:
                        verticalArray[equalToRandomNum][someWeirdNum + 1] = total;
                        total++;
                        if(horizontalArray[equalToRandomNum][someWeirdNum] == 0)
                        {
                            horizontalArray[equalToRandomNum][someWeirdNum] = 1;
                            Target = 1130;
                        }
                        else
                        {
                            horizontalArray[equalToRandomNum][someWeirdNum] = 3;
                            Target = 1130;
                        }
                        break;
                    case 1130:
                        someWeirdNum++;
                        if(total == verticalNumber*horizontalNumber + 1)
                            Target = -1;
                        else
                            Target = 270;
                        break;
                    case 1160:
                        if(horizontalArray[equalToRandomNum][someWeirdNum] == 0)
                        {
                            horizontalArray[equalToRandomNum][someWeirdNum] = 1;
                            someVariableThatGetsCheckedOnce = 0;
                            equalToRandomNum = 1;
                            someWeirdNum = 1;
                            Target = 260;
                        }
                        else
                        {
                            horizontalArray[equalToRandomNum][someWeirdNum] = 3;
                            Target = 210;
                        }
                        break;
                }
            }


            for(int j = 1; j <= verticalNumber; j++)
            {
                Print("I");

                for(int i = 1; i <= horizontalNumber; i++)
                {
                    if(horizontalArray[i][j] >= 2)
                        Print("   ");
                    else
                        Print("  I");
                }

                Print(" \r\n");

                for(int i = 1; i <= horizontalNumber; i++)
                {
                    if(horizontalArray[i][j] == 0 || horizontalArray[i][j] == 2)
                        Print(":--");
                    else
                        Print(":  ");
                }

                Print(":\r\n");
            }
        }
    }
}