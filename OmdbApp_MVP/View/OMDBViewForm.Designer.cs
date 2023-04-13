namespace OmdbApp_MVP.View
{
    partial class OmdbViewForm
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
            Add = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(89, 122, 129);
            Add.Location = new Point(989, 84);
            Add.Name = "Add";
            Add.Size = new Size(185, 32);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(89, 122, 129);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(989, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(89, 122, 129);
            pictureBox1.Location = new Point(603, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(89, 122, 129);
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(12, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(585, 346);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(197, 202, 233);
            label1.Location = new Point(683, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 5;
            label1.Text = "Movie Poster";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(89, 122, 129);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(1003, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += TextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(197, 202, 233);
            label2.Location = new Point(1038, 135);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(93, 19);
            label2.TabIndex = 7;
            label2.Text = "Search Movie";
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(89, 122, 129);
            Delete.Location = new Point(1007, 220);
            Delete.Name = "Delete";
            Delete.Size = new Size(167, 34);
            Delete.TabIndex = 9;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ViewForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(7, 54, 66);
            ClientSize = new Size(1221, 472);
            Controls.Add(Delete);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(Add);
            Font = new Font("Fira Code Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "OMDB";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button Add;
        public TextBox textBox1;
        public PictureBox pictureBox1;
        public ListBox listBox1;
        public Label label1;
        public TextBox textBox2;
        public Label label2;
        public Button Delete;
    }
}