namespace GUICurrencyConverterByDeyan
{
    partial class ConversionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.currency = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(158, 23);
            this.numericUpDownAmount.TabIndex = 1;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(257, 14);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(48, 15);
            this.currency.TabIndex = 2;
            this.currency.Text = "BGN to ";
            this.currency.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 50);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(233, 25);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(176, 12);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Convert";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ConvertCurrency);
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(302, 11);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCurrency.TabIndex = 5;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 507);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.numericUpDownAmount);
            this.Name = "ConversionForm";
            this.Text = "CurrencyConverterByDeyan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private Label currency;
        private Label resultLabel;
        private Button resultButton;
        private ComboBox comboBoxCurrency;
    }
}