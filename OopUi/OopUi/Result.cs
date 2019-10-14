using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUi
{
    class Result
    {
        private double physics;
        private double chemistry;
        private double math;
        private double sum;
        private double avg;
        private string gradePoint;

        public double Physics { set; get; }
        public double Chemistry { set; get; }
        public double Math { set; get; }

        public Result()
        {
            this.Physics = physics;
            this.Chemistry = chemistry;
            this.Math = math;
        }

        public double GetAvarage()
        {
            sum = Physics + Chemistry + Math;
            avg = sum / 3;
            return avg;
        }
        public string GetGradePoint()
        {
            if (avg>=80 && avg<=100)
            {
                gradePoint = "A+";
                return gradePoint;
            }
            if (avg >= 70 && avg <= 79)
            {
                gradePoint = "B+";
                return gradePoint;
            }
            if (avg >= 60 && avg <= 69)
            {
                gradePoint = "C+";
                return gradePoint;
            }
            if (avg >= 50 && avg <= 59)
            {
                gradePoint = "C+";
                return gradePoint;
            }
            if (avg < 50)
            {
                gradePoint = "F";
                return gradePoint;
            }

            return gradePoint;
        }
    }        
    }

