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
        string name = "";
        string summary = "";
        string actor = "";
        string assumption = "";
        string description = "";
        string exception = "";
        string result = "";
        public string UseCaseName
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Summary
        {
            get { return summary; }
            set { this.summary = value; }
        }
        public string Actor
        {
            get { return actor; }
            set { this.actor = value; }
        }
        public string Assumption
        {
            get { return assumption; }
            set { this.assumption = value; }
        }
        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }
        public string Exception
        {
            get { return exception; }
            set { this.exception = value; }
        }
        public string Result
        {
            get { return result; }
            set { this.result = value; }
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

        private void updateTextbox()
        {
            tbName.Text = name;
            tbSummary.Text = summary;
            tbActors.Text = actor;
            tbDescription.Text = description;
            tbExecptions.Text = exception;
            tbResult.Text = result;
            tbAssumptions.Text = assumption;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (name == null || summary == null || actor == null || assumption == null || description == null || exception == null || result == null)
            {
                MessageBox.Show("Some field are blank!");
                return; 
            }
            this.DialogResult = DialogResult.OK;
        }

        private void formProperties_Load(object sender, EventArgs e)
        {
            updateTextbox();
        }
    }
}
