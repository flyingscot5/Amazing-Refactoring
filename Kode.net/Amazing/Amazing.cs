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

public class Amazing {
    private static int Target;
    public static Random Random = new Random(0);
    public static StringBuilder Result = new StringBuilder();

    public static void Main(string[] args) {
        Doit(int.Parse(args[0]),int.Parse(args[1]));
        Console.WriteLine(Result);
    }

    private static void Clear() {
        Result = new StringBuilder();
    }

    private static void Println() {
        Result.AppendLine();
    }

    public static void Print(string text) {
        Result.Append(text);
    }

    public static int NextRandomNumber(int count) {
        return (int) (count * Random.NextDouble()) + 1;
    }

    public static void Goto(int lineno) {
        Target = lineno;
    }

    public static void Doit(int horizontal, int vertical) {
        Clear();
        Print("Amazing - Copyright by Creative Computing, Morristown, NJ");
        Println();

        var horizontalSide = horizontal;
        var verticalSide = vertical;
        if (horizontalSide == 1 || verticalSide == 1) return;

        var wArray = new int[horizontalSide + 1][];

        for (var i = 0; i <= horizontalSide; i++) {
            wArray[i] = new int[verticalSide + 1];
        }

        var vArray = new int[horizontalSide + 1][];
        for (var i = 0; i <= horizontalSide; i++) {
            vArray[i] = new int[verticalSide + 1];
        }

        var q = 0;
        var z = 0;
        var randomNum = NextRandomNumber(horizontalSide);

        // 130:170
        for (var i = 1; i <= horizontalSide; i++) {
            if (i == randomNum)
                Print(":  ");
            else
                Print(":--");
        }
        // 180
        Print(":");
        Println();

        // 190
        int c = 1;
        wArray[randomNum][1] = c;
        c++;

        // 200
        int r = randomNum;
        int s = 1;

        Goto(270);

        while (Target != -1) {
            switch (Target) {
                case 210:
                    if (r != horizontalSide)
                        Goto(250);
                    else
                        Goto(220);
                    continue;
                case 220:
                    if (s != verticalSide)
                        Goto(240);
                    else
                        Goto(230);
                    continue;
                case 230:
                    r = 1;
                    s = 1;
                    Goto(260);
                    continue;
                case 240:
                    r = 1;
                    s++;
                    Goto(260);
                    continue;
                case 250:
                    r++;
                    Goto(260);
                    continue;
                case 260:
                    if (wArray[r][s] == 0)
                        Goto(210);
                    else
                        Goto(270);
                    continue;
                case 270:
                    if (r - 1 == 0)
                        Goto(600);
                    else
                        Goto(280);
                    continue;
                case 280:
                    if (wArray[r - 1][s] != 0)
                        Goto(600);
                    else
                        Goto(290);
                    continue;
                case 290:
                    if (s - 1 == 0)
                        Goto(430);
                    else
                        Goto(300);
                    continue;
                case 300:
                    if (wArray[r][s - 1] != 0)
                        Goto(430);
                    else
                        Goto(310);
                    continue;
                case 310:
                    if (r == horizontalSide)
                        Goto(350);
                    else
                        Goto(320);
                    continue;
                case 320:
                    if (wArray[r + 1][s] != 0)
                        Goto(350);
                    else
                        Goto(330);
                    continue;
                case 330:
                    randomNum = NextRandomNumber(3);
                    Goto(340);
                    continue;
                case 340:
                    if (randomNum == 1)
                        Goto(940);
                    else if (randomNum == 2)
                        Goto(980);
                    else if (randomNum == 3)
                        Goto(1020);
                    else
                        Goto(350);
                    continue;
                case 350:
                    if (s != verticalSide)
                        Goto(380);
                    else
                        Goto(360);
                    continue;
                case 360:
                    if (z == 1)
                        Goto(410);
                    else
                        Goto(370);
                    continue;
                case 370:
                    q = 1;
                    Goto(390);
                    continue;
                case 380:
                    if (wArray[r][s + 1] != 0)
                        Goto(410);
                    else
                        Goto(390);
                    continue;
                case 390:
                    randomNum = NextRandomNumber(3);
                    Goto(400);
                    continue;
                case 400:
                    if (randomNum == 1)
                        Goto(940);
                    else if (randomNum == 2)
                        Goto(980);
                    else if (randomNum == 3)
                        Goto(1090);
                    else
                        Goto(410);
                    continue;
                case 410:
                    randomNum = NextRandomNumber(2);
                    Goto(420);
                    continue;
                case 420:
                    if (randomNum == 1)
                        Goto(940);
                    else if (randomNum == 2)
                        Goto(980);
                    else
                        Goto(430);
                    continue;
                case 430:
                    if (r == horizontalSide)
                        Goto(530);
                    else
                        Goto(440);
                    continue;
                case 440:
                    if (wArray[r + 1][s] != 0)
                        Goto(530);
                    else
                        Goto(450);
                    continue;
                case 450:
                    if (s != verticalSide)
                        Goto(480);
                    else
                        Goto(460);
                    continue;
                case 460:
                    if (z == 1)
                        Goto(510);
                    else
                        Goto(470);
                    continue;
                case 470:
                    q = 1;
                    Goto(490);
                    continue;
                case 480:
                    if (wArray[r][s + 1] != 0)
                        Goto(510);
                    else
                        Goto(490);
                    continue;
                case 490:
                    randomNum = NextRandomNumber(3);
                    Goto(500);
                    continue;
                case 500:
                    if (randomNum == 1)
                        Goto(940);
                    else if (randomNum == 2)
                        Goto(1020);
                    else if (randomNum == 3)
                        Goto(1090);
                    else
                        Goto(510);
                    continue;
                case 510:
                    randomNum = NextRandomNumber(2);
                    Goto(520);
                    continue;
                case 520:
                    if (randomNum == 1)
                        Goto(940);
                    else if (randomNum == 2)
                        Goto(1020);
                    else
                        Goto(530);
                    continue;
                case 530:
                    if (s != verticalSide)
                        Goto(560);
                    else
                        Goto(540);
                    continue;
                case 540:
                    if (z == 1)
                        Goto(590);
                    else
                        Goto(550);
                    continue;
                case 550:
                    q = 1;
                    Goto(570);
                    continue;
                case 560:
                    if (wArray[r][s + 1] != 0)
                        Goto(590);
                    else
                        Goto(570);
                    continue;
                case 570:
                    randomNum = NextRandomNumber(2);
                    Goto(580);
                    continue;
                case 580:
                    if (randomNum == 1)
                        Goto(940);
                    else if (randomNum == 2)
                        Goto(1090);
                    else
                        Goto(590);
                    continue;
                case 590:
                    Goto(940);
                    continue;
                case 600:
                    if (s - 1 == 0)
                        Goto(790);
                    else
                        Goto(610);
                    continue;
                case 610:
                    if (wArray[r][s - 1] != 0)
                        Goto(790);
                    else
                        Goto(620);
                    continue;
                case 620:
                    if (r == horizontalSide)
                        Goto(720);
                    else
                        Goto(630);
                    continue;
                case 630:
                    if (wArray[r + 1][s] != 0)
                        Goto(720);
                    else
                        Goto(640);
                    continue;
                case 640:
                    if (s != verticalSide)
                        Goto(670);
                    else
                        Goto(650);
                    continue;
                case 650:
                    if (z == 1)
                        Goto(700);
                    else
                        Goto(660);
                    continue;
                case 660:
                    q = 1;
                    Goto(680);
                    continue;
                case 670:
                    if (wArray[r][s + 1] != 0)
                        Goto(700);
                    else
                        Goto(680);
                    continue;
                case 680:
                    randomNum = NextRandomNumber(3);
                    Goto(690);
                    continue;
                case 690:
                    if (randomNum == 1)
                        Goto(980);
                    else if (randomNum == 2)
                        Goto(1020);
                    else if (randomNum == 3)
                        Goto(1090);
                    else
                        Goto(700);
                    continue;
                case 700:
                    randomNum = NextRandomNumber(2);
                    Goto(710);
                    continue;
                case 710:
                    if (randomNum == 1)
                        Goto(980);
                    else if (randomNum == 2)
                        Goto(1020);
                    else
                        Goto(720);
                    continue;
                case 720:
                    if (s != verticalSide)
                        Goto(750);
                    else
                        Goto(730);
                    continue;
                case 730:
                    if (z == 1)
                        Goto(780);
                    else
                        Goto(740);
                    continue;
                case 740:
                    q = 1;
                    Goto(760);
                    continue;
                case 750:
                    if (wArray[r][s + 1] != 0)
                        Goto(780);
                    else
                        Goto(760);
                    continue;
                case 760:
                    randomNum = NextRandomNumber(2);
                    Goto(770);
                    continue;
                case 770:
                    if (randomNum == 1)
                        Goto(980);
                    else if (randomNum == 2)
                        Goto(1090);
                    else
                        Goto(780);
                    continue;
                case 780:
                    Goto(980);
                    continue;
                case 790:
                    if (r == horizontalSide)
                        Goto(880);
                    else
                        Goto(800);
                    continue;
                case 800:
                    if (wArray[r + 1][s] != 0)
                        Goto(880);
                    else
                        Goto(810);
                    continue;
                case 810:
                    if (s != verticalSide)
                        Goto(840);
                    else
                        Goto(820);
                    continue;
                case 820:
                    if (z == 1)
                        Goto(870);
                    else
                        Goto(830);
                    continue;
                case 830:
                    q = 1;
                    Goto(990);
                    continue;
                case 840:
                    if (wArray[r][s + 1] != 0)
                        Goto(870);
                    else
                        Goto(850);
                    continue;
                case 850:
                    randomNum = NextRandomNumber(2);
                    Goto(860);
                    continue;
                case 860:
                    if (randomNum == 1)
                        Goto(1020);
                    else if (randomNum == 2)
                        Goto(1090);
                    else
                        Goto(870);
                    continue;
                case 870:
                    Goto(1020);
                    continue;
                case 880:
                    if (s != verticalSide)
                        Goto(910);
                    else
                        Goto(890);
                    continue;
                case 890:
                    if (z == 1)
                        Goto(930);
                    else
                        Goto(900);
                    continue;
                case 900:
                    q = 1;
                    Goto(920);
                    continue;
                case 910:
                    if (wArray[r][s + 1] != 0)
                        Goto(930);
                    else
                        Goto(920);
                    continue;
                case 920:
                    Goto(1090);
                    continue;
                case 930:
                    Goto(1190);
                    continue;
                case 940:
                    wArray[r - 1][s] = c;
                    Goto(950);
                    continue;
                case 950:
                    c++;
                    vArray[r - 1][s] = 2;
                    r--;
                    Goto(960);
                    continue;
                case 960:
                    if (c == horizontalSide * verticalSide + 1)
                        Goto(1200);
                    else
                        Goto(970);
                    continue;
                case 970:
                    q = 0;
                    Goto(270);
                    continue;
                case 980:
                    wArray[r][s - 1] = c;
                    Goto(990);
                    continue;
                case 990:
                    c++;
                    Goto(1000);
                    continue;
                case 1000:
                    vArray[r][s - 1] = 1;
                    s--;
                    if (c == horizontalSide * verticalSide + 1)
                        Goto(1200);
                    else
                        Goto(1010);
                    continue;
                case 1010:
                    q = 0;
                    Goto(270);
                    continue;
                case 1020:
                    wArray[r + 1][s] = c;
                    Goto(1030);
                    continue;
                case 1030:
                    c++;
                    if (vArray[r][s] == 0)
                        Goto(1050);
                    else
                        Goto(1040);
                    continue;
                case 1040:
                    vArray[r][s] = 3;
                    Goto(1060);
                    continue;
                case 1050:
                    vArray[r][s] = 2;
                    Goto(1060);
                    continue;
                case 1060:
                    r++;
                    Goto(1070);
                    continue;
                case 1070:
                    if (c == horizontalSide * verticalSide + 1)
                        Goto(1200);
                    else
                        Goto(1080);
                    continue;
                case 1080:
                    Goto(600);
                    continue;
                case 1090:
                    if (q == 1)
                        Goto(1150);
                    else
                        Goto(1100);
                    continue;
                case 1100:
                    wArray[r][s + 1] = c;
                    c++;
                    if (vArray[r][s] == 0)
                        Goto(1120);
                    else
                        Goto(1110);
                    continue;
                case 1110:
                    vArray[r][s] = 3;
                    Goto(1130);
                    continue;
                case 1120:
                    vArray[r][s] = 1;
                    Goto(1130);
                    continue;
                case 1130:
                    s++;
                    if (c == verticalSide * horizontalSide + 1)
                        Goto(1200);
                    else
                        Goto(1140);
                    continue;
                case 1140:
                    Goto(270);
                    continue;
                case 1150:
                    z = 1;
                    Goto(1160);
                    continue;
                case 1160:
                    if (vArray[r][s] == 0)
                        Goto(1180);
                    else
                        Goto(1170);
                    continue;
                case 1170:
                    vArray[r][s] = 3;
                    q = 0;
                    Goto(1190);
                    continue;
                case 1180:
                    vArray[r][s] = 1;
                    q = 0;
                    r = 1;
                    s = 1;
                    Goto(260);
                    continue;
                case 1190:
                    Goto(210);
                    continue;
                case 1200:
                    Target = -1;
                    continue;
            }

        }

        // 1200:
        for (int j = 1; j <= verticalSide; j++) {
            Print("I");        // 1210

            for (int i = 1; i <= horizontalSide; i++) {
                if (vArray[i][j] >= 2)
                    Print("   ");  // 1240
                else
                    Print("  I");  // 1260
            }

            Print(" ");   // 1280
            Println();

            for (int i = 1; i <= horizontalSide; i++) {
                if (vArray[i][j] == 0)
                    Print(":--");   // 1300, 1340
                else if (vArray[i][j] == 2)
                    Print(":--");  // 1310, 1340
                else
                    Print(":  "); // 1320
            }

            Print(":");    // 1360
            Println();
        }
    }
}
}