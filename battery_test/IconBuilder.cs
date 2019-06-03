using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace cbattery
{
    public enum IconBuilderTextSizes
    {
        Double = 12,
        Triple = 8
    }
    
    /// <summary>
    /// IconBuilder is designed to create Icon object with custom preferences
    /// </summary>
    public class IconBuilder
    {
        public Size IconSize { private set; get; }
        public int TextXOffset { set; get; }
        public int TextYOffset { set; get; }
        private Bitmap Bmp;
        
        public IconBuilder()
        {
            TextXOffset = -4;
            TextYOffset = -2;
            IconSize =  SystemInformation.SmallIconSize;
            Bmp = new Bitmap(IconSize.Width, IconSize.Height); 
        }

        public void SetBottomColor(Color bottomColor)
        {
            using (Graphics g = Graphics.FromImage(Bmp))
            {
                using (SolidBrush brush = new SolidBrush(bottomColor))
                {
                    // Yeah, width and height is too much
                    g.FillRectangle(brush, 
                        0, 
                        Bmp.Height - 1 * (Bmp.Height / 16), 
                        Bmp.Width, 
                        Bmp.Height);    
                }
            }
        }

        public void SetString(Color stringColor, string s, IconBuilderTextSizes size)
        {
            using (Graphics g = Graphics.FromImage(Bmp))
            {
                using (SolidBrush brush = new SolidBrush(stringColor))
                {
                    using (Font font = new Font("Microsoft Sans Serif", (int)size))
                    {
                        g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                        g.DrawString(s, font, brush, TextXOffset, TextYOffset);
                    }
                }
            }
        }

        public void Clear()
        {
            using (Graphics g = Graphics.FromImage(Bmp))
            {
                g.Clear(Color.Transparent);
            }
        }

        public Icon Build()
        {
            var hicon = Bmp.GetHicon();
            var icon = Icon.FromHandle(hicon);
            Clear();
            return icon;
        }
    }
}