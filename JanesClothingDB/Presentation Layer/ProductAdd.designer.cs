namespace JanesClothingDB
{
    partial class frmProductAdd
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
            this.lblBrandID = new System.Windows.Forms.Label();
            this.cbBrandID = new System.Windows.Forms.ComboBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbBrandID = new System.Windows.Forms.ListBox();
            this.gbProductDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(44, 66);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(82, 18);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(221, 63);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(199, 24);
            this.txtProductID.TabIndex = 0;
            // 
            // lblBrandID
            // 
            this.lblBrandID.AutoSize = true;
            this.lblBrandID.Location = new System.Drawing.Point(44, 109);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(69, 18);
            this.lblBrandID.TabIndex = 2;
            this.lblBrandID.Text = "Brand ID:";
            // 
            // cbBrandID
            // 
            this.cbBrandID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandID.FormattingEnabled = true;
            this.cbBrandID.Location = new System.Drawing.Point(221, 106);
            this.cbBrandID.Name = "cbBrandID";
            this.cbBrandID.Size = new System.Drawing.Size(199, 26);
            this.cbBrandID.TabIndex = 1;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(44, 152);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(143, 18);
            this.lblProductDescription.TabIndex = 4;
            this.lblProductDescription.Text = "Product Description:";
            // 
            // gbProductDescription
            // 
            this.gbProductDescription.Controls.Add(this.lbBrandID);
            this.gbProductDescription.Controls.Add(this.lblColourFast);
            this.gbProductDescription.Controls.Add(this.cbColourFast);
            this.gbProductDescription.Controls.Add(this.rbUnisex);
            this.gbProductDescription.Controls.Add(this.rbFemale);
            this.gbProductDescription.Controls.Add(this.rbMale);
            this.gbProductDescription.Controls.Add(this.lblGender);
            this.gbProductDescription.Controls.Add(this.txtPrice);
            this.gbProductDescription.Controls.Add(this.lblPrice);
            this.gbProductDescription.Controls.Add(this.txtProductDescription);
            this.gbProductDescription.Controls.Add(this.lblProductID);
            this.gbProductDescription.Controls.Add(this.lblProductDescription);
            this.gbProductDescription.Controls.Add(this.txtProductID);
            this.gbProductDescription.Controls.Add(this.cbBrandID);
            this.gbProductDescription.Controls.Add(this.lblBrandID);
            this.gbProductDescription.Location = new System.Drawing.Point(29, 37);
            this.gbProductDescription.Name = "gbProductDescription";
            this.gbProductDescription.Size = new System.Drawing.Size(514, 393);
            this.gbProductDescription.TabIndex = 0;
            this.gbProductDescription.TabStop = false;
            this.gbProductDescription.Text = "Product Description";
            // 
            // lblColourFast
            // 
            this.lblColourFast.AutoSize = true;
            this.lblColourFast.Location = new System.Drawing.Point(44, 281);
            this.lblColourFast.Name = "lblColourFast";
            this.lblColourFast.Size = new System.Drawing.Size(90, 18);
            this.lblColourFast.TabIndex = 13;
            this.lblColourFast.Text = "Colour Fast:";
            // 
            // cbColourFast
            // 
            this.cbColourFast.AutoSize = true;
            this.cbColourFast.Location = new System.Drawing.Point(221, 283);
            this.cbColourFast.Name = "cbColourFast";
            this.cbColourFast.Size = new System.Drawing.Size(18, 17);
            this.cbColourFast.TabIndex = 7;
            this.cbColourFast.UseVisualStyleBackColor = true;
            // 
            // rbUnisex
            // 
            this.rbUnisex.AutoSize = true;
            this.rbUnisex.Location = new System.Drawing.Point(346, 236);
            this.rbUnisex.Name = "rbUnisex";
            this.rbUnisex.Size = new System.Drawing.Size(74, 22);
            this.rbUnisex.TabIndex = 6;
            this.rbUnisex.TabStop = true;
            this.rbUnisex.Text = "Unisex";
            this.rbUnisex.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(290, 236);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(38, 22);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "F";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(221, 236);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(42, 22);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "M";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(44, 238);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 18);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(221, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(44, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(221, 149);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(199, 24);
            this.txtProductDescription.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(577, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 72);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(577, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 72);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(577, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 72);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbBrandID
            // 
            this.lbBrandID.FormattingEnabled = true;
            this.lbBrandID.ItemHeight = 18;
            this.lbBrandID.Location = new System.Drawing.Point(435, 110);
            this.lbBrandID.Name = "lbBrandID";
            this.lbBrandID.Size = new System.Drawing.Size(15, 22);
            this.lbBrandID.TabIndex = 14;
            this.lbBrandID.Visible = false;
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 489);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbProductDescription);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProductAdd";
            this.Text = "Add Product Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductDetails_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductDetails_FormClosed);
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.gbProductDescription.ResumeLayout(false);
            this.gbProductDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.ComboBox cbBrandID;
        private System.Windows.Forms.Label lblProductDescription;
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbBrandID;
    }
}