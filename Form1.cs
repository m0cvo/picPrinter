using System.Drawing.Printing;

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

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
        }
        private void CaptureScreen()
        {
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += PrintPage;

            PrintDialog pDialog = new PrintDialog();
            pDialog.ShowHelp = true;
            pDialog.AllowSelection = false;
            pDialog.AllowSomePages = false;
            pDialog.Document = pDoc;
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            };
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = pictureBox1.Image;
            Point loc = new Point(10, 10);
            e.Graphics.DrawImage(img, loc);
        }        
    }
}