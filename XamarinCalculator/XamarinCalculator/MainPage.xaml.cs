using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCalculator.operations;

namespace XamarinCalculator
{
	public partial class MainPage : ContentPage
	{
        // Make isDecimalClicked False when an operatore is clicked and the previous value was true
        // and push that number from decimalValues into the list of double.
        private bool isOperatorSelected = false, isDecimalClicked = false;
        private string currentOperatorSelected = null, decimalValues = null, finalResult = null;
        private List<double> listOfNumbers = new List<double> { };
        //MathematicalOperations mathOperations = new MathematicalOperations();

        public MainPage()
		{
			InitializeComponent();
            //listOfNumbers.Add(0);
		}

        private void OperationValueSetter(string valueToShow, bool isFinalResult)
        {
            if(!isFinalResult)
                CalculationScreen_Label.Text += valueToShow;
            else
                CalculationScreen_Label.Text = valueToShow;
        }

        private void Zero_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(0);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "0";
            OperationValueSetter("0", false);
            return;
        }

        private void One_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(1);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "1";
            OperationValueSetter("1", false);
            return;
        }

        private void Two_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(2);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "2";
            OperationValueSetter("2", false);
            return;
        }

        private void Three_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(3);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "3";
            OperationValueSetter("3", false);
            return;
        }

        private void Four_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(4);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "4";
            OperationValueSetter("4", false);
            return;
        }

        private void Five_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(5);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "5";
            OperationValueSetter("5", false);
            return;
        }

        private void Six_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(6);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "6";
            OperationValueSetter("6", false);
            return;
        }

        private void Seven_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(7);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "7";
            OperationValueSetter("7", false);
            return;
        }

        private void Eight_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(8);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "8";
            OperationValueSetter("8", false);
            return;
        }

        private void Nine_Button_Clicked(object sender, EventArgs e)
        {
            if (!isDecimalClicked)
                listOfNumbers.Add(9);
            else if (isOperatorSelected)
                isOperatorSelected = false;
            else
                decimalValues += "9";
            OperationValueSetter("9", false);
            return;
        }

        private void Period_Button_Clicked(object sender, EventArgs e)
        {
            if (isDecimalClicked)
                return;

            isDecimalClicked = true;

            if (listOfNumbers.Count == 0)
                decimalValues += "0"; //If we press DECIMAL at the very beginning, when the list is empty.

            double last_value = listOfNumbers.Last();
            decimalValues += Convert.ToString(listOfNumbers.Last()) + ".";
            OperationValueSetter(".", false);
            return;
        }

        private void Equal_Button_Clicked(object sender, EventArgs e)
        {
            if (currentOperatorSelected == "Divide")
            {
                MathematicalOperations mathOperations = new MathematicalOperations();
                finalResult = mathOperations.Divide(listOfNumbers);
                OperationValueSetter("Final Result : " + finalResult, true);
            }
            else if (currentOperatorSelected == "Multiply")
            {
                MathematicalOperations mathOperations = new MathematicalOperations();
                finalResult = mathOperations.Multiply(listOfNumbers);
                OperationValueSetter("Final Result : " + finalResult, true);
            }
            else if (currentOperatorSelected == "Addition")
            {
                MathematicalOperations mathOperations = new MathematicalOperations();
                finalResult = mathOperations.Addition(listOfNumbers);
                OperationValueSetter("Final Result : " + finalResult, true);
            }
            isOperatorSelected = false;
            isDecimalClicked = false;
            currentOperatorSelected = null;
            decimalValues = null;
            listOfNumbers.Clear();
        }

        private void Divide_Button_Clicked(object sender, EventArgs e)
        {
            if (isOperatorSelected)
                return;
            if (isDecimalClicked)
            {
                isDecimalClicked = false;
                isOperatorSelected = true;
                
                // Remove last element, because we will push the updated one (decimal value).
                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                listOfNumbers.Add(Convert.ToDouble(decimalValues.Trim()));

                currentOperatorSelected = "Divide";
            }
            else
            {
                isOperatorSelected = false;
                currentOperatorSelected = "Divide";
            }
            OperationValueSetter("/", false);
        }

        private void Multiply_Button_Clicked(object sender, EventArgs e)
        {
            if (isOperatorSelected)
                return;
            if (isDecimalClicked)
            {
                isDecimalClicked = false;
                isOperatorSelected = true;

                // Remove last element, because we will push the updated one (decimal value).
                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                listOfNumbers.Add(Convert.ToDouble(decimalValues.Trim()));

                currentOperatorSelected = "Multiply";
            }
            else
            {
                isOperatorSelected = false;
                currentOperatorSelected = "Multiply";
            }
            OperationValueSetter("*", false);
        }

        private void Addition_Button_Clicked(object sender, EventArgs e)
        {
            if (isOperatorSelected)
                return;
            //OperationValueSetter("+", false);

            if (isDecimalClicked)
            {
                isDecimalClicked = false;
                isOperatorSelected = true;

                // Remove last element, because we will push the updated one (decimal value).
                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                listOfNumbers.Add(Convert.ToDouble(decimalValues.Trim()));

                currentOperatorSelected = "Addition";
            }
            else
            {
                isOperatorSelected = false;
                currentOperatorSelected = "Addition";
            }
            OperationValueSetter("+", false);
        }

        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            isOperatorSelected = false;
            isDecimalClicked = false;
            currentOperatorSelected = null;
            decimalValues = null;
            listOfNumbers.Clear();
            CalculationScreen_Label.Text = null;
        }
    }
}
