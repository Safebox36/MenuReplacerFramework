using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Replacer_Designer
{
	internal class Helper
	{
		public static Point AbsolutePosition(Size screenDimensions, Size dimensions, PointF absolutePosition)
		{
			var diff = screenDimensions - dimensions;
			return new((int)Math.Round(diff.Width * absolutePosition.X), (int)Math.Round(diff.Height * absolutePosition.Y));
		}

		public static Bitmap? GetOptionByKey(MenuOptions menuOptions, string key)
		{
			switch(key)
			{
				case "pnlMenuOption1": return menuOptions.ImageNewGame;
				case "pnlMenuOption2": return menuOptions.ImageLoadGame;
				case "pnlMenuOption3": return menuOptions.ImageOptions;
				case "pnlMenuOption5": return menuOptions.ImageCredits;
				case "pnlMenuOption6": return menuOptions.ImageExitGame;
				default: return null;
			}
		}

		public static Bitmap? GetOptionOverByKey(MenuOptions menuOptions, string key)
			{ switch(key) {
				case "pnlMenuOption1": return menuOptions.ImageOverNewGame;
				case "pnlMenuOption2": return menuOptions.ImageOverLoadGame;
				case "pnlMenuOption3": return menuOptions.ImageOverOptions;
				case "pnlMenuOption5": return menuOptions.ImageOverCredits;
				case "pnlMenuOption6": return menuOptions.ImageOverExitGame;
				default: return null;
			}
		}

		public static float GetOptionScaleByKey(MenuOptions menuOptions, string key)
		{
			switch(key)
			{
				case "pnlMenuOption1": return menuOptions.ScaleNewGame;
				case "pnlMenuOption2": return menuOptions.ScaleLoadGame;
				case "pnlMenuOption3": return menuOptions.ScaleOptions;
				case "pnlMenuOption5": return menuOptions.ScaleCredits;
				case "pnlMenuOption6": return menuOptions.ScaleExitGame;
				default: return 1f;
			}
		}
	}
}
