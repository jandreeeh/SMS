using SMS.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App
{
    public partial class ProgramView : Form, IProgramView
    {
        public ProgramView()
        {
            InitializeComponent();
        }

        public int ProgramId { get => short.Parse(textBoxId.Text); set => textBoxId.Text = value.ToString(); }
        public string ProgramName { get => textBoxProgramName.Text.Trim(); set => textBoxProgramName.Text = value; }
        public string Description { get => textBoxDescription.Text.Trim(); set => textBoxDescription.Text = value; }

        public void GetProgramList(BindingSource bindingSource)
        {
            dataGridViewProgramList.DataSource = bindingSource;
        }
    }
}
