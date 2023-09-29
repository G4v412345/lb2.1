namespace WinFormsApp1
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
            appname = new Label();
            appversion = new Label();
            appnametextbox = new TextBox();
            appversiontextbox = new TextBox();
            updatebtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // appname
            // 
            appname.AutoSize = true;
            appname.Location = new Point(99, 86);
            appname.Name = "appname";
            appname.Size = new Size(67, 15);
            appname.TabIndex = 0;
            appname.Text = "App Name:";
            // 
            // appversion
            // 
            appversion.AutoSize = true;
            appversion.Location = new Point(231, 86);
            appversion.Name = "appversion";
            appversion.Size = new Size(73, 15);
            appversion.TabIndex = 1;
            appversion.Text = "App Version:";
            // 
            // appnametextbox
            // 
            appnametextbox.Location = new Point(99, 104);
            appnametextbox.Name = "appnametextbox";
            appnametextbox.Size = new Size(100, 23);
            appnametextbox.TabIndex = 2;
            // 
            // appversiontextbox
            // 
            appversiontextbox.Location = new Point(231, 104);
            appversiontextbox.Name = "appversiontextbox";
            appversiontextbox.Size = new Size(100, 23);
            appversiontextbox.TabIndex = 3;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(99, 162);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(232, 23);
            updatebtn.TabIndex = 4;
            updatebtn.Text = "Оновити перший екземпляр";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 86);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 6;
            label1.Text = "ексземляр класу_1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(480, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(274, 81);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 214);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 8;
            label2.Text = "екземпляр класу_2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(480, 232);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(274, 81);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(updatebtn);
            Controls.Add(appversiontextbox);
            Controls.Add(appnametextbox);
            Controls.Add(appversion);
            Controls.Add(appname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appname;
        private Label appversion;
        private TextBox appnametextbox;
        private TextBox appversiontextbox;
        private Button updatebtn;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}