namespace Calculator
{
    partial class Calculator
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
            panel1 = new Panel();
            Erase = new Button();
            Comma = new Button();
            NumOutput = new TextBox();
            Equal = new Button();
            OperatorOutput = new TextBox();
            sum = new Button();
            sub = new Button();
            mul = new Button();
            div = new Button();
            OperatorPanel = new Panel();
            panel1.SuspendLayout();
            OperatorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Erase);
            panel1.Controls.Add(Comma);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 225);
            panel1.TabIndex = 1;
            // 
            // Erase
            // 
            Erase.BackColor = Color.MistyRose;
            Erase.FlatAppearance.BorderColor = Color.Red;
            Erase.FlatStyle = FlatStyle.Popup;
            Erase.Font = new Font("Segoe UI", 18F);
            Erase.Location = new Point(112, 168);
            Erase.Name = "Erase";
            Erase.Size = new Size(52, 50);
            Erase.TabIndex = 13;
            Erase.Text = "C";
            Erase.UseVisualStyleBackColor = false;
            Erase.Click += Erase_Click;
            // 
            // Comma
            // 
            Comma.Font = new Font("Segoe UI", 18F);
            Comma.Location = new Point(56, 168);
            Comma.Name = "Comma";
            Comma.Size = new Size(52, 50);
            Comma.TabIndex = 12;
            Comma.Text = ",";
            Comma.UseVisualStyleBackColor = true;
            Comma.Click += Comma_Click;
            // 
            // NumOutput
            // 
            NumOutput.Cursor = Cursors.IBeam;
            NumOutput.Font = new Font("Segoe UI", 14F);
            NumOutput.Location = new Point(12, 12);
            NumOutput.Name = "NumOutput";
            NumOutput.ReadOnly = true;
            NumOutput.Size = new Size(171, 41);
            NumOutput.TabIndex = 2;
            NumOutput.Text = "0";
            // 
            // Equal
            // 
            Equal.Enabled = false;
            Equal.Font = new Font("Segoe UI", 20F);
            Equal.Location = new Point(6, 296);
            Equal.Name = "Equal";
            Equal.Size = new Size(264, 52);
            Equal.TabIndex = 3;
            Equal.Text = "═";
            Equal.TextAlign = ContentAlignment.TopCenter;
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // OperatorOutput
            // 
            OperatorOutput.Cursor = Cursors.IBeam;
            OperatorOutput.Font = new Font("Segoe UI", 14F);
            OperatorOutput.Location = new Point(225, 12);
            OperatorOutput.Name = "OperatorOutput";
            OperatorOutput.ReadOnly = true;
            OperatorOutput.Size = new Size(52, 41);
            OperatorOutput.TabIndex = 4;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(0, 3);
            sum.Name = "sum";
            sum.Size = new Size(52, 50);
            sum.TabIndex = 14;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            sub.Font = new Font("Segoe UI", 18F);
            sub.Location = new Point(0, 59);
            sub.Name = "sub";
            sub.Size = new Size(52, 50);
            sub.TabIndex = 15;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            // 
            // mul
            // 
            mul.Font = new Font("Segoe UI", 18F);
            mul.Location = new Point(0, 115);
            mul.Name = "mul";
            mul.Size = new Size(52, 50);
            mul.TabIndex = 16;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            div.Font = new Font("Segoe UI", 18F);
            div.Location = new Point(0, 171);
            div.Name = "div";
            div.Size = new Size(52, 50);
            div.TabIndex = 17;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            // 
            // OperatorPanel
            // 
            OperatorPanel.Controls.Add(sum);
            OperatorPanel.Controls.Add(div);
            OperatorPanel.Controls.Add(sub);
            OperatorPanel.Controls.Add(mul);
            OperatorPanel.Location = new Point(225, 63);
            OperatorPanel.Name = "OperatorPanel";
            OperatorPanel.Size = new Size(58, 220);
            OperatorPanel.TabIndex = 18;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 352);
            Controls.Add(OperatorPanel);
            Controls.Add(OperatorOutput);
            Controls.Add(Equal);
            Controls.Add(NumOutput);
            Controls.Add(panel1);
            Name = "Calculator";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            OperatorPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox NumOutput;
        private Button Erase;
        private Button Comma;
        private Button Equal;
        private TextBox OperatorOutput;
        private Button sum;
        private Button sub;
        private Button mul;
        private Button div;
        private Panel OperatorPanel;
    }
}
