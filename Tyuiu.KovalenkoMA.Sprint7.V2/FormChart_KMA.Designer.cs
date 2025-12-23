namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    partial class FormChart_KMA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chartCapital_КМА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonCloseChart_KMA = new Button();
            ((System.ComponentModel.ISupportInitialize)chartCapital_КМА).BeginInit();
            SuspendLayout();
            // 
            // chartCapital_КМА
            // 
            chartArea1.Name = "ChartArea1";
            chartCapital_КМА.ChartAreas.Add(chartArea1);
            chartCapital_КМА.Dock = DockStyle.Fill;
            chartCapital_КМА.Location = new Point(0, 0);
            chartCapital_КМА.Name = "chartCapital_КМА";
            chartCapital_КМА.Size = new Size(800, 450);
            chartCapital_КМА.TabIndex = 0;
            // 
            // buttonCloseChart_KMA
            // 
            buttonCloseChart_KMA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCloseChart_KMA.Location = new Point(694, 409);
            buttonCloseChart_KMA.Name = "buttonCloseChart_KMA";
            buttonCloseChart_KMA.Size = new Size(94, 29);
            buttonCloseChart_KMA.TabIndex = 1;
            buttonCloseChart_KMA.Text = "Закрыть";
            buttonCloseChart_KMA.UseVisualStyleBackColor = true;
            buttonCloseChart_KMA.Click += buttonCloseChart_KMA_Click;
            // 
            // FormChart_KMA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseChart_KMA);
            Controls.Add(chartCapital_КМА);
            Name = "FormChart_KMA";
            Text = "График ";
            ((System.ComponentModel.ISupportInitialize)chartCapital_КМА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapital_КМА;
        private Button buttonCloseChart_KMA;
    }
}

