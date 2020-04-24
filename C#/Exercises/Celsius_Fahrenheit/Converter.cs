namespace Celsius_Fahrenheit
{
    public class Converter
    {
        private double celsius;
        private double fahrenheit;

        public Converter (double celsius, double fahrenheit) {
            this.celsius = celsius;
            this.fahrenheit = fahrenheit;
        }

        public double Celsius 
        {
            get {return celsius;}
            set {celsius = value;}

        }

        public double Fahrenheit
        {
            get {return fahrenheit;}
            set {fahrenheit = value;}
        }

        public string fahren_celsius(double fahrenheit){ 
                double newCels = (fahrenheit -32)/1.8;
                return fahrenheit + "fahrenheits is " + newCels +" Celsius";
            
        }

        public string celsius_fahren(double celsius){
            if(celsius < -271.15){
                return "Temperature below absulute zero";
            }else {
                double newFahren = (celsius * 1.8) + 32;
                string answer = celsius + " Celsius is " + newFahren + " Fahrenheit's";
                return answer;
            }
        }

        
    }
}