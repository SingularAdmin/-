namespace mchoice.View
{
    partial class AddQuizWUserControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.removeLastButton = new System.Windows.Forms.Button();
            this.CreateQuizButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(195, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(622, 387);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.BackColor = System.Drawing.Color.Aquamarine;
            this.addQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addQuestionButton.Location = new System.Drawing.Point(37, 51);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(126, 44);
            this.addQuestionButton.TabIndex = 12;
            this.addQuestionButton.Text = "Add Question";
            this.addQuestionButton.UseVisualStyleBackColor = false;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // removeLastButton
            // 
            this.removeLastButton.BackColor = System.Drawing.Color.Aquamarine;
            this.removeLastButton.Enabled = false;
            this.removeLastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLastButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeLastButton.Location = new System.Drawing.Point(37, 133);
            this.removeLastButton.Name = "removeLastButton";
            this.removeLastButton.Size = new System.Drawing.Size(126, 44);
            this.removeLastButton.TabIndex = 13;
            this.removeLastButton.Text = "Remove Last";
            this.removeLastButton.UseVisualStyleBackColor = false;
            this.removeLastButton.Click += new System.EventHandler(this.removeLastButton_Click);
            // 
            // CreateQuizButton
            // 
            this.CreateQuizButton.BackColor = System.Drawing.Color.Coral;
            this.CreateQuizButton.Enabled = false;
            this.CreateQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuizButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateQuizButton.Location = new System.Drawing.Point(37, 394);
            this.CreateQuizButton.Name = "CreateQuizButton";
            this.CreateQuizButton.Size = new System.Drawing.Size(126, 44);
            this.CreateQuizButton.TabIndex = 14;
            this.CreateQuizButton.Text = "Create Quiz";
            this.CreateQuizButton.UseVisualStyleBackColor = false;
            this.CreateQuizButton.Click += new System.EventHandler(this.createQuizButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "You need at least: 15 questions";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Entertainment",
            "Science",
            "Science & Nature",
            "Politics",
            "Geography",
            "Vehicles",
            "Sports",
            "Celebrities",
            "Animals",
            "Art",
            "Mythology",
            "Video Games",
            "Television",
            "Japanese Anime & Manga",
            "Music",
            "Cartoon & Animations",
            "Comics",
            "Film",
            "Books",
            "Musicals & Theatres",
            "Board Games",
            "Gadgets",
            "Computers",
            "Mathematics",
            "History",
            "General Knowledge"});
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBox.Location = new System.Drawing.Point(357, 25);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(279, 20);
            this.SearchBox.TabIndex = 16;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.LightCyan;
            this.printButton.Enabled = false;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printButton.Location = new System.Drawing.Point(37, 251);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(126, 44);
            this.printButton.TabIndex = 17;
            this.printButton.Text = "Print Quiz Answers Sheet";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // AddQuizWUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 458);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateQuizButton);
            this.Controls.Add(this.removeLastButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddQuizWUserControl";
            this.Text = "Multiple Choice Creator";
            this.Load += new System.EventHandler(this.userControlTst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button removeLastButton;
        private System.Windows.Forms.Button CreateQuizButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button printButton;
    }
}