using System;
using System.Collections.Generic;
using System.Text;

namespace pract5
{
    class Man
    {
        public string name;
        public int howOld;
        public string sex;
        public int weight;


        public Man(string inName, int inHowOld, string inSex, int inWeight)
        {
            name = inName;
            howOld = inHowOld;
            sex = inSex;
            weight = inWeight;
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int HowOld
        {
            get
            {
                return howOld;
            }
            set
            {
                howOld = value;
            }
        }


        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }


        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }


        public string ShowInformation()
        {
            string info = "Имя человека - " + name + "\n" + "Пол - " + sex + "\n" + "Вес - " + weight + "кг\n" + "Возраст (лет) - " + howOld;
            return info;
        }

        
        public static Man operator ++(in Man he)
        {
            he.HowOld = he.HowOld + 1;
            return he;
        }

        public static bool operator>(Man he, Man she)
        {
            return he.Weight > she.Weight;
        }

        public static bool operator <(Man he, Man she)
        {
            return he.Weight < she.Weight;
        }
    }
}
