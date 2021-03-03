namespace Project_Hospital
{
    partial class PatientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MTBCN = new System.Windows.Forms.MaskedTextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LnKSıgnIn = new System.Windows.Forms.LinkLabel();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Citizen Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // MTBCN
            // 
            this.MTBCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTBCN.Location = new System.Drawing.Point(199, 111);
            this.MTBCN.Mask = "00000000000";
            this.MTBCN.Name = "MTBCN";
            this.MTBCN.Size = new System.Drawing.Size(143, 26);
            this.MTBCN.TabIndex = 3;
            this.MTBCN.ValidatingType = typeof(int);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTxt.Location = new System.Drawing.Point(199, 164);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(143, 26);
            this.PasswordTxt.TabIndex = 4;
            // 
            // LnKSıgnIn
            // 
            this.LnKSıgnIn.AutoSize = true;
            this.LnKSıgnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LnKSıgnIn.Location = new System.Drawing.Point(183, 225);
            this.LnKSıgnIn.Name = "LnKSıgnIn";
            this.LnKSıgnIn.Size = new System.Drawing.Size(63, 21);
            this.LnKSıgnIn.TabIndex = 5;
            this.LnKSıgnIn.TabStop = true;
            this.LnKSıgnIn.Text = "Sign In";
            this.LnKSıgnIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnKSıgnIn_LinkClicked);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogIn.Location = new System.Drawing.Point(252, 216);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(97, 30);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // PatientPage
            // 
            this.AcceptButton = this.buttonLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 265);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.LnKSıgnIn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.MTBCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "PatientPage";
            this.Text = "Patient Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTBCN;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.LinkLabel LnKSıgnIn;
        private System.Windows.Forms.Button buttonLogIn;
    }
}