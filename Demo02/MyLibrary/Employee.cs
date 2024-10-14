using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GetInt () { return 5; }

        //abstract -> sirve si necesitamos obligar que la clase que hereda sea obligatorio
        //Virtual -> permite que no sea obligatorio
        public virtual decimal CalculaMonthlyPayment()
        {
            return 12000;
        }
        public int GetPaymentDays()
        {
            return 30;
        }
    }

    public class Secretary : Employee
    {
        public override decimal CalculaMonthlyPayment()=> 15000;
        
    }
    public class Manager : Employee
    {
        public override decimal CalculaMonthlyPayment() => 30000;
    }
    public class Developer : Employee { }
}
