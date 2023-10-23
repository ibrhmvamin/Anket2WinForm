using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket2Winfrom
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public Worker() { } 
        public Worker(string name, string surname, string mail, string phone, DateTime date)
        {
            Name = name;
            Surname = surname;
            Mail = mail;
            Phone = phone;
            Date = date;
        }

        public override string ToString()
        {
            return $"Name : {Name} ; Surname : {Surname} ; Mail : {Mail} ; Phone : {Phone} ; Birthday : {Date} ;";
        }
    }
}
