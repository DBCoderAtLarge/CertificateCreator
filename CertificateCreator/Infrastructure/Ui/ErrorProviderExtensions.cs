using System.Drawing;
using System.Windows.Forms;

namespace CertificateCreator.Infrastructure.Ui
{
    public static class ErrorProviderExtensions
    {
        public static ErrorProvider SetIcon(this ErrorProvider errorProvider, Icon icon, Size size)
        {
            var bitmap = new Bitmap(size.Width, size.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(icon.ToBitmap(), new Rectangle(Point.Empty, size));
            }
            errorProvider.Icon = Icon.FromHandle(bitmap.GetHicon());
            return errorProvider;
        }
    }
}
