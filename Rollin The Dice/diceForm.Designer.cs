namespace Rollin_The_Dice
{
    partial class diceForm
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.sslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTwoRolled = new System.Windows.Forms.Label();
            this.lblThreeRolled = new System.Windows.Forms.Label();
            this.lblFourRolled = new System.Windows.Forms.Label();
            this.lblFiveRolled = new System.Windows.Forms.Label();
            this.lblSixRolled = new System.Windows.Forms.Label();
            this.lblSevenRolled = new System.Windows.Forms.Label();
            this.lblEightRolled = new System.Windows.Forms.Label();
            this.lblNineRolled = new System.Windows.Forms.Label();
            this.lblTenRolled = new System.Windows.Forms.Label();
            this.lblElevenRolled = new System.Windows.Forms.Label();
            this.lblTwelveRolled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.ssInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(12, 299);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(449, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll The &Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(0, 0);
            this.dgResults.Name = "dgResults";
            this.dgResults.Size = new System.Drawing.Size(472, 293);
            this.dgResults.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 333);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Write";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(250, 333);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "R&ead";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(369, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslInfo});
            this.ssInfo.Location = new System.Drawing.Point(0, 551);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(485, 22);
            this.ssInfo.TabIndex = 6;
            this.ssInfo.Text = "statusStrip1";
            // 
            // sslInfo
            // 
            this.sslInfo.Name = "sslInfo";
            this.sslInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // lblTwoRolled
            // 
            this.lblTwoRolled.AutoSize = true;
            this.lblTwoRolled.Location = new System.Drawing.Point(12, 374);
            this.lblTwoRolled.Name = "lblTwoRolled";
            this.lblTwoRolled.Size = new System.Drawing.Size(35, 13);
            this.lblTwoRolled.TabIndex = 7;
            this.lblTwoRolled.Text = "label1";
            // 
            // lblThreeRolled
            // 
            this.lblThreeRolled.AutoSize = true;
            this.lblThreeRolled.Location = new System.Drawing.Point(12, 403);
            this.lblThreeRolled.Name = "lblThreeRolled";
            this.lblThreeRolled.Size = new System.Drawing.Size(35, 13);
            this.lblThreeRolled.TabIndex = 8;
            this.lblThreeRolled.Text = "label2";
            // 
            // lblFourRolled
            // 
            this.lblFourRolled.AutoSize = true;
            this.lblFourRolled.Location = new System.Drawing.Point(12, 432);
            this.lblFourRolled.Name = "lblFourRolled";
            this.lblFourRolled.Size = new System.Drawing.Size(35, 13);
            this.lblFourRolled.TabIndex = 9;
            this.lblFourRolled.Text = "label3";
            // 
            // lblFiveRolled
            // 
            this.lblFiveRolled.AutoSize = true;
            this.lblFiveRolled.Location = new System.Drawing.Point(12, 461);
            this.lblFiveRolled.Name = "lblFiveRolled";
            this.lblFiveRolled.Size = new System.Drawing.Size(35, 13);
            this.lblFiveRolled.TabIndex = 10;
            this.lblFiveRolled.Text = "label4";
            // 
            // lblSixRolled
            // 
            this.lblSixRolled.AutoSize = true;
            this.lblSixRolled.Location = new System.Drawing.Point(12, 490);
            this.lblSixRolled.Name = "lblSixRolled";
            this.lblSixRolled.Size = new System.Drawing.Size(35, 13);
            this.lblSixRolled.TabIndex = 11;
            this.lblSixRolled.Text = "label5";
            // 
            // lblSevenRolled
            // 
            this.lblSevenRolled.AutoSize = true;
            this.lblSevenRolled.Location = new System.Drawing.Point(12, 519);
            this.lblSevenRolled.Name = "lblSevenRolled";
            this.lblSevenRolled.Size = new System.Drawing.Size(35, 13);
            this.lblSevenRolled.TabIndex = 12;
            this.lblSevenRolled.Text = "label6";
            // 
            // lblEightRolled
            // 
            this.lblEightRolled.AutoSize = true;
            this.lblEightRolled.Location = new System.Drawing.Point(247, 373);
            this.lblEightRolled.Name = "lblEightRolled";
            this.lblEightRolled.Size = new System.Drawing.Size(35, 13);
            this.lblEightRolled.TabIndex = 13;
            this.lblEightRolled.Text = "label7";
            // 
            // lblNineRolled
            // 
            this.lblNineRolled.AutoSize = true;
            this.lblNineRolled.Location = new System.Drawing.Point(247, 403);
            this.lblNineRolled.Name = "lblNineRolled";
            this.lblNineRolled.Size = new System.Drawing.Size(35, 13);
            this.lblNineRolled.TabIndex = 14;
            this.lblNineRolled.Text = "label8";
            // 
            // lblTenRolled
            // 
            this.lblTenRolled.AutoSize = true;
            this.lblTenRolled.Location = new System.Drawing.Point(247, 432);
            this.lblTenRolled.Name = "lblTenRolled";
            this.lblTenRolled.Size = new System.Drawing.Size(35, 13);
            this.lblTenRolled.TabIndex = 15;
            this.lblTenRolled.Text = "label9";
            // 
            // lblElevenRolled
            // 
            this.lblElevenRolled.AutoSize = true;
            this.lblElevenRolled.Location = new System.Drawing.Point(247, 461);
            this.lblElevenRolled.Name = "lblElevenRolled";
            this.lblElevenRolled.Size = new System.Drawing.Size(41, 13);
            this.lblElevenRolled.TabIndex = 16;
            this.lblElevenRolled.Text = "label10";
            this.lblElevenRolled.Visible = false;
            // 
            // lblTwelveRolled
            // 
            this.lblTwelveRolled.AutoSize = true;
            this.lblTwelveRolled.Location = new System.Drawing.Point(247, 490);
            this.lblTwelveRolled.Name = "lblTwelveRolled";
            this.lblTwelveRolled.Size = new System.Drawing.Size(41, 13);
            this.lblTwelveRolled.TabIndex = 17;
            this.lblTwelveRolled.Text = "label11";
            this.lblTwelveRolled.Visible = false;
            // 
            // diceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 573);
            this.Controls.Add(this.lblTwelveRolled);
            this.Controls.Add(this.lblElevenRolled);
            this.Controls.Add(this.lblTenRolled);
            this.Controls.Add(this.lblNineRolled);
            this.Controls.Add(this.lblEightRolled);
            this.Controls.Add(this.lblSevenRolled);
            this.Controls.Add(this.lblSixRolled);
            this.Controls.Add(this.lblFiveRolled);
            this.Controls.Add(this.lblFourRolled);
            this.Controls.Add(this.lblThreeRolled);
            this.Controls.Add(this.lblTwoRolled);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.btnRoll);
            this.Name = "diceForm";
            this.Text = "Rollin The Dice";
            this.Load += new System.EventHandler(this.diceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel sslInfo;
        private System.Windows.Forms.Label lblTwoRolled;
        private System.Windows.Forms.Label lblThreeRolled;
        private System.Windows.Forms.Label lblFourRolled;
        private System.Windows.Forms.Label lblFiveRolled;
        private System.Windows.Forms.Label lblSixRolled;
        private System.Windows.Forms.Label lblSevenRolled;
        private System.Windows.Forms.Label lblEightRolled;
        private System.Windows.Forms.Label lblNineRolled;
        private System.Windows.Forms.Label lblTenRolled;
        private System.Windows.Forms.Label lblElevenRolled;
        private System.Windows.Forms.Label lblTwelveRolled;
    }
}

