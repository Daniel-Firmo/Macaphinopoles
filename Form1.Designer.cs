namespace Jogo
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
            jogo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(846, 301);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(227, 83);
            button1.TabIndex = 0;
            button1.Text = "Jogar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // jogo
            // 
            jogo.Font = new Font("Snap ITC", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jogo.ForeColor = Color.Pink;
            jogo.Location = new Point(746, 197);
            jogo.Name = "jogo";
            jogo.Size = new Size(424, 57);
            jogo.TabIndex = 1;
            jogo.Text = "Macaphinopoles";
            jogo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1898, 1024);
            Controls.Add(jogo);
            Controls.Add(button1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Jogo incrivelmente incrivel";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label jogo;
    }
}
