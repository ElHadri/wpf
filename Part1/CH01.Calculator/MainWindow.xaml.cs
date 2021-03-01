using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CH01.Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string _operator;
		int _first;
		bool _nextEmpty;
		const string _error = "ERROR";

		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnKeyPressed(object sender, RoutedEventArgs e)
		{
			int digit;
			string content = ((Button)e.Source).Content.ToString();

			if (int.TryParse(content, out digit))
			{
				if (_nextEmpty)
				{
					_number.Text = string.Empty;
					_nextEmpty = false;
				}
				// a digit
				if (_number.Text.Length < 8)
					_number.Text += content;
			}
			else
			{   // operator
				if (_number.Text == _error)
					return;
				if (_operator == null)
				{
					if (string.IsNullOrEmpty(_number.Text))
						return;
					_first = int.Parse(_number.Text);
					_nextEmpty = true;
				}
				else
				{
					OnCalculate(this, e);
				}
				_operator = content;
			}
		}

		private void OnCalculate(object sender, RoutedEventArgs e)
		{
			if (_operator != null)
			{
				bool error;
				int result = DoCalculation(_first, int.Parse(_number.Text), out error);
				_number.Text = error ? _error : result.ToString();
				_first = result;
				_nextEmpty = true;
				_operator = null;
			}
			e.Handled = true;
		}

		private int DoCalculation(int num1, int num2, out bool error)
		{
			int result = 0;
			error = false;
			switch (_operator)
			{
				case "+":
					result = num1 + num2;
					break;
				case "-":
					result = num1 - num2;
					break;
				case "X":
					result = num1 * num2;
					break;
				case "/":
					if (num2 == 0)
						error = true;
					else
						result = num1 / num2;
					break;
			}
			return result;
		}

	}

}
