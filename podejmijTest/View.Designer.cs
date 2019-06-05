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
            this.components = new System.ComponentModel.Container();
            this.startB = new System.Windows.Forms.Button();
            this.answersCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.questionTextL = new System.Windows.Forms.Label();
            this.questionNumberL = new System.Windows.Forms.Label();
            this.previousB = new System.Windows.Forms.Button();
            this.nextB = new System.Windows.Forms.Button();
            this.finishB = new System.Windows.Forms.Button();
            this.timeLeftL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseTestB = new System.Windows.Forms.Button();
            this.testNameL = new System.Windows.Forms.Label();
            this.levelL = new System.Windows.Forms.Label();
            this.authorL = new System.Windows.Forms.Label();
            this.timeL = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Enabled = false;
            this.startB.Location = new System.Drawing.Point(60, 121);
            this.startB.Margin = new System.Windows.Forms.Padding(4);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(159, 41);
            this.startB.TabIndex = 1;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // answersCheckedBox
            // 
            this.answersCheckedBox.CheckOnClick = true;
            this.answersCheckedBox.FormattingEnabled = true;
            this.answersCheckedBox.Location = new System.Drawing.Point(429, 143);
            this.answersCheckedBox.Name = "answersCheckedBox";
            this.answersCheckedBox.Size = new System.Drawing.Size(308, 123);
            this.answersCheckedBox.TabIndex = 4;
            // 
            // questionTextL
            // 
            this.questionTextL.AutoSize = true;
            this.questionTextL.Location = new System.Drawing.Point(519, 73);
            this.questionTextL.Name = "questionTextL";
            this.questionTextL.Size = new System.Drawing.Size(94, 17);
            this.questionTextL.TabIndex = 5;
            this.questionTextL.Text = "Treść pytania";
            // 
            // questionNumberL
            // 
            this.questionNumberL.AutoSize = true;
            this.questionNumberL.Location = new System.Drawing.Point(529, 45);
            this.questionNumberL.Name = "questionNumberL";
            this.questionNumberL.Size = new System.Drawing.Size(96, 17);
            this.questionNumberL.TabIndex = 6;
            this.questionNumberL.Text = "Pytanie nr 0/0";
            // 
            // previousB
            // 
            this.previousB.Enabled = false;
            this.previousB.Location = new System.Drawing.Point(356, 183);
            this.previousB.Name = "previousB";
            this.previousB.Size = new System.Drawing.Size(44, 35);
            this.previousB.TabIndex = 7;
            this.previousB.Text = "←";
            this.previousB.UseVisualStyleBackColor = true;
            this.previousB.Click += new System.EventHandler(this.previousB_Click);
            // 
            // nextB
            // 
            this.nextB.Enabled = false;
            this.nextB.Location = new System.Drawing.Point(772, 183);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(33, 35);
            this.nextB.TabIndex = 8;
            this.nextB.Text = "→";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // finishB
            // 
            this.finishB.Enabled = false;
            this.finishB.Location = new System.Drawing.Point(532, 309);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(75, 45);
            this.finishB.TabIndex = 9;
            this.finishB.Text = "Zakończ test";
            this.finishB.UseVisualStyleBackColor = true;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // timeLeftL
            // 
            this.timeLeftL.AutoSize = true;
            this.timeLeftL.Location = new System.Drawing.Point(519, 365);
            this.timeLeftL.Name = "timeLeftL";
            this.timeLeftL.Size = new System.Drawing.Size(119, 17);
            this.timeLeftL.TabIndex = 10;
            this.timeLeftL.Text = "Czas pozostały: ∞";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Szczegóły dot. testu:";
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.DefaultExt = "xml";
            this.chooseFileDialog.Filter = "xml files (*.xml)|*.xml";
            this.chooseFileDialog.Title = "Wybierz plik xml zawierający test";
            this.chooseFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.chooseFileDialog_FileOk);
            // 
            // chooseTestB
            // 
            this.chooseTestB.Location = new System.Drawing.Point(60, 73);
            this.chooseTestB.Name = "chooseTestB";
            this.chooseTestB.Size = new System.Drawing.Size(159, 41);
            this.chooseTestB.TabIndex = 12;
            this.chooseTestB.Text = "Wybierz test";
            this.chooseTestB.UseVisualStyleBackColor = true;
            this.chooseTestB.Click += new System.EventHandler(this.chooseTestB_Click);
            // 
            // testNameL
            // 
            this.testNameL.AutoSize = true;
            this.testNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testNameL.Location = new System.Drawing.Point(108, 192);
            this.testNameL.Name = "testNameL";
            this.testNameL.Size = new System.Drawing.Size(0, 17);
            this.testNameL.TabIndex = 13;
            // 
            // levelL
            // 
            this.levelL.AutoSize = true;
            this.levelL.Location = new System.Drawing.Point(100, 267);
            this.levelL.Name = "levelL";
            this.levelL.Size = new System.Drawing.Size(62, 17);
            this.levelL.TabIndex = 14;
            this.levelL.Text = "Poziom: ";
            // 
            // authorL
            // 
            this.authorL.AutoSize = true;
            this.authorL.Location = new System.Drawing.Point(108, 295);
            this.authorL.Name = "authorL";
            this.authorL.Size = new System.Drawing.Size(46, 17);
            this.authorL.TabIndex = 15;
            this.authorL.Text = "Autor:";
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.Location = new System.Drawing.Point(108, 323);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(43, 17);
            this.timeL.TabIndex = 16;
            this.timeL.Text = "Czas:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 408);
            this.Controls.Add(this.timeL);
            this.Controls.Add(this.authorL);
            this.Controls.Add(this.levelL);
            this.Controls.Add(this.testNameL);
            this.Controls.Add(this.chooseTestB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeLeftL);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.previousB);
            this.Controls.Add(this.questionNumberL);
            this.Controls.Add(this.questionTextL);
            this.Controls.Add(this.answersCheckedBox);
            this.Controls.Add(this.startB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.CheckedListBox answersCheckedBox;
        private System.Windows.Forms.Label questionTextL;
        private System.Windows.Forms.Label questionNumberL;
        private System.Windows.Forms.Button previousB;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.Label timeLeftL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.Button chooseTestB;
        private System.Windows.Forms.Label testNameL;
        private System.Windows.Forms.Label levelL;
        private System.Windows.Forms.Label authorL;
        private System.Windows.Forms.Label timeL;
        private System.Windows.Forms.Timer timerSec;
    }
}

