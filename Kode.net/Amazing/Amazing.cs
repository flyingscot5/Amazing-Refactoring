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

        public static void Doit(int horizontal, int vertical)
        {
            Clear();
            Print("Amazing - Copyright by Creative Computing, Morristown, NJ");
            Println();

            var horizontalSide = horizontal;
            var verticalSide = vertical;
            if(horizontalSide == 1 || verticalSide == 1) return;

            var wArray = new int[horizontalSide + 1][];

            for(var i = 0; i <= horizontalSide; i++)
            {
                wArray[i] = new int[verticalSide + 1];
            }

            var vArray = new int[horizontalSide + 1][];
            for(var i = 0; i <= horizontalSide; i++)
            {
                vArray[i] = new int[verticalSide + 1];
            }

            var wasq = 0;
            var z = 0;
            var randomNum = NextRandomNumber(horizontalSide);

            var c = 1;
            wArray[randomNum][1] = c;
            c++;

            var r = randomNum;
            var s = 1;


            for(var i = 1; i <= horizontalSide; i++)
            {
                if(i == randomNum)
                    Print(":  ");
                else
                    Print(":--");
            }

            Print(":");
            Println();

            Target = 270;

            while(Target != -1)
            {
                switch(Target)
                {
                    case 210:
                        if(r != horizontalSide)
                            Target = 250;
                        else
                            Target = 220;
                        break;
                    case 220:
                        if(s != verticalSide)
                            Target = 240;
                        else
                            Target = 230;
                        break;
                    case 230:
                        r = 1;
                        s = 1;
                        Target = 260;
                        break;
                    case 240:
                        r = 1;
                        s++;
                        Target = 260;
                        break;
                    case 250:
                        r++;
                        Target = 260;
                        break;
                    case 260:
                        if(wArray[r][s] == 0)
                            Target = 210;
                        else
                            Target = 270;
                        break;
                    case 270:
                        if(r - 1 == 0)
                            Target = 600;
                        else
                            Target = 280;
                        break;
                    case 280:
                        if(wArray[r - 1][s] != 0)
                            Target = 600;
                        else
                            Target = 290;
                        break;
                    case 290:
                        if(s - 1 == 0)
                            Target = 430;
                        else
                            Target = 300;
                        break;
                    case 300:
                        if(wArray[r][s - 1] != 0)
                            Target = 430;
                        else
                            Target = 310;
                        break;
                    case 310:
                        if(r == horizontalSide)
                            Target = 350;
                        else
                            Target = 320;
                        break;
                    case 320:
                        if(wArray[r + 1][s] != 0)
                            Target = 350;
                        else
                            Target = 330;
                        break;
                    case 330:
                        randomNum = NextRandomNumber(3);
                        Target = 340;
                        break;
                    case 340:
                        if(randomNum == 1)
                            Target = 940;
                        else if(randomNum == 2)
                            Target = 980;
                        else if(randomNum == 3)
                            Target = 1020;
                        else
                            Target = 350;
                        break;
                    case 350:
                        if(s != verticalSide)
                            Target = 380;
                        else
                            Target = 360;
                        break;
                    case 360:
                        if(z == 1)
                            Target = 410;
                        else
                            Target = 370;
                        break;
                    case 370:
                        wasq = 1;
                        Target = 390;
                        break;
                    case 380:
                        if(wArray[r][s + 1] != 0)
                            Target = 410;

                        else
                            Target = 390;
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
                        if(r == horizontalSide)
                            Target = 530;

                        else
                            Target = 440;
                        break;
                    case 440:
                        if(wArray[r + 1][s] != 0)
                            Target = 530;

                        else
                            Target = 450;
                        break;
                    case 450:
                        if(s != verticalSide)
                            Target = 480;

                        else
                            Target = 460;
                        break;
                    case 460:
                        if(z == 1)
                            Target = 510;

                        else
                            Target = 470;
                        break;
                    case 470:
                        wasq = 1;
                        Target = 490;
                        break;
                    case 480:
                        if(wArray[r][s + 1] != 0)
                            Target = 510;

                        else
                            Target = 490;
                        break;
                    case 490:
                        randomNum = NextRandomNumber(3);
                        Target = 500;
                        break;
                    case 500:
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
                        Target = 520;
                        break;
                    case 520:
                        if(randomNum == 1)
                            Target = 940;

                        else if(randomNum == 2)
                            Target = 1020;

                        else
                            Target = 530;
                        break;
                    case 530:
                        if(s != verticalSide)
                            Target = 560;

                        else
                            Target = 540;
                        break;
                    case 540:
                        if(z == 1)
                            Target = 590;

                        else
                            Target = 550;
                        break;
                    case 550:
                        wasq = 1;
                        Target = 570;
                        break;
                    case 560:
                        if(wArray[r][s + 1] != 0)
                            Target = 590;

                        else
                            Target = 570;
                        break;
                    case 570:
                        randomNum = NextRandomNumber(2);
                        Target = 580;
                        break;
                    case 580:
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
                        if(s - 1 == 0)
                            Target = 790;

                        else
                            Target = 610;
                        break;
                    case 610:
                        if(wArray[r][s - 1] != 0)
                            Target = 790;

                        else
                            Target = 620;
                        break;
                    case 620:
                        if(r == horizontalSide)
                            Target = 720;

                        else
                            Target = 630;
                        break;
                    case 630:
                        if(wArray[r + 1][s] != 0)
                            Target = 720;

                        else
                            Target = 640;
                        break;
                    case 640:
                        if(s != verticalSide)
                            Target = 670;

                        else
                            Target = 650;
                        break;
                    case 650:
                        if(z == 1)
                            Target = 700;

                        else
                            Target = 660;
                        break;
                    case 660:
                        wasq = 1;
                        Target = 680;
                        break;
                    case 670:
                        if(wArray[r][s + 1] != 0)
                            Target = 700;

                        else
                            Target = 680;
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
                        if(s != verticalSide)
                            Target = 750;

                        else
                            Target = 730;
                        break;
                    case 730:
                        if(z == 1)
                            Target = 780;

                        else
                            Target = 740;
                        break;
                    case 740:
                        wasq = 1;
                        Target = 760;
                        break;
                    case 750:
                        if(wArray[r][s + 1] != 0)
                            Target = 780;

                        else
                            Target = 760;
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
                        if(r == horizontalSide)
                            Target = 880;

                        else
                            Target = 800;
                        break;
                    case 800:
                        if(wArray[r + 1][s] != 0)
                            Target = 880;

                        else
                            Target = 810;
                        break;
                    case 810:
                        if(s != verticalSide)
                            Target = 840;

                        else
                            Target = 820;
                        break;
                    case 820:
                        if(z == 1)
                            Target = 870;

                        else
                            Target = 830;
                        break;
                    case 830:
                        wasq = 1;
                        Target = 990;
                        break;
                    case 840:
                        if(wArray[r][s + 1] != 0)
                            Target = 870;

                        else
                            Target = 850;
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
                        if(s != verticalSide)
                            Target = 910;

                        else
                            Target = 890;
                        break;
                    case 890:
                        if(z == 1)
                            Target = 930;

                        else
                            Target = 900;
                        break;
                    case 900:
                        wasq = 1;
                        Target = 920;
                        break;
                    case 910:
                        if(wArray[r][s + 1] != 0)
                            Target = 930;

                        else
                            Target = 920;
                        break;
                    case 920:
                        Target = 1090;
                        break;
                    case 930:
                        Target = 1190;
                        break;
                    case 940:
                        wArray[r - 1][s] = c;
                        Target = 950;
                        break;
                    case 950:
                        c++;
                        vArray[r - 1][s] = 2;
                        r--;
                        Target = 960;
                        break;
                    case 960:
                        if(c == horizontalSide*verticalSide + 1)
                            Target = 1200;

                        else
                            Target = 970;
                        break;
                    case 970:
                        wasq = 0;
                        Target = 270;
                        break;
                    case 980:
                        wArray[r][s - 1] = c;
                        Target = 990;
                        break;
                    case 990:
                        c++;
                        Target = 1000;
                        break;
                    case 1000:
                        vArray[r][s - 1] = 1;
                        s--;
                        if(c == horizontalSide*verticalSide + 1)
                            Target = 1200;
                        else
                            Target = 1010;
                        break;
                    case 1010:
                        wasq = 0;
                        Target = 270;
                        break;
                    case 1020:
                        wArray[r + 1][s] = c;
                        Target = 1030;
                        break;
                    case 1030:
                        c++;
                        if(vArray[r][s] == 0)
                            Target = 1050;
                        else
                            Target = 1040;
                        break;
                    case 1040:
                        vArray[r][s] = 3;
                        Target = 1060;
                        break;
                    case 1050:
                        vArray[r][s] = 2;
                        Target = 1060;
                        break;
                    case 1060:
                        r++;
                        Target = 1070;
                        break;
                    case 1070:
                        if(c == horizontalSide*verticalSide + 1)
                            Target = 1200;

                        else
                            Target = 1080;
                        break;
                    case 1080:
                        Target = 600;
                        break;
                    case 1090:
                        if(wasq == 1)
                            Target = 1150;

                        else
                            Target = 1100;
                        break;
                    case 1100:
                        wArray[r][s + 1] = c;
                        c++;
                        if(vArray[r][s] == 0)
                            Target = 1120;

                        else
                            Target = 1110;
                        break;
                    case 1110:
                        vArray[r][s] = 3;
                        Target = 1130;
                        break;
                    case 1120:
                        vArray[r][s] = 1;

                        Target = 1130;
                        break;
                    case 1130:
                        s++;
                        if(c == verticalSide*horizontalSide + 1)
                            Target = 1200;

                        else
                            Target = 1140;
                        break;
                    case 1140:
                        Target = 270;
                        break;
                    case 1150:
                        z = 1;
                        Target = 1160;
                        break;
                    case 1160:
                        if(vArray[r][s] == 0)
                            Target = 1180;

                        else
                            Target = 1170;
                        break;
                    case 1170:
                        vArray[r][s] = 3;
                        wasq = 0;
                        Target = 1190;
                        break;
                    case 1180:
                        vArray[r][s] = 1;
                        wasq = 0;
                        r = 1;
                        s = 1;
                        Target = 260;
                        break;
                    case 1190:
                        Target = 210;
                        break;
                    case 1200:
                        Target = -1;
                        break;
                }
            }

            // 1200:
            for(int j = 1; j <= verticalSide; j++)
            {
                Print("I"); // 1210

                for(int i = 1; i <= horizontalSide; i++)
                {
                    if(vArray[i][j] >= 2)
                        Print("   "); // 1240
                    else
                        Print("  I"); // 1260
                }

                Print(" "); // 1280
                Println();

                for(int i = 1; i <= horizontalSide; i++)
                {
                    if(vArray[i][j] == 0)
                        Print(":--"); // 1300, 1340
                    else if(vArray[i][j] == 2)
                        Print(":--"); // 1310, 1340
                    else
                        Print(":  "); // 1320
                }

                Print(":"); // 1360
                Println();
            }
        }
    }
}