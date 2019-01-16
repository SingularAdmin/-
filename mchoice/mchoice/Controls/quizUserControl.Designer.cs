using System;

namespace mchoice.Controls
{
    partial class quizUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizUserControl));
            this.titleL = new System.Windows.Forms.Label();
            this.descriptionL = new System.Windows.Forms.Label();
            this.ratingL = new System.Windows.Forms.Label();
            this.timerL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.takeQuizB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleL.Location = new System.Drawing.Point(147, 14);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(40, 17);
            this.titleL.TabIndex = 0;
            this.titleL.Text = "Title";
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descriptionL.Location = new System.Drawing.Point(18, 33);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(79, 17);
            this.descriptionL.TabIndex = 1;
            this.descriptionL.Text = "Description";
            // 
            // ratingL
            // 
            this.ratingL.AutoSize = true;
            this.ratingL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ratingL.ForeColor = System.Drawing.Color.OrangeRed;
            this.ratingL.Location = new System.Drawing.Point(16, 59);
            this.ratingL.Name = "ratingL";
            this.ratingL.Size = new System.Drawing.Size(72, 25);
            this.ratingL.TabIndex = 3;
            this.ratingL.Text = "* * * * *";
            // 
            // timerL
            // 
            this.timerL.AutoSize = true;
            this.timerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timerL.Location = new System.Drawing.Point(264, 87);
            this.timerL.Name = "timerL";
            this.timerL.Size = new System.Drawing.Size(77, 17);
            this.timerL.TabIndex = 15;
            this.timerL.Text = "10 Minutes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(242, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 25);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // takeQuizB
            // 
            this.takeQuizB.BackColor = System.Drawing.Color.OrangeRed;
            this.takeQuizB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeQuizB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.takeQuizB.Location = new System.Drawing.Point(124, 87);
            this.takeQuizB.Name = "takeQuizB";
            this.takeQuizB.Size = new System.Drawing.Size(75, 23);
            this.takeQuizB.TabIndex = 19;
            this.takeQuizB.Text = "Take Quiz";
            this.takeQuizB.UseVisualStyleBackColor = false;
            // 
            // quizUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.takeQuizB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timerL);
            this.Controls.Add(this.ratingL);
            this.Controls.Add(this.descriptionL);
            this.Controls.Add(this.titleL);
            this.Name = "quizUserControl";
            this.Size = new System.Drawing.Size(340, 114);
            this.Load += new System.EventHandler(this.quizUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void quizUserControl_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.Label descriptionL;
        private System.Windows.Forms.Label ratingL;
        private System.Windows.Forms.Label timerL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button takeQuizB;
    }
}
