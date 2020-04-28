using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceCombinationFinder
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            Thread t = new Thread(()=>{

                Thread.Sleep(4000);
                this.Dispose();
                Application.Run(new MainWindow());
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
