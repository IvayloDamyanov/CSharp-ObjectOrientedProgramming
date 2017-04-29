using System;

namespace HomeWork
{
    public class GSMCallHistoryTest
    {
        public static void TestHistory()
        {
            GSM testPhone = new GSM("Lumia", "Nokia", 259.99, "Me", "BatPro", 8.4, 2.3, 1, "5'", "16M");
            Console.WriteLine(testPhone);
            testPhone.addCallToHistory(new Call(DateTime.Now, "0888114477", 25));
            testPhone.addCallToHistory(new Call(DateTime.Now, "0888225588", 18));
            testPhone.addCallToHistory(new Call(DateTime.Now, "0888336699", 67));
            Console.WriteLine("Calls:\n");
            foreach (Call call in testPhone.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine("Total price of calls: {0:0.00}", testPhone.CallPrice());
            int max = -1;
            int remIndex = 0;
            foreach (Call call in testPhone.CallHistory)
            {
                if (call._durationSec > max)
                {
                    max = call._durationSec;
                    remIndex = testPhone.CallHistory.IndexOf(call);
                }
            }
            testPhone.delCallFromHistory(2);
            Console.WriteLine("Total price of calls after removal of longest call: {0:0.00}", testPhone.CallPrice());
            testPhone.clearCallHistory();
            Console.WriteLine("Total price after clearing calls: {0:0.00}", testPhone.CallPrice());
        }
    }
}
