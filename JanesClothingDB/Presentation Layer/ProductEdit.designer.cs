namespace JanesClothingDB
{
    partial class frmProductEdit
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.gbProductDescription = new System.Windows.Forms.GroupBox();
            this.lblColourFast = new System.Windows.Forms.Label();
            this.cbColourFast = new System.Windows.Forms.CheckBox();
            this.rbUnisex = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.cbBrandID = new System.Windows.Forms.ComboBox();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbProductDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(42, 65);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(82, 18);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(153, 62);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(199, 24);
            this.txtProductID.TabIndex = 0;
            // 
            // gbProductDescription
            // 
            this.gbProductDescription.Controls.Add(this.lblColourFast);
            this.gbProductDescription.Controls.Add(this.cbColourFast);
            this.gbProductDescription.Controls.Add(this.rbUnisex);
            this.gbProductDescription.Controls.Add(this.rbFemale);
            this.gbProductDescription.Controls.Add(this.rbMale);
            this.gbProductDescription.Controls.Add(this.lblGender);
            this.gbProductDescription.Controls.Add(this.txtPrice);
            this.gbProductDescription.Controls.Add(this.lblPrice);
            this.gbProductDescription.Controls.Add(this.txtProductDescription);
            this.gbProductDescription.Controls.Add(this.lblProductDescription);
            this.gbProductDescription.Controls.Add(this.cbBrandID);
            this.gbProductDescription.Controls.Add(this.lblBrandID);
            this.gbProductDescription.Location = new System.Drawing.Point(45, 139);
            this.gbProductDescription.Name = "gbProductDescription";
            this.gbProductDescription.Size = new System.Drawing.Size(453, 261);
            this.gbProductDescription.TabIndex = 2;
            this.gbProductDescription.TabStop = false;
            this.gbProductDescription.Text = "Product Description";
            // 
            // lblColourFast
            // 
            this.lblColourFast.AutoSize = true;
            this.lblColourFast.Location = new System.Drawing.Point(50, 221);
            this.lblColourFast.Name = "lblColourFast";
            this.lblColourFast.Size = new System.Drawing.Size(90, 18);
            this.lblColourFast.TabIndex = 13;
            this.lblColourFast.Text = "Colour Fast:";
            // 
            // cbColourFast
            // 
            this.cbColourFast.AutoSize = true;
            this.cbColourFast.Enabled = false;
            this.cbColourFast.Location = new System.Drawing.Point(227, 223);
            this.cbColourFast.Name = "cbColourFast";
            this.cbColourFast.Size = new System.Drawing.Size(18, 17);
            this.cbColourFast.TabIndex = 6;
            this.cbColourFast.UseVisualStyleBackColor = true;
            // 
            // rbUnisex
            // 
            this.rbUnisex.AutoSize = true;
            this.rbUnisex.Enabled = false;
            this.rbUnisex.Location = new System.Drawing.Point(352, 176);
            this.rbUnisex.Name = "rbUnisex";
            this.rbUnisex.Size = new System.Drawing.Size(74, 22);
            this.rbUnisex.TabIndex = 5;
            this.rbUnisex.TabStop = true;
            this.rbUnisex.Text = "Unisex";
            this.rbUnisex.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(296, 176);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(38, 22);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "F";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(227, 176);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(42, 22);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "M";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(50, 178);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 18);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(227, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 24);
            this.txtPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 135);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Enabled = false;
            this.txtProductDescription.Location = new System.Drawing.Point(227, 89);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(199, 24);
            this.txtProductDescription.TabIndex = 1;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(50, 92);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(143, 18);
            this.lblProductDescription.TabIndex = 4;
            this.lblProductDescription.Text = "Product Description:";
            // 
            // cbBrandID
            // 
            this.cbBrandID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandID.Enabled = false;
            this.cbBrandID.FormattingEnabled = true;
            this.cbBrandID.Location = new System.Drawing.Point(227, 46);
            this.cbBrandID.Name = "cbBrandID";
            this.cbBrandID.Size = new System.Drawing.Size(199, 26);
            this.cbBrandID.TabIndex = 0;
            // 
            // lblBrandID
            // 
            this.lblBrandID.AutoSize = true;
            this.lblBrandID.Location = new System.Drawing.Point(50, 49);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(69, 18);
            this.lblBrandID.TabIndex = 2;
            this.lblBrandID.Text = "Brand ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(381, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(244, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(105, 430);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 506);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbProductDescription);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProductID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProductEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductEdit_FormClosing);
            this.gbProductDescription.ResumeLayout(false);
            this.gbProductDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.GroupBox gbProductDescription;
        private System.Windows.Forms.Label lblColourFast;
        private System.Windows.Forms.CheckBox cbColourFast;
        private System.Windows.Forms.RadioButton rbUnisex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.ComboBox cbBrandID;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}