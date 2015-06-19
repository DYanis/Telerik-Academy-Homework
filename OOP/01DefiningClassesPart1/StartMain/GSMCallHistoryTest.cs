namespace StartMain
{
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        GSM phone = new GSM("Lumia", "Nokia", 1150, "Ivan");

        public void testCallHistory()
        {
            // add call history
            phone.AddCall(new Call("16.03.2015", "12:33", 08922315643, 264));
            phone.AddCall(new Call("16.03.2015", "22:33", 08925123643, 120));
            phone.AddCall(new Call("13.03.2015", "22:53", 08925622243, 30));
            phone.AddCall(new Call("16.03.2015", "22:33", 08956784689, 85));
            phone.AddCall(new Call("17.03.2015", "07:39", 08642234343, 522));
            // print callHistory
            foreach (var item in phone.callHistory)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            // prince price 37cents/1min
            Console.WriteLine("total price - " + phone.CallPrice());

            // remove longest call and print next price
            phone.RemoveCall("17.03.2015", "07:39", 08642234343);
            Console.WriteLine("total price - " + phone.CallPrice());

            // clear and print callHistory
            phone.ClearCall();
            foreach (var item in phone.callHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
