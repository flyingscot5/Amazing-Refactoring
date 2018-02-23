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
        public static Random Random = new Random(0);
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

        private static void Println()
        {
            Result.AppendLine();
        }

        public static void Print(string text)
        {
            Result.Append(text);
        }

        public static int NextRandomNumber(int count)
        {
            return (int)( count*Random.NextDouble() ) + 1;
        }


        public static void Doit(int horizontalNumber, int verticalNumber)
        {
            Clear();
            Print("Amazing - Copyright by Creative Computing, Morristown, NJ");
            Println();

            if(horizontalNumber == 1 || verticalNumber == 1) return;

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

            var q = 0;
            var z = 0;
            var randomNum = NextRandomNumber(horizontalNumber);

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

            Print(":");
            Println();

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
                        if(equalToRandomNum - 1 == 0)
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
                            Target = 300;
                        break;
                    case 300:
                        if(verticalArray[equalToRandomNum][someWeirdNum - 1] == 0)
                            Target = 310;
                        else
                            Target = 430;
                        break;
                    case 310:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 350;
                        else
                            Target = 320;
                        break;
                    case 320:
                        if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                        {
                            randomNum = NextRandomNumber(3);
                            Target = 340;
                        }
                        else
                            Target = 350;
                        break;
                    case 340:
                        switch(randomNum)
                        {
                            case 1:
                                Target = 940;
                                break;
                            case 2:
                                Target = 980;
                                break;
                            case 3:
                                Target = 1020;
                                break;
                            default:
                                Target = 350;
                                break;
                        }
                        break;
                    case 350:
                        if(someWeirdNum == verticalNumber)
                        {
                            if(z == 1)
                            {
                                Target = 410;
                            }
                            else
                            {
                                q = 1;
                                Target = 390;
                            }
                        }
                        else
                        {
                            if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            {
                                Target = 390;
                            }
                            else
                            {
                                Target = 410;
                            }
                        }
                        break;
                    case 390:
                        randomNum = NextRandomNumber(3);
                        Target = 400;
                        break;
                    case 400:
                        if(randomNum == 1)
                            Target = 940;

                        else if(randomNum == 2)
                            Target = 980;

                        else if(randomNum == 3)
                            Target = 1090;
                        else
                            Target = 410;
                        break;
                    case 410:
                        randomNum = NextRandomNumber(2);
                        Target = 420;
                        break;
                    case 420:
                        if(randomNum == 1)
                            Target = 940;

                        else if(randomNum == 2)
                            Target = 980;
                        else
                            Target = 430;
                        break;
                    case 430:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 530;
                        else
                            Target = 440;
                        break;
                    case 440:
                        if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                            Target = 450;
                        else
                            Target = 530;
                        break;
                    case 450:
                        if(someWeirdNum == verticalNumber)
                            Target = 460;
                        else
                            Target = 480;
                        break;
                    case 460:
                        if(z == 1)
                            Target = 510;
                        else
                            q = 1;
                        Target = 490;
                        break;
                    case 480:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 490;
                        else
                            Target = 510;
                        break;
                    case 490:
                        randomNum = NextRandomNumber(3);
                        if(randomNum == 1)
                            Target = 940;
                        else if(randomNum == 2)
                            Target = 1020;
                        else if(randomNum == 3)
                            Target = 1090;
                        else
                            Target = 510;
                        break;
                    case 510:
                        randomNum = NextRandomNumber(2);
                        if(randomNum == 1)
                            Target = 940;
                        else if(randomNum == 2)
                            Target = 1020;
                        else
                            Target = 530;
                        break;
                    case 530:
                        if(someWeirdNum == verticalNumber)
                            Target = 540;
                        else
                            Target = 560;
                        break;
                    case 540:
                        if(z == 1)
                            Target = 590;
                        else
                            q = 1;
                        Target = 570;
                        break;
                    case 560:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 570;
                        else
                            Target = 590;
                        break;
                    case 570:
                        randomNum = NextRandomNumber(2);
                        if(randomNum == 1)
                            Target = 940;
                        else if(randomNum == 2)
                            Target = 1090;
                        else
                            Target = 590;
                        break;
                    case 590:
                        Target = 940;
                        break;
                    case 600:
                        if(someWeirdNum - 1 == 0)
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
                            Target = 650;
                        else
                            Target = 670;
                        break;
                    case 650:
                        if(z == 1)
                            Target = 700;
                        else
                            Target = 660;
                        break;
                    case 660:
                        q = 1;
                        Target = 680;
                        break;
                    case 670:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 680;
                        else
                            Target = 700;
                        break;
                    case 680:
                        randomNum = NextRandomNumber(3);
                        Target = 690;
                        break;
                    case 690:
                        if(randomNum == 1)
                            Target = 980;
                        else if(randomNum == 2)
                            Target = 1020;
                        else if(randomNum == 3)
                            Target = 1090;
                        else
                            Target = 700;
                        break;
                    case 700:
                        randomNum = NextRandomNumber(2);
                        Target = 710;
                        break;
                    case 710:
                        if(randomNum == 1)
                            Target = 980;
                        else if(randomNum == 2)
                            Target = 1020;
                        else
                            Target = 720;
                        break;
                    case 720:
                        if(someWeirdNum == verticalNumber)
                            Target = 730;
                        else
                            Target = 750;
                        break;
                    case 730:
                        if(z == 1)
                            Target = 780;
                        else
                        {
                            Target = 760;
                            q = 1;
                        }
                        break;
                    case 750:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 760;
                        else
                            Target = 780;
                        break;
                    case 760:
                        randomNum = NextRandomNumber(2);
                        Target = 770;
                        break;
                    case 770:
                        if(randomNum == 1)
                            Target = 980;

                        else if(randomNum == 2)
                            Target = 1090;

                        else
                            Target = 780;
                        break;
                    case 780:
                        Target = 980;
                        break;
                    case 790:
                        if(equalToRandomNum == horizontalNumber)
                            Target = 880;

                        else
                            Target = 800;
                        break;
                    case 800:
                        if(verticalArray[equalToRandomNum + 1][someWeirdNum] == 0)
                            Target = 810;
                        else
                            Target = 880;
                        break;
                    case 810:
                        if(someWeirdNum == verticalNumber)
                            Target = 820;
                        else
                            Target = 840;
                        break;
                    case 820:
                        if(z == 1)
                            Target = 870;
                        else
                            Target = 830;
                        break;
                    case 830:
                        q = 1;
                        Target = 990;
                        break;
                    case 840:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 850;
                        else
                            Target = 870;
                        break;
                    case 850:
                        randomNum = NextRandomNumber(2);
                        Target = 860;
                        break;
                    case 860:
                        if(randomNum == 1)
                            Target = 1020;
                        else if(randomNum == 2)
                            Target = 1090;
                        else
                            Target = 870;
                        break;
                    case 870:
                        Target = 1020;
                        break;
                    case 880:
                        if(someWeirdNum == verticalNumber)
                            Target = 890;
                        else
                            Target = 910;
                        break;
                    case 890:
                        if(z == 1)
                            Target = 930;
                        else
                            Target = 900;
                        break;
                    case 900:
                        q = 1;
                        Target = 920;
                        break;
                    case 910:
                        if(verticalArray[equalToRandomNum][someWeirdNum + 1] == 0)
                            Target = 920;
                        else
                            Target = 930;
                        break;
                    case 920:
                        Target = 1090;
                        break;
                    case 930:
                        Target = 210;
                        break;
                    case 940:
                        verticalArray[equalToRandomNum - 1][someWeirdNum] = total;
                        Target = 950;
                        break;
                    case 950:
                        total++;
                        horizontalArray[equalToRandomNum - 1][someWeirdNum] = 2;
                        equalToRandomNum--;
                        Target = 960;
                        break;
                    case 960:
                        if(total == horizontalNumber*verticalNumber + 1)
                            Target = 1200;

                        else
                            Target = 970;
                        break;
                    case 970:
                        q = 0;
                        Target = 270;
                        break;
                    case 980:
                        verticalArray[equalToRandomNum][someWeirdNum - 1] = total;
                        Target = 990;
                        break;
                    case 990:
                        total++;
                        Target = 1000;
                        break;
                    case 1000:
                        horizontalArray[equalToRandomNum][someWeirdNum - 1] = 1;
                        someWeirdNum--;
                        if(total == horizontalNumber*verticalNumber + 1)
                            Target = 1200;
                        else
                            Target = 1010;
                        break;
                    case 1010:
                        q = 0;
                        Target = 270;
                        break;
                    case 1020:
                        verticalArray[equalToRandomNum + 1][someWeirdNum] = total;
                        Target = 1030;
                        break;
                    case 1030:
                        total++;
                        if(horizontalArray[equalToRandomNum][someWeirdNum] == 0)
                            Target = 1050;
                        else
                            Target = 1040;
                        break;
                    case 1040:
                        horizontalArray[equalToRandomNum][someWeirdNum] = 3;
                        Target = 1060;
                        break;
                    case 1050:
                        horizontalArray[equalToRandomNum][someWeirdNum] = 2;
                        Target = 1060;
                        break;
                    case 1060:
                        equalToRandomNum++;
                        Target = 1070;
                        break;
                    case 1070:
                        if(total == horizontalNumber*verticalNumber + 1)
                            Target = 1200;
                        else
                            Target = 1080;
                        break;
                    case 1080:
                        Target = 600;
                        break;
                    case 1090:
                        if(q == 1)
                            Target = 1150;
                        else
                            Target = 1100;
                        break;
                    case 1100:
                        verticalArray[equalToRandomNum][someWeirdNum + 1] = total;
                        total++;
                        if(horizontalArray[equalToRandomNum][someWeirdNum] == 0)
                            Target = 1120;
                        else
                            Target = 1110;
                        break;
                    case 1110:
                        horizontalArray[equalToRandomNum][someWeirdNum] = 3;
                        Target = 1130;
                        break;
                    case 1120:
                        horizontalArray[equalToRandomNum][someWeirdNum] = 1;
                        Target = 1130;
                        break;
                    case 1130:
                        someWeirdNum++;
                        if(total == verticalNumber*horizontalNumber + 1)
                            Target = 1200;
                        else
                            Target = 270;
                        break;
                    case 1150:
                        z = 1;
                        Target = 1160;
                        break;
                    case 1160:
                        if(horizontalArray[equalToRandomNum][someWeirdNum] == 0)
                            Target = 1180;
                        else
                            Target = 1170;
                        break;
                    case 1170:
                        horizontalArray[equalToRandomNum][someWeirdNum] = 3;
                        q = 0;
                        Target = 210;
                        break;
                    case 1180:
                        horizontalArray[equalToRandomNum][someWeirdNum] = 1;
                        q = 0;
                        equalToRandomNum = 1;
                        someWeirdNum = 1;
                        Target = 260;
                        break;
                    case 1200:
                        Target = -1;
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

                Print(" ");
                Println();

                for(int i = 1; i <= horizontalNumber; i++)
                {
                    if(horizontalArray[i][j] == 0 || horizontalArray[i][j] == 2)
                        Print(":--");
                    else
                        Print(":  ");
                }

                Print(":");
                Println();
            }
        }
    }
}