using Draw;
namespace DrawExample
{
    partial class Drawing1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shape1 = new Draw.Shape();
            this.SuspendLayout();
            // 
            // shape1
            // 
            this.shape1.Location = new System.Drawing.Point(360, 124);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(150, 150);
            this.shape1.TabIndex = 0;
            // 
            // Drawing1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shape1);
            this.Name = "Drawing1";
            this.ResumeLayout(false);

        }

        #endregion

        private Shape shape1;
    }
}
