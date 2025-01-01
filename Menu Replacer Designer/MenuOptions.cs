using System.ComponentModel;
using System.Drawing.Design;

namespace Menu_Replacer_Designer
{
	internal class MenuOptions : ICloneable
	{
		internal class Option : ICloneable
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

			[EditorBrowsable(EditorBrowsableState.Never)]
			protected Bitmap DefaultImage { get => defaultImg; set => defaultImg = value; }

			[EditorBrowsable(EditorBrowsableState.Never)]
			protected Bitmap DefaultImageOver { get => defaultImgOver; set => defaultImgOver = value; }

			public object Clone()
			{
				Option option = new(this.defaultImg, this.defaultImgOver);
				option.img = this.img;
				option.imgOver = this.imgOver;
				option.border = this.border;
				option.width = this.width;
				option.height = this.height;
				option.scale = this.scale;
				return option;
			}

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

			public new object Clone()
			{
				OptionModConfig option = new(this.DefaultImage, this.DefaultImageOver);
				option.Image = this.Image;
				option.ImageOver = this.ImageOver;
				option.Border = this.Border;
				option.Width = this.Width;
				option.Height = this.Height;
				option.Scale = this.Scale;
				return option;
			}
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

		public object Clone()
		{
			MenuOptions menuOptions = new();
			menuOptions.absolutePosAlignX = this.absolutePosAlignX;
			menuOptions.absolutePosAlignY = this.absolutePosAlignY;
			menuOptions.ignoreLayoutX = this.ignoreLayoutX;
			menuOptions.ignoreLayoutY = this.ignoreLayoutY;
			menuOptions.positionX = this.positionX;
			menuOptions.positionY = this.positionY;
			menuOptions.flowDirection = this.flowDirection;
			menuOptions.optNewGame = (Option)this.optNewGame.Clone();
			menuOptions.optLoadGame = (Option)this.optLoadGame.Clone();
			menuOptions.optOptions = (Option)this.optOptions.Clone();
			menuOptions.optModConfig = (OptionModConfig)this.optModConfig.Clone();
			menuOptions.optCredits = (Option)this.optCredits.Clone();
			menuOptions.optExitGame = (Option)this.optExitGame.Clone();
			return menuOptions;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
