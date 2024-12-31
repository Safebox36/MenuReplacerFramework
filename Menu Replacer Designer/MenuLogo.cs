﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Replacer_Designer
{
	internal class MenuLogo
	{
		private Bitmap? image;
		private float absolutePosAlignX = 0.5f;
		private float absolutePosAlignY = 0.1f;
		private bool ignoreLayoutX = false;
		private bool ignoreLayoutY = false;
		private float positionX = 0.0f;
		private float positionY = 0.0f;
		private float width = 1024.0f;
		private float height = 256.0f;
		private float scale = 1.0f;
		private int minScale = 1280;

		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for the logo.")]
		public Bitmap Image { get => image ?? Properties.Resources.menu_logo; set => image = value; }
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
		[DefaultValue(0.0f)]
		[Description("The horizontal position of the logo.")]
		public float PositionX { get => positionX; set => positionX = value; }
		[DefaultValue(0.0f)]
		[Description("The vertical position of the logo.")]
		public float PositionY { get => positionY; set => positionY = value; }
		[DefaultValue(1024.0f)]
		[Description("The width and cropping of the logo.")]
		public float Width { get => width; set => width = value; }
		[DefaultValue(256.0f)]
		[Description("The height and cropping of the logo.")]
		public float Height { get => height; set => height = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the logo.")]
		public float Scale { get => scale; set => scale = value; }
		[DefaultValue(1280)]
		[Description("The minimum resolution the game window can be before the logo gets resized.")]
		public int MinScale { get => minScale; set => minScale = value; }

		public override string ToString()
		{
			return "";
		}
	}
}
