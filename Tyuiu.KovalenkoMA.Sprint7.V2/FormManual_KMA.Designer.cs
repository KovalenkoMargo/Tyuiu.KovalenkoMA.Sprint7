namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    partial class FormManual_KMA
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
            richTextBoxManual_KMA = new RichTextBox();
            buttonCloseManual_KMA = new Button();
            SuspendLayout();
            // 
            // richTextBoxManual_KMA
            // 
            richTextBoxManual_KMA.Dock = DockStyle.Fill;
            richTextBoxManual_KMA.Location = new Point(0, 0);
            richTextBoxManual_KMA.Name = "richTextBoxManual_KMA";
            richTextBoxManual_KMA.Size = new Size(800, 450);
            richTextBoxManual_KMA.TabIndex = 0;
            richTextBoxManual_KMA.Text = "";
            // 
            // buttonCloseManual_KMA
            // 
            buttonCloseManual_KMA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCloseManual_KMA.Location = new Point(694, 409);
            buttonCloseManual_KMA.Name = "buttonCloseManual_KMA";
            buttonCloseManual_KMA.Size = new Size(94, 29);
            buttonCloseManual_KMA.TabIndex = 1;
            buttonCloseManual_KMA.Text = "Закрыть";
            buttonCloseManual_KMA.UseVisualStyleBackColor = true;
            // 
            // FormManual_KMA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseManual_KMA);
            Controls.Add(richTextBoxManual_KMA);
            Name = "FormManual_KMA";
            Text = "Руководство";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxManual_KMA;
        private Button buttonCloseManual_KMA;
    }
}