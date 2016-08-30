namespace UseCaseHelper
{
    partial class formProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.tbAssumptions = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbExecptions = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Summary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assumptions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Exceptions:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Result:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(376, 22);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(116, 63);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(376, 22);
            this.tbSummary.TabIndex = 8;
            this.tbSummary.TextChanged += new System.EventHandler(this.tbSummary_TextChanged);
            // 
            // tbActors
            // 
            this.tbActors.Location = new System.Drawing.Point(116, 96);
            this.tbActors.Name = "tbActors";
            this.tbActors.Size = new System.Drawing.Size(376, 22);
            this.tbActors.TabIndex = 9;
            this.tbActors.TextChanged += new System.EventHandler(this.tbActors_TextChanged);
            // 
            // tbAssumptions
            // 
            this.tbAssumptions.Location = new System.Drawing.Point(116, 124);
            this.tbAssumptions.Name = "tbAssumptions";
            this.tbAssumptions.Size = new System.Drawing.Size(376, 22);
            this.tbAssumptions.TabIndex = 10;
            this.tbAssumptions.TextChanged += new System.EventHandler(this.tbAssumptions_TextChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(116, 154);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(376, 111);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // tbExecptions
            // 
            this.tbExecptions.Location = new System.Drawing.Point(116, 280);
            this.tbExecptions.Multiline = true;
            this.tbExecptions.Name = "tbExecptions";
            this.tbExecptions.Size = new System.Drawing.Size(376, 167);
            this.tbExecptions.TabIndex = 12;
            this.tbExecptions.TextChanged += new System.EventHandler(this.tbExecptions_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(116, 462);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(376, 22);
            this.tbResult.TabIndex = 13;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(372, 518);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 28);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // formProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 622);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbExecptions);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbAssumptions);
            this.Controls.Add(this.tbActors);
            this.Controls.Add(this.tbSummary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formProperties";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.formProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.TextBox tbAssumptions;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbExecptions;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btSave;
    }
}