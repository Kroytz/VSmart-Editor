using ImGuiNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSmart_Editor
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //ImGui.End();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Session.Instance.Load();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.New();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.Save(Session.Instance.CurrentProjectFile);
        }

        private void showDebugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportAsVsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
