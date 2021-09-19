
namespace WordGuesser
{
    partial class MainForm
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
            this.lettersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wordLbl = new System.Windows.Forms.Label();
            this.lifePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lifeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lettersPanel
            // 
            this.lettersPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.lettersPanel.Location = new System.Drawing.Point(28, 26);
            this.lettersPanel.Name = "lettersPanel";
            this.lettersPanel.Size = new System.Drawing.Size(650, 100);
            this.lettersPanel.TabIndex = 0;
            // 
            // wordLbl
            // 
            this.wordLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wordLbl.Location = new System.Drawing.Point(33, 194);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(640, 66);
            this.wordLbl.TabIndex = 1;
            this.wordLbl.Text = "0123456789001234567890";
            this.wordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lifePanel
            // 
            this.lifePanel.BackColor = System.Drawing.Color.Goldenrod;
            this.lifePanel.Location = new System.Drawing.Point(223, 357);
            this.lifePanel.Name = "lifePanel";
            this.lifePanel.Size = new System.Drawing.Size(250, 50);
            this.lifePanel.TabIndex = 2;
            // 
            // lifeLbl
            // 
            this.lifeLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLbl.Location = new System.Drawing.Point(429, 331);
            this.lifeLbl.Name = "lifeLbl";
            this.lifeLbl.Size = new System.Drawing.Size(45, 26);
            this.lifeLbl.TabIndex = 3;
            this.lifeLbl.Text = "5/5";
            this.lifeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.lifeLbl);
            this.Controls.Add(this.lifePanel);
            this.Controls.Add(this.wordLbl);
            this.Controls.Add(this.lettersPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Guesser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel lettersPanel;
        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.FlowLayoutPanel lifePanel;
        private System.Windows.Forms.Label lifeLbl;
    }
}

