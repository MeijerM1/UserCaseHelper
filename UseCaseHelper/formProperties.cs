using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class formProperties : Form
    {
        public formProperties()
        {
            InitializeComponent();
        }
        string name;
        string summary;
        string actor;
        string assumption;
        string description;
        string exception;
        string result;
        public string UseCaseName
        {
            get { return name; }
        }
        public string Summary
        {
            get { return summary; }
        }
        public string Actor
        {
            get { return actor; }
        }
        public string Assumption
        {
            get { return assumption; }
        }
        public string Description
        {
            get { return description; }
        }
        public string Exception
        {
            get { return exception; }
        }
        public string Result
        {
            get { return result; }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
        }

        private void tbSummary_TextChanged(object sender, EventArgs e)
        {
            summary = tbSummary.Text;
        }

        private void tbActors_TextChanged(object sender, EventArgs e)
        {
            actor = tbActors.Text;
        }

        private void tbAssumptions_TextChanged(object sender, EventArgs e)
        {
            assumption = tbAssumptions.Text;
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            description = tbDescription.Text;
        }

        private void tbExecptions_TextChanged(object sender, EventArgs e)
        {
            exception = tbExecptions.Text;
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {
            result = tbResult.Text;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
