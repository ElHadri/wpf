using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.LiveShaping
{
	class StockItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public string Name { get; set; }

		double _value;
		public double Value
		{
			get { return _value; }
			set
			{
				_value = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Value"));
			}
		}
	}
}
