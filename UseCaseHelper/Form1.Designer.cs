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
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.btClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExport = new System.Windows.Forms.Button();
            this.rbMove = new System.Windows.Forms.RadioButton();
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
            this.rbUseCase.Text = "Use case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Checked = true;
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
            this.gbModus.Controls.Add(this.rbMove);
            this.gbModus.Controls.Add(this.rbRemove);
            this.gbModus.Controls.Add(this.rbSelect);
            this.gbModus.Controls.Add(this.rbCreate);
            this.gbModus.Location = new System.Drawing.Point(191, 12);
            this.gbModus.Name = "gbModus";
            this.gbModus.Size = new System.Drawing.Size(237, 142);
            this.gbModus.TabIndex = 2;
            this.gbModus.TabStop = false;
            this.gbModus.Text = "Modus";
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.Location = new System.Drawing.Point(6, 106);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(81, 21);
            this.rbRemove.TabIndex = 2;
            this.rbRemove.Text = "Remove";
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(6, 70);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(68, 21);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Checked = true;
            this.rbCreate.Location = new System.Drawing.Point(6, 32);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(71, 21);
            this.rbCreate.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 619);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(985, 82);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(125, 35);
            this.btExport.TabIndex = 6;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(118, 32);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(63, 21);
            this.rbMove.TabIndex = 3;
            this.rbMove.Text = "Move";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 805);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.RadioButton rbMove;
    }
}

