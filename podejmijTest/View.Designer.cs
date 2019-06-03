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
            this.startB = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseTestB = new System.Windows.Forms.Button();
            this.testNameL = new System.Windows.Forms.Label();
            this.levelL = new System.Windows.Forms.Label();
            this.authorL = new System.Windows.Forms.Label();
            this.timeL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(60, 121);
            this.startB.Margin = new System.Windows.Forms.Padding(4);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(159, 41);
            this.startB.TabIndex = 1;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(429, 143);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(308, 123);
            this.checkedListBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Treść pytania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pytanie ../x";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(772, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Zakończ test";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Czas pozostały: ";
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
            this.testNameL.Size = new System.Drawing.Size(54, 17);
            this.testNameL.TabIndex = 13;
            this.testNameL.Text = "Tytuł: ";
            this.testNameL.Visible = false;
            // 
            // levelL
            // 
            this.levelL.AutoSize = true;
            this.levelL.Location = new System.Drawing.Point(100, 267);
            this.levelL.Name = "levelL";
            this.levelL.Size = new System.Drawing.Size(62, 17);
            this.levelL.TabIndex = 14;
            this.levelL.Text = "Poziom: ";
            this.levelL.Visible = false;
            // 
            // authorL
            // 
            this.authorL.AutoSize = true;
            this.authorL.Location = new System.Drawing.Point(108, 295);
            this.authorL.Name = "authorL";
            this.authorL.Size = new System.Drawing.Size(46, 17);
            this.authorL.TabIndex = 15;
            this.authorL.Text = "Autor:";
            this.authorL.Visible = false;
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.Location = new System.Drawing.Point(108, 323);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(43, 17);
            this.timeL.TabIndex = 16;
            this.timeL.Text = "Czas:";
            this.timeL.Visible = false;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.startB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.Button chooseTestB;
        private System.Windows.Forms.Label testNameL;
        private System.Windows.Forms.Label levelL;
        private System.Windows.Forms.Label authorL;
        private System.Windows.Forms.Label timeL;
    }
}

