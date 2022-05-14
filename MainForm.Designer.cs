
namespace TSAR
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutputTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageUserControl1 = new TSAR.ImageUserControl();
            this.recognizedTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.scaleButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuScale50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuScale75 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuScale100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuScale125 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuScale150 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuScale200 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelection = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.openOutputTextFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openImageToolStripMenuItem.Text = "Open Image...";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // openOutputTextFileToolStripMenuItem
            // 
            this.openOutputTextFileToolStripMenuItem.Name = "openOutputTextFileToolStripMenuItem";
            this.openOutputTextFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openOutputTextFileToolStripMenuItem.Text = "Open Output Text File...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.splitContainer1.Panel1.Controls.Add(this.imageUserControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.recognizedTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(984, 659);
            this.splitContainer1.SplitterDistance = 571;
            this.splitContainer1.TabIndex = 1;
            // 
            // imageUserControl1
            // 
            this.imageUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageUserControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imageUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageUserControl1.Location = new System.Drawing.Point(0, 0);
            this.imageUserControl1.Name = "imageUserControl1";
            this.imageUserControl1.Size = new System.Drawing.Size(569, 657);
            this.imageUserControl1.TabIndex = 0;
            // 
            // recognizedTextBox
            // 
            this.recognizedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recognizedTextBox.Location = new System.Drawing.Point(3, 2);
            this.recognizedTextBox.Multiline = true;
            this.recognizedTextBox.Name = "recognizedTextBox";
            this.recognizedTextBox.Size = new System.Drawing.Size(401, 651);
            this.recognizedTextBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleButton,
            this.toolStripButtonClear,
            this.toolStripButtonInfo,
            this.toolStripButtonSelection});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // scaleButton
            // 
            this.scaleButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuScale50,
            this.toolStripMenuScale75,
            this.toolStripMenuScale100,
            this.toolStripMenuScale125,
            this.toolStripMenuScale150,
            this.toolStripMenuScale200});
            this.scaleButton.Image = ((System.Drawing.Image)(resources.GetObject("scaleButton.Image")));
            this.scaleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(88, 22);
            this.scaleButton.Text = "Масштаб";
            // 
            // toolStripMenuScale50
            // 
            this.toolStripMenuScale50.Name = "toolStripMenuScale50";
            this.toolStripMenuScale50.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuScale50.Text = "50%";
            this.toolStripMenuScale50.Click += new System.EventHandler(this.toolStripMenuItemScale50_Click);
            // 
            // toolStripMenuScale75
            // 
            this.toolStripMenuScale75.Name = "toolStripMenuScale75";
            this.toolStripMenuScale75.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuScale75.Text = "75%";
            this.toolStripMenuScale75.Click += new System.EventHandler(this.toolStripMenuItemScale75_Click);
            // 
            // toolStripMenuScale100
            // 
            this.toolStripMenuScale100.Name = "toolStripMenuScale100";
            this.toolStripMenuScale100.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuScale100.Text = "100%";
            this.toolStripMenuScale100.Click += new System.EventHandler(this.toolStripMenuItemScale100_Click);
            // 
            // toolStripMenuScale125
            // 
            this.toolStripMenuScale125.Name = "toolStripMenuScale125";
            this.toolStripMenuScale125.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuScale125.Text = "125%";
            this.toolStripMenuScale125.Click += new System.EventHandler(this.toolStripMenuItemScale125_Click);
            // 
            // toolStripMenuScale150
            // 
            this.toolStripMenuScale150.Name = "toolStripMenuScale150";
            this.toolStripMenuScale150.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuScale150.Text = "150%";
            this.toolStripMenuScale150.Click += new System.EventHandler(this.toolStripMenuItemScale150_Click);
            // 
            // toolStripMenuScale200
            // 
            this.toolStripMenuScale200.Name = "toolStripMenuScale200";
            this.toolStripMenuScale200.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuScale200.Text = "200%";
            this.toolStripMenuScale200.Click += new System.EventHandler(this.toolStripMenuItemScale200_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonClear.Text = "Стереть";
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(94, 22);
            this.toolStripButtonInfo.Text = "Общ. инф-я";
            this.toolStripButtonInfo.Click += new System.EventHandler(this.toolStripButtonInfo_Click);
            // 
            // toolStripButtonSelection
            // 
            this.toolStripButtonSelection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelection.Image")));
            this.toolStripButtonSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelection.Name = "toolStripButtonSelection";
            this.toolStripButtonSelection.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonSelection.Text = "Выделение";
            this.toolStripButtonSelection.Click += new System.EventHandler(this.toolStripButtonSelection_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Tesseract Semi Automatic Recognition (TSAR)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOutputTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
     //   private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox recognizedTextBox;
    //    private System.Windows.Forms.Panel imagePanel;
        private ImageUserControl imageUserControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton scaleButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuScale50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuScale75;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuScale100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuScale125;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuScale150;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuScale200;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelection;
    }
}

