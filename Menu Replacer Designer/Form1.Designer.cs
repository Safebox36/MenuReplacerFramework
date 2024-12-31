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
			flowMenuOptions = new FlowLayoutPanel();
			pnlMenuOption1 = new Panel();
			pnlMenuOption2 = new Panel();
			pnlMenuOption3 = new Panel();
			pnlMenuOption4 = new Panel();
			pnlMenuOption5 = new Panel();
			pnlMenuOption6 = new Panel();
			pnlLogo = new Panel();
			mnuStrip = new MenuStrip();
			mnuFile = new ToolStripMenuItem();
			mnuNewMenu = new ToolStripMenuItem();
			mnuOpenMenu = new ToolStripMenuItem();
			mnuSaveMenu = new ToolStripMenuItem();
			mnuCloseMenu = new ToolStripMenuItem();
			mnuEdit = new ToolStripMenuItem();
			mnuUndo = new ToolStripMenuItem();
			mnuRedo = new ToolStripMenuItem();
			pnlMenu.SuspendLayout();
			flowMenuOptions.SuspendLayout();
			mnuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// propsAll
			// 
			propsAll.Location = new Point(658, 27);
			propsAll.Margin = new Padding(3, 3, 12, 12);
			propsAll.Name = "propsAll";
			propsAll.PropertySort = PropertySort.Categorized;
			propsAll.Size = new Size(256, 360);
			propsAll.TabIndex = 0;
			propsAll.ToolbarVisible = false;
			propsAll.PropertyValueChanged += propsAll_PropertyValueChanged;
			// 
			// pnlMenu
			// 
			pnlMenu.BackgroundImage = Properties.Resources.menu_background;
			pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
			pnlMenu.Controls.Add(flowMenuOptions);
			pnlMenu.Controls.Add(pnlLogo);
			pnlMenu.Location = new Point(12, 27);
			pnlMenu.Name = "pnlMenu";
			pnlMenu.Size = new Size(640, 360);
			pnlMenu.TabIndex = 1;
			// 
			// flowMenuOptions
			// 
			flowMenuOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flowMenuOptions.AutoSize = true;
			flowMenuOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			flowMenuOptions.BackColor = Color.Transparent;
			flowMenuOptions.Controls.Add(pnlMenuOption1);
			flowMenuOptions.Controls.Add(pnlMenuOption2);
			flowMenuOptions.Controls.Add(pnlMenuOption3);
			flowMenuOptions.Controls.Add(pnlMenuOption4);
			flowMenuOptions.Controls.Add(pnlMenuOption5);
			flowMenuOptions.Controls.Add(pnlMenuOption6);
			flowMenuOptions.FlowDirection = FlowDirection.TopDown;
			flowMenuOptions.Location = new Point(190, 31);
			flowMenuOptions.Name = "flowMenuOptions";
			flowMenuOptions.Size = new Size(256, 300);
			flowMenuOptions.TabIndex = 1;
			flowMenuOptions.WrapContents = false;
			flowMenuOptions.Paint += flowMenuOptions_Paint;
			// 
			// pnlMenuOption1
			// 
			pnlMenuOption1.Anchor = AnchorStyles.Top;
			pnlMenuOption1.BackColor = Color.Transparent;
			pnlMenuOption1.Location = new Point(68, 0);
			pnlMenuOption1.Margin = new Padding(0);
			pnlMenuOption1.Name = "pnlMenuOption1";
			pnlMenuOption1.Size = new Size(120, 50);
			pnlMenuOption1.TabIndex = 3;
			pnlMenuOption1.Paint += pnlMenuOption_Paint;
			pnlMenuOption1.MouseEnter += pnlMenuOption_MouseEnter;
			pnlMenuOption1.MouseLeave += pnlMenuOption_MouseLeave;
			// 
			// pnlMenuOption2
			// 
			pnlMenuOption2.Anchor = AnchorStyles.Top;
			pnlMenuOption2.BackColor = Color.Transparent;
			pnlMenuOption2.Location = new Point(68, 50);
			pnlMenuOption2.Margin = new Padding(0);
			pnlMenuOption2.Name = "pnlMenuOption2";
			pnlMenuOption2.Size = new Size(120, 50);
			pnlMenuOption2.TabIndex = 4;
			pnlMenuOption2.Paint += pnlMenuOption_Paint;
			pnlMenuOption2.MouseEnter += pnlMenuOption_MouseEnter;
			pnlMenuOption2.MouseLeave += pnlMenuOption_MouseLeave;
			// 
			// pnlMenuOption3
			// 
			pnlMenuOption3.Anchor = AnchorStyles.Top;
			pnlMenuOption3.BackColor = Color.Transparent;
			pnlMenuOption3.Location = new Point(68, 100);
			pnlMenuOption3.Margin = new Padding(0);
			pnlMenuOption3.Name = "pnlMenuOption3";
			pnlMenuOption3.Size = new Size(120, 50);
			pnlMenuOption3.TabIndex = 5;
			pnlMenuOption3.Paint += pnlMenuOption_Paint;
			pnlMenuOption3.MouseEnter += pnlMenuOption_MouseEnter;
			pnlMenuOption3.MouseLeave += pnlMenuOption_MouseLeave;
			// 
			// pnlMenuOption4
			// 
			pnlMenuOption4.Anchor = AnchorStyles.Top;
			pnlMenuOption4.BackColor = Color.Transparent;
			pnlMenuOption4.Location = new Point(0, 150);
			pnlMenuOption4.Margin = new Padding(0);
			pnlMenuOption4.Name = "pnlMenuOption4";
			pnlMenuOption4.Size = new Size(256, 50);
			pnlMenuOption4.TabIndex = 6;
			pnlMenuOption4.Paint += pnlMenuOption4_Paint;
			pnlMenuOption4.MouseEnter += pnlMenuOption_MouseEnter;
			pnlMenuOption4.MouseLeave += pnlMenuOption_MouseLeave;
			// 
			// pnlMenuOption5
			// 
			pnlMenuOption5.Anchor = AnchorStyles.Top;
			pnlMenuOption5.BackColor = Color.Transparent;
			pnlMenuOption5.Location = new Point(68, 200);
			pnlMenuOption5.Margin = new Padding(0);
			pnlMenuOption5.Name = "pnlMenuOption5";
			pnlMenuOption5.Size = new Size(120, 50);
			pnlMenuOption5.TabIndex = 6;
			pnlMenuOption5.Paint += pnlMenuOption_Paint;
			pnlMenuOption5.MouseEnter += pnlMenuOption_MouseEnter;
			pnlMenuOption5.MouseLeave += pnlMenuOption_MouseLeave;
			// 
			// pnlMenuOption6
			// 
			pnlMenuOption6.Anchor = AnchorStyles.Top;
			pnlMenuOption6.BackColor = Color.Transparent;
			pnlMenuOption6.Location = new Point(68, 250);
			pnlMenuOption6.Margin = new Padding(0);
			pnlMenuOption6.Name = "pnlMenuOption6";
			pnlMenuOption6.Size = new Size(120, 50);
			pnlMenuOption6.TabIndex = 7;
			pnlMenuOption6.Paint += pnlMenuOption_Paint;
			pnlMenuOption6.MouseEnter += pnlMenuOption_MouseEnter;
			pnlMenuOption6.MouseLeave += pnlMenuOption_MouseLeave;
			// 
			// pnlLogo
			// 
			pnlLogo.BackColor = Color.Transparent;
			pnlLogo.Location = new Point(41, 31);
			pnlLogo.Name = "pnlLogo";
			pnlLogo.Size = new Size(1024, 256);
			pnlLogo.TabIndex = 2;
			pnlLogo.Visible = false;
			pnlLogo.Paint += pnlLogo_Paint;
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
			pnlMenu.ResumeLayout(false);
			pnlMenu.PerformLayout();
			flowMenuOptions.ResumeLayout(false);
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
		private FlowLayoutPanel flowMenuOptions;
		private Panel pnlLogo;
		private Panel pnlMenuOption1;
		private Panel pnlMenuOption2;
		private Panel pnlMenuOption3;
		private Panel pnlMenuOption4;
		private Panel pnlMenuOption5;
		private Panel pnlMenuOption6;
	}
}
