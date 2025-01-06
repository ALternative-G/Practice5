namespace Practice5
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPrint = new System.Windows.Forms.TextBox();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.buttonAddKeyboard = new System.Windows.Forms.Button();
            this.buttonAddScreen = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrint
            // 
            this.textBoxPrint.Location = new System.Drawing.Point(21, 12);
            this.textBoxPrint.Multiline = true;
            this.textBoxPrint.Name = "textBoxPrint";
            this.textBoxPrint.Size = new System.Drawing.Size(590, 920);
            this.textBoxPrint.TabIndex = 0;
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(748, 51);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(256, 57);
            this.buttonAddComponent.TabIndex = 1;
            this.buttonAddComponent.Text = "Добавить компонент";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.buttonAddComponent_Click);
            // 
            // buttonAddKeyboard
            // 
            this.buttonAddKeyboard.Location = new System.Drawing.Point(748, 132);
            this.buttonAddKeyboard.Name = "buttonAddKeyboard";
            this.buttonAddKeyboard.Size = new System.Drawing.Size(256, 57);
            this.buttonAddKeyboard.TabIndex = 2;
            this.buttonAddKeyboard.Text = "Добавить клавиатуру";
            this.buttonAddKeyboard.UseVisualStyleBackColor = true;
            this.buttonAddKeyboard.Click += new System.EventHandler(this.buttonAddKeyboard_Click);
            // 
            // buttonAddScreen
            // 
            this.buttonAddScreen.Location = new System.Drawing.Point(748, 216);
            this.buttonAddScreen.Name = "buttonAddScreen";
            this.buttonAddScreen.Size = new System.Drawing.Size(256, 57);
            this.buttonAddScreen.TabIndex = 3;
            this.buttonAddScreen.Text = "Добавить экран";
            this.buttonAddScreen.UseVisualStyleBackColor = true;
            this.buttonAddScreen.Click += new System.EventHandler(this.buttonAddScreen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(748, 767);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(256, 57);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить по индексу";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(748, 684);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(256, 31);
            this.textBoxDelete.TabIndex = 5;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(748, 439);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(256, 57);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Обновить данные";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 956);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddScreen);
            this.Controls.Add(this.buttonAddKeyboard);
            this.Controls.Add(this.buttonAddComponent);
            this.Controls.Add(this.textBoxPrint);
            this.Name = "Form1";
            this.Text = "Основная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrint;
        private System.Windows.Forms.Button buttonAddComponent;
        private System.Windows.Forms.Button buttonAddKeyboard;
        private System.Windows.Forms.Button buttonAddScreen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

