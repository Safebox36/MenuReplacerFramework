﻿using Newtonsoft.Json;
using System.ComponentModel;
using System.Drawing.Design;
using System.Text.Json.Serialization;

namespace Menu_Replacer_Designer
{
	internal class MenuBase : ICloneable
	{
		private const string version = "2025-01-01";
		private Size gameResolution = new(1280, 720);
		private string backgroundImage = "";
		private string cursorImage = "";
		private bool useTitle = false;
		private MenuLogo menuLogo = new();
		private MenuOptions menuOptions = new();

		[Browsable(false)]
		public string Version { get => version; }
		[DefaultValue(typeof(Size), "1280, 720")]
		[Category(" ")]
		[Description("The resolution of the game window.")]
		public Size GameResolution { get => gameResolution; set => gameResolution = value; }
		[DefaultValue("")]
		[Category(" ")]
		[Description("The background image.")]
		[Editor(typeof(ImageNameEditor), typeof(UITypeEditor))]
		public string BackgroundImage { get => backgroundImage; set => backgroundImage = value; }
		[DefaultValue("")]
		[Category(" ")]
		[Description("The cursor image.")]
		[Editor(typeof(ImageNameEditor), typeof(UITypeEditor))]
		public string CursorImage { get => cursorImage; set => cursorImage = value; }
		[DefaultValue(false)]
		[Category(" ")]
		[Description("Use a title separate from the background.")]
		public bool UseTitle { get => useTitle; set => useTitle = value; }
		[DisplayName("Logo")]
		[JsonProperty("Logo")]
		[Category(" ")]
		[Description("The optional logo separate from the background image.")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public MenuLogo MenuLogo { get => menuLogo; set => menuLogo = value; }
		[DisplayName("Options")]
		[JsonProperty("Options")]
		[Category(" ")]
		[Description("The menu option buttons.")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public MenuOptions MenuOptions { get => menuOptions; set => menuOptions = value; }

		public object Clone()
		{
			MenuBase menuBase = new();
			menuBase.gameResolution = this.gameResolution;
			menuBase.backgroundImage = this.backgroundImage;
			menuBase.cursorImage = this.cursorImage;
			menuBase.useTitle = this.useTitle;
			menuBase.menuLogo = (MenuLogo)this.menuLogo.Clone();
			menuBase.menuOptions = (MenuOptions)this.menuOptions.Clone();
			return menuBase;
		}
	}
}
