using ImGuiNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SharpDX.D3DCompiler;

namespace VSmart_Editor
{
    public partial class FormMenu : Form
    {


        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Session.Instance.Load();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.New();
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.Save(Session.Instance.CurrentProjectFile);
        }

        private void showDebugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.ShowDebugInfo = !Session.Instance.ShowDebugInfo;
        }

        private void exportAsVsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() =>
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "valve smart prop (*.vsmart)|*.vsmart";
                //saveFileDialog.ShowDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Program.ExportToVsmart(saveFileDialog.FileName);
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.SaveAs();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo()
            {
                FileName = "https://developer.valvesoftware.com/wiki/Counter-Strike_2_Workshop_Tools/Level_Design/Smartprops",
                UseShellExecute = true,
            };
            Process.Start(psi);
        }
    }
}
