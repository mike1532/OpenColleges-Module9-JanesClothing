namespace JanesClothingDB.Presentation_Layer
{
    partial class frmProductSearch
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
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbProductDescription = new System.Windows.Forms.RadioButton();
            this.rbBrand = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.lbBrands = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(36, 41);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(107, 22);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "List all rows";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Click += new System.EventHandler(this.rbAll_Click);
            // 
            // rbProductDescription
            // 
            this.rbProductDescription.AutoSize = true;
            this.rbProductDescription.Location = new System.Drawing.Point(36, 110);
            this.rbProductDescription.Name = "rbProductDescription";
            this.rbProductDescription.Size = new System.Drawing.Size(225, 22);
            this.rbProductDescription.TabIndex = 1;
            this.rbProductDescription.Text = "Search by product description";
            this.rbProductDescription.UseVisualStyleBackColor = true;
            this.rbProductDescription.Click += new System.EventHandler(this.rbDescription_Click);
            // 
            // rbBrand
            // 
            this.rbBrand.AutoSize = true;
            this.rbBrand.Location = new System.Drawing.Point(36, 179);
            this.rbBrand.Name = "rbBrand";
            this.rbBrand.Size = new System.Drawing.Size(136, 22);
            this.rbBrand.TabIndex = 2;
            this.rbBrand.Text = "Search by brand";
            this.rbBrand.UseVisualStyleBackColor = true;
            this.rbBrand.Click += new System.EventHandler(this.rbBrand_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(299, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 24);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Visible = false;
            // 
            // cbBrands
            // 
            this.cbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Location = new System.Drawing.Point(299, 106);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(241, 26);
            this.cbBrands.TabIndex = 4;
            this.cbBrands.Visible = false;
            // 
            // lbBrands
            // 
            this.lbBrands.FormattingEnabled = true;
            this.lbBrands.ItemHeight = 18;
            this.lbBrands.Location = new System.Drawing.Point(550, 110);
            this.lbBrands.Name = "lbBrands";
            this.lbBrands.Size = new System.Drawing.Size(20, 22);
            this.lbBrands.TabIndex = 5;
            this.lbBrands.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 240);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 298);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbBrands);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbBrand);
            this.Controls.Add(this.rbProductDescription);
            this.Controls.Add(this.rbAll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProductSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.frmProductSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbProductDescription;
        private System.Windows.Forms.RadioButton rbBrand;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.ListBox lbBrands;
        private System.Windows.Forms.Button btnSearch;
    }
}