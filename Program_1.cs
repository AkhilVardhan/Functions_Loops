using System;

namespace D1_Recap_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             * Data Types
             * Numbers :
             *      Integer 
             *       int,  int16,Int32,int64,long
             *       Float, Decimal, Double
             * Characters :
             *     Char,String,StringBuilder
             * Date & Time :
             *     DateTime
             *     TimeSpan
             * Boolean 
             *    bool
             * bytes
             * 
             */

            /* What is variable ? 
                Variable on which holds the value and it varies from time to time in the life time
                Every variable has its own scope or life time.
                After end of scope the variable is not available or not accesible.
               When we declare variable system will allocate memory based on datatype.
               When the scope is ended then System will remove or clear the memory allocated for that variable.
             */
            /*Declaration of variables */
            int firstNum, secondNum, thirdNum;
            int fourthNum;
            int fithNum;
            /*
             * int fourthNum1,string strName ;
             * This is wrong way of declaration;
             */
            int fourthNum1;
            string strName;

            //Assignment of the values to variables.

            firstNum = 10;
            secondNum = 30;
            thirdNum = 0;
            Console.WriteLine("The value of firstNum is :{0}", firstNum);

            Console.WriteLine("The value of firstNum - {0} & secondNum - {1}", firstNum,secondNum);

            Console.WriteLine("The value of firstNum - {0}, secondNum - {1} & thirdNum {2} ", firstNum, secondNum, thirdNum);

            /* Break point 
             * The execution will stop at the line which contains break point While executing /running  the application
             * so that we can check values based on requirement
             * F10 .. will be useful to go next line without going inside function
             * F11 .. will be useful to go inside function
             * opening Immediat window  short cut -- Ctrl + alt + i
             */

            Console.WriteLine("Please enter firstNum ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter secondNum ");
            secondNum = int.Parse(Console.ReadLine());
            //Calling function with input parameters and assigning the return value to variable.
            thirdNum = AdditionofNumbers(firstNum, secondNum);
            Console.WriteLine("Addition of numbers completed and result is {0}", thirdNum);
            //Calling Function with out any input parameters
            ShowMessage();
        }

        public static int AdditionofNumbers(int p_FirstNum, int p_SecondNum)
        {
            Console.WriteLine("we are inside of Addition of nUmbers Method");
            return p_FirstNum + p_SecondNum;
        }

        public static void ShowMessage()
        {
            Console.WriteLine("Hellow we are welcome to you");
        }
    }
}
