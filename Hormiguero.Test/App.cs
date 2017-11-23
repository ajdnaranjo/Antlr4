using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hormiguero.Test
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

         
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            trView.Nodes.Clear();
            Stream myStream = null;
            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                StringBuilder text = new StringBuilder();
                try
                {
                    if ((myStream = ofdSelectFile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string input = string.Empty;

                            System.IO.StreamReader file = new System.IO.StreamReader(myStream);
                            while ((input = file.ReadLine()) != null)
                            {
                                text.AppendLine(input);

                            }
                            file.Close();

                        }
                    }
                    var csharp = new CSharp();
                    var result = csharp.ProcessUsings(text);

                    foreach (var data in result)
                    {
                        var treeNode = trView.Nodes.Add(data.Token);
                        foreach (var item in data.Value)
                        {
                            trView.Nodes.Add(treeNode.Text, item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
