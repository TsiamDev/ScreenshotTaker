using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotTaker
{
    public partial class Form1 : Form
    {
        #region Declarations
        private IKeyboardMouseEvents m_GlobalHook;
        private FolderBrowserDialog fbd;

        public string ssDirPath;

        #endregion

        #region Initialization
        public Form1()
        {
            InitializeComponent();
            Subscribe();

            fbd = new FolderBrowserDialog();

            ssDirPath = null;
        }
        #endregion

        #region Sample Code for key presses Modified from: https://github.com/gmamaladze/globalmousekeyhook/blob/vNext/examples/FormsExample/Sample.cs
        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KeyPress: \t{0}", e.KeyChar);
            HandleKeyPressed(e.KeyChar);
        }
        #endregion

        #region keyPressed Handler
        public void HandleKeyPressed(char keyCode)
        {
            if (keyCode == '1')
            {
                if (ssDirPath == null)
                {
                    SelectDir(ref ssLabel, "Hit '1' to save screenshot to the specified folder.", ref ssDirPath);
                }
                string path = SaveScreenshot();
                lastSSLabel.Text = "Last File Created: " + path;
            }
        }
        #endregion

        #region Screenshot
        private void pickDirButton_Click(object sender, EventArgs e)
        {
            SelectDir(ref ssLabel, "Hit '1' to save screenshot to the specified folder.", ref ssDirPath);
        }

        private void SelectDir(ref Label label, string str, ref string reference)
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string path = fbd.SelectedPath;
                path = path.Replace("\\", "/");
                path += "/";
                reference = path;

                label.Text = str;
            }
        }

        public string SaveScreenshot()
        {
            string name = null;
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

                name = DateTime.Now.ToString();
                name = name.Replace("/", "-");
                name = name.Replace(":", "-");
                name = ssDirPath + name + ".png";

                bmp.Save(name);  // saves the image
            }
            
            return name;
        }
        #endregion
    }
}
