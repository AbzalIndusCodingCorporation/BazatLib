using System;

namespace BazatLib {
    public class Bazat {
        private static string abzal = "Abzal";

        public static string Great() {
            Console.Write("Abzal, eto ti? [yes/no] ");
            if (Console.ReadLine() != "yes") {
                Console.Write("Horosho, vvedi imya: ");
                abzal = Console.ReadLine();
                if ((abzal == "admin") || (abzal == "root") || (abzal == "administrator")) {
                    Console.WriteLine("Horosho, vvedi password: ");
                    string adminTryIn = "";
                    while (true) {
                        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                        if (pressedKey.Key == ConsoleKey.Enter) {
                            break;
                        }
                        else {
                            adminTryIn += pressedKey.KeyChar;
                        }
                    }
                    Random rand = new Random();
                    string actuallyPassword = rand.Next(0, 9).ToString();
                    if (adminTryIn == actuallyPassword) {
                        return abzal;
                    }
                    else {
                        Console.WriteLine("W R O N G   P A S S W O R D !  \nA C C E S S   D E N I E D !  \nH A C K E R   A T T A C K   D E T E C T E D !");
                        abzal = "";
                        return abzal;
                    }
                }
            }
            return abzal;
        }

        public static void TheEnd(string abzal, double res) {
            if (abzal == "")
                System.Threading.Thread.Sleep(4000);
            else {
                Console.WriteLine(res);
                Console.ReadKey();
            }

        }

        public static int ReadInt() {
            int n;
            if (abzal == "Abzal") {
                try {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Базад, ты не правильно ввел число.\nПопробуй еще раз");
                    n = ReadInt();
                }            }
            else {
                n = Convert.ToInt32(Console.ReadLine());
            }
            return n;
        }
    }
}
