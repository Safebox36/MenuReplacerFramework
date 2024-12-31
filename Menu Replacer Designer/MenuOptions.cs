using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Replacer_Designer
{
	internal class MenuOptions
	{
		internal class Option
		{
			private Bitmap? img;
			private Bitmap? imgOver;
			private Padding border;
			private int width = 120;
			private int height = 50;
			private float scale = 1.0f;

			private Bitmap defaultImg;
			private Bitmap defaultImgOver;

			public Option(Bitmap img, Bitmap imgOver)
			{
				this.defaultImg = img;
				this.defaultImgOver = imgOver;
			}

			[DefaultValue(typeof(Bitmap), "")]
			[Description("The image for the button.")]
			public Bitmap Image { get => img ?? defaultImg; set => img = value; }
			[DefaultValue(typeof(Bitmap), "")]
			[Description("The image for the button when hovered over.")] 
			public Bitmap ImageOver { get => imgOver ?? defaultImgOver; set => imgOver = value; }
			[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
			[Description("The border around the button.")] 
			public Padding Border { get => border; set => border = value; }
			[DefaultValue(120)]
			[Description("The width of the button.")]
			public int Width { get => width; set => width = value; }
			[DefaultValue(50)]
			[Description("The height of the button.")]
			public int Height { get => height; set => height = value; }
			[DefaultValue(1.0f)]
			[Description("The scale of the button.")] 
			public float Scale { get => scale; set => scale = value; }

			public override string ToString()
			{
				return "";
			}
		}

		internal class OptionModConfig : Option
		{
			[DefaultValue(256)]
			public new int Width { get => base.Width; set => base.Width = value; }

			public OptionModConfig(Bitmap img, Bitmap imgOver) : base(img, imgOver) { this.Width = 256; }
		}

		private Option optNewGame = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private Option optLoadGame = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private Option optOptions = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private OptionModConfig optModConfig = new(Properties.Resources.menu_mwse, Properties.Resources.menu_mwse_over);
		private Option optCredits = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private Option optExitGame = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);

		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Option NewGame { get => optNewGame; set => optNewGame = value; }
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Option LoadGame { get => optLoadGame; set => optLoadGame = value; }
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Option Options { get => optOptions; set => optOptions = value; }
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public OptionModConfig ModConfig { get => optModConfig; set => optModConfig = value; }
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Option Credits { get => optCredits; set => optCredits = value; }
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Option ExitGame { get => optExitGame; set => optExitGame = value; }
		
		public override string ToString()
		{
			return "";
		}
	}
}
