using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TSAR
{
    public partial class ImageUserControl : UserControl
    {
        private struct DenormRectangle
        {
            public int x;
            public int y;
            public int width;
            public int height;
        }
        public ImageUserControl()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
        }

        public void LoadImage(string fileName)
        {
            _loadedImage = new Bitmap(Image.FromFile(fileName));
            Scale(1);
        }

        public void Scale(double scale)
        {
            _scale = scale;
            AutoScrollMinSize = ImageScaledSize;
            Invalidate();
        }

        public Bitmap SelectedPiece
        {
            get
            {
                if (!_selectedArea.HasValue || _loadedImage == null)
                    return null;

                var selection = new Rectangle(
                    Math.Min(_selectedArea.Value.x, _selectedArea.Value.x + _selectedArea.Value.width) - HorizontalScroll.Value,
                    Math.Min(_selectedArea.Value.y, _selectedArea.Value.y + _selectedArea.Value.height) - VerticalScroll.Value,
                    Math.Abs(_selectedArea.Value.width),
                    Math.Abs(_selectedArea.Value.height));

                var topLeft = ScreenToImage(new Point(selection.X, selection.Y));
                topLeft = new Point(Math.Max(0, topLeft.X), Math.Max(0, topLeft.Y));
                var bottomRight = ScreenToImage(new Point(selection.X + selection.Width, selection.Y + selection.Height));
                bottomRight = new Point(Math.Min(_loadedImage.Width - 1, bottomRight.X), Math.Min(_loadedImage.Height - 1, bottomRight.Y));
                return _loadedImage.Clone(new Rectangle(topLeft, new Size(bottomRight.X - topLeft.X + 1, bottomRight.Y - topLeft.Y + 1)),
                    _loadedImage.PixelFormat);
            }
        }

        private Bitmap _loadedImage = null;
        private double _scale = 1;

        private DenormRectangle? _selectedArea;
        private bool inSelection = false;

       

        private Size ImageScaledSize 
        { 
            get 
            {
                if (_loadedImage == null)
                    return new Size(0, 0);
                return new Size((int)(_scale * _loadedImage.Width), (int)(_scale * _loadedImage.Height));
            } 
        }

        private void ImageUserControl_Paint(object sender, PaintEventArgs e)
        {
            int viewWidth = Math.Max(ImageScaledSize.Width, ClientRectangle.Width);
            int viewHeight = Math.Max(ImageScaledSize.Height, ClientRectangle.Height);
            e.Graphics.FillRectangle(System.Drawing.SystemBrushes.Window, new Rectangle(0, 0, viewWidth, viewHeight));
            if (_loadedImage == null)
            {
                string drawString = "Изображение не загружено";
                using (Font drawFont = new Font("Arial", 24))
                using (SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.LightGray))
                {
                    RectangleF rect = new RectangleF(0, 0, viewWidth, viewHeight);
                    StringFormat drawFormat = new StringFormat();
                    drawFormat.Alignment = StringAlignment.Center;
                    drawFormat.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, rect, drawFormat);
                }
                return;
            }

            int left = (viewWidth - ImageScaledSize.Width) / 2 - HorizontalScroll.Value;
            int top = (viewHeight - ImageScaledSize.Height) / 2 - VerticalScroll.Value;
            e.Graphics.DrawImage(_loadedImage, new Rectangle(new Point(left, top), ImageScaledSize));

            if(_selectedArea.HasValue)
            {
                var selectedRect = new Rectangle(
                    Math.Min(_selectedArea.Value.x, _selectedArea.Value.x + _selectedArea.Value.width) - HorizontalScroll.Value,
                    Math.Min(_selectedArea.Value.y, _selectedArea.Value.y + _selectedArea.Value.height) - VerticalScroll.Value,
                    Math.Abs(_selectedArea.Value.width),
                    Math.Abs(_selectedArea.Value.height));
                e.Graphics.DrawRectangle(new Pen(Color.Red), selectedRect);
            }
        }

        private void ImageUserControl_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void ImageUserControl_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ImageUserControl_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ImageUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            inSelection = true;
            _selectedArea = new DenormRectangle
            {
                x = e.Location.X + HorizontalScroll.Value,
                y = e.Location.Y + VerticalScroll.Value,
                width = 0,
                height = 0
            };
            Invalidate();
        }

        private void ImageUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            inSelection = false;
        }

        private Point ScreenToImage(Point pt)
        {
            int viewWidth = Math.Max(ImageScaledSize.Width, ClientRectangle.Width);
            int viewHeight = Math.Max(ImageScaledSize.Height, ClientRectangle.Height);
            int truePtX = pt.X + HorizontalScroll.Value;
            int truePtY = pt.Y + VerticalScroll.Value;

            int inImageX = _loadedImage.Width / 2 + (int)((truePtX - viewWidth/2) / _scale);
            int inImageY = _loadedImage.Height / 2 + (int)((truePtY - viewHeight/2) / _scale);

            return new Point(inImageX, inImageY);
        }



        private void ImageUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(inSelection && _selectedArea.HasValue)
            {
                int x = e.Location.X + HorizontalScroll.Value;
                int y = e.Location.Y + VerticalScroll.Value;
                int resWidth = x - _selectedArea.Value.x;
                int resHeight = y - _selectedArea.Value.y;
                _selectedArea = new DenormRectangle
                {
                    x = _selectedArea.Value.x,
                    y = _selectedArea.Value.y,
                    width = resWidth,
                    height = resHeight
                };
                Invalidate();
            }
        }

#if zzz
        private void ImageUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(!_selectedArea.HasValue)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        _selectedArea = null;
                        Invalidate();
                    }
                    break;
                default:
                    break;
            }
        }
#endif
    }

}
