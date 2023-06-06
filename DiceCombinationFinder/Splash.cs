using System.Threading;
using System.Windows.Forms;

namespace DiceCombinationFinder
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread t = new Thread(()=>{

                Thread.Sleep(2000);
                this.Dispose();
                Application.Run(new MainWindow());
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
