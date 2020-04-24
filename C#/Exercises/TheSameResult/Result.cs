using System;

namespace TheSameResult
{
    public class Result
    {
        private double numberOne;
        private double numberTwo;

        public double NumberOne{
        get{return numberOne;}
        set{numberOne = value;}
        }

        public double NumberTwo{
        get{return numberTwo;}
        set{numberTwo = value;}
        }

        public Result (double numberOne,double numberTwo){
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
        }

        public Boolean theSame(double numberOne, double numberTwo){
            if(numberOne == numberTwo){
                return true;
            }else {
                return false;
            }
        }

       

        
    }
}