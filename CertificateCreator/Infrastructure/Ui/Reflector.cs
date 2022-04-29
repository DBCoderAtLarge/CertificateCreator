using System.Reflection;
using System.Windows.Forms;

namespace CertificateCreator.Infrastructure.Ui
{
    public class Reflector
    {
        public static Control GetPropValue(object src, string propName)
        {
            return src.GetType()
                .GetField(propName, BindingFlags.Instance | BindingFlags.NonPublic)
                .GetValue(src) as Control;
        }

    }
}
