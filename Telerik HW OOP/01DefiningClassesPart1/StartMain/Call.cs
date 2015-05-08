namespace StartMain
{
    using System;

    class Call
    {
        public string date { get; set; }
        public string time { get; set; }
        public long dialledPhoneNumber { get; set; }
        public long duration { get; set; }

        public Call(string date, string time, long dialledPhoneNumber, long duration)
        {
            this.date = date;
            this.time = time;
            this.dialledPhoneNumber = dialledPhoneNumber;
            this.duration = duration;           
        }

        public override string ToString()
        {
            return "Date - " + date + "\n" + "Time - " + time + "\n" + "Dialled Phone Number - " + dialledPhoneNumber + "\n" + "Duration - " + duration;
        }
    }
}
