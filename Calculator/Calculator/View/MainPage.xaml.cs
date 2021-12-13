using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Calculator.ViewModel;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Methods();
        }

        //private decimal firstNumber;
        //private string operatorName;
        //private bool isOperatorClicked;

        //public void OnNumberButton_Clicked(object sender, EventArgs e)
        //{
        //    var button = sender as Button;
        //    if (resultText.Text == "0" || isOperatorClicked)
        //    {
        //        isOperatorClicked = false;
        //        resultText.Text = button.Text;
        //    }

        //    else
        //    {
        //        resultText.Text += button.Text;
        //    }

        //}

        //public void OnClearButton_Clicked(object sender, EventArgs e)
        //{
        //    resultText.Text = "0";
        //}


        //public void OnOperationButton_Clicked(object sender, EventArgs e) 
        //{
        //    var button = sender as Button;
        //    isOperatorClicked = true;
        //    operatorName = button.Text;
        //    firstNumber = Convert.ToDecimal(resultText.Text);
        //}

        //public void OnEqualButton_Clicked(object sender, EventArgs e) 
        //{
        //    try
        //    {
        //        decimal secondNumber = Convert.ToDecimal(resultText.Text);
        //        string finalResult = Calculate(firstNumber, secondNumber).ToString("0.##");
        //        resultText.Text = finalResult;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public decimal Calculate(decimal firstNumber, decimal secondNumber) 
        //{
        //    decimal result = 0;
        //    if (operatorName == "+")
        //    {
        //        result= firstNumber + secondNumber;
        //    }

        //    else if (operatorName == "-")
        //    {
        //        result= firstNumber - secondNumber;
        //    }

        //    else if (operatorName == "*")
        //    {
        //        result= firstNumber * secondNumber;
        //    }
        //    else if (operatorName == "/")
        //    {
        //        result= firstNumber / secondNumber;
        //    }
        //    return result;
        //}
    }
}
