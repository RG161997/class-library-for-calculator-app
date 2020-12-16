using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Calculator.Controllers;

namespace Calculator.Models
{
    public class SimpleCalc
    {

        public decimal number1
        {
            get;
            set;
        }
        public decimal number2
        {
            get;
            set;
        }
        public string op
        {
            get;
           

        }
        public decimal result
        {
            get;
            set;
        }
        public decimal Add(decimal leftNumber,decimal rightNumber)
        {
            return (leftNumber + rightNumber);
        }
        public decimal Sub(decimal leftNumber,decimal rightNumber)
        {
            return (leftNumber - rightNumber);
        }
        public decimal Mult(decimal leftNumber, decimal rightNumber)
        {
            return (leftNumber * rightNumber);
        }
        public decimal Div(decimal leftNumber, decimal rightNumber)
        {
            return (leftNumber / rightNumber);
        }
        public decimal OperatorSwitch(string op,decimal leftNumber,decimal rightNumber)
        {
            decimal res=0.0M;
            switch (op)
            {
                case "Add":
                    res = Add(leftNumber,rightNumber);
                    break;
                case "Subtract":
                    res = Sub(leftNumber, rightNumber);
                    break;
                case "Multiply":
                    res = Mult(leftNumber, rightNumber);
                    break;
                case "Divide":
                    try
                    {
                        res = Div(leftNumber, rightNumber);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Divide by 0 not allowed");
                    }
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;

            }
            return res;
        }
    }
    }
