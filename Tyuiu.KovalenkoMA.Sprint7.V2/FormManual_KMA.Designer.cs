namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    partial class FormManual_KMA
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox richTextBoxManual_KMA;
        private Button buttonCloseManual_KMA;
        private Panel panelHeader_KMA;
        private Label labelTitle_KMA;
        private Panel panelFooter_KMA;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual_KMA));
            this.richTextBoxManual_KMA = new System.Windows.Forms.RichTextBox();
            this.buttonCloseManual_KMA = new System.Windows.Forms.Button();
            this.panelHeader_KMA = new System.Windows.Forms.Panel();
            this.labelTitle_KMA = new System.Windows.Forms.Label();
            this.panelFooter_KMA = new System.Windows.Forms.Panel();
            this.panelHeader_KMA.SuspendLayout();
            this.panelFooter_KMA.SuspendLayout();
            this.SuspendLayout();

            // panelHeader_KMA
            this.panelHeader_KMA.BackColor = Color.DarkBlue;
            this.panelHeader_KMA.Controls.Add(this.labelTitle_KMA);
            this.panelHeader_KMA.Dock = DockStyle.Top;
            this.panelHeader_KMA.Location = new Point(0, 0);
            this.panelHeader_KMA.Name = "panelHeader_KMA";
            this.panelHeader_KMA.Size = new Size(850, 70);
            this.panelHeader_KMA.TabIndex = 0;

            // labelTitle_KMA
            this.labelTitle_KMA.Dock = DockStyle.Fill;
            this.labelTitle_KMA.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitle_KMA.ForeColor = Color.White;
            this.labelTitle_KMA.Location = new Point(0, 0);
            this.labelTitle_KMA.Name = "labelTitle_KMA";
            this.labelTitle_KMA.Size = new Size(850, 70);
            this.labelTitle_KMA.TabIndex = 0;
            this.labelTitle_KMA.Text = "РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ";
            this.labelTitle_KMA.TextAlign = ContentAlignment.MiddleCenter;

            // richTextBoxManual_KMA
            this.richTextBoxManual_KMA.BorderStyle = BorderStyle.None;
            this.richTextBoxManual_KMA.Dock = DockStyle.Fill;
            this.richTextBoxManual_KMA.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.richTextBoxManual_KMA.Location = new Point(0, 70);
            this.richTextBoxManual_KMA.Name = "richTextBoxManual_KMA";
            this.richTextBoxManual_KMA.ReadOnly = true;
            this.richTextBoxManual_KMA.Size = new Size(850, 480);
            this.richTextBoxManual_KMA.TabIndex = 1;
            this.richTextBoxManual_KMA.Text = "";

            // panelFooter_KMA
            this.panelFooter_KMA.BackColor = Color.FromArgb(240, 240, 240);
            this.panelFooter_KMA.Controls.Add(this.buttonCloseManual_KMA);
            this.panelFooter_KMA.Dock = DockStyle.Bottom;
            this.panelFooter_KMA.Location = new Point(0, 550);
            this.panelFooter_KMA.Name = "panelFooter_KMA";
            this.panelFooter_KMA.Size = new Size(850, 50);
            this.panelFooter_KMA.TabIndex = 2;

            // buttonCloseManual_KMA
            this.buttonCloseManual_KMA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.buttonCloseManual_KMA.BackColor = Color.SteelBlue;
            this.buttonCloseManual_KMA.FlatStyle = FlatStyle.Flat;
            this.buttonCloseManual_KMA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.buttonCloseManual_KMA.ForeColor = Color.White;
            this.buttonCloseManual_KMA.Location = new Point(730, 10);
            this.buttonCloseManual_KMA.Name = "buttonCloseManual_KMA";
            this.buttonCloseManual_KMA.Size = new Size(100, 30);
            this.buttonCloseManual_KMA.TabIndex = 0;
            this.buttonCloseManual_KMA.Text = "Закрыть";
            this.buttonCloseManual_KMA.UseVisualStyleBackColor = false;
            this.buttonCloseManual_KMA.Click += new EventHandler(this.buttonCloseManual_KMA_Click);

            // FormManual_KMA
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(850, 600);
            this.Controls.Add(this.richTextBoxManual_KMA);
            this.Controls.Add(this.panelFooter_KMA);
            this.Controls.Add(this.panelHeader_KMA);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManual_KMA";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя | Сеть магазинов";
            this.panelHeader_KMA.ResumeLayout(false);
            this.panelFooter_KMA.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}