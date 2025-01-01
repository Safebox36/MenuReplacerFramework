using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Menu_Replacer_Designer
{
	internal class MenuLogo : ICloneable
	{
		private string image = "";
		private float absolutePosAlignX = 0.5f;
		private float absolutePosAlignY = 0.1f;
		private bool ignoreLayoutX = false;
		private bool ignoreLayoutY = false;
		private int positionX = 0;
		private int positionY = 0;
		private int width = 1024;
		private int height = 256;
		private float scale = 1.0f;
		private int minScale = 1280;

		[DefaultValue("")]
		[Description("The image for the logo.")]
		[Editor(typeof(ImageNameEditor), typeof(UITypeEditor))]
		public string Image { get => image; set => image = value; }
		[DefaultValue(0.5f)]
		[Description("The horizontal alignment of the logo.")]
		public float AbsolutePosAlignX { get => absolutePosAlignX; set => absolutePosAlignX = Math.Clamp(value, 0.0f, 1.0f); }
		[DefaultValue(0.1f)]
		[Description("The vertical alignment of the logo.")]
		public float AbsolutePosAlignY { get => absolutePosAlignY; set => absolutePosAlignY = Math.Clamp(value, 0.0f, 1.0f); }
		[DefaultValue(false)]
		[Description("Ignore the horizontal layout rules of the parent (use positionX instead).")]
		public bool IgnoreLayoutX { get => ignoreLayoutX; set => ignoreLayoutX = value; }
		[DefaultValue(false)]
		[Description("Ignore the vertical layout rules of the parent (use positionY instead).")]
		public bool IgnoreLayoutY { get => ignoreLayoutY; set => ignoreLayoutY = value; }
		[DefaultValue(0)]
		[Description("The horizontal position of the logo.")]
		public int PositionX { get => positionX; set => positionX = value; }
		[DefaultValue(0)]
		[Description("The vertical position of the logo.")]
		public int PositionY { get => positionY; set => positionY = value; }
		[DefaultValue(1024)]
		[Description("The width and cropping of the logo.")]
		public int Width { get => width; set => width = value; }
		[DefaultValue(256)]
		[Description("The height and cropping of the logo.")]
		public int Height { get => height; set => height = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the logo.")]
		public float Scale { get => scale; set => scale = value; }
		[DefaultValue(1280)]
		[Description("The minimum resolution the game window can be before the logo gets resized.")]
		public int MinScale { get => minScale; set => minScale = value; }

		public object Clone()
		{
			MenuLogo menuLogo = new();
			menuLogo.image = this.image;
			menuLogo.absolutePosAlignX = this.absolutePosAlignX;
			menuLogo.absolutePosAlignY = this.absolutePosAlignY;
			menuLogo.ignoreLayoutX = this.ignoreLayoutX;
			menuLogo.ignoreLayoutY = this.ignoreLayoutY;
			menuLogo.positionX = this.positionX;
			menuLogo.positionY = this.positionY;
			menuLogo.width = this.width;
			menuLogo.height = this.height;
			menuLogo.scale = this.scale;
			menuLogo.minScale = this.minScale;
			return menuLogo;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
