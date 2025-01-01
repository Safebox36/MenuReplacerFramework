using Newtonsoft.Json;
using System.Collections;

namespace Menu_Replacer_Designer
{
	public partial class Form1 : Form
	{
		private MenuBase menuBase = new MenuBase();
		private SizeF resolutionScale = new SizeF(640f / 1280f, 360f / 720f);

		private bool isMouseOver = false;

		public Form1()
		{
			InitializeComponent();
			this.propsAll.SelectedObject = menuBase;

			this.mnuSaveMenu.Click += (s, e) =>
			{
				SaveFileDialog save = new();
				save.Filter = "JSON | *.json";
				save.FileName = "sb_menu.json";
				DialogResult result = save.ShowDialog();
				if (result == DialogResult.OK)
				{
					string data = JsonConvert.SerializeObject(this.menuBase, Formatting.Indented);
					FileStream file = File.OpenWrite(save.FileName);
					StreamWriter stream = new(file);
					stream.Write(data);
					stream.Close();
					file.Close();
				}
			};
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
						Bitmap image = Helper.ConvertDDSTGA(this.menuBase.BackgroundImage) ?? Properties.Resources.menu_background;
						this.pnlMenu.BackgroundImage = Bitmap.FromHbitmap(image.GetHbitmap());
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
			MenuLogo logo = this.menuBase.MenuLogo;
			Bitmap image = Helper.ConvertDDSTGA(logo.Image) ?? Properties.Resources.menu_logo;
			float minScale = this.menuBase.GameResolution.Width < logo.MinScale ? (float)this.menuBase.GameResolution.Width / (float)logo.MinScale : 1f;
			((Panel)sender).Size = new((int)Math.Round((logo.Width * logo.Scale) * (resolutionScale.Width * minScale)), (int)Math.Round((logo.Height * logo.Scale) * (resolutionScale.Height * minScale)));
			Point position = Helper.AbsolutePosition(this.pnlMenu.Size, ((Panel)sender).Size, new(logo.AbsolutePosAlignX, logo.AbsolutePosAlignY));
			((Panel)sender).Location = new(logo.IgnoreLayoutX ? (int)Math.Round(logo.PositionX * resolutionScale.Width) : position.X, logo.IgnoreLayoutY ? (int)Math.Round(logo.PositionY * resolutionScale.Height) : position.Y);
			((Panel)sender).CreateGraphics().DrawImage(image, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, logo.Width, logo.Height), GraphicsUnit.Pixel);
		}

		private void pnlMenuOption_Paint(object sender, PaintEventArgs e)
		{
			MenuOptions.Option option = Helper.GetOptionByKey(this.menuBase.MenuOptions, ((Panel)sender).Name);
			Bitmap image = this.isMouseOver ? (Helper.ConvertDDSTGA(option.ImageOver) ?? Properties.Resources.menu_option_over) : (Helper.ConvertDDSTGA(option.Image) ?? Properties.Resources.menu_option);
			((Panel)sender).Size = new((int)Math.Round((option.Width * option.Scale) * resolutionScale.Width), (int)Math.Round((option.Height * option.Scale) * resolutionScale.Height));
			((Panel)sender).CreateGraphics().DrawImage(image, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, option.Width, option.Height), GraphicsUnit.Pixel);
		}

		private void pnlMenuOption4_Paint(object sender, PaintEventArgs e)
		{
			MenuOptions.OptionModConfig option = this.menuBase.MenuOptions.ModConfig;
			Bitmap image = this.isMouseOver ? (Helper.ConvertDDSTGA(option.ImageOver) ?? Properties.Resources.menu_mwse_over) : (Helper.ConvertDDSTGA(option.Image) ?? Properties.Resources.menu_mwse);
			((Panel)sender).Size = new((int)Math.Round((option.Width * option.Scale) * resolutionScale.Width), (int)Math.Round((option.Height * option.Scale) * resolutionScale.Height));
			((Panel)sender).CreateGraphics().DrawImage(image, new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height), new Rectangle(0, 0, option.Width, option.Height), GraphicsUnit.Pixel);
		}

		private void flowMenuOptions_Paint(object sender, PaintEventArgs e)
		{
			MenuOptions menu = this.menuBase.MenuOptions;
			((FlowLayoutPanel)sender).FlowDirection = menu.FlowDirection == MenuOptions.EnumFlowDirection.top_to_bottom ? FlowDirection.TopDown : FlowDirection.LeftToRight;
			Point position = Helper.AbsolutePosition(this.pnlMenu.Size, ((FlowLayoutPanel)sender).Size, new(menu.AbsolutePosAlignX, menu.AbsolutePosAlignY));
			((FlowLayoutPanel)sender).Location = new(menu.IgnoreLayoutX ? (int)Math.Round(menu.PositionX * resolutionScale.Width) : position.X, menu.IgnoreLayoutY ? (int)Math.Round(menu.PositionY * resolutionScale.Height) : position.Y);
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

		private void Form1_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void Form1_MouseLeave(object sender, EventArgs e)
		{
			if (this.pnlMenu.ClientRectangle.Contains(this.pnlMenu.PointToClient(Cursor.Position)))
			{
				Bitmap image = Helper.ConvertDDSTGA(this.menuBase.CursorImage) ?? Properties.Resources.menu_cursor;
				Bitmap cursor = new(image, new((int)Math.Round(image.Width * resolutionScale.Width), (int)Math.Round(image.Height * resolutionScale.Height)));
				this.Cursor = new(cursor.GetHicon());
			}
		}
	}
}
