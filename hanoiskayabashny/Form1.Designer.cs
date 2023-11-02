namespace hanoiskayabashny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(38, 68);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Взять";
            button1.UseVisualStyleBackColor = false;
            button1.Click += takeButtons_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(206, 68);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Взять";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += takeButtons_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(376, 68);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Взять";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += takeButtons_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(38, 407);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Положить";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += putButtons_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(206, 407);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "Положить";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += putButtons_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(376, 407);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "Положить";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += putButtons_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(533, 485);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            Text = "Ханойская башня";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}