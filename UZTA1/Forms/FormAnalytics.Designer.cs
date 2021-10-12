
namespace UZTA1.Forms
{
    partial class FormAnalytics
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
            this.sparkLine1 = new Syncfusion.Windows.Forms.Chart.SparkLine();
            this.SuspendLayout();
            // 
            // sparkLine1
            // 
            this.sparkLine1.EndPoint = 10D;
            this.sparkLine1.HighPoint = 90D;
            this.sparkLine1.Location = new System.Drawing.Point(12, 12);
            this.sparkLine1.LowPoint = 10D;
            this.sparkLine1.Name = "sparkLine1";
            this.sparkLine1.NegativeItem = new double[] {
        0D,
        0D,
        0D,
        0D,
        0D};
            this.sparkLine1.Size = new System.Drawing.Size(776, 426);
            this.sparkLine1.Source = new double[] {
        20D,
        90D,
        30D,
        60D,
        10D};
            this.sparkLine1.StartPoint = 20D;
            this.sparkLine1.TabIndex = 0;
            this.sparkLine1.Text = "sparkLine1";
            this.sparkLine1.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.Line;
            // 
            // FormAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sparkLine1);
            this.Name = "FormAnalytics";
            this.Text = "Analytics";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine1;
    }
}