
namespace Otobüs_Bileti
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnBay = new System.Windows.Forms.RadioButton();
            this.rbtnBayan = new System.Windows.Forms.RadioButton();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // rbtnBay
            // 
            this.rbtnBay.AutoSize = true;
            this.rbtnBay.Checked = true;
            this.rbtnBay.Location = new System.Drawing.Point(112, 196);
            this.rbtnBay.Name = "rbtnBay";
            this.rbtnBay.Size = new System.Drawing.Size(43, 17);
            this.rbtnBay.TabIndex = 6;
            this.rbtnBay.TabStop = true;
            this.rbtnBay.Text = "Bay";
            this.rbtnBay.UseVisualStyleBackColor = true;
            // 
            // rbtnBayan
            // 
            this.rbtnBayan.AutoSize = true;
            this.rbtnBayan.Location = new System.Drawing.Point(227, 196);
            this.rbtnBayan.Name = "rbtnBayan";
            this.rbtnBayan.Size = new System.Drawing.Size(55, 17);
            this.rbtnBayan.TabIndex = 7;
            this.rbtnBayan.Text = "Bayan";
            this.rbtnBayan.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(112, 229);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(227, 228);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(112, 141);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(100, 20);
            this.mtxtPhone.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 308);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.rbtnBayan);
            this.Controls.Add(this.rbtnBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.MaskedTextBox mtxtPhone;
        public System.Windows.Forms.RadioButton rbtnBay;
        public System.Windows.Forms.RadioButton rbtnBayan;
    }
}