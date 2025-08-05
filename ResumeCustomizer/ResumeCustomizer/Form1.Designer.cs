namespace ResumeCustomizer
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
            this.BtnLoadResume = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadJobDesc = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.txtResume = new System.Windows.Forms.RichTextBox();
            this.txtJobDesc = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoadResume
            // 
            this.BtnLoadResume.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnLoadResume.Location = new System.Drawing.Point(89, 76);
            this.BtnLoadResume.Name = "BtnLoadResume";
            this.BtnLoadResume.Size = new System.Drawing.Size(237, 56);
            this.BtnLoadResume.TabIndex = 0;
            this.BtnLoadResume.Text = "Load Resume";
            this.BtnLoadResume.UseVisualStyleBackColor = false;
            this.BtnLoadResume.Click += new System.EventHandler(this.BtnLoadResume_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 775);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 9);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLoadJobDesc
            // 
            this.btnLoadJobDesc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoadJobDesc.Location = new System.Drawing.Point(700, 76);
            this.btnLoadJobDesc.Name = "btnLoadJobDesc";
            this.btnLoadJobDesc.Size = new System.Drawing.Size(237, 56);
            this.btnLoadJobDesc.TabIndex = 2;
            this.btnLoadJobDesc.Text = "Load job Description";
            this.btnLoadJobDesc.UseVisualStyleBackColor = false;
            this.btnLoadJobDesc.Click += new System.EventHandler(this.btnLoadJobDesc_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGenerate.Location = new System.Drawing.Point(401, 405);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(237, 56);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSaveOutput.Location = new System.Drawing.Point(401, 795);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(237, 56);
            this.btnSaveOutput.TabIndex = 4;
            this.btnSaveOutput.Text = "Save Output";
            this.btnSaveOutput.UseVisualStyleBackColor = false;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click_1);
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(26, 138);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(478, 261);
            this.txtResume.TabIndex = 5;
            this.txtResume.Text = "";
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Location = new System.Drawing.Point(528, 138);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(488, 261);
            this.txtJobDesc.TabIndex = 6;
            this.txtJobDesc.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(26, 467);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(990, 322);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(224, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "AI-Powered Resume and Cover Letter Customizer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 863);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtJobDesc);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLoadJobDesc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnLoadResume);
            this.Name = "Form1";
            this.Text = "ResumeCustomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadResume;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoadJobDesc;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.RichTextBox txtResume;
        private System.Windows.Forms.RichTextBox txtJobDesc;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label1;
    }
}

