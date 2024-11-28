namespace Maui9Issues;

public partial class Page2 : ContentPage
{
	Page2ViewModel _vm;
	public Page2(Page2ViewModel vm)
	{
		InitializeComponent();
		_vm = vm;
		BindingContext = _vm;
	}
}