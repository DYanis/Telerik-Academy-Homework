namespace StartMain
{
    using System;

    class StartMain
    {
        static void Main()
        {
            var firstPhone = new GSM("Gnusmas", "sS", 3, "Acho");

            // GSMTest.Test();

            firstPhone.AddCall(new Call("15.03.2015","23:43",0894234324,230));
            firstPhone.AddCall(new Call("11.03.2015", "01:35", 0882356342, 120));

           // Console.WriteLine(firstPhone.CallPrice());
           // Console.WriteLine(firstPhone.callHistory[0].dialledPhoneNumber);

            GSMCallHistoryTest gsmCallHistoryTest = new GSMCallHistoryTest();
            gsmCallHistoryTest.testCallHistory();

            firstPhone.Battery = new Battery(BatteryTypeEnum.LiIon, 213, 4324);
            Console.WriteLine(firstPhone.Battery.batteryTypeEnum);


            

                

        }
    }
}
