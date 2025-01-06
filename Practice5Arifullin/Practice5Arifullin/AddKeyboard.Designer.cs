namespace Practice5
{
    partial class AddKeyboard
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
            this.btnSaveKeyboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDurability = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveKeyboard
            // 
            this.btnSaveKeyboard.Location = new System.Drawing.Point(424, 414);
            this.btnSaveKeyboard.Name = "btnSaveKeyboard";
            this.btnSaveKeyboard.Size = new System.Drawing.Size(192, 39);
            this.btnSaveKeyboard.TabIndex = 0;
            this.btnSaveKeyboard.Text = "Save keyboard";
            this.btnSaveKeyboard.UseVisualStyleBackColor = true;
            this.btnSaveKeyboard.Click += new System.EventHandler(this.btnSaveKeyboard_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(173, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firm";
            // 
            // textBoxFirm
            // 
            this.textBoxFirm.Location = new System.Drawing.Point(582, 90);
            this.textBoxFirm.Name = "textBoxFirm";
            this.textBoxFirm.Size = new System.Drawing.Size(200, 31);
            this.textBoxFirm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colour";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(582, 166);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 31);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(173, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price";
            // 
            // textBoxDurability
            // 
            this.textBoxDurability.Location = new System.Drawing.Point(582, 320);
            this.textBoxDurability.Name = "textBoxDurability";
            this.textBoxDurability.Size = new System.Drawing.Size(200, 31);
            this.textBoxDurability.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(173, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Durability";
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Location = new System.Drawing.Point(582, 127);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(200, 33);
            this.comboBoxColour.TabIndex = 24;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(582, 203);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(200, 33);
            this.comboBoxType.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(173, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Type";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(582, 242);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(200, 33);
            this.comboBoxFormat.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Format";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(582, 281);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(200, 33);
            this.comboBoxSize.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(173, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Size";
            // 
            // AddKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 777);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxColour);
            this.Controls.Add(this.textBoxDurability);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveKeyboard);
            this.Name = "AddKeyboard";
            this.Text = "Add keyboard";
            this.Load += new System.EventHandler(this.AddKeyboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveKeyboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDurability;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxColour;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label5;
    }
}