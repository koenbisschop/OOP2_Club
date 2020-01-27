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
    public static class Levensloop
    {
        public static int Age(DateTime dob)
        {
            int age = DateTime.Today.Year - dob.Year;
            if (DateTime.Today.Month <= dob.Month)
            {
                age--;
                if (DateTime.Today.Month == dob.Month && DateTime.Today.Day >= dob.Day)
                    age++;
            }
            return age;
        }

        public static AgeCategories GetAgeCategory(DateTime dob)
        {
            AgeCategories ageCategory = AgeCategories.Undefined;
            int age = Levensloop.Age(dob);
            if (age <= 8)
                ageCategory = AgeCategories.Kind;
            if (age <= 15 && age > 8)
                ageCategory = AgeCategories.Adolecent;
            if (age < 18 && age > 15)
                ageCategory = AgeCategories.Jongere;
            if (age > 18)
                ageCategory = AgeCategories.Volwassene;

            return ageCategory;
        }


    }
}
