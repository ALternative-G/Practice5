namespace Practice5
{
    partial class AddCompTech
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
            this.btnSaveComponent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveComponent
            // 
            this.btnSaveComponent.Location = new System.Drawing.Point(424, 414);
            this.btnSaveComponent.Name = "btnSaveComponent";
            this.btnSaveComponent.Size = new System.Drawing.Size(192, 39);
            this.btnSaveComponent.TabIndex = 0;
            this.btnSaveComponent.Text = "Сохранить коспонент";
            this.btnSaveComponent.UseVisualStyleBackColor = true;
            this.btnSaveComponent.Click += new System.EventHandler(this.btnSaveComponent_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(173, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фирма";
            // 
            // textBoxFirm
            // 
            this.textBoxFirm.Location = new System.Drawing.Point(582, 181);
            this.textBoxFirm.Name = "textBoxFirm";
            this.textBoxFirm.Size = new System.Drawing.Size(200, 31);
            this.textBoxFirm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(582, 257);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 31);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(173, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Цена";
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Location = new System.Drawing.Point(582, 218);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(200, 33);
            this.comboBoxColour.TabIndex = 24;
            // 
            // AddCompTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 777);
            this.Controls.Add(this.comboBoxColour);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveComponent);
            this.Name = "AddCompTech";
            this.Text = "Компонент компьютера";
            this.Load += new System.EventHandler(this.AddCompTech_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxColour;
    }
}