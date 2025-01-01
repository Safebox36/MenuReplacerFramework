using Pfim;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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

		public static Bitmap? ConvertDDSTGA(string fileName)
		{
			if (!File.Exists(fileName)) return null;
			using IImage image = Pfimage.FromFile(fileName);
			bool widthPow2 = false;
			bool heightPow2 = false;
			for (int i = 3; i < 14; i++)
			{
				if (image.Width == Math.Pow(2, i)) widthPow2 = true;
				if (image.Height == Math.Pow(2, i)) heightPow2 = true;
			}
			if (!widthPow2 || !heightPow2)
			{
				MessageBox.Show("This image's width or height is not a power of 2.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
			PixelFormat format;

			switch (image.Format)
			{
				case Pfim.ImageFormat.Rgb24:
					format = PixelFormat.Format24bppRgb;
					break;
				case Pfim.ImageFormat.Rgba32:
					format = PixelFormat.Format32bppArgb;
					break;
				case Pfim.ImageFormat.R5g5b5:
					format = PixelFormat.Format16bppRgb555;
					break;
				case Pfim.ImageFormat.R5g6b5:
					format = PixelFormat.Format16bppRgb565;
					break;
				case Pfim.ImageFormat.R5g5b5a1:
					format = PixelFormat.Format16bppArgb1555;
					break;
				case Pfim.ImageFormat.Rgb8:
					format = PixelFormat.Format8bppIndexed;
					break;
				default:
					throw new NotImplementedException();
			}

			GCHandle handle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
			try
			{
				nint data = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);
				Bitmap bitmap = new Bitmap(image.Width, image.Height, image.Stride, format, data);
				return bitmap;
			}
			finally
			{
				handle.Free();
			}
		}
	}
}
