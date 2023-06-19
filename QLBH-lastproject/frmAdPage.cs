using WinFormsApp1.UC;

namespace WinFormsApp1
{
    public partial class frmAdPage : Form
    {
        private bool activeForm;
        public frmAdPage()
        {
            InitializeComponent();
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            activeForm = false;
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
                pnl.BackColor = Color.Silver;
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "BtnAllProduct":
                    activeForm = true;
                    add_UControls(new UC_AllProducts());
                    pnlProducts.BackColor = Color.White;
                    break;
                case "BtnAllUsers":
                    activeForm = true;
                    add_UControls(new UC_AllUsers());
                    pnlUsers.BackColor = Color.White;
                    break;
                case "BtnAllOrders":
                    activeForm = true;
                    add_UControls(new UC_AllOrders());
                    pnlOrders.BackColor = Color.White;
                    break;
            }
        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure to close this?", "CLose Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}