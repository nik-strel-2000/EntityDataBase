namespace TestirovanieNik
{
    partial class EditProduct
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
            this.EditBt = new System.Windows.Forms.Button();
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.PriceProductTx = new System.Windows.Forms.MaskedTextBox();
            this.NameProductTx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(203, 341);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(94, 29);
            this.EditBt.TabIndex = 7;
            this.EditBt.Text = "Изменить";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(172, 270);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTypeProduct.TabIndex = 6;
            // 
            // PriceProductTx
            // 
            this.PriceProductTx.Location = new System.Drawing.Point(171, 197);
            this.PriceProductTx.Mask = "00000.00";
            this.PriceProductTx.Name = "PriceProductTx";
            this.PriceProductTx.Size = new System.Drawing.Size(150, 27);
            this.PriceProductTx.TabIndex = 5;
            // 
            // NameProductTx
            // 
            this.NameProductTx.Location = new System.Drawing.Point(171, 133);
            this.NameProductTx.Name = "NameProductTx";
            this.NameProductTx.Size = new System.Drawing.Size(151, 27);
            this.NameProductTx.TabIndex = 4;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 502);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.comboBoxTypeProduct);
            this.Controls.Add(this.PriceProductTx);
            this.Controls.Add(this.NameProductTx);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProduct_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EditBt;
        private ComboBox comboBoxTypeProduct;
        private MaskedTextBox PriceProductTx;
        private TextBox NameProductTx;
    }
}