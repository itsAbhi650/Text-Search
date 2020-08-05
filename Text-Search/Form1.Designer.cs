namespace Text_Search
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
            this.tbSearchArea = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbTextArea = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDown = new System.Windows.Forms.RadioButton();
            this.checkUP = new System.Windows.Forms.RadioButton();
            this.lnsLabel = new System.Windows.Forms.Label();
            this.colLabel = new System.Windows.Forms.Label();
            this.LIndexLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gc = new System.Windows.Forms.Label();
            this.gcifcr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.altcol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lioff = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchArea
            // 
            this.tbSearchArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchArea.Location = new System.Drawing.Point(11, 12);
            this.tbSearchArea.Name = "tbSearchArea";
            this.tbSearchArea.Size = new System.Drawing.Size(315, 20);
            this.tbSearchArea.TabIndex = 0;
            this.tbSearchArea.TextChanged += new System.EventHandler(this.tbSearchArea_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(332, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbTextArea
            // 
            this.rtbTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTextArea.HideSelection = false;
            this.rtbTextArea.Location = new System.Drawing.Point(3, 136);
            this.rtbTextArea.Name = "rtbTextArea";
            this.rtbTextArea.Size = new System.Drawing.Size(406, 281);
            this.rtbTextArea.TabIndex = 2;
            this.rtbTextArea.Text = "";
            this.rtbTextArea.SelectionChanged += new System.EventHandler(this.rtbTextArea_SelectionChanged);
            this.rtbTextArea.TextChanged += new System.EventHandler(this.rtbTextArea_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMatchCase);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constraints";
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(15, 70);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(83, 17);
            this.cbMatchCase.TabIndex = 5;
            this.cbMatchCase.Text = "Match Case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDown);
            this.groupBox2.Controls.Add(this.checkUP);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 45);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direction";
            // 
            // checkDown
            // 
            this.checkDown.AutoSize = true;
            this.checkDown.Checked = true;
            this.checkDown.Location = new System.Drawing.Point(52, 22);
            this.checkDown.Name = "checkDown";
            this.checkDown.Size = new System.Drawing.Size(53, 17);
            this.checkDown.TabIndex = 1;
            this.checkDown.TabStop = true;
            this.checkDown.Text = "Down";
            this.checkDown.UseVisualStyleBackColor = true;
            // 
            // checkUP
            // 
            this.checkUP.AutoSize = true;
            this.checkUP.Location = new System.Drawing.Point(9, 22);
            this.checkUP.Name = "checkUP";
            this.checkUP.Size = new System.Drawing.Size(39, 17);
            this.checkUP.TabIndex = 0;
            this.checkUP.TabStop = true;
            this.checkUP.Text = "Up";
            this.checkUP.UseVisualStyleBackColor = true;
            // 
            // lnsLabel
            // 
            this.lnsLabel.AutoSize = true;
            this.lnsLabel.Location = new System.Drawing.Point(63, 24);
            this.lnsLabel.Name = "lnsLabel";
            this.lnsLabel.Size = new System.Drawing.Size(0, 13);
            this.lnsLabel.TabIndex = 4;
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(63, 47);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(0, 13);
            this.colLabel.TabIndex = 5;
            // 
            // LIndexLabel
            // 
            this.LIndexLabel.AutoSize = true;
            this.LIndexLabel.Location = new System.Drawing.Point(63, 70);
            this.LIndexLabel.Name = "LIndexLabel";
            this.LIndexLabel.Size = new System.Drawing.Size(0, 13);
            this.LIndexLabel.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gc);
            this.groupBox3.Controls.Add(this.gcifcr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.altcol);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lioff);
            this.groupBox3.Controls.Add(this.colLabel);
            this.groupBox3.Controls.Add(this.LIndexLabel);
            this.groupBox3.Controls.Add(this.lnsLabel);
            this.groupBox3.Location = new System.Drawing.Point(208, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 93);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            //this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // gc
            // 
            this.gc.AutoSize = true;
            this.gc.Location = new System.Drawing.Point(132, 24);
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(36, 13);
            this.gc.TabIndex = 15;
            this.gc.Text = "gcifcr:";
            // 
            // gcifcr
            // 
            this.gcifcr.AutoSize = true;
            this.gcifcr.Location = new System.Drawing.Point(174, 25);
            this.gcifcr.Name = "gcifcr";
            this.gcifcr.Size = new System.Drawing.Size(0, 13);
            this.gcifcr.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Index (/n):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "debug:";
            // 
            // altcol
            // 
            this.altcol.AutoSize = true;
            this.altcol.Location = new System.Drawing.Point(174, 47);
            this.altcol.Name = "altcol";
            this.altcol.Size = new System.Drawing.Size(0, 13);
            this.altcol.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SelStart:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Line:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Col:";
            // 
            // lioff
            // 
            this.lioff.AutoSize = true;
            this.lioff.Location = new System.Drawing.Point(174, 71);
            this.lioff.Name = "lioff";
            this.lioff.Size = new System.Drawing.Size(0, 13);
            this.lioff.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rtbTextArea);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchArea);
            this.Name = "Form1";
            this.Text = "Text Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchArea;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbTextArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton checkDown;
        private System.Windows.Forms.RadioButton checkUP;
        private System.Windows.Forms.Label lnsLabel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label LIndexLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lioff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label altcol;
        private System.Windows.Forms.Label gc;
        private System.Windows.Forms.Label gcifcr;
    }
}

