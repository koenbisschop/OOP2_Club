using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClub
{
    public enum AgeCategories
    {
        Kind,
        Adolecent,
        Jongere,
        Volwassene,
        Undefined
    }
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

        public AgeCategories AgeCategory
        {
            get
            {
                return GetAgeCategory();
            }
        }
        public Member(string name, DateTime dob)
        {
            Name = name;
            Dob = dob;
        }

        public AgeCategories GetAgeCategory()
        {
            AgeCategories ageCategory = AgeCategories.Undefined;

            if (Age <= 8)
                ageCategory = AgeCategories.Kind;
            if (Age <= 15 && Age > 8)
                ageCategory = AgeCategories.Adolecent;
            if (Age < 18 && Age > 15)
                ageCategory = AgeCategories.Jongere;
            if (Age > 18)
                ageCategory = AgeCategories.Volwassene;

            return ageCategory;
        }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - Dob.Year;
                if (DateTime.Today.Month <= Dob.Month)
                {
                    age--;
                    if (DateTime.Today.Month == Dob.Month && DateTime.Today.Day >= Dob.Day)
                        age++;
                }
                return age;
            }
        }

        public decimal Price
        {
            get
            {
                decimal price = 0M;

                if (AgeCategory == AgeCategories.Kind)
                    price = 0M;
                if (AgeCategory == AgeCategories.Adolecent)
                    price = 10M;
                if (AgeCategory == AgeCategories.Jongere)
                    price = 15M;
                if (AgeCategory == AgeCategories.Volwassene)
                    price = 21M;

                return price;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Age} jaar oud | {AgeCategory} | {Price.ToString("C2")} te betalen";
        }
    }
}
