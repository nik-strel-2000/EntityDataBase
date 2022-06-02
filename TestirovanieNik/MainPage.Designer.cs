namespace TestirovanieNik
{
    partial class MainPage
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.AddBt = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SoursTx = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 29;
            this.dataGridViewProduct.Size = new System.Drawing.Size(610, 315);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewProduct_RowPrePaint);
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(53, 372);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(94, 29);
            this.AddBt.TabIndex = 1;
            this.AddBt.Text = "Добавить";
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddTx_Click);
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(232, 370);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(94, 29);
            this.EditBt.TabIndex = 2;
            this.EditBt.Text = "Изменить";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditTx_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(415, 369);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(94, 29);
            this.DeleteBt.TabIndex = 3;
            this.DeleteBt.Text = "Удалить";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteTx_Click);
            // 
            // SoursTx
            // 
            this.SoursTx.Location = new System.Drawing.Point(628, 40);
            this.SoursTx.Name = "SoursTx";
            this.SoursTx.PlaceholderText = "Поиск";
            this.SoursTx.Size = new System.Drawing.Size(125, 27);
            this.SoursTx.TabIndex = 4;
            this.SoursTx.TextChanged += new System.EventHandler(this.SoursTx_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(628, 101);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxType.TabIndex = 5;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Location = new System.Drawing.Point(628, 149);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(114, 24);
            this.checkBoxSort.TabIndex = 6;
            this.checkBoxSort.Text = "Сортировка";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            this.checkBoxSort.CheckedChanged += new System.EventHandler(this.checkBoxSort_CheckedChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxSort);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.SoursTx);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "MainPage";
            this.Text = "Главня страница";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewProduct;
        public Button DeleteBt;
        private TextBox SoursTx;
        private ComboBox comboBoxType;
        private CheckBox checkBoxSort;
        public Button AddBt;
        public Button EditBt;
    }
}