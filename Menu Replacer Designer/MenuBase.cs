using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Replacer_Designer
{
	internal class MenuBase
	{
		private Size gameResolution = new(1280, 720);
		private Bitmap? backgroundImage;// = Properties.Resources.menu_background;
		private Bitmap? cursorImage;
		private bool useTitle = false;
		private MenuLogo menuLogo = new();
		private MenuOptions menuOptions = new();

		[DefaultValue(typeof(Size), "1280, 720")]
		[Category(" ")]
		[Description("The resolution of the game window.")]
		public Size GameResolution { get => gameResolution; set => gameResolution = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The background image.")]
		public Bitmap BackgroundImage { get => backgroundImage ?? Properties.Resources.menu_background; set => backgroundImage = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The cursor image.")]
		public Bitmap CursorImage { get => cursorImage ?? Properties.Resources.menu_cursor; set => cursorImage = value; }
		[DefaultValue(false)]
		[Category(" ")]
		[Description("Use a title separate from the background.")]
		public bool UseTitle { get => useTitle; set => useTitle = value; }
		[DisplayName("Logo")]
		[Category(" ")]
		[Description("The optional logo separate from the background image.")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public MenuLogo MenuLogo { get => menuLogo; set => menuLogo = value; }
		[DisplayName("Options")]
		[Category(" ")]
		[Description("The menu option buttons.")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public MenuOptions MenuOptions { get => menuOptions; set => menuOptions = value; }
	}
}
