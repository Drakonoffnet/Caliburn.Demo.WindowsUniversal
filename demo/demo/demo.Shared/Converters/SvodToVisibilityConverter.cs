using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Megogo.Converters
{
    public class SvodToVisibilityConverter : VodToVisibilityConverter
    {
        public SvodToVisibilityConverter()
            : base("svod")
        {

        }
    }
}