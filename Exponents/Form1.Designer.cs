namespace Exponents
{
    partial class Form1
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
            this.xInputTextBox = new System.Windows.Forms.TextBox();
            this.xPromptLabel = new System.Windows.Forms.Label();
            this.xOutputLabel = new System.Windows.Forms.Label();
            this.xGoButton = new System.Windows.Forms.Button();
            this.xResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xInputTextBox
            // 
            this.xInputTextBox.Location = new System.Drawing.Point(138, 69);
            this.xInputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xInputTextBox.Name = "xInputTextBox";
            this.xInputTextBox.Size = new System.Drawing.Size(148, 26);
            this.xInputTextBox.TabIndex = 0;
            this.xInputTextBox.TextChanged += new System.EventHandler(this.xInputTextBox_TextChanged);
            // 
            // xPromptLabel
            // 
            this.xPromptLabel.AutoSize = true;
            this.xPromptLabel.Location = new System.Drawing.Point(138, 42);
            this.xPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xPromptLabel.Name = "xPromptLabel";
            this.xPromptLabel.Size = new System.Drawing.Size(127, 20);
            this.xPromptLabel.TabIndex = 3;
            this.xPromptLabel.Text = "Enter an integer:";
            this.xPromptLabel.Click += new System.EventHandler(this.xInputLabel_Click);
            // 
            // xOutputLabel
            // 
            this.xOutputLabel.AutoSize = true;
            this.xOutputLabel.Location = new System.Drawing.Point(153, 278);
            this.xOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xOutputLabel.Name = "xOutputLabel";
            this.xOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.xOutputLabel.TabIndex = 4;
            this.xOutputLabel.Visible = false;
            // 
            // xGoButton
            // 
            this.xGoButton.Location = new System.Drawing.Point(158, 148);
            this.xGoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xGoButton.Name = "xGoButton";
            this.xGoButton.Size = new System.Drawing.Size(112, 103);
            this.xGoButton.TabIndex = 6;
            this.xGoButton.Text = "Go!";
            this.xGoButton.UseVisualStyleBackColor = true;
            this.xGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // xResetButton
            // 
            this.xResetButton.Location = new System.Drawing.Point(158, 326);
            this.xResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xResetButton.Name = "xResetButton";
            this.xResetButton.Size = new System.Drawing.Size(112, 35);
            this.xResetButton.TabIndex = 7;
            this.xResetButton.Text = "Reset";
            this.xResetButton.UseVisualStyleBackColor = true;
            this.xResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.xResetButton);
            this.Controls.Add(this.xGoButton);
            this.Controls.Add(this.xOutputLabel);
            this.Controls.Add(this.xPromptLabel);
            this.Controls.Add(this.xInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xInputTextBox;
        private System.Windows.Forms.Label xPromptLabel;
        private System.Windows.Forms.Label xOutputLabel;
        private System.Windows.Forms.Button xGoButton;
        private System.Windows.Forms.Button xResetButton;
    }
}

