namespace Menu_Replacer_Designer
{
	public partial class Form1 : Form
	{
		private MenuBase menuBase = new MenuBase();

		public Form1()
		{
			InitializeComponent();
			this.propsAll.SelectedObject = menuBase;
		}

		private void propsAll_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.ChangedItem != null)
			{
				switch (e.ChangedItem.Label)
				{
					case "BackgroundImage":
						this.pnlMenu.BackgroundImage = Bitmap.FromHbitmap(this.menuBase.BackgroundImage.GetHbitmap());
						break;
				}
			}
		}
	}
}
