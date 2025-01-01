using System.Windows.Forms.Design;

namespace Menu_Replacer_Designer
{
	internal class ImageNameEditor : FileNameEditor
	{
		protected override void InitializeDialog(OpenFileDialog openFileDialog)
		{
			base.InitializeDialog(openFileDialog);
			openFileDialog.Filter = "Morrowind Textures | *.dds;*.tga";
		}
	}
}
