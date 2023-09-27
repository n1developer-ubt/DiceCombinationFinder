using Microsoft.Web.WebView2.Core;
using System; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceCombinationFinder
{
    public partial class Visualizer : Form
    {
        private readonly string _fileToLoad;
        public Visualizer(string fileToLoad)
        {
            InitializeComponent();

            _fileToLoad = fileToLoad;
            Load();
        }

        private async Task Load()
        {
            try
            {
                var op = new CoreWebView2EnvironmentOptions("--disable-web-security");
                var env = await CoreWebView2Environment.CreateAsync(null, null, op);

                await wv.EnsureCoreWebView2Async(env);

                //wv.CoreWebView2.OpenDevToolsWindow();
                wv.Source = new Uri(_fileToLoad);
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
