namespace Menu_Replacer_Designer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			propsAll = new PropertyGrid();
			pnlMenu = new Panel();
			mnuStrip = new MenuStrip();
			mnuFile = new ToolStripMenuItem();
			mnuNewMenu = new ToolStripMenuItem();
			mnuOpenMenu = new ToolStripMenuItem();
			mnuSaveMenu = new ToolStripMenuItem();
			mnuCloseMenu = new ToolStripMenuItem();
			mnuEdit = new ToolStripMenuItem();
			mnuUndo = new ToolStripMenuItem();
			mnuRedo = new ToolStripMenuItem();
			mnuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// propsAll
			// 
			propsAll.Location = new Point(658, 27);
			propsAll.Margin = new Padding(3, 3, 12, 12);
			propsAll.Name = "propsAll";
			propsAll.PropertySort = PropertySort.Categorized;
			propsAll.Size = new Size(213, 360);
			propsAll.TabIndex = 0;
			propsAll.ToolbarVisible = false;
			propsAll.PropertyValueChanged += propsAll_PropertyValueChanged;
			// 
			// pnlMenu
			// 
			pnlMenu.BackgroundImage = Properties.Resources.menu_background;
			pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
			pnlMenu.BorderStyle = BorderStyle.FixedSingle;
			pnlMenu.Location = new Point(12, 27);
			pnlMenu.Name = "pnlMenu";
			pnlMenu.Size = new Size(640, 360);
			pnlMenu.TabIndex = 1;
			// 
			// mnuStrip
			// 
			mnuStrip.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit });
			mnuStrip.Location = new Point(0, 0);
			mnuStrip.Name = "mnuStrip";
			mnuStrip.Size = new Size(1031, 24);
			mnuStrip.TabIndex = 2;
			mnuStrip.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNewMenu, mnuOpenMenu, mnuSaveMenu, mnuCloseMenu });
			mnuFile.Name = "mnuFile";
			mnuFile.Size = new Size(37, 20);
			mnuFile.Text = "&File";
			// 
			// mnuNewMenu
			// 
			mnuNewMenu.Image = Properties.Resources.menu_new;
			mnuNewMenu.ImageScaling = ToolStripItemImageScaling.None;
			mnuNewMenu.Name = "mnuNewMenu";
			mnuNewMenu.Size = new Size(185, 22);
			mnuNewMenu.Text = "&New Menu Replacer";
			// 
			// mnuOpenMenu
			// 
			mnuOpenMenu.Image = Properties.Resources.menu_open;
			mnuOpenMenu.ImageScaling = ToolStripItemImageScaling.None;
			mnuOpenMenu.Name = "mnuOpenMenu";
			mnuOpenMenu.Size = new Size(185, 22);
			mnuOpenMenu.Text = "&Open Menu Replacer";
			// 
			// mnuSaveMenu
			// 
			mnuSaveMenu.Image = Properties.Resources.menu_save;
			mnuSaveMenu.ImageScaling = ToolStripItemImageScaling.None;
			mnuSaveMenu.Name = "mnuSaveMenu";
			mnuSaveMenu.Size = new Size(185, 22);
			mnuSaveMenu.Text = "&Save Menu Replacer";
			// 
			// mnuCloseMenu
			// 
			mnuCloseMenu.Image = Properties.Resources.menu_close;
			mnuCloseMenu.ImageScaling = ToolStripItemImageScaling.None;
			mnuCloseMenu.Name = "mnuCloseMenu";
			mnuCloseMenu.Size = new Size(185, 22);
			mnuCloseMenu.Text = "&Close Menu Replacer";
			// 
			// mnuEdit
			// 
			mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuUndo, mnuRedo });
			mnuEdit.Name = "mnuEdit";
			mnuEdit.Size = new Size(39, 20);
			mnuEdit.Text = "&Edit";
			// 
			// mnuUndo
			// 
			mnuUndo.Image = Properties.Resources.menu_undo;
			mnuUndo.ImageScaling = ToolStripItemImageScaling.None;
			mnuUndo.Name = "mnuUndo";
			mnuUndo.Size = new Size(103, 22);
			mnuUndo.Text = "Undo";
			// 
			// mnuRedo
			// 
			mnuRedo.Image = Properties.Resources.menu_redo;
			mnuRedo.ImageScaling = ToolStripItemImageScaling.None;
			mnuRedo.Name = "mnuRedo";
			mnuRedo.Size = new Size(103, 22);
			mnuRedo.Text = "Redo";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(1031, 450);
			Controls.Add(pnlMenu);
			Controls.Add(propsAll);
			Controls.Add(mnuStrip);
			MainMenuStrip = mnuStrip;
			Name = "Form1";
			Text = "Form1";
			mnuStrip.ResumeLayout(false);
			mnuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PropertyGrid propsAll;
		private Panel pnlMenu;
		private MenuStrip mnuStrip;
		private ToolStripMenuItem mnuFile;
		private ToolStripMenuItem mnuNewMenu;
		private ToolStripMenuItem mnuOpenMenu;
		private ToolStripMenuItem mnuSaveMenu;
		private ToolStripMenuItem mnuCloseMenu;
		private ToolStripMenuItem mnuEdit;
		private ToolStripMenuItem mnuUndo;
		private ToolStripMenuItem mnuRedo;
	}
}
