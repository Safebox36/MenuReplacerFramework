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
		private bool useTitle = false;

		[DefaultValue(typeof(Size), "1280, 720")]
		[Category("Menu")]
		[Description("The resolution of the game window.")]
		public Size GameResolution { get => gameResolution; set => gameResolution = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category("Menu")]
		[Description("The background image.")]
		public Bitmap BackgroundImage { get => backgroundImage; set { if (value == null) { backgroundImage = Properties.Resources.menu_background; } else { backgroundImage = value; } } }
		[DefaultValue(false)]
		[Category("Menu")]
		[Description("Use a title separate from the background.")]
		public bool UseTitle { get => useTitle; set => useTitle = value; }
	}
}
