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
            this.drawing11 = new Drawing1();
            this.shape1 = new Draw.Shape();
            this.SuspendLayout();
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
            // shape1
            // 
            this.shape1.Location = new System.Drawing.Point(173, 67);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(150, 150);
            this.shape1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 432);
            this.Controls.Add(this.shape1);
            this.Controls.Add(this.drawing11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Drawing1 drawing11;
        private Shape shape1;

    }
}
