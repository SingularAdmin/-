namespace mchoice.View
{
    partial class testMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogSignbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addQuizButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LogSignbutton);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.addQuizButton);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 481);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(264, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 362);
            this.flowLayoutPanel1.TabIndex = 32;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // LogSignbutton
            // 
            this.LogSignbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogSignbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogSignbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogSignbutton.ForeColor = System.Drawing.Color.White;
            this.LogSignbutton.Location = new System.Drawing.Point(610, 3);
            this.LogSignbutton.Name = "LogSignbutton";
            this.LogSignbutton.Size = new System.Drawing.Size(161, 26);
            this.LogSignbutton.TabIndex = 25;
            this.LogSignbutton.Text = "Log in / Sign up";
            this.LogSignbutton.UseVisualStyleBackColor = false;
            this.LogSignbutton.Click += new System.EventHandler(this.LogSignbutton_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.Location = new System.Drawing.Point(18, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Load Categories from DBase";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addQuizButton
            // 
            this.addQuizButton.Location = new System.Drawing.Point(41, 414);
            this.addQuizButton.Name = "addQuizButton";
            this.addQuizButton.Size = new System.Drawing.Size(112, 44);
            this.addQuizButton.TabIndex = 29;
            this.addQuizButton.Text = "Add Quiz";
            this.addQuizButton.UseVisualStyleBackColor = true;
            this.addQuizButton.Click += new System.EventHandler(this.addQuizButton_Click_1);
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
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBox.Location = new System.Drawing.Point(264, 69);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(200, 20);
            this.SearchBox.TabIndex = 26;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(510, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 21);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
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
            this.checkedListBox1.Location = new System.Drawing.Point(18, 140);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 259);
            this.checkedListBox1.TabIndex = 28;
            // 
            // testMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 505);
            this.Controls.Add(this.panel1);
            this.Name = "testMainForm";
            this.Text = "testMainForm";
            this.Load += new System.EventHandler(this.testMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button LogSignbutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addQuizButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}