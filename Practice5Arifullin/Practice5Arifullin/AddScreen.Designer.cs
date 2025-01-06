namespace Practice5
{
    partial class AddScreen
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
            this.btnSaveScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.textBoxDiagonal = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFrequence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveScreen
            // 
            this.btnSaveScreen.Location = new System.Drawing.Point(424, 414);
            this.btnSaveScreen.Name = "btnSaveScreen";
            this.btnSaveScreen.Size = new System.Drawing.Size(192, 39);
            this.btnSaveScreen.TabIndex = 0;
            this.btnSaveScreen.Text = "Сохранить экран";
            this.btnSaveScreen.UseVisualStyleBackColor = true;
            this.btnSaveScreen.Click += new System.EventHandler(this.btnSaveScreen_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(173, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фирма";
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
            this.label2.Text = "Цвет";
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
            this.label7.Text = "Цена";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(173, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Диагональ";
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Location = new System.Drawing.Point(582, 127);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(200, 33);
            this.comboBoxColour.TabIndex = 24;
            // 
            // textBoxDiagonal
            // 
            this.textBoxDiagonal.Location = new System.Drawing.Point(582, 203);
            this.textBoxDiagonal.Name = "textBoxDiagonal";
            this.textBoxDiagonal.Size = new System.Drawing.Size(200, 31);
            this.textBoxDiagonal.TabIndex = 19;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(582, 240);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(200, 31);
            this.textBoxHeight.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(173, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Высота";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(582, 277);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(200, 31);
            this.textBoxWidth.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ширина";
            // 
            // textBoxFrequence
            // 
            this.textBoxFrequence.Location = new System.Drawing.Point(582, 314);
            this.textBoxFrequence.Name = "textBoxFrequence";
            this.textBoxFrequence.Size = new System.Drawing.Size(200, 31);
            this.textBoxFrequence.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(173, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Частота";
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 777);
            this.Controls.Add(this.textBoxFrequence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxColour);
            this.Controls.Add(this.textBoxDiagonal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveScreen);
            this.Name = "AddScreen";
            this.Text = "Экран";
            this.Load += new System.EventHandler(this.AddScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxColour;
        private System.Windows.Forms.TextBox textBoxDiagonal;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFrequence;
        private System.Windows.Forms.Label label5;
    }
}