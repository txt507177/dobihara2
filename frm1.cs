using System.Resources;
using System.Windows.Forms;

namespace dobihara2
{
    public partial class frm1 : Form
    {
        PictureBox pb1 = new PictureBox();
        Image di1;
        int csy1;
        int csx1;
        public frm1()
        {
            InitializeComponent();
            this.Load += load1;
            this.Load += load2;
            this.Resize += resw1;
            this.Resize += resw2;
        }
        public void frm1_Load(object sender, EventArgs e)
        {
            csy1 = this.ClientSize.Height/2 - 200;
            csx1 = 0;//this.Controls.Count;//
        }
        public void load1(object sender, EventArgs e)
        {
            di1 = Resource1.di1;
        }
        public void load2(object sender, EventArgs e)
        {
            pb1.Image = di1;
            pb1.Width = 1980;
            pb1.Height = 242;
            //pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.Location = new Point(csx1, csy1);
            //pb1.Location = new Point(this.Controls.Count, 400);
            this.Controls.Add(pb1);
            //cws1();
        }
        public void resw1(object sender, EventArgs e)
        {
            csy1 = this.ClientSize.Height/2 - 200;
            csx1 = 0;
        }
        public void resw2(object sender, EventArgs e)
        {
            cws1();
        }
        public void cws1()
        {
            Point ws = new Point(this.ClientSize.Width, this.ClientSize.Height);
            pb1.Location = new Point(csx1, csy1);
            //MessageBox.Show(this.ClientSize.Height.ToString());
            if (ws.Y / 2 != 0)
            {
                MessageBox.Show(ws.Y.ToString());
            }
            //pb1.Height = 500;
        }
    }
}
