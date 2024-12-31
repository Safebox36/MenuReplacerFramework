using System.Collections;

namespace Menu_Replacer_Designer
{
	public partial class Form1 : Form
	{
		private MenuBase menuBase = new MenuBase();
		private SizeF resolutionScale = new SizeF(640f / 1280f, 360f / 720f);
		private Bitmap activeLogo = Properties.Resources.menu_logo;
		private Bitmap activeOption1 = Properties.Resources.menu_option;
		private Bitmap activeOption2 = Properties.Resources.menu_option;
		private Bitmap activeOption3 = Properties.Resources.menu_option;
		private Bitmap activeOption4 = Properties.Resources.menu_mwse;
		private Bitmap activeOption5 = Properties.Resources.menu_option;
		private Bitmap activeOption6 = Properties.Resources.menu_option;

		private bool isMouseOver = false;

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
					case "GameResolution":
						resolutionScale = new(640f / ((Size)e.ChangedItem.Value).Width, 360f / ((Size)e.ChangedItem.Value).Height);
						break;
					case "BackgroundImage":
						this.pnlMenu.BackgroundImage = Bitmap.FromHbitmap(this.menuBase.BackgroundImage.GetHbitmap());
						break;
					case "UseTitle":
						this.pnlLogo.Visible = (bool)e.ChangedItem.Value;
						break;
				}
			}
			this.pnlMenu.Refresh();
		}

		private void pnlLogo_Paint(object sender, PaintEventArgs e)
		{
			Bitmap image = this.menuBase.MenuLogo.Image ?? Properties.Resources.menu_logo;
			((Panel)sender).Size = new((int)Math.Round((image.Width * this.menuBase.MenuLogo.Scale) * resolutionScale.Width), (int)Math.Round((image.Height * this.menuBase.MenuLogo.Scale) * resolutionScale.Height));
			((Panel)sender).Location = Helper.AbsolutePosition(this.pnlMenu.Size, ((Panel)sender).Size, new(this.menuBase.MenuLogo.AbsolutePosAlignX, this.menuBase.MenuLogo.AbsolutePosAlignY));
			((Panel)sender).CreateGraphics().DrawImage(image, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
		}

		private void pnlMenuOption_Paint(object sender, PaintEventArgs e)
		{
			Bitmap image = this.isMouseOver ?
				(Helper.GetOptionOverByKey(this.menuBase.MenuOptions, ((Panel)sender).Name) ?? Properties.Resources.menu_option_over) :
				(Helper.GetOptionByKey(this.menuBase.MenuOptions, ((Panel)sender).Name) ?? Properties.Resources.menu_option);
			((Panel)sender).Size = new((int)Math.Round((image.Width * Helper.GetOptionScaleByKey(this.menuBase.MenuOptions, ((Panel)sender).Name)) * resolutionScale.Width), (int)Math.Round((image.Height) * resolutionScale.Height));
			((Panel)sender).CreateGraphics().DrawImage(image, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, 120, 50), GraphicsUnit.Pixel);
		}

		private void pnlMenuOption4_Paint(object sender, PaintEventArgs e)
		{
			Bitmap image = this.isMouseOver ?
				(this.menuBase.MenuOptions.ImageOverModConfig ?? Properties.Resources.menu_mwse_over) :
				(this.menuBase.MenuOptions.ImageModConfig ?? Properties.Resources.menu_mwse);
			((Panel)sender).Size = new((int)Math.Round(256 * resolutionScale.Width), (int)Math.Round(50 * resolutionScale.Height));
			((Panel)sender).CreateGraphics().DrawImage(image, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, 256, 50), GraphicsUnit.Pixel);
		}

		private void flowMenuOptions_Paint(object sender, PaintEventArgs e)
		{
			((Panel)sender).Location = Helper.AbsolutePosition(this.pnlMenu.Size, ((Panel)sender).Size, new(0.5f, 0.95f));
		}

		private void pnlMenuOption_MouseEnter(object sender, EventArgs e)
		{
			this.isMouseOver = true;
			((Panel)sender).Refresh();
		}

		private void pnlMenuOption_MouseLeave(object sender, EventArgs e)
		{
			this.isMouseOver = false;
			((Panel)sender).Refresh();
		}
	}
}
