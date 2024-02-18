namespace RJContumControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e) 
        { 
            rjDropdownMenu1.IsAccessible = true; 
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(rjButton1, rjButton1.Width, 0);
        }
    }
}
