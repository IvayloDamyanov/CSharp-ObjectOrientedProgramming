using System;

namespace HomeWork
{
    public class GSMtest
    {
        public static void TestArray()
        {
            GSM[] array =
            {
                    new GSM("Lumia", "Nokia", 259.99, "Me", "BatPro", 8.4, 2.3, 1, "5'", "16M"), //ползвал съм енумерациите като числа, предположих, че това е идеята
                    new GSM("Galaxy", "Samsung", 559.99, "Not me", "BatSam", 6.4, 2.1, 3, "8'", "16M"), //ползвал съм енумерациите като числа, предположих, че това е идеята
                    new GSM("Mandatory", "Alcatel", null, null, null, null, null, null, null, null) //по условие модел и производител са задължителни
                };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(GSM.IPhone4s);
        }
    }
}
