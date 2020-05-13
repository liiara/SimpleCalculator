using System;

namespace ConsoleApplicationDemo
{
    class Personal
    {

        static void Main(string[] args)
        {
            // Variable declaration
            string FirstNumberStr;
            string SecondNumberStr;
            int FirstNumberInt;
            int SecondNumberInt;
            string Operation;
            int Result;
            bool Success1;
            bool Success2;

            // Users Inputs
            Console.WriteLine("Write a number");
            FirstNumberStr = Console.ReadLine();

            Console.WriteLine("Choose one (+, -, *, /)");
            Operation = Console.ReadLine();

            Console.WriteLine("Write a number again");
            SecondNumberStr = Console.ReadLine();

            //Convert Inputs from string to INT
            Success1 = Int32.TryParse(FirstNumberStr, out FirstNumberInt);
            Success2 = Int32.TryParse(SecondNumberStr, out SecondNumberInt);

            if(Success1 && Success2){


                Console.WriteLine("Result");

                switch(Operation){
                    case "add":
                    case "+":
                       Result = FirstNumberInt + SecondNumberInt;
                       Console.WriteLine(Result);
                       break;


                    case "-":
                       Result = FirstNumberInt - SecondNumberInt;
                       Console.WriteLine(Result);
                       break;


                    case "*":
                       Result = FirstNumberInt * SecondNumberInt;
                       Console.WriteLine(Result);
                       break;


                    case "/":
                       Result = FirstNumberInt / SecondNumberInt;
                       Console.WriteLine(Result);   
                       break;

                    default:
                        Console.WriteLine("Please, type a valid operator!");
                        break;

                }
                // *** Same logic but done using if statements ***

                // if(Operation == "+") {
                //     Result = FirstNumberInt + SecondNumberInt;
                //     Console.WriteLine(Result);
                // }
                
                // if(Operation == "-"){
                //     Result = FirstNumberInt - SecondNumberInt;
                //     Console.WriteLine(Result);
                // }

                // if(Operation == "*"){
                //     Result = FirstNumberInt * SecondNumberInt;
                //     Console.WriteLine(Result);
                // }

                // if (Operation == "/"){
                //     Result = FirstNumberInt / SecondNumberInt;
                //     Console.WriteLine(Result);
                // }

                
            }

            Console.WriteLine("END OF PROGRAM");
        }
    }
}