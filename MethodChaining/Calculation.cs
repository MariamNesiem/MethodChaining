using System;
using System.Collections.Generic;
using System.Text;

namespace MethodChaining
{
    class Calculation
    {
        private float MyNumber = 0;
        public string Message="";
        public Calculation(float number)
        {
                this.MyNumber = number;
        }

        public Calculation Addition(float number)
        {
                this.MyNumber += number;
            return this;
        }

        public Calculation Subtraction(float number)
        {
                this.MyNumber -= number;
            return this;
        }

        public Calculation Division(float number)
        {
            this.MyNumber = number == 0 ?  0: this.MyNumber/number;
            return this;
        }

        public Calculation Multiplication(float number)
        {
                this.MyNumber *= number;
            return this;
        }


        public float Result()
        {
            return this.MyNumber;
        }
    }
}
