namespace podejmijTest
{
    partial class View
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboTests = new System.Windows.Forms.ComboBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.listAnswers = new System.Windows.Forms.CheckedListBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelQustionNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboTests);
            this.splitContainer1.Panel1.Controls.Add(this.labelTimer);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonFinish);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNext);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPrevious);
            this.splitContainer1.Panel2.Controls.Add(this.listAnswers);
            this.splitContainer1.Panel2.Controls.Add(this.labelQuestion);
            this.splitContainer1.Panel2.Controls.Add(this.labelQustionNumber);
            this.splitContainer1.Size = new System.Drawing.Size(635, 433);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboTests
            // 
            this.comboTests.FormattingEnabled = true;
            this.comboTests.Location = new System.Drawing.Point(49, 41);
            this.comboTests.Name = "comboTests";
            this.comboTests.Size = new System.Drawing.Size(121, 21);
            this.comboTests.TabIndex = 3;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(89, 232);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(36, 13);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "Timer:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(69, 113);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(179, 343);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 5;
            this.buttonFinish.Text = "Zakończ";
            this.buttonFinish.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(294, 343);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "→";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(63, 343);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "←";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // listAnswers
            // 
            this.listAnswers.FormattingEnabled = true;
            this.listAnswers.Location = new System.Drawing.Point(111, 103);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(203, 169);
            this.listAnswers.TabIndex = 2;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(204, 44);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(16, 13);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "...";
            // 
            // labelQustionNumber
            // 
            this.labelQustionNumber.AutoSize = true;
            this.labelQustionNumber.Location = new System.Drawing.Point(183, 20);
            this.labelQustionNumber.Name = "labelQustionNumber";
            this.labelQustionNumber.Size = new System.Drawing.Size(62, 13);
            this.labelQustionNumber.TabIndex = 0;
            this.labelQustionNumber.Text = "Pytanie 0/0";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 433);
            this.Controls.Add(this.splitContainer1);
            this.Name = "View";
            this.Text = "Test";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboTests;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.CheckedListBox listAnswers;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelQustionNumber;
    }
}

