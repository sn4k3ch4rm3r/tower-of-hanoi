using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Data
{
    public struct User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public bool Equals(User other)
        {
            return this.Age == other.Age && this.Name == other.Name;
        }

        public static bool operator == (User u1, User u2)
        {
            return u1.Equals(u2);
        }
        public static bool operator !=(User u1, User u2)
        {
            return !u1.Equals(u2);
        }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}
