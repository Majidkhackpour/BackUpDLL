using System.Windows.Forms;

namespace BackUpDLL
{
    public partial class FRMInitialSettings : Form
    {
        public string ConnectionString { get; private set; } = "";
        public FRMInitialSettings()
        {
            InitializeComponent();
        }
    }
}
