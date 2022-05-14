using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSAR
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            recognizedTextBox.Font = new Font(recognizedTextBox.Font.FontFamily, 16);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
               // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imageUserControl1.LoadImage(openFileDialog.FileName);
                        _imageFileName = openFileDialog.FileName;
                    //    imagePanel.Refresh();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItemScale50_Click(object sender, EventArgs e)
        {
            imageUserControl1.Scale(0.5);
        }

        private void toolStripMenuItemScale75_Click(object sender, EventArgs e)
        {
            imageUserControl1.Scale(0.75);
        }

        private void toolStripMenuItemScale100_Click(object sender, EventArgs e)
        {
            imageUserControl1.Scale(1);
        }

        private void toolStripMenuItemScale125_Click(object sender, EventArgs e)
        {
            imageUserControl1.Scale(1.25);
        }

        private void toolStripMenuItemScale150_Click(object sender, EventArgs e)
        {
            imageUserControl1.Scale(1.5);
        }

        private void toolStripMenuItemScale200_Click(object sender, EventArgs e)
        {
            imageUserControl1.Scale(2);
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            _runner.Run(_imageFileName, false, new Language[] { Language.Korean, Language.ChineseTrad, Language.Russian }, 
                () => {
                    MessageBox.Show("Done!");
            });
        }

        private string _imageFileName;
        private TessRunner _runner = new TessRunner();
        private string _prevTextBoxContent;

        private void toolStripButtonSelection_Click(object sender, EventArgs e)
        {
#if dddd
            var selectedSubimage = imageUserControl1.SelectedPiece;
            if (selectedSubimage == null)
                return;

            selectedSubimage.Save("subimage.png");
#endif
        }

        private void getSelectedText(Language language)
        {
            try
            {
                using (var selectedSubimage = imageUserControl1.SelectedPiece)
                {
                    if (selectedSubimage == null)
                        return;
                    string dirName = @"e:\project\csharp\TSAR\temp\";
                    string subImageFileName = dirName + "subimage.png";
                    selectedSubimage.Save(subImageFileName);
                    _runner.Run(subImageFileName, true, new Language[] { language }, () =>
                    {
                        string recognizedText = System.IO.File.ReadAllText(dirName + "tess_out.txt");
                        recognizedText = recognizedText.Trim();
                        _prevTextBoxContent = recognizedTextBox.Text;
                        recognizedTextBox.Text = recognizedTextBox.Text + recognizedText + ' ';
                    });
                }
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
                return;
            switch(e.KeyCode)
            {
                case Keys.Q:
                    getSelectedText(Language.Korean);
                    break;
                case Keys.W:
                    getSelectedText(Language.ChineseTrad);
                    break;
                case Keys.E:
                    getSelectedText(Language.Russian);
                    break;
                case Keys.R:
                    getSelectedText(Language.English);
                    break;
                case Keys.Z:
                    //if(_prevTextBoxContent.Length != 0)
                    {
                        recognizedTextBox.Text = _prevTextBoxContent;
                    }
                    break;
            }
        }
    }
}
