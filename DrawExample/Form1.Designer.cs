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
            this.link11 = new DrawExample.Link1();
            this.shape12 = new DrawExample.Shape1();
            this.shape11 = new DrawExample.Shape1();
            this.drawing11 = new DrawExample.Drawing1();
            this.SuspendLayout();
            // 
            // link11
            // 
            this.link11.BackColor = System.Drawing.Color.Transparent;
            this.link11.Location = new System.Drawing.Point(254, 192);
            this.link11.Name = "link11";
            this.link11.Selected = false;
            this.link11.Size = new System.Drawing.Size(233, 10);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 432);
            this.Controls.Add(this.link11);
            this.Controls.Add(this.shape12);
            this.Controls.Add(this.shape11);
            this.Controls.Add(this.drawing11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Drawing1 drawing11;
        private Shape1 shape11;
        private Shape1 shape12;
        private Link1 link11;

    }
}
