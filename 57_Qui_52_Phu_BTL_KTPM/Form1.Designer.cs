
namespace _57_Qui_52_Phu_BTL_KTPM
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
            this.bnCommentTestCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnCommentTestCase
            // 
            this.bnCommentTestCase.Location = new System.Drawing.Point(556, 273);
            this.bnCommentTestCase.Name = "bnCommentTestCase";
            this.bnCommentTestCase.Size = new System.Drawing.Size(272, 156);
            this.bnCommentTestCase.TabIndex = 0;
            this.bnCommentTestCase.Text = "testcaseComment";
            this.bnCommentTestCase.UseVisualStyleBackColor = true;
            this.bnCommentTestCase.Click += new System.EventHandler(this.bnCommentTestCase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 794);
            this.Controls.Add(this.bnCommentTestCase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnCommentTestCase;
    }
}

