using System.Collections;

namespace Menu_Replacer_Designer
{
	public partial class Form1 : Form
	{
		private MenuBase menuBase = new MenuBase();
		private SizeF defaultScale = new SizeF(640f / 1280f, 360f / 720f);

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
						defaultScale = new(640f / ((Size)e.ChangedItem.Value).Width, 360f / ((Size)e.ChangedItem.Value).Height);
						break;
					case "BackgroundImage":
						this.pnlMenu.BackgroundImage = Bitmap.FromHbitmap(this.menuBase.BackgroundImage.GetHbitmap());
						break;
					case "UseTitle":
						this.pnlLogo.Visible = (bool)e.ChangedItem.Value;
						break;
				}
			}
		}

		private void pnlLogo_Paint(object sender, PaintEventArgs e)
		{
			((Panel)sender).Size = new((int)Math.Round(1024 * defaultScale.Width), (int)Math.Round(256 * defaultScale.Height));
			((Panel)sender).Location = Helper.AbsolutePosition(this.pnlMenu.Size, ((Panel)sender).Size, new(0.5f, 0.1f));
			((Panel)sender).CreateGraphics().DrawImage(Properties.Resources.menu_logo, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, Properties.Resources.menu_logo.Width, Properties.Resources.menu_logo.Height), GraphicsUnit.Pixel);
		}

		private void pnlMenuOption_Paint(object sender, PaintEventArgs e)
		{
			((Panel)sender).Size = new((int)Math.Round(120 * defaultScale.Width), (int)Math.Round(50 * defaultScale.Height));
			((Panel)sender).CreateGraphics().DrawImage(Properties.Resources.menu_option, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, 120, 50), GraphicsUnit.Pixel);
		}

		private void pnlMenuOption4_Paint(object sender, PaintEventArgs e)
		{
			((Panel)sender).Size = new((int)Math.Round(256 * defaultScale.Width), (int)Math.Round(50 * defaultScale.Height));
			((Panel)sender).CreateGraphics().DrawImage(Properties.Resources.menu_mwse, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, 256, 50), GraphicsUnit.Pixel);
		}
	}
}
