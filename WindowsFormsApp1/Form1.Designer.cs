namespace WindowsFormsApp1
{
    partial class frmAutomobileCost
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
            this.Ca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inTxtCarOil = new System.Windows.Forms.TextBox();
            this.inTxtCarNote = new System.Windows.Forms.TextBox();
            this.inTxtCarRegistration = new System.Windows.Forms.TextBox();
            this.inTxtCarInsurance = new System.Windows.Forms.TextBox();
            this.inTxtCarGas = new System.Windows.Forms.TextBox();
            this.inTxtCarRepairs = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.outTxtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ca
            // 
            this.Ca.AutoSize = true;
            this.Ca.Location = new System.Drawing.Point(118, 57);
            this.Ca.Name = "Ca";
            this.Ca.Size = new System.Drawing.Size(103, 25);
            this.Ca.TabIndex = 0;
            this.Ca.Text = "Car Note:";
            this.Ca.Click += new System.EventHandler(this.Ca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Insurence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oil Change:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basic Repairs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registration Fees:";
            // 
            // inTxtCarOil
            // 
            this.inTxtCarOil.Location = new System.Drawing.Point(232, 232);
            this.inTxtCarOil.Name = "inTxtCarOil";
            this.inTxtCarOil.Size = new System.Drawing.Size(213, 31);
            this.inTxtCarOil.TabIndex = 6;
            // 
            // inTxtCarNote
            // 
            this.inTxtCarNote.Location = new System.Drawing.Point(223, 51);
            this.inTxtCarNote.Name = "inTxtCarNote";
            this.inTxtCarNote.Size = new System.Drawing.Size(221, 31);
            this.inTxtCarNote.TabIndex = 7;
            // 
            // inTxtCarRegistration
            // 
            this.inTxtCarRegistration.Location = new System.Drawing.Point(223, 362);
            this.inTxtCarRegistration.Name = "inTxtCarRegistration";
            this.inTxtCarRegistration.Size = new System.Drawing.Size(221, 31);
            this.inTxtCarRegistration.TabIndex = 8;
            // 
            // inTxtCarInsurance
            // 
            this.inTxtCarInsurance.Location = new System.Drawing.Point(223, 111);
            this.inTxtCarInsurance.Name = "inTxtCarInsurance";
            this.inTxtCarInsurance.Size = new System.Drawing.Size(221, 31);
            this.inTxtCarInsurance.TabIndex = 9;
            // 
            // inTxtCarGas
            // 
            this.inTxtCarGas.Location = new System.Drawing.Point(223, 171);
            this.inTxtCarGas.Name = "inTxtCarGas";
            this.inTxtCarGas.Size = new System.Drawing.Size(221, 31);
            this.inTxtCarGas.TabIndex = 10;
            // 
            // inTxtCarRepairs
            // 
            this.inTxtCarRepairs.Location = new System.Drawing.Point(223, 291);
            this.inTxtCarRepairs.Name = "inTxtCarRepairs";
            this.inTxtCarRepairs.Size = new System.Drawing.Size(221, 31);
            this.inTxtCarRepairs.TabIndex = 11;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(150, 437);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(173, 28);
            this.BtnCalculate.TabIndex = 12;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.submitExpenses);
            // 
            // outTxtResults
            // 
            this.outTxtResults.Location = new System.Drawing.Point(12, 495);
            this.outTxtResults.Multiline = true;
            this.outTxtResults.Name = "outTxtResults";
            this.outTxtResults.Size = new System.Drawing.Size(416, 106);
            this.outTxtResults.TabIndex = 13;
            this.outTxtResults.Text = "***Final Results*** \r\nTotal Monthly Cost $ \r\nTotal Annual Cost $";
            // 
            // frmAutomobileCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 763);
            this.Controls.Add(this.outTxtResults);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.inTxtCarRepairs);
            this.Controls.Add(this.inTxtCarGas);
            this.Controls.Add(this.inTxtCarInsurance);
            this.Controls.Add(this.inTxtCarRegistration);
            this.Controls.Add(this.inTxtCarNote);
            this.Controls.Add(this.inTxtCarOil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ca);
            this.Name = "frmAutomobileCost";
            this.Text = "Automobile Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inTxtCarOil;
        private System.Windows.Forms.TextBox inTxtCarNote;
        private System.Windows.Forms.TextBox inTxtCarRegistration;
        private System.Windows.Forms.TextBox inTxtCarInsurance;
        private System.Windows.Forms.TextBox inTxtCarGas;
        private System.Windows.Forms.TextBox inTxtCarRepairs;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox outTxtResults;
    }
}

