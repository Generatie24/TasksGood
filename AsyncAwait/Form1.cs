using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        string path = @"c:\Intec\Data\Data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnProccess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            lblMessage.Text = "Proccessing information... Please wait";
            int count = await task;
            lblMessage.Text = $"Number of characters is {CountCharacters()}";

        }

        private  int CountCharacters()
        {
            Thread.Sleep(5000);
            using (StreamReader reader = new StreamReader(path))
            {
                //var content = reader.ReadToEnd();
                var content = reader.ReadToEnd();
                var count = content.Length;
                return count;
            }
        }
    }
}
