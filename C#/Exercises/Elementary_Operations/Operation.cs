using System;
namespace Elementary_Operations
{
    public class Operation
    {
        private double firstNumber;
        private double secondNumber;

        public Operation(double firstNumber, double secondNumber){
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;

        }

        public double FirstNumber{
            get {return firstNumber;}
            set {firstNumber = value;}
        }

        public double SecondNumber{
            get{return secondNumber;}
            set{secondNumber = value;}
        }

        public double sum(double firstNumber, double secondNumber){
            return firstNumber + secondNumber;
        }

        public double subFirstMinusSecond(double firstNumber, double secondNumber){
            return firstNumber - secondNumber;
        }

        public double subSecondMinusFirst(double firstNumber, double secondNumber){
            return secondNumber - firstNumber;
        }

        public double multiplication(double firstNumber, double secondNumber){
            return firstNumber * secondNumber;
        }

        public double divideFirstbySecond(double firstNumber, double secondNumber){
            if(secondNumber == 0){
                return -1;
            }else {
                return firstNumber / secondNumber;
            }
            
        }

        public void allOperations(double firstNumber, double secondNumber){
            
            Console.WriteLine(sum(firstNumber,secondNumber));
            Console.WriteLine(subFirstMinusSecond(firstNumber,secondNumber));
            Console.WriteLine(multiplication(firstNumber,secondNumber));
            Console.WriteLine(divideFirstbySecond(firstNumber,secondNumber));
            

            

        }


    }
}