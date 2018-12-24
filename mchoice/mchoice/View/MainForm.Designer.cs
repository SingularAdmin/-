namespace mchoice
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
            this.LogSignbutton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.addQuizButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogSignbutton
            // 
            this.LogSignbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogSignbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogSignbutton.ForeColor = System.Drawing.Color.White;
            this.LogSignbutton.Location = new System.Drawing.Point(670, 12);
            this.LogSignbutton.Name = "LogSignbutton";
            this.LogSignbutton.Size = new System.Drawing.Size(179, 33);
            this.LogSignbutton.TabIndex = 0;
            this.LogSignbutton.Text = "Log in / Sign up";
            this.LogSignbutton.UseVisualStyleBackColor = false;
            this.LogSignbutton.Click += new System.EventHandler(this.button1_Click);
            this.LogSignbutton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.LogSignbutton.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(325, 19);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(259, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(582, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 21);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(25, 145);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(154, 259);
            this.checkedListBox1.TabIndex = 4;
            // 
            // addQuizButton
            // 
            this.addQuizButton.Location = new System.Drawing.Point(44, 449);
            this.addQuizButton.Name = "addQuizButton";
            this.addQuizButton.Size = new System.Drawing.Size(112, 44);
            this.addQuizButton.TabIndex = 5;
            this.addQuizButton.Text = "Add Quiz";
            this.addQuizButton.UseVisualStyleBackColor = true;
            this.addQuizButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 505);
            this.Controls.Add(this.addQuizButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.LogSignbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogSignbutton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button addQuizButton;
    }
}

