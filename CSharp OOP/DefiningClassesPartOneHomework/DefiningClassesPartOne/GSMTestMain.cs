namespace DefiningClassesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DefiningClassesPartOne
    {
        static void Main()
        {
            Console.WriteLine("GSM Test:\n");
            GSMTest();
            Console.WriteLine();
            Console.WriteLine("GSM Call History Test:\n");
            GSMCallHistoryTest();
        }

        static void GSMTest()
        {
            GSM[] phones = new GSM[5];

            phones[0] = new GSM("LG", "G2", 500, "Biggie Smalls", new Battery("AS/T29589-2014", 180, 13, BatteryType.NiMH), new Display(4, 16));
            phones[1] = new GSM("Samsung", "S5", 420, "Tupac Shakur", new Battery("TU/U96548-2014", 200, 15, BatteryType.LiIon), new Display(5, 16));
            phones[2] = new GSM("IPhone", "6S", 700, "Eminem", new Battery("KO/J74346-2015", 220, 11, BatteryType.LiIon), new Display(4.2, 16));
            phones[3] = new GSM("Nokia", "Lumia 900", 450, "Dr. Dre", new Battery("PL/Y37539-2013", 190, 14, BatteryType.NiCd), new Display(4.7, 16));
            phones[4] = new GSM("Samsung", "S6", 600, "Eazy E", new Battery("BG/S65575-2014", 200, 12, BatteryType.NiMH), new Display(5.5, 16));

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine(new string('-', 50));
            }
            Console.WriteLine();
            Console.WriteLine("Printing the static IPhone4S:");
            Console.WriteLine();
            Console.WriteLine(GSM.IPhone4S);
        }

        static void GSMCallHistoryTest()
        {
            GSM myGSM = new GSM("Samsung", "Galaxy S2", 500, "Jimmy Hendrix", new Battery("HJ/T43456-2012", 190, 12, BatteryType.LiIon), new Display(4.7, 16));

            myGSM.AddCall("22.12.2014", "11:55:32", "0888123456", 132);
            myGSM.AddCall("23.12.2014", "12:56:33", "0888654321", 160);
            myGSM.AddCall("24.12.2014", "13:57:34", "0888456123", 258);
            myGSM.AddCall("25.12.2014", "14:58:35", "0888654123", 400);
            myGSM.AddCall("26.12.2014", "15:59:36", "0888321654", 17);

            Console.WriteLine(myGSM.ShowCallHistory());

            Console.WriteLine("Total call price: {0:F2}", myGSM.CallPrice(0.37M));

            int longestCall = myGSM.CallHistory[0].Duration;
            int longestCallIndex = 0;
            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                int temp = myGSM.CallHistory[i].Duration;
                if (longestCall < temp)
                {
                    longestCall = temp;
                    longestCallIndex = i;
                }
            }

            myGSM.RemoveCall(myGSM.CallHistory[longestCallIndex]);
            // Console.WriteLine("longest call is {0}s and it costs {1:F2}", longestCall, longestCall * 0.37 / 60);
            Console.WriteLine("Total call price after deleting the longest call: {0:F2}", myGSM.CallPrice(0.37M));

            myGSM.ClearCallHistory();
            Console.WriteLine(myGSM.ShowCallHistory());
        }
    }
}
