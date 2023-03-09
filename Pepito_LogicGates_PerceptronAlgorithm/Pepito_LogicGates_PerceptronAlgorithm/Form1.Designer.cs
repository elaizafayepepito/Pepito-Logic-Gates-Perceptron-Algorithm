namespace Pepito_LogicGates_PerceptronAlgorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonNand = new System.Windows.Forms.Button();
            this.buttonNor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logic Gates Perceptron Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input first number:";
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num1.Location = new System.Drawing.Point(281, 133);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(302, 34);
            this.num1.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Window;
            this.num2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num2.Location = new System.Drawing.Point(281, 189);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(302, 34);
            this.num2.TabIndex = 5;
            // 
            // buttonOr
            // 
            this.buttonOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOr.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOr.Location = new System.Drawing.Point(67, 258);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(89, 53);
            this.buttonOr.TabIndex = 6;
            this.buttonOr.Text = "OR";
            this.buttonOr.UseVisualStyleBackColor = false;
            this.buttonOr.Click += new System.EventHandler(this.buttonOr_Click);
            // 
            // buttonAnd
            // 
            this.buttonAnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAnd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAnd.Location = new System.Drawing.Point(172, 258);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(89, 53);
            this.buttonAnd.TabIndex = 7;
            this.buttonAnd.Text = "AND";
            this.buttonAnd.UseVisualStyleBackColor = false;
            this.buttonAnd.Click += new System.EventHandler(this.buttonAnd_Click);
            // 
            // buttonXor
            // 
            this.buttonXor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonXor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonXor.Location = new System.Drawing.Point(281, 258);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(89, 53);
            this.buttonXor.TabIndex = 8;
            this.buttonXor.Text = "XOR";
            this.buttonXor.UseVisualStyleBackColor = false;
            this.buttonXor.Click += new System.EventHandler(this.buttonXor_Click);
            // 
            // buttonNand
            // 
            this.buttonNand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNand.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNand.Location = new System.Drawing.Point(394, 258);
            this.buttonNand.Name = "buttonNand";
            this.buttonNand.Size = new System.Drawing.Size(89, 53);
            this.buttonNand.TabIndex = 9;
            this.buttonNand.Text = "NAND";
            this.buttonNand.UseVisualStyleBackColor = false;
            // 
            // buttonNor
            // 
            this.buttonNor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNor.Location = new System.Drawing.Point(507, 258);
            this.buttonNor.Name = "buttonNor";
            this.buttonNor.Size = new System.Drawing.Size(89, 53);
            this.buttonNor.TabIndex = 10;
            this.buttonNor.Text = "NOR";
            this.buttonNor.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(293, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Input second number:";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Menu;
            this.output.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(78, 398);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(505, 34);
            this.output.TabIndex = 11;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(685, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.buttonNor);
            this.Controls.Add(this.buttonNand);
            this.Controls.Add(this.buttonXor);
            this.Controls.Add(this.buttonAnd);
            this.Controls.Add(this.buttonOr);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Logic Gates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num1;
        private TextBox num2;
        private Button buttonOr;
        private Button buttonAnd;
        private Button buttonXor;
        private Button buttonNand;
        private Button buttonNor;
        private Label label4;
        private Label label3;
        private TextBox output;
    }
}