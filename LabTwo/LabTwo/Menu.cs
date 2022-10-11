namespace LabTwo
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuBtnTask1_Click(object sender, EventArgs e)
        {
            Task1 task = new Task1();
            task.Show(this);
        }

        private void menuBtnTask2_Click(object sender, EventArgs e)
        {
            Task2 task = new Task2();
            task.Show(this);
        }
    }
}