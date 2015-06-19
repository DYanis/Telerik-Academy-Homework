namespace StartMain
{
    using System;
    using System.Linq;

    class Battery
    {
        // model, hours idle and hours talk
        readonly public int hoursIdle;
        readonly public int hoursTalk;
        readonly public BatteryTypeEnum batteryTypeEnum;

        public Battery(BatteryTypeEnum batteryTypeEnum, int hoursIdle, int hoursTalk)
        {
            this.batteryTypeEnum = batteryTypeEnum;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
    }
}
