using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Levenswerk;

namespace OOPClub
{
    class Member
    {
        string _name;
        DateTime _dob;

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return _dob;
            }
            private set
            {
                _dob = value;
            }
        }

        public  Levensloop.AgeCategories AgeCategory
        {
            get
            {
                return Levensloop.GetAgeCategory(Dob);
            }
        }
        public Member(string name, DateTime dob)
        {
            Name = name;
            Dob = dob;
        }

        public decimal Price
        {
            get
            {
                decimal price = 0M;

                if (AgeCategory == Levensloop.AgeCategories.Kind)
                    price = 0M;
                if (AgeCategory == Levensloop.AgeCategories.Adolecent)
                    price = 10M;
                if (AgeCategory == Levensloop.AgeCategories.Jongere)
                    price = 15M;
                if (AgeCategory == Levensloop.AgeCategories.Volwassene)
                    price = 21M;

                return price;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Levensloop.Age(Dob)} jaar oud | {AgeCategory} | {Price.ToString("C2")} te betalen";
        }
    }
}
