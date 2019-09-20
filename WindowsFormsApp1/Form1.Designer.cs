namespace WindowsFormsApp1
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
            this.btn_gas = new System.Windows.Forms.Button();
            this.btn_rem = new System.Windows.Forms.Button();
            this.btn_indicator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gas
            // 
            this.btn_gas.Location = new System.Drawing.Point(98, 12);
            this.btn_gas.Name = "btn_gas";
            this.btn_gas.Size = new System.Drawing.Size(75, 23);
            this.btn_gas.TabIndex = 0;
            this.btn_gas.Text = "Gas!";
            this.btn_gas.UseVisualStyleBackColor = true;
            this.btn_gas.Click += new System.EventHandler(this.btn_gas_Click);
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(98, 41);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(75, 23);
            this.btn_rem.TabIndex = 1;
            this.btn_rem.Text = "Rem!";
            this.btn_rem.UseVisualStyleBackColor = true;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // btn_indicator
            // 
            this.btn_indicator.BackColor = System.Drawing.SystemColors.Control;
            this.btn_indicator.Location = new System.Drawing.Point(98, 70);
            this.btn_indicator.Name = "btn_indicator";
            this.btn_indicator.Size = new System.Drawing.Size(75, 23);
            this.btn_indicator.TabIndex = 2;
            this.btn_indicator.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 109);
            this.Controls.Add(this.btn_indicator);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.btn_gas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gas;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.Button btn_indicator;
    }
}

