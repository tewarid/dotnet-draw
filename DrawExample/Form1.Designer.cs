using Draw;
namespace DrawExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.link11 = new DrawExample.Link1();
            this.shape12 = new DrawExample.Shape1();
            this.shape11 = new DrawExample.Shape1();
            this.drawing11 = new DrawExample.Drawing1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0, 0";
            // 
            // link11
            // 
            this.link11.End = new System.Drawing.Point(738, 200);
            this.link11.Location = new System.Drawing.Point(-2, 198);
            this.link11.Name = "link11";
            this.link11.Selected = false;
            this.link11.Size = new System.Drawing.Size(742, 5);
            this.link11.Start = new System.Drawing.Point(0, 201);
            this.link11.TabIndex = 3;
            // 
            // shape12
            // 
            this.shape12.Location = new System.Drawing.Point(436, 102);
            this.shape12.Name = "shape12";
            this.shape12.Selected = false;
            this.shape12.Size = new System.Drawing.Size(238, 66);
            this.shape12.TabIndex = 2;
            // 
            // shape11
            // 
            this.shape11.Location = new System.Drawing.Point(160, 102);
            this.shape11.Name = "shape11";
            this.shape11.Selected = false;
            this.shape11.Size = new System.Drawing.Size(208, 57);
            this.shape11.TabIndex = 1;
            // 
            // drawing11
            // 
            this.drawing11.AutoScroll = true;
            this.drawing11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawing11.Location = new System.Drawing.Point(0, 0);
            this.drawing11.Name = "drawing11";
            this.drawing11.Size = new System.Drawing.Size(738, 432);
            this.drawing11.TabIndex = 0;
            this.drawing11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link11);
            this.Controls.Add(this.shape12);
            this.Controls.Add(this.shape11);
            this.Controls.Add(this.drawing11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Drawing1 drawing11;
        private Shape1 shape11;
        private Shape1 shape12;
        private Link1 link11;
        private System.Windows.Forms.Label label1;

    }
}
