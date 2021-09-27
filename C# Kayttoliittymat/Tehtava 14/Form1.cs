using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tehtava_14
{
    public partial class Form1 : Form
    {
        private string EditorFileName = "Untitled";
        public Form1()
        {
            InitializeComponent();
        }

        private void setFormTitleText()
        {
            FileInfo fileinfo = new FileInfo(EditorFileName);
            Text = fileinfo.Name + "-Editor";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";
            richTextBox1.Clear();
            setFormTitleText();
        }

        private void readFile()
        {
            try
            {
                using (StreamReader Reader = new StreamReader(EditorFileName))
                {
                    richTextBox1.Clear();

                    richTextBox1.Text = Reader.ReadToEnd();

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveFile()
        {
            try
            {
                using (StreamWriter SrWrite = new StreamWriter(EditorFileName))
                {
                    SrWrite.Write(richTextBox1);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Title = "Open";
            Openfile.ShowReadOnly = true;
            Openfile.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            if(Openfile.ShowDialog() == DialogResult.OK)
            {
                EditorFileName = Openfile.FileName;

                readFile();
                setFormTitleText();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditorFileName == "Untitled")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                saveFile();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDlg = new SaveFileDialog();

            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            if (SaveFileDlg.ShowDialog() == DialogResult.OK)
            {
                EditorFileName = SaveFileDlg.FileName;

                saveFile();
                setFormTitleText();
            }
        }
    }
}

