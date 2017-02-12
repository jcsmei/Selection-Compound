namespace SelectionCompound
{
    partial class frmSelectionConjunction
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
            this.btnConjunction = new System.Windows.Forms.Button();
            this.btnNegation = new System.Windows.Forms.Button();
            this.btnDisjunction = new System.Windows.Forms.Button();
            this.btnExclusiveDisjunction = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConjunction
            // 
            this.btnConjunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConjunction.Location = new System.Drawing.Point(38, 180);
            this.btnConjunction.Name = "btnConjunction";
            this.btnConjunction.Size = new System.Drawing.Size(200, 40);
            this.btnConjunction.TabIndex = 0;
            this.btnConjunction.Text = "Logical Conjunction";
            this.btnConjunction.UseVisualStyleBackColor = true;
            this.btnConjunction.Click += new System.EventHandler(this.btnConjunction_Click);
            // 
            // btnNegation
            // 
            this.btnNegation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegation.Location = new System.Drawing.Point(38, 227);
            this.btnNegation.Name = "btnNegation";
            this.btnNegation.Size = new System.Drawing.Size(200, 40);
            this.btnNegation.TabIndex = 1;
            this.btnNegation.Text = "Logical Negation";
            this.btnNegation.UseVisualStyleBackColor = true;
            this.btnNegation.Click += new System.EventHandler(this.btnNegation_Click);
            // 
            // btnDisjunction
            // 
            this.btnDisjunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisjunction.Location = new System.Drawing.Point(257, 180);
            this.btnDisjunction.Name = "btnDisjunction";
            this.btnDisjunction.Size = new System.Drawing.Size(200, 40);
            this.btnDisjunction.TabIndex = 2;
            this.btnDisjunction.Text = "Logical Disjunction";
            this.btnDisjunction.UseVisualStyleBackColor = true;
            this.btnDisjunction.Click += new System.EventHandler(this.btnDisjunction_Click);
            // 
            // btnExclusiveDisjunction
            // 
            this.btnExclusiveDisjunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclusiveDisjunction.Location = new System.Drawing.Point(257, 227);
            this.btnExclusiveDisjunction.Name = "btnExclusiveDisjunction";
            this.btnExclusiveDisjunction.Size = new System.Drawing.Size(200, 40);
            this.btnExclusiveDisjunction.TabIndex = 3;
            this.btnExclusiveDisjunction.Text = "Logical Exclusive Disjunction";
            this.btnExclusiveDisjunction.UseVisualStyleBackColor = true;
            this.btnExclusiveDisjunction.Click += new System.EventHandler(this.btnExclusiveDisjunction_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(24, 19);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(450, 135);
            this.txtDisplay.TabIndex = 4;
            // 
            // frmSelectionConjunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 302);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnExclusiveDisjunction);
            this.Controls.Add(this.btnDisjunction);
            this.Controls.Add(this.btnNegation);
            this.Controls.Add(this.btnConjunction);
            this.Name = "frmSelectionConjunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConjunction;
        private System.Windows.Forms.Button btnNegation;
        private System.Windows.Forms.Button btnDisjunction;
        private System.Windows.Forms.Button btnExclusiveDisjunction;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

