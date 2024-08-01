using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double? a, double? b, char? op)
        {
            //lesson 2

            /*a = a ?? 0; b = b ?? 0; c = c ?? 0; 

            var sum = a + b + c;
            var str = $"{a} + {b} + {c} = {sum}";*/

            //lesson 3
            
            a = a ?? 0; b = b ?? 0; op = op ?? '+';
         
            double? res = 0;
            string str;

            switch (op)
            {
                case '+':
                    res = a + b; str = $"{a} {op} {b} = {res}"; break;

                case '-':
                    res = a - b; str = $"{a} {op} {b} = {res}"; break;

                case '*':
                    res = a * b; str = $"{a} {op} {b} = {res}"; break;

                case '/':
                    if (b != 0) { 
                        res = a / b; 
                        str = $"{a} {op} {b} = {res}"; 
                    }
                    else str = $"Нельзя делить на 0"; break;

                default:
                    str = $"Введите корректные значения"; break;

            }

            return str;
        }
    }
}
