using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopAppRename
{
    public partial class Form1 : Form
    {
       private string folderPath;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //CHOOSE THE FOLDER END DISPLAY IT
            var folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            string[] filesList = Directory.GetFiles(folder.SelectedPath);
            folderPath = folder.SelectedPath+"\\";
            string fileName;

            for (int index = 0; index < filesList.Length; index++) {
                fileName = filesList[index].Split('\\').Last();
                dataGridFiles.Rows.Add(fileName);
            }
            
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            string newFileNameValue;
            string oldFileNameValue;

            for (int index = 0; index < dataGridFiles.RowCount; index++) {

                if (dataGridFiles[1, index].Value != null) {
                 newFileNameValue = dataGridFiles[1, index].Value.ToString();
                 oldFileNameValue = dataGridFiles[0, index].Value.ToString();
                 RenameFile(oldFileNameValue, newFileNameValue);
                }
            }

        }

        public void RenameFile(string oldFileName, string newFileName) {
         string fileExtension;
         fileExtension ="."+oldFileName.Split('.').Last();
         File.Move(folderPath + oldFileName, folderPath + newFileName+fileExtension);
        }

        // realizar um recaregamento dos dados no dataGriw

    }
}
