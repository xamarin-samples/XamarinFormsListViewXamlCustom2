using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsListViewXamlCustom2
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();

			// Make data list
			List<ItemInfo> list = new List<ItemInfo>();
			list.Add(new ItemInfo { Name = "Apple", Score = 100 });
			list.Add(new ItemInfo { Name = "Banana", Score = 150 });
			list.Add(new ItemInfo { Name = "Candy", Score = 80 });
			list.Add(new ItemInfo { Name = "Drop", Score = -10 });

			// Bind
			this.BindingContext = list;
		}
	}
}
