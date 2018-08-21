using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinCalculator.operations
{
    class MathematicalOperations
    {
        public string Addition(List<double> list_of_numbers)
        {
            return Convert.ToString(list_of_numbers.Sum());
        }

        public string Subtraction(List<double> list_of_numbers)
        {
            double temp = 0;
            foreach (double current_value in list_of_numbers)
            {
                temp -= current_value;
            }

            return Convert.ToString(temp);
        }

        public string Multiply(List<double> list_of_numbers)
        {
            double temp = 0;
            bool firsTime = true;
            foreach (double current_value in list_of_numbers)
            {
                if (firsTime && temp == 0)
                {
                    temp = current_value;
                    firsTime = false;
                }
                else
                {
                    temp = temp * current_value;
                }
            }

            return Convert.ToString(temp);
        }

        public string Divide(List<double> list_of_numbers)
        {
            double temp = 0;
            bool firsTime = true, zeroException = false;
            try
            {
                foreach (double current_value in list_of_numbers)
                {
                    //temp /= current_value;
                    if (firsTime && temp == 0)
                    {
                        temp = current_value;
                        firsTime = false;
                    }
                    else
                    {
                        temp = temp / current_value;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                zeroException = true;
            }

            if (zeroException)
            {
                zeroException = false;
                return "Cannot Divide By 0";
            }
            return Convert.ToString(temp);
        }
    }
}
