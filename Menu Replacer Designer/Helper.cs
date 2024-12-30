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
	}
}
