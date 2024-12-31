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

		private Bitmap? imgOpt1;
		private Bitmap? imgOpt2;
		private Bitmap? imgOpt3;
		private Bitmap? imgOpt4;
		private Bitmap? imgOpt5;
		private Bitmap? imgOpt6;
		private Bitmap? imgOverOpt1;
		private Bitmap? imgOverOpt2;
		private Bitmap? imgOverOpt3;
		private Bitmap? imgOverOpt4;
		private Bitmap? imgOverOpt5;
		private Bitmap? imgOverOpt6;
		private Padding borderOpt1;
		private Padding borderOpt2;
		private Padding borderOpt3;
		private Padding borderOpt4;
		private Padding borderOpt5;
		private Padding borderOpt6;
		private float widthOpt1 = 120.0f;
		private float heightOpt1 = 50.0f;
		private float widthOpt2 = 120.0f;
		private float heightOpt2 = 50.0f;
		private float scaleOpt1 = 1.0f;
		private float scaleOpt2 = 1.0f;
		private float scaleOpt3 = 1.0f;
		private float scaleOpt4 = 1.0f;
		private float scaleOpt5 = 1.0f;
		private float scaleOpt6 = 1.0f;

		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for New Game button.")]
		public Bitmap ImageNewGame { get => imgOpt1 ?? Properties.Resources.menu_option; set => imgOpt1 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Load Game button.")]
		public Bitmap ImageLoadGame { get => imgOpt2 ?? Properties.Resources.menu_option; set => imgOpt2 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Options button.")]
		public Bitmap ImageOptions { get => imgOpt3 ?? Properties.Resources.menu_option; set => imgOpt3 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Mod Config button.")]
		public Bitmap ImageModConfig { get => imgOpt4 ?? Properties.Resources.menu_mwse; set => imgOpt4 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Credits button.")]
		public Bitmap ImageCredits { get => imgOpt5 ?? Properties.Resources.menu_option; set => imgOpt5 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Exit Game button.")]
		public Bitmap ImageExitGame { get => imgOpt6 ?? Properties.Resources.menu_option; set => imgOpt6 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for New Game button when hovered over.")]
		public Bitmap ImageOverNewGame { get => imgOverOpt1 ?? Properties.Resources.menu_option_over; set => imgOverOpt1 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Load Game button when hovered over.")]
		public Bitmap ImageOverLoadGame { get => imgOverOpt2 ?? Properties.Resources.menu_option_over; set => imgOverOpt2 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Options button when hovered over.")]
		public Bitmap ImageOverOptions { get => imgOverOpt3 ?? Properties.Resources.menu_option_over; set => imgOverOpt3 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Mod Config button when hovered over.")]
		public Bitmap ImageOverModConfig { get => imgOverOpt4 ?? Properties.Resources.menu_mwse_over; set => imgOverOpt4 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Credits button when hovered over.")]
		public Bitmap ImageOverCredits { get => imgOverOpt5 ?? Properties.Resources.menu_option_over; set => imgOverOpt5 = value; }
		[DefaultValue(typeof(Bitmap), "")]
		[Category(" ")]
		[Description("The image for Exit Game button when hovered over.")]
		public Bitmap ImageOverExitGame { get => imgOverOpt6 ?? Properties.Resources.menu_option_over; set => imgOverOpt6 = value; }
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Category("--- Options")]
		[Description("The border around New Game button.")]
		public Padding BorderNewGame { get => borderOpt1; set => borderOpt1 = value; }
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Category("--- Options")]
		[Description("The border around Load Game button.")]
		public Padding BorderLoadGame { get => borderOpt2; set => borderOpt2 = value; }
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Category("--- Options")]
		[Description("The border around Options button.")]
		public Padding BorderOptions { get => borderOpt3; set => borderOpt3 = value; }
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Category("--- Options")]
		[Description("The border around Mod Config button.")]
		public Padding BorderModConfig { get => borderOpt4; set => borderOpt4 = value; }
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Category("--- Options")]
		[Description("The border around Credits button.")]
		public Padding BorderCredits { get => borderOpt5; set => borderOpt5 = value; }
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Category("--- Options")]
		[Description("The border around Exit Game button.")]
		public Padding BorderExitGame { get => borderOpt6; set => borderOpt6 = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the New Game button.")]
		public float ScaleNewGame { get => scaleOpt1; set => scaleOpt1 = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the Load Game button.")]
		public float ScaleLoadGame { get => scaleOpt2; set => scaleOpt2 = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the Options button.")]
		public float ScaleOptions { get => scaleOpt3; set => scaleOpt3 = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the Mod Config button.")]
		public float ScaleModConfig { get => scaleOpt4; set => scaleOpt4 = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the Credits button.")]
		public float ScaleCredits { get => scaleOpt5; set => scaleOpt5 = value; }
		[DefaultValue(1.0f)]
		[Description("The scale of the Exit Game button.")]
		public float ScaleExitGame { get => scaleOpt6; set => scaleOpt6 = value; }

		public override string ToString()
		{
			return "";
		}
	}
}
