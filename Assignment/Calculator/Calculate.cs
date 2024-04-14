using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculate : ICalculate
    {
        private decimal operand1;
        private decimal operand2;
        private decimal answer;

        public decimal Operand1 {
            get { return operand1; }
            set { operand1 = value; }
        }

        public decimal Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }

        public decimal Result
        {
            get { return answer; }
            set { answer = value; }
        }

        public void Addition()
        {
            Result = Operand1 + Operand2;
        }

        public void Subtraction()
        {
            Result = Operand1 - Operand2;
        }

        public void Multiplication()
        {
            Result = Operand1 * Operand2;
        }

        public void Division()
        {
            Result = Operand1 / Operand2;
        }

        public void Clear()
        {
            Operand1 = 0;
            Operand2 = 0;
        }

        public void Equal(string operation)
        {
            switch (operation)
            {
                case "+":
                    Addition();
                    break;
                case "-":
                    Subtraction();
                    break;
                case "x":
                    Multiplication();
                    break;
                case "÷": 
                    Division();
                    break;
                default:
                    MessageBox.Show("Please select an operator");
                    break;
            }
        }
    }
}

