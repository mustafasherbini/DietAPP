using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Human
    {
        protected int age, fatP;
        protected double wight, height, wist, neck, BMR, Maintainclaories;
        protected string name;

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public double Wight
        {
            set { wight = value; }
            get { return wight; }

        }
        public double Height
        {
            set { height = value; }
            get { return height; }

        }
        public double Wist
        {
            set { wist = value; }
            get { return wist; }

        }
        public double Neck
        {
            set { neck = value; }
            get { return neck; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }

        }

        public double calories(float val)
        {

            switch (val)
            {
                case 1:
                    Maintainclaories = BMR * 1;
                    break;

                case 2:
                    Maintainclaories = BMR * 1.2;
                    break;
                case 3:
                    Maintainclaories = BMR * 1.375;
                    break;
                case 4:
                    Maintainclaories = BMR * 1.55;
;
                    break;
                case 5:
                    Maintainclaories = BMR * 1.7;
                    ;
                    break;

            }


            return Maintainclaories;

        }


    }
    class male : Human
    {
        public male(string nm, int ag, double h, double wgt, double wst, double nk)
        {
            name = nm;
            wight = wgt;
            age = ag;
            height = h;
            wist = wst;
            neck = nk;
            BMR = (10* wight) + (6.25 * height) - (5 * age);
            fatP = 0;
            //Men	BMR = (10 × weight in kg) + (6.25 × height in cm) - (5 × age in years) +
        }
        public int Fatpecntge()
        {
            //BF = 495 / ( 1.0324 – 0.19077 * log10(w- n ) + 0.15456 * log10(h ) ) – 450


            fatP = (int)(459 / (1.0324 - 0.19077 * Math.Log10(wist - neck) + 0.15456 * Math.Log10(height) - 450));
           
            return fatP;
        }

    }

    class female : Human
    {
        protected double hip;

        public double Hip
        {
            get { return hip; }
            set { hip = value; }
        }
        public female(string nm, int ag, double h, double wgt, double wst, double nk, double hp)
        {
            name = nm;
            wight = wgt;
            age = ag;
            height = h;
            wist = wst;
            neck = nk;
            hip = hp;
            BMR = (float)((10* wight) + (6.25 * height) - (5 * age) - 161);
            fatP = 0;
            // Women BMR = (10 × weight in kg) +(6.25 × height in cm) -(5 × age in years) -161
        }
        public int Fatpecntge()
        {
            //Women, Body Fat % = 495 / (1.29579 – 0.35004 * log10(waist + hip – neck) + 0.22100 * log10(height)) – 450

            fatP = (int)(459/ (1.29579 - 0.35004 * Math.Log10(wist + hip - neck) + 0.22100 * Math.Log10(height) - 450));
            return fatP;
        }
    }


}