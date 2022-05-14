
namespace TSAR
{
    partial class ImageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ImageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "ImageUserControl";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ImageUserControl_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageUserControl_Paint);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageUserControl_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageUserControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageUserControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageUserControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageUserControl_MouseUp);
            this.Resize += new System.EventHandler(this.ImageUserControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
