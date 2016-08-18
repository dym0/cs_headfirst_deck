namespace Deck
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
            this.Reset1 = new System.Windows.Forms.Button();
            this.Reset2 = new System.Windows.Forms.Button();
            this.Shuffle2 = new System.Windows.Forms.Button();
            this.Shuffle = new System.Windows.Forms.Button();
            this.MoveToDeck2 = new System.Windows.Forms.Button();
            this.MoveToDeck1 = new System.Windows.Forms.Button();
            this.deckList1 = new System.Windows.Forms.ListBox();
            this.deckList2 = new System.Windows.Forms.ListBox();
            this.deckLabel1 = new System.Windows.Forms.Label();
            this.deckLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset1
            // 
            this.Reset1.AccessibleName = "ResetLeft";
            this.Reset1.Location = new System.Drawing.Point(47, 208);
            this.Reset1.Name = "Reset1";
            this.Reset1.Size = new System.Drawing.Size(75, 23);
            this.Reset1.TabIndex = 0;
            this.Reset1.Text = "Reset";
            this.Reset1.UseVisualStyleBackColor = true;
            this.Reset1.Click += new System.EventHandler(this.Reset1_Click);
            // 
            // Reset2
            // 
            this.Reset2.AccessibleName = "ResetRight";
            this.Reset2.Location = new System.Drawing.Point(233, 208);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(75, 23);
            this.Reset2.TabIndex = 1;
            this.Reset2.Text = "Reset";
            this.Reset2.UseVisualStyleBackColor = true;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // Shuffle2
            // 
            this.Shuffle2.AccessibleName = "Shuffle2";
            this.Shuffle2.Location = new System.Drawing.Point(233, 237);
            this.Shuffle2.Name = "Shuffle2";
            this.Shuffle2.Size = new System.Drawing.Size(75, 23);
            this.Shuffle2.TabIndex = 2;
            this.Shuffle2.Text = "Shuffle";
            this.Shuffle2.UseVisualStyleBackColor = true;
            this.Shuffle2.Click += new System.EventHandler(this.Shuffle2_Click);
            // 
            // Shuffle
            // 
            this.Shuffle.AccessibleName = "Shuffle1";
            this.Shuffle.Location = new System.Drawing.Point(47, 237);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(75, 23);
            this.Shuffle.TabIndex = 3;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // MoveToDeck2
            // 
            this.MoveToDeck2.Location = new System.Drawing.Point(158, 71);
            this.MoveToDeck2.Name = "MoveToDeck2";
            this.MoveToDeck2.Size = new System.Drawing.Size(28, 23);
            this.MoveToDeck2.TabIndex = 6;
            this.MoveToDeck2.Text = ">>";
            this.MoveToDeck2.UseVisualStyleBackColor = true;
            this.MoveToDeck2.Click += new System.EventHandler(this.MoveToDeck2_Click);
            // 
            // MoveToDeck1
            // 
            this.MoveToDeck1.Location = new System.Drawing.Point(158, 144);
            this.MoveToDeck1.Name = "MoveToDeck1";
            this.MoveToDeck1.Size = new System.Drawing.Size(28, 23);
            this.MoveToDeck1.TabIndex = 7;
            this.MoveToDeck1.Text = "<<";
            this.MoveToDeck1.UseVisualStyleBackColor = true;
            this.MoveToDeck1.Click += new System.EventHandler(this.MoveToDeck1_Click);
            // 
            // deckList1
            // 
            this.deckList1.FormattingEnabled = true;
            this.deckList1.Location = new System.Drawing.Point(12, 24);
            this.deckList1.Name = "deckList1";
            this.deckList1.Size = new System.Drawing.Size(140, 173);
            this.deckList1.TabIndex = 8;
            this.deckList1.SelectedIndexChanged += new System.EventHandler(this.deckList1_SelectedIndexChanged);
            // 
            // deckList2
            // 
            this.deckList2.FormattingEnabled = true;
            this.deckList2.Location = new System.Drawing.Point(200, 24);
            this.deckList2.Name = "deckList2";
            this.deckList2.Size = new System.Drawing.Size(140, 173);
            this.deckList2.TabIndex = 9;
            // 
            // deckLabel1
            // 
            this.deckLabel1.AutoSize = true;
            this.deckLabel1.Location = new System.Drawing.Point(12, 5);
            this.deckLabel1.Name = "deckLabel1";
            this.deckLabel1.Size = new System.Drawing.Size(35, 13);
            this.deckLabel1.TabIndex = 10;
            this.deckLabel1.Text = "label1";
            // 
            // deckLabel2
            // 
            this.deckLabel2.AutoSize = true;
            this.deckLabel2.Location = new System.Drawing.Point(200, 5);
            this.deckLabel2.Name = "deckLabel2";
            this.deckLabel2.Size = new System.Drawing.Size(35, 13);
            this.deckLabel2.TabIndex = 11;
            this.deckLabel2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 282);
            this.Controls.Add(this.deckLabel2);
            this.Controls.Add(this.deckLabel1);
            this.Controls.Add(this.deckList2);
            this.Controls.Add(this.deckList1);
            this.Controls.Add(this.MoveToDeck1);
            this.Controls.Add(this.MoveToDeck2);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.Shuffle2);
            this.Controls.Add(this.Reset2);
            this.Controls.Add(this.Reset1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset1;
        private System.Windows.Forms.Button Reset2;
        private System.Windows.Forms.Button Shuffle2;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button MoveToDeck2;
        private System.Windows.Forms.Button MoveToDeck1;
        private System.Windows.Forms.ListBox deckList1;
        private System.Windows.Forms.ListBox deckList2;
        private System.Windows.Forms.Label deckLabel1;
        private System.Windows.Forms.Label deckLabel2;
    }
}

