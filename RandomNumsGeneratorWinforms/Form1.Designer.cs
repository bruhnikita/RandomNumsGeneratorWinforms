namespace RandomNumsGeneratorWinforms
{
    partial class MainForm
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
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            countTextBox = new TextBox();
            resultListBox = new ListBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // minTextBox
            // 
            minTextBox.Dock = DockStyle.Top;
            minTextBox.Location = new Point(0, 0);
            minTextBox.Name = "minTextBox";
            minTextBox.PlaceholderText = "Введите минимум:";
            minTextBox.Size = new Size(800, 23);
            minTextBox.TabIndex = 0;
            // 
            // maxTextBox
            // 
            maxTextBox.Dock = DockStyle.Top;
            maxTextBox.Location = new Point(0, 23);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.PlaceholderText = "Введите максимум";
            maxTextBox.Size = new Size(800, 23);
            maxTextBox.TabIndex = 1;
            // 
            // countTextBox
            // 
            countTextBox.Dock = DockStyle.Top;
            countTextBox.Location = new Point(0, 46);
            countTextBox.Name = "countTextBox";
            countTextBox.PlaceholderText = "Введите количество чисел для генерации:";
            countTextBox.Size = new Size(800, 23);
            countTextBox.TabIndex = 2;
            // 
            // resultListBox
            // 
            resultListBox.Dock = DockStyle.Fill;
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 15;
            resultListBox.Location = new Point(0, 69);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(800, 381);
            resultListBox.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Dock = DockStyle.Bottom;
            btnGenerate.Location = new Point(0, 378);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(800, 72);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(resultListBox);
            Controls.Add(countTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(minTextBox);
            Name = "MainForm";
            Text = "Генератор чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox minTextBox;
        private TextBox maxTextBox;
        private TextBox countTextBox;
        private ListBox resultListBox;
        private Button btnGenerate;
    }
}
