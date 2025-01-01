using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Replacer_Designer
{
	internal class MenuOptions
	{
		internal class Option
		{
			private string img = "";
			private string imgOver = "";
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

			[DefaultValue("")]
			[Description("The image for the button.")]
			[Editor(typeof(ImageNameEditor), typeof(UITypeEditor))]
			public string Image { get => img; set => img = value; }
			[DefaultValue("")]
			[Description("The image for the button when hovered over.")]
			[Editor(typeof(ImageNameEditor), typeof(UITypeEditor))]
			public string ImageOver { get => imgOver; set => imgOver = value; }
			[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
			[Description("The border around the button.")] 
			public Padding Border { get => border; set => border = value; }
			[DefaultValue(120)]
			[Description("The width and cropping of the button.")]
			public int Width { get => width; set => width = value; }
			[DefaultValue(50)]
			[Description("The height and cropping of the button.")]
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
			public new string Image { get => base.Image; set => base.Image = value; }
			public new string ImageOver { get => base.ImageOver; set => base.ImageOver = value; }
			public new Padding Border { get => base.Border; set => base.Border = value; }
			[DefaultValue(256)]
			public new int Width { get => base.Width; set => base.Width = value; }
			public new int Height { get => base.Height; set => base.Height = value; }
			public new float Scale { get => base.Scale; set => base.Scale = value; }

			public OptionModConfig(Bitmap img, Bitmap imgOver) : base(img, imgOver) { this.Width = 256; }
		}

		internal enum EnumFlowDirection
		{
			left_to_right,
			top_to_bottom
		};

		private float absolutePosAlignX = 0.5f;
		private float absolutePosAlignY = 0.95f;
		private bool ignoreLayoutX = false;
		private bool ignoreLayoutY = false;
		private int positionX = 0;
		private int positionY = 0;
		private EnumFlowDirection flowDirection = EnumFlowDirection.top_to_bottom;
		private Option optNewGame = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private Option optLoadGame = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private Option optOptions = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private OptionModConfig optModConfig = new(Properties.Resources.menu_mwse, Properties.Resources.menu_mwse_over);
		private Option optCredits = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);
		private Option optExitGame = new(Properties.Resources.menu_option, Properties.Resources.menu_option_over);

		[DefaultValue(0.5f)]
		[Description("The horizontal alignment of the buttons.")]
		public float AbsolutePosAlignX { get => absolutePosAlignX; set => absolutePosAlignX = value; }
		[DefaultValue(0.95f)]
		[Description("The vertical alignment of the buttons.")]
		public float AbsolutePosAlignY { get => absolutePosAlignY; set => absolutePosAlignY = value; }
		[DefaultValue(false)]
		[Description("Ignore the horizontal layout rules of the parent (use positionX instead).")]
		public bool IgnoreLayoutX { get => ignoreLayoutX; set => ignoreLayoutX = value; }
		[DefaultValue(false)]
		[Description("Ignore the vertical layout rules of the parent (use positionY instead).")]
		public bool IgnoreLayoutY { get => ignoreLayoutY; set => ignoreLayoutY = value; }
		[DefaultValue(0)]
		[Description("The horizontal position of the buttons.")]
		public int PositionX { get => positionX; set => positionX = value; }
		[DefaultValue(0)]
		[Description("The vertical position of the buttons.")]
		public int PositionY { get => positionY; set => positionY = value; }
		[DefaultValue(EnumFlowDirection.top_to_bottom)]
		[Description("The flow direction of the buttons.")]
		[TypeConverter(typeof(EnumConverter))]
		public EnumFlowDirection FlowDirection { get => flowDirection; set => flowDirection = value; }
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
