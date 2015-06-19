namespace StartMain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GSM
    {
        private const double pricePerMinute = 37;

        static public string Iphone4S
        {
            get
            {
                return @"Announced - 2011, October
Size - 3.5 inches (~54.0% screen-to-body ratio)
Resolution - 640 x 960 pixels (~330 ppi pixel density)
OS - iOS 5, upgradable to iOS 7.1.2, upgradable to iOS 8.2";
            }
        }

        private string model;

        private string manufacturer;

        private double price;

        private string owner;

        private Display display;

        private Battery battery;

        public GSM(string model, string manufacturer)
        {
            if (model.Length > 1)
            {
                this.model = model;
            }
            else throw new ArgumentException("incorrect data lenght");

            if (manufacturer.Length > 1)
            {
                this.manufacturer = manufacturer;
            }
            else throw new ArgumentException("incorrect data lenght");
        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Invalid price");
            }
            else this.price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Invalid price");
            }
            else this.price = price;

            if (owner.Length < 2)
            {
                throw new ArgumentException("Invalid price");
            }
            else this.owner = owner;
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (Model.Length > 1)
                {
                    this.model = Model;
                }
                else Console.WriteLine("incorrect data");
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (Manufacturer.Length > 1)
                {
                    this.manufacturer = value;
                }
                else Console.WriteLine("incorrect data");
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                else this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid price");
                }
                else this.owner = value;
            }
        }

        public List<Call> callHistory = new List<Call>();

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCall(string date,string time , long number)
        {
            foreach (var item in callHistory)
            {
                if (item.date == date && item.time == time && item.dialledPhoneNumber == number)
                {
                    callHistory.Remove(item);
                    break;
                }
            }          
        }

        public void ClearCall()
        {
            callHistory.Clear();
        }

        public double CallPrice()
        {
            double price = 0;
            foreach (var item in callHistory)
            {
                price += ((double)item.duration / 60) * pricePerMinute;
            }
            return price/100;
        }

        public override string ToString()
        {
            return "Model - " + model + "\n" + "manufacturer - " + manufacturer + "\n" + "price - " + price + "\n" + "owner - " + owner;
        }
    }
}
