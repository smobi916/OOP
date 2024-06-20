namespace ParametricCurvePlotter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Panel pnlGraph;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(13, 13);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "1";
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(120, 10);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 1;
            this.btnPlot.Text = "Малювати";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // pnlGraph
            // 
            this.pnlGraph.Location = new System.Drawing.Point(13, 40);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(775, 398);
            this.pnlGraph.TabIndex = 2;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Parametric Curve Plotter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
