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

        public static void NextTargetNumber(int caseLength, int num1, int num2, int num3)
        {
            switch (NewRandomNumber(caseLength))
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

        public static void SimpleIf(int input1, int input2, int target1, int target2)
        {
            if (input1 == input2)
            {
                Target = target1;
            }
            else
            {
                Target = target2;
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
                        NextTargetNumber(3, 940, 980, 1030);
                        break;
                    case 350:
                        if(someWeirdNum == verticalNumber)
                        {
                            SimpleIf(z, 1, 420, 400);
                        }
                        else
                        {
                            SimpleIf(verticalArray[equalToRandomNum][someWeirdNum + 1], 0, 400, 420);
                        }
                        break;
                    case 400:
                        NextTargetNumber(3, 940, 980, 1090);
                        break;
                    case 420:
                        NextTargetNumber(2, 940, 980, 0);
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
                        NextTargetNumber(3, 940, 1030, 1090);
                        break;
                    case 510:
                        NextTargetNumber(2, 940, 1030, 0);
                        break;
                    case 530:
                        SimpleIf(someWeirdNum, verticalNumber, 540, 560);
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
                        SimpleIf(verticalArray[equalToRandomNum][someWeirdNum + 1], 0, 570, 940);
                        break;
                    case 570:
                        NextTargetNumber(2, 940, 1090, 0);
                        break;
                    case 600:
                        SimpleIf(someWeirdNum, 1, 790, 610);
                        break;
                    case 610:
                        SimpleIf(verticalArray[equalToRandomNum][someWeirdNum - 1], 0, 620, 790);
                        break;
                    case 620:
                        SimpleIf(equalToRandomNum, horizontalNumber, 720, 630);
                        break;
                    case 630:
                        SimpleIf(verticalArray[equalToRandomNum + 1][someWeirdNum], 0, 640, 720);
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
                        NextTargetNumber(3, 980, 1030, 1090);
                        break;
                    case 710:
                        NextTargetNumber(2, 980, 1030, 0);
                        break;
                    case 720:
                        if(someWeirdNum == verticalNumber)
                            SimpleIf(z, 1, 980, 770);
                        else
                            Target = 750;
                        break;
                    case 750:
                        SimpleIf(verticalArray[equalToRandomNum][someWeirdNum + 1], 0, 770, 980);
                        break;
                    case 770:
                        NextTargetNumber(2, 980, 1090, 0);
                        break;
                    case 790:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 880;
                        else
                        {
                            SimpleIf(verticalArray[equalToRandomNum + 1][someWeirdNum], 0, 810, 880);
                        }
                        break;
                    case 810:
                        if(someWeirdNum == verticalNumber)
                        {
                            SimpleIf(z, 1, 1030, 1000);
                        }
                        else
                        {
                            SimpleIf(verticalArray[equalToRandomNum][someWeirdNum + 1], 0, 860, 1030);
                        }
                        break;
                    case 860:
                        NextTargetNumber(2, 1030, 1090, 0);
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
                        SimpleIf(verticalArray[equalToRandomNum][someWeirdNum + 1], 0, 1090, 210);
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
                        SimpleIf(total, (verticalNumber * horizontalNumber + 1), -1, 270);
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