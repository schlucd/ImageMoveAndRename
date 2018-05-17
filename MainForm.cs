using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;

namespace QuickPickConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Setting the starting directories from App.config
            FromInput.Text = ConfigurationManager.AppSettings.Get("SourceDirectory");
            ToInput.Text = ConfigurationManager.AppSettings.Get("DestinationDirectory");
            ProcessedInput.Text = ConfigurationManager.AppSettings.Get("ProcessedDirectory");
        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("DestinationInputEnabled") != "0")
            {
                ToInput.Enabled = true;
                ToDir.Visible = true;
            }
            if (ConfigurationManager.AppSettings.Get("ProcessedInputEnabled") != "0")
            {
                ProcessedInput.Enabled = true;
                ProcessedDir.Visible = true;
            }
            if (ConfigurationManager.AppSettings.Get("MoveOriginalToProcessed") == "0")
            {
                ProcessedDir.Visible = false;
                ProcessedLabel.Visible = false;
                ProcessedInput.Visible = false;
            } 

        }
        
        private void FromDir_Click(object sender, EventArgs e)
        {           
            //Opens File Explorer 
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = FromInput.Text;
            dialog.IsFolderPicker = true;

            //Updating the text in the input field to what user chooses in Explorer   
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FromInput.Text = dialog.FileName;
            }
        }

        private void ToDir_Click(object sender, EventArgs e)
        {
            //Opens File Explorer 
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = ToInput.Text;
            dialog.IsFolderPicker = true;

            //Updating the text in the input field to what user chooses in Explorer dialog        
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ToInput.Text = dialog.FileName;
            }   
        }

        private void ProcessedDir_Click(object sender, EventArgs e)
        {
            //Opens File Explorer 
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = ProcessedInput.Text;
            dialog.IsFolderPicker = true;

            //Updating the text in the input field to what user chooses in Explorer dialog
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok && ConfigurationManager.AppSettings.Get("ProcessedInputEnabled") != "0")
            {
                ProcessedInput.Text = dialog.FileName;
            }
        }

        //Checking Unit Num input is all numerical
        private void UnitInput_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(UnitInput.Text, "^[0-9]+$" ))
            {
                ErrorDisplay();
                Notification.Text = "Unit Number must only include numbers";
                StartButton.Enabled = false;
            }
            else
            {
                Notification.Visible = false;
                StartButton.Enabled = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string SourceDir = FromInput.Text;
            string DestDir = ToInput.Text;
            string BackupDir = ProcessedInput.Text;
            string UnitNum = UnitInput.Text;
            int i = 0; //Number the images when copying

            if (!Directory.Exists(SourceDir))
            {
                MessageBox.Show("The Source location does not exist. Try selecting it again.");
            }
            else if (!Directory.Exists(DestDir))
            {
                MessageBox.Show("The Destination location does not exist.  Check your configuration settings.");
            }
            else if (!Directory.Exists(BackupDir))
            {
                MessageBox.Show("The Processed location does not exist. Check your configuration settings.");
            }
            else
            {
                //Make sure the source has images
                int FilesToTransfer = Directory.GetFiles(SourceDir, "*.jpg").Length;
                if (FilesToTransfer < 1)
                {
                    ErrorDisplay();
                    Notification.Text = "No images to copy (need .jpg)";
                }
                //Check Unit #
                else if (UnitNum.Length < 4 || UnitNum.Length > 10)
                {
                    ErrorDisplay();
                    Notification.Text = "Unit Number must be 4 to 10 digits long ";
                }

                //Need original file name for search pattern in the BackupDir
                string FolderName = SourceDir.Split('\\').Last();
                
                //Check directories don't already exist
                if (Directory.GetDirectories(DestDir, UnitNum).Length != 0)
                {
                    MessageBox.Show("A folder with this unit number already exists on the server");
                }
                else if (Directory.GetDirectories(BackupDir, FolderName).Length != 0)
                {
                    MessageBox.Show("A folder with this unit number already exists in 'Processed'");
                }
                else
                {
                    //Turning this off in .config will remove making a new directory with the Unit Number for the name  
                    if (ConfigurationManager.AppSettings.Get("CreateDirectoryWithUnitNumber") == "1")
                    {
                        DirectoryInfo newChildDir = new DirectoryInfo(DestDir).CreateSubdirectory(UnitNum);
                        DestDir = newChildDir.ToString();
                    }

                    ProgressBar.Visible = true;
                    try
                    {
                        foreach (var image in Directory.GetFiles(SourceDir, "*.jpg"))
                        {
                            //Img Naming Convention = 80956.jpg, 80956-1.jpg, 80956-2.jpg, etc
                            if (i == 0)
                            {
                                File.Copy(image, Path.Combine(DestDir, UnitNum + ".jpg"));
                                ProgressBar.PerformStep();
                            }
                            else
                            {
                                File.Copy(image, Path.Combine(DestDir, UnitNum + "-" + i + ".jpg"));
                                ProgressBar.PerformStep();
                            }
                            i++;
                        }
                    }
                    catch
                    {
                        //If user doesn't have permissions to target directory
                        MessageBox.Show("Do not have permissions to copy files to/from one of the locations.");
                    }
                    ProgressBar.Visible = false;

                    //Moving the source folder to the Processed directory with original file name
                    if (ConfigurationManager.AppSettings.Get("MoveOriginalToProcessed") == "1")
                    {
                        DirectoryInfo origDir = new DirectoryInfo(SourceDir);
                        BackupDir = BackupDir + '\\' + FolderName;
                        origDir.MoveTo(BackupDir);
                    }

                    //Checking all pictures copied
                    if (Directory.GetFiles(DestDir, "*.jpg").Length != FilesToTransfer)
                    {
                        MessageBox.Show("Not all images were copied to the Destination folder");
                    }
                    else
                    {
                        Notification.Visible = true;
                        Notification.ForeColor = Color.ForestGreen;
                        Notification.Text = "Transferred";
                    }
                }
            }
        }

        private void ErrorDisplay()
        {
            Notification.ForeColor = Color.DarkRed;
            Notification.Visible = true;
            return;
        }
    }
}
