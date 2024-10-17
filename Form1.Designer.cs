namespace _17thang10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            btnreg = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 124);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Gmail:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 175);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = " Mật khẩu:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(190, 124);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(290, 27);
            txtemail.TabIndex = 2;
            txtemail.TextChanged += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(190, 175);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(290, 27);
            txtpassword.TabIndex = 3;
            // 
            // btnreg
            // 
            btnreg.Location = new Point(190, 244);
            btnreg.Name = "btnreg";
            btnreg.Size = new Size(290, 29);
            btnreg.TabIndex = 4;
            btnreg.Text = " Đăng ký";
            btnreg.UseVisualStyleBackColor = true;
            btnreg.Click += btnreg_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(190, 378);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnreg);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Button btnreg;
        private Label lblMessage;
    }
}
