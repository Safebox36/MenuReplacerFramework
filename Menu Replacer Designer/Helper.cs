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

		public static MenuOptions.Option GetOptionByKey(MenuOptions menuOptions, string key)
		{
			switch(key)
			{
				case "pnlMenuOption1": return menuOptions.NewGame;
				case "pnlMenuOption2": return menuOptions.LoadGame;
				case "pnlMenuOption3": return menuOptions.Options;
				case "pnlMenuOption5": return menuOptions.Credits;
				case "pnlMenuOption6": return menuOptions.ExitGame;
				default: return null;
			}
		}
	}
}
