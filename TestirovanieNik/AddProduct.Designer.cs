namespace TestirovanieNik
{
    partial class AddProduct
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
            this.NameProductTx = new System.Windows.Forms.TextBox();
            this.PriceProductTx = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.AddBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameProductTx
            // 
            this.NameProductTx.Location = new System.Drawing.Point(114, 99);
            this.NameProductTx.Name = "NameProductTx";
            this.NameProductTx.Size = new System.Drawing.Size(151, 27);
            this.NameProductTx.TabIndex = 0;
            this.NameProductTx.TextChanged += new System.EventHandler(this.NameProductTx_TextChanged);
            // 
            // PriceProductTx
            // 
            this.PriceProductTx.Location = new System.Drawing.Point(114, 163);
            this.PriceProductTx.Mask = "00000.00";
            this.PriceProductTx.Name = "PriceProductTx";
            this.PriceProductTx.Size = new System.Drawing.Size(150, 27);
            this.PriceProductTx.TabIndex = 1;
            this.PriceProductTx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PriceProductTx_MaskInputRejected);
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(115, 236);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTypeProduct.TabIndex = 2;
            this.comboBoxTypeProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeProduct_SelectedIndexChanged);
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(146, 307);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(94, 29);
            this.AddBt.TabIndex = 3;
            this.AddBt.Text = "Добавить";
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 527);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.comboBoxTypeProduct);
            this.Controls.Add(this.PriceProductTx);
            this.Controls.Add(this.NameProductTx);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameProductTx;
        private MaskedTextBox PriceProductTx;
        private ComboBox comboBoxTypeProduct;
        private Button AddBt;
    }
}