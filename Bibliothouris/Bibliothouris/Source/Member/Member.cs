using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.User
{
    public class Member
    {

    

        public String INSS { get; }
        public String lastName { get; }
        public String firstName { get; }
        public String street { get; }
        public String number { get; }
        public String postalCode { get; }
        public String city { get; }

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
