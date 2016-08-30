namespace UseCaseHelper
{
    partial class Form1
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
            this.gmElements = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbUseCase = new System.Windows.Forms.RadioButton();
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.gbModus = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.btClear = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gmElements.SuspendLayout();
            this.gbModus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmElements
            // 
            this.gmElements.Controls.Add(this.rbLine);
            this.gmElements.Controls.Add(this.rbUseCase);
            this.gmElements.Controls.Add(this.rbActor);
            this.gmElements.Location = new System.Drawing.Point(12, 12);
            this.gmElements.Name = "gmElements";
            this.gmElements.Size = new System.Drawing.Size(153, 142);
            this.gmElements.TabIndex = 1;
            this.gmElements.TabStop = false;
            this.gmElements.Text = "Elementen";
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(6, 106);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(56, 21);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbUseCase
            // 
            this.rbUseCase.AutoSize = true;
            this.rbUseCase.Location = new System.Drawing.Point(6, 70);
            this.rbUseCase.Name = "rbUseCase";
            this.rbUseCase.Size = new System.Drawing.Size(88, 21);
            this.rbUseCase.TabIndex = 1;
            this.rbUseCase.TabStop = true;
            this.rbUseCase.Text = "Use case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(6, 32);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(62, 21);
            this.rbActor.TabIndex = 0;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // gbModus
            // 
            this.gbModus.Controls.Add(this.rbSelect);
            this.gbModus.Controls.Add(this.rbCreate);
            this.gbModus.Location = new System.Drawing.Point(191, 12);
            this.gbModus.Name = "gbModus";
            this.gbModus.Size = new System.Drawing.Size(153, 142);
            this.gbModus.TabIndex = 2;
            this.gbModus.TabStop = false;
            this.gbModus.Text = "Modus";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(6, 70);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(68, 21);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(6, 32);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(71, 21);
            this.rbCreate.TabIndex = 0;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(985, 30);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(125, 35);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear all";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(985, 75);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(125, 35);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 619);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.gbModus);
            this.Controls.Add(this.gmElements);
            this.Name = "Form1";
            this.Text = "Use case helper";
            this.gmElements.ResumeLayout(false);
            this.gmElements.PerformLayout();
            this.gbModus.ResumeLayout(false);
            this.gbModus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gmElements;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbUseCase;
        private System.Windows.Forms.RadioButton rbActor;
        private System.Windows.Forms.GroupBox gbModus;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Panel panel1;
    }
}

