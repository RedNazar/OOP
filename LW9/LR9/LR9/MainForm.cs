using System.Drawing;
using System.Windows.Forms;


namespace LR9
{
    public partial class MainForm : Form
    {
        Katok K;
        public MainForm()
        {
            InitializeComponent();

            Random R = new Random();
            K = new Katok(R.Next(3, 8));
            K.Parent = this;
            K.Size = ClientSize;
            K.Anchor = (AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right |
                AnchorStyles.Top);
        }

    }

}