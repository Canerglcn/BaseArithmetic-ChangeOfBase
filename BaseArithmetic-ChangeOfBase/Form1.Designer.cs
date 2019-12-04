namespace BaseArithmetic_ChangeOfBase
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
            this.BtnChanceOfBase = new System.Windows.Forms.Button();
            this.txtCurrentNumber = new System.Windows.Forms.TextBox();
            this.txtCurrentBase = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTargetBase = new System.Windows.Forms.Label();
            this.txtTargetBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultNumber = new System.Windows.Forms.Label();
            this.txtFinalBase = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnChanceOfBase
            // 
            this.BtnChanceOfBase.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnChanceOfBase.Location = new System.Drawing.Point(116, 129);
            this.BtnChanceOfBase.Name = "BtnChanceOfBase";
            this.BtnChanceOfBase.Size = new System.Drawing.Size(131, 29);
            this.BtnChanceOfBase.TabIndex = 0;
            this.BtnChanceOfBase.Text = "Change Of Base";
            this.BtnChanceOfBase.UseVisualStyleBackColor = true;
            this.BtnChanceOfBase.Click += new System.EventHandler(this.BtnChanceOfBase_Click);
            // 
            // txtCurrentNumber
            // 
            this.txtCurrentNumber.Location = new System.Drawing.Point(116, 48);
            this.txtCurrentNumber.Name = "txtCurrentNumber";
            this.txtCurrentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentNumber.TabIndex = 1;
            // 
            // txtCurrentBase
            // 
            this.txtCurrentBase.Location = new System.Drawing.Point(279, 50);
            this.txtCurrentBase.Name = "txtCurrentBase";
            this.txtCurrentBase.Size = new System.Drawing.Size(23, 20);
            this.txtCurrentBase.TabIndex = 2;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(47, 48);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 16);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBase.Location = new System.Drawing.Point(236, 51);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 16);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base:";
            // 
            // lblTargetBase
            // 
            this.lblTargetBase.AutoSize = true;
            this.lblTargetBase.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTargetBase.Location = new System.Drawing.Point(27, 90);
            this.lblTargetBase.Name = "lblTargetBase";
            this.lblTargetBase.Size = new System.Drawing.Size(83, 16);
            this.lblTargetBase.TabIndex = 6;
            this.lblTargetBase.Text = "Target Base:";
            // 
            // txtTargetBase
            // 
            this.txtTargetBase.Location = new System.Drawing.Point(116, 89);
            this.txtTargetBase.Name = "txtTargetBase";
            this.txtTargetBase.Size = new System.Drawing.Size(35, 20);
            this.txtTargetBase.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Base:";
            // 
            // lblResultNumber
            // 
            this.lblResultNumber.AutoSize = true;
            this.lblResultNumber.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResultNumber.Location = new System.Drawing.Point(27, 195);
            this.lblResultNumber.Name = "lblResultNumber";
            this.lblResultNumber.Size = new System.Drawing.Size(121, 16);
            this.lblResultNumber.TabIndex = 9;
            this.lblResultNumber.Text = "Result Of Number:";
            // 
            // txtFinalBase
            // 
            this.txtFinalBase.Location = new System.Drawing.Point(279, 195);
            this.txtFinalBase.Name = "txtFinalBase";
            this.txtFinalBase.Size = new System.Drawing.Size(23, 20);
            this.txtFinalBase.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(171, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(26, 16);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "00";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.Location = new System.Drawing.Point(171, 94);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(217, 15);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "( Target base must be  2<= x <=10 )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultNumber);
            this.Controls.Add(this.txtFinalBase);
            this.Controls.Add(this.lblTargetBase);
            this.Controls.Add(this.txtTargetBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtCurrentBase);
            this.Controls.Add(this.txtCurrentNumber);
            this.Controls.Add(this.BtnChanceOfBase);
            this.Name = "Form1";
            this.Text = "BaseArithmetic-Change Of Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChanceOfBase;
        private System.Windows.Forms.TextBox txtCurrentNumber;
        private System.Windows.Forms.TextBox txtCurrentBase;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTargetBase;
        private System.Windows.Forms.TextBox txtTargetBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultNumber;
        private System.Windows.Forms.TextBox txtFinalBase;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWarning;
    }
}

