using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorMemento
{
    public partial class MainForm : Form
    {
        private Memento memento;
        public MainForm()
        {
            InitializeComponent();
            memento = new Memento(rtb.Text);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            memento.Undo(ref rtb);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            memento.Remember(rtb.Text);
        }
    }
}
