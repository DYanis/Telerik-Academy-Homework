using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private const int workDays = 5;

        public decimal WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }

        public Worker(string fName, string lName, decimal WeekSalary, int WorkHoursPerDay)
            : base(fName, lName)
        {
            this.WeekSalary = WeekSalary;
            this.WorkHoursPerDay = WorkHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (this.WeekSalary / workDays) / this.WorkHoursPerDay;
            return moneyPerHour;
        }
    }
}
