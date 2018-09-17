namespace ThreeT
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
            this.btn_Insert = new System.Windows.Forms.Button();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.textBox3_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(255, 205);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(242, 53);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(100, 22);
            this.textBox1_id.TabIndex = 1;
            // 
            // textBox2_name
            // 
            this.textBox2_name.Location = new System.Drawing.Point(242, 96);
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(100, 22);
            this.textBox2_name.TabIndex = 2;
            // 
            // textBox3_email
            // 
            this.textBox3_email.Location = new System.Drawing.Point(242, 142);
            this.textBox3_email.Name = "textBox3_email";
            this.textBox3_email.Size = new System.Drawing.Size(100, 22);
            this.textBox3_email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(518, 58);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Create Table";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3_email);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.btn_Insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox2_name;
        private System.Windows.Forms.TextBox textBox3_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create;
    }
}

