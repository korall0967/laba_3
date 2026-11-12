namespace laba_3
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(12, 12);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(503, 426);
            formsPlot1.TabIndex = 0;
            formsPlot1.MouseMove += formsPlot1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 46);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(633, 12);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 2;
            label1.Text = "Параметры графика";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(633, 37);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "Толщина:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(746, 37);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(633, 63);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 5;
            label3.Text = "Область построения:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(633, 87);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(64, 23);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(724, 87);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(64, 23);
            numericUpDown3.TabIndex = 7;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(633, 113);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 8;
            label4.Text = "Детализация, точек:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(633, 146);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(154, 23);
            numericUpDown4.TabIndex = 9;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(633, 172);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 10;
            label5.Text = "Цвет:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(684, 172);
            button1.Name = "button1";
            button1.Size = new Size(103, 25);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(632, 204);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 94);
            listBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(632, 304);
            button2.Name = "button2";
            button2.Size = new Size(155, 30);
            button2.TabIndex = 13;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(numericUpDown4);
            Controls.Add(label4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "Вариант 10. Королев Б25-171-1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
    }
}
