namespace picPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddPicture_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //Using the OpenFileDialog (renamed to AddPicture
            //The user can upload any picture to the pictureBox.
            if(AddPicture.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(AddPicture.FileName);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}