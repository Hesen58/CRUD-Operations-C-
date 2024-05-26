namespace CRUD
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            NameBox = new TextBox();
            PasswordBox = new TextBox();
            EmailBox = new TextBox();
            UsernameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button1.Location = new Point(134, 382);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button2.Location = new Point(270, 382);
            button2.Name = "button2";
            button2.Size = new Size(104, 41);
            button2.TabIndex = 1;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            button3.Location = new Point(404, 382);
            button3.Name = "button3";
            button3.Size = new Size(104, 41);
            button3.TabIndex = 2;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Salmon;
            button4.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            button4.Location = new Point(547, 382);
            button4.Name = "button4";
            button4.Size = new Size(104, 41);
            button4.TabIndex = 3;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            button5.Location = new Point(682, 382);
            button5.Name = "button5";
            button5.Size = new Size(104, 41);
            button5.TabIndex = 4;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            NameBox.Location = new Point(378, 182);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(202, 30);
            NameBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            PasswordBox.Location = new Point(378, 288);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(202, 30);
            PasswordBox.TabIndex = 6;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // EmailBox
            // 
            EmailBox.AccessibleName = "text";
            EmailBox.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            EmailBox.Location = new Point(378, 131);
            EmailBox.Name = "EmailBox";
            EmailBox.RightToLeft = RightToLeft.No;
            EmailBox.Size = new Size(202, 30);
            EmailBox.TabIndex = 7;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            UsernameBox.Location = new Point(378, 237);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(202, 30);
            UsernameBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.Location = new Point(311, 81);
            label1.Name = "label1";
            label1.Size = new Size(40, 22);
            label1.TabIndex = 10;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label2.Location = new Point(274, 134);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 11;
            label2.Text = "Email : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label3.Location = new Point(277, 190);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 12;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            label4.Location = new Point(233, 245);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 13;
            label4.Text = "Username : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold);
            label5.Location = new Point(235, 296);
            label5.Name = "label5";
            label5.Size = new Size(118, 22);
            label5.TabIndex = 14;
            label5.Text = "Password : ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            numericUpDown1.Location = new Point(379, 79);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 30);
            numericUpDown1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(204, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(551, 253);
            dataGridView1.TabIndex = 16;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(925, 477);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsernameBox);
            Controls.Add(EmailBox);
            Controls.Add(PasswordBox);
            Controls.Add(NameBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "CRUD APP";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox NameBox;
        private TextBox PasswordBox;
        private TextBox EmailBox;
        private TextBox UsernameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
    }
}
