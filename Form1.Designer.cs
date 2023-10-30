namespace WinFormdop
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
            txtBirthday = new TextBox();
            monthCalendar1 = new MonthCalendar();
            btnHighlightBirthday = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBirthday.Location = new Point(344, 93);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(125, 34);
            txtBirthday.TabIndex = 0;
            txtBirthday.TextChanged += textBox1_TextChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(323, 196);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // btnHighlightBirthday
            // 
            btnHighlightBirthday.Font = new Font("SFNS Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHighlightBirthday.ForeColor = Color.Red;
            btnHighlightBirthday.Location = new Point(291, 155);
            btnHighlightBirthday.Name = "btnHighlightBirthday";
            btnHighlightBirthday.Size = new Size(252, 29);
            btnHighlightBirthday.TabIndex = 2;
            btnHighlightBirthday.Text = "найти указанный день";
            btnHighlightBirthday.UseVisualStyleBackColor = true;
            btnHighlightBirthday.Click += btnHighlightBirthday_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SFNS Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(15, 93);
            label1.Name = "label1";
            label1.Size = new Size(323, 24);
            label1.TabIndex = 3;
            label1.Text = "Введие дату своего рождения";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHighlightBirthday);
            Controls.Add(monthCalendar1);
            Controls.Add(txtBirthday);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBirthday;
        private MonthCalendar monthCalendar1;
        private Button btnHighlightBirthday;
        private Label label1;
    }
}