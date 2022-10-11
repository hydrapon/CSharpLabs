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

        private void menuBtnTask3_Click(object sender, EventArgs e)
        {
            Task3 task = new Task3();
            task.Show(this);
        }

        private void menuBtnTask4_Click(object sender, EventArgs e)
        {
            Task4 task = new Task4();
            task.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task5 task = new Task5();
            task.Show(this);
        }
    }
}