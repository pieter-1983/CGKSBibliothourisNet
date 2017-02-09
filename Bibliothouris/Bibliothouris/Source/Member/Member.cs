using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Bibliothouris.Source.User
{
    [DelimitedRecord(",")]
    public class Member
    {

    

        public string INSS { get; }
        public string lastName { get; }
        public string firstName { get; }
        public string street { get; }
        public string number { get; }
        public string postalCode { get; }
        public string city { get; }

        public Member()
        {
            
        }
        public Member(string firstName, string street, string number, string postalCode, string city, string INSS, string lastName)
        {
            this.firstName = firstName;
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
            this.city = city;
            this.INSS = INSS;
            this.lastName = lastName;
        }
    }
}
