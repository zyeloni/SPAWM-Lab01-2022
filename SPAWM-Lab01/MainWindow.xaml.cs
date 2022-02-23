using System;
using System.Windows;
using SPAWM_Lab01.Helpers;

namespace SPAWM_Lab01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            OperationBox.Items.Clear();
            OperationBox.Items.Add("+");
            OperationBox.Items.Add("-");
            OperationBox.Items.Add("*");
            OperationBox.Items.Add("/");
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (NumberOne.Text == null || NumberTwo.Text == null || OperationBox.SelectedValue == null)
            {
                MessageBox.Show("Nie podano prawidłowych danych");
                return;
            }
            
            double a;
            double b;
            string? operation;

            operation = OperationBox.SelectedValue.ToString();

            try
            {
                a = Double.Parse(NumberOne.Text);
                b = Double.Parse(NumberTwo.Text);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Zły format liczb");
                return;
            }

            try
            {
                Result.Text = Calculate(a, b, operation).ToString();
            }
            catch (DivideByZeroException exception)
            {
                MessageBox.Show("Nie można dzielić przez zero !");
            }
        }

        private double Calculate(double d, double d1, string? operation)
        {
            switch (operation)
            {
                case "+":
                    return CalculateHelper.Sum(d, d1);
                case "-":
                    return CalculateHelper.Sub(d, d1);
                case "*":
                    return CalculateHelper.Mul(d, d1);
                case "/":
                    return CalculateHelper.Div(d, d1);
                default:
                    return 0;
            }
        }
    }
}