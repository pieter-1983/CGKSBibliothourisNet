using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.User
{
    public class User
    {
        public int ID { get; }
        public String Name { get; }

        public User(int ID, String name)
        {
            this.ID = ID;
            this.Name = name;
        }
    }
}
