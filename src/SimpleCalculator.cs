using System;

namespace ter
{    class SimpleCalculator
    {
        enum Operation:byte{add,less,multiply,divide};
        struct ParsResult{
            public int num1,num2;
            public Operation sign;
        } 
        static ParsResult Parsser (string question){
             ParsResult result = new ParsResult();
             int numericValue;
             string aux="";
             for (int i=0;i<question.Length;i++){
                 if (int.TryParse(question.Substring(i,1),out numericValue)){
                     aux+=question.Substring(i,1);
                      if (i == question.Length-1){
                         result.num2 = Convert.ToInt32(aux);
                     }
                 }
                 else{
                     result.num1 = Convert.ToInt32(aux);
                     switch (Convert.ToChar(question.Substring(i,1)))
                     {
                         case '+':
                         result.sign = Operation.add;
                             break;
                        case '-':
                         result.sign = Operation.less;
                             break;
                        case '*':
                         result.sign = Operation.multiply;
                             break;
                        case '/':
                         result.sign = Operation.divide;
                             break;
                         
                     }
                     aux ="";
                     
                 }
             }
             return result;
        }
        static void Main()
        {
            int localResult = 0;
            Console.Write("input :");
            ParsResult pars_result = Parsser(Console.ReadLine());
            switch (pars_result.sign)
                     {
                         case Operation.add:
                         localResult=pars_result.num1 + pars_result.num2;
                             break;
                        case Operation.less:
                         localResult=pars_result.num1 - pars_result.num2;
                             break;
                        case Operation.multiply:
                         localResult=pars_result.num1 * pars_result.num2;
                             break;
                        case Operation.divide:
                         localResult=pars_result.num1 / pars_result.num2;
                             break;
                         
                     }
            Console.WriteLine("Result is {0}",localResult);
           
           // int number1,number2;
        }
    }
}
