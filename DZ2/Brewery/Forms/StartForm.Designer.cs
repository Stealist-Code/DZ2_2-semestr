namespace Brewery
{
    partial class StartForm
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
            startButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(352, 93);
            label1.Name = "label1";
            label1.Size = new Size(376, 46);
            label1.TabIndex = 0;
            label1.Text = "Симулятор Пивоварни";
            // 
            // startButton
            // 
            startButton.Location = new Point(468, 223);
            startButton.Name = "startButton";
            startButton.Size = new Size(142, 55);
            startButton.TabIndex = 1;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(468, 321);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(142, 55);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 632);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startButton;
        private Button exitButton;
    }
}
