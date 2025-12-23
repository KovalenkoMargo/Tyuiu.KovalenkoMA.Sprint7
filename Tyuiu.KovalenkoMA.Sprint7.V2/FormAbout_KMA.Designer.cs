namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    partial class FormAbout_KMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KMA));
            buttonCloseAbout_KMA = new Button();
            pictureBoxPhoto_KMA = new PictureBox();
            labelInfo_KMA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_KMA).BeginInit();
            SuspendLayout();
            // 
            // buttonCloseAbout_KMA
            // 
            buttonCloseAbout_KMA.Location = new Point(486, 303);
            buttonCloseAbout_KMA.Name = "buttonCloseAbout_KMA";
            buttonCloseAbout_KMA.Size = new Size(94, 29);
            buttonCloseAbout_KMA.TabIndex = 0;
            buttonCloseAbout_KMA.Text = "Закрыть";
            buttonCloseAbout_KMA.UseVisualStyleBackColor = true;
            buttonCloseAbout_KMA.Click += buttonCloseAbout_KMA_Click;
            // 
            // pictureBoxPhoto_KMA
            // 
            pictureBoxPhoto_KMA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto_KMA.Image = (Image)resources.GetObject("pictureBoxPhoto_KMA.Image");
            pictureBoxPhoto_KMA.Location = new Point(12, 9);
            pictureBoxPhoto_KMA.Name = "pictureBoxPhoto_KMA";
            pictureBoxPhoto_KMA.Size = new Size(184, 330);
            pictureBoxPhoto_KMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto_KMA.TabIndex = 5;
            pictureBoxPhoto_KMA.TabStop = false;
            // 
            // labelInfo_KMA
            // 
            labelInfo_KMA.AutoSize = true;
            labelInfo_KMA.Location = new Point(226, 23);
            labelInfo_KMA.Name = "labelInfo_KMA";
            labelInfo_KMA.Size = new Size(371, 220);
            labelInfo_KMA.TabIndex = 6;
            labelInfo_KMA.Text = resources.GetString("labelInfo_KMA.Text");
            // 
            // FormAbout_KMA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 344);
            Controls.Add(labelInfo_KMA);
            Controls.Add(pictureBoxPhoto_KMA);
            Controls.Add(buttonCloseAbout_KMA);
            Name = "FormAbout_KMA";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_KMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCloseAbout_KMA;
        private PictureBox pictureBoxPhoto_KMA;
        private Label labelInfo_KMA;
    }
}