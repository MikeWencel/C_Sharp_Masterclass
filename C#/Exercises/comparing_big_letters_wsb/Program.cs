using System;
  class Program
    {
        static void Main(string[] args)
        {

            
            String text = Console.ReadLine();
            while(text != string.Empty)
            {
            String [] textTab = text.Split(" ");
            String firstNum = textTab[0];
            String secondNum = textTab[2];
            String sign = textTab[1];
            String point = "2";
            if(firstNum.Length == secondNum.Length)
            {
            
                switch(sign){
                        case "==": {
                        for (int i = 0; i < firstNum.Length; i++) {
                            if (firstNum[i] != secondNum[i]) {
                                point = "0";
                                break;
                            } else {
                                point = "1";
                            }
                            
                        }
                        Console.WriteLine(point);
                        break;
                    }
                        case "!=": {
                        for (int i = 0; i < firstNum.Length; i++) {
                            if (firstNum[i] != secondNum[i]) {
                                point = "1";
                                break;
                            } else {
                                point = "0";
                                
                            }
                            
                        }
                        Console.WriteLine(point);
                        break;
                    }
                            case "<=": {
                        for (int i = 0; i < firstNum.Length; i++) {
                            if (firstNum[i] <= secondNum[i]) {
                                point = "1";
                            } else {
                                point = "0";
                                break;
                                
                            }
                            
                        }
                        Console.WriteLine(point);
                        break;
                    }

                        case ">=": {
                        for (int i = 0; i < firstNum.Length; i++) {
                            if (firstNum[i] >= secondNum[i]) {
                                point = "1";
                            } else {
                                point = "0";
                                break;
                                
                            }
                            
                        }
                        Console.WriteLine(point);
                        break;
                    }
                    
                }
            }else {
                switch(sign){
                    case "==": {
                        point = "0";
                        Console.WriteLine(point);
                        break;
                    }
                    case "!=": {
                        point = "1";
                        Console.WriteLine(point);
                        break;
                    }
                    case "<=":
                    {
                        if(firstNum.Length < secondNum.Length){
                            point = "1";
                        }else{
                            point ="0";
                        }
                        Console.WriteLine(point);
                        break;
                    }
                    case ">=":
                    {
                        if(firstNum.Length < secondNum.Length){
                            point = "1";
                        }else {
                            point = "0";
                        }
                        Console.WriteLine(point);
                        break;
                    }
                    
                }
            }
            text = Console.ReadLine();
            }
            
        }
    }
