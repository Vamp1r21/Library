
namespace LibraryV2._0
{
    partial class InformationForm
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
            this.InforomationLb = new System.Windows.Forms.ListBox();
            this.YearPublicTb = new System.Windows.Forms.TextBox();
            this.YearPublicLb = new System.Windows.Forms.Label();
            this.MoreYearBtn = new System.Windows.Forms.Button();
            this.LessYearBtn = new System.Windows.Forms.Button();
            this.AuthorElemTb = new System.Windows.Forms.TextBox();
            this.AuthorElemBtn = new System.Windows.Forms.Button();
            this.AuthorElemLb = new System.Windows.Forms.Label();
            this.TitleElemLb = new System.Windows.Forms.Label();
            this.TitleElemBtn = new System.Windows.Forms.Button();
            this.TitleElemTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InforomationLb
            // 
            this.InforomationLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InforomationLb.FormattingEnabled = true;
            this.InforomationLb.ItemHeight = 38;
            this.InforomationLb.Location = new System.Drawing.Point(13, 13);
            this.InforomationLb.Name = "InforomationLb";
            this.InforomationLb.Size = new System.Drawing.Size(406, 688);
            this.InforomationLb.TabIndex = 0;
            // 
            // YearPublicTb
            // 
            this.YearPublicTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearPublicTb.Location = new System.Drawing.Point(451, 70);
            this.YearPublicTb.Name = "YearPublicTb";
            this.YearPublicTb.Size = new System.Drawing.Size(491, 38);
            this.YearPublicTb.TabIndex = 1;
            // 
            // YearPublicLb
            // 
            this.YearPublicLb.AutoSize = true;
            this.YearPublicLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearPublicLb.Location = new System.Drawing.Point(611, 35);
            this.YearPublicLb.Name = "YearPublicLb";
            this.YearPublicLb.Size = new System.Drawing.Size(176, 32);
            this.YearPublicLb.TabIndex = 2;
            this.YearPublicLb.Text = "Введите год";
            // 
            // MoreYearBtn
            // 
            this.MoreYearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreYearBtn.Location = new System.Drawing.Point(451, 137);
            this.MoreYearBtn.Name = "MoreYearBtn";
            this.MoreYearBtn.Size = new System.Drawing.Size(238, 124);
            this.MoreYearBtn.TabIndex = 3;
            this.MoreYearBtn.Text = "Книги младше введенного года";
            this.MoreYearBtn.UseVisualStyleBackColor = true;
            this.MoreYearBtn.Click += new System.EventHandler(this.MoreYearBtn_Click);
            // 
            // LessYearBtn
            // 
            this.LessYearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessYearBtn.Location = new System.Drawing.Point(704, 137);
            this.LessYearBtn.Name = "LessYearBtn";
            this.LessYearBtn.Size = new System.Drawing.Size(238, 124);
            this.LessYearBtn.TabIndex = 4;
            this.LessYearBtn.Text = "Книги старше введенного года";
            this.LessYearBtn.UseVisualStyleBackColor = true;
            this.LessYearBtn.Click += new System.EventHandler(this.LessYearBtn_Click);
            // 
            // AuthorElemTb
            // 
            this.AuthorElemTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorElemTb.Location = new System.Drawing.Point(451, 318);
            this.AuthorElemTb.Name = "AuthorElemTb";
            this.AuthorElemTb.Size = new System.Drawing.Size(491, 38);
            this.AuthorElemTb.TabIndex = 5;
            // 
            // AuthorElemBtn
            // 
            this.AuthorElemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorElemBtn.Location = new System.Drawing.Point(451, 362);
            this.AuthorElemBtn.Name = "AuthorElemBtn";
            this.AuthorElemBtn.Size = new System.Drawing.Size(491, 124);
            this.AuthorElemBtn.TabIndex = 6;
            this.AuthorElemBtn.Text = "Информация о введенной части авторе";
            this.AuthorElemBtn.UseVisualStyleBackColor = true;
            this.AuthorElemBtn.Click += new System.EventHandler(this.AuthorElemBtn_Click);
            // 
            // AuthorElemLb
            // 
            this.AuthorElemLb.AutoSize = true;
            this.AuthorElemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorElemLb.Location = new System.Drawing.Point(484, 283);
            this.AuthorElemLb.Name = "AuthorElemLb";
            this.AuthorElemLb.Size = new System.Drawing.Size(435, 32);
            this.AuthorElemLb.TabIndex = 7;
            this.AuthorElemLb.Text = "Введите часть фамилии автора";
            // 
            // TitleElemLb
            // 
            this.TitleElemLb.AutoSize = true;
            this.TitleElemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleElemLb.Location = new System.Drawing.Point(493, 498);
            this.TitleElemLb.Name = "TitleElemLb";
            this.TitleElemLb.Size = new System.Drawing.Size(417, 32);
            this.TitleElemLb.TabIndex = 10;
            this.TitleElemLb.Text = "Введите часть названия книги";
            // 
            // TitleElemBtn
            // 
            this.TitleElemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleElemBtn.Location = new System.Drawing.Point(451, 577);
            this.TitleElemBtn.Name = "TitleElemBtn";
            this.TitleElemBtn.Size = new System.Drawing.Size(491, 124);
            this.TitleElemBtn.TabIndex = 9;
            this.TitleElemBtn.Text = "Информация о введенной части книги";
            this.TitleElemBtn.UseVisualStyleBackColor = true;
            this.TitleElemBtn.Click += new System.EventHandler(this.TitleElemBtn_Click);
            // 
            // TitleElemTb
            // 
            this.TitleElemTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleElemTb.Location = new System.Drawing.Point(451, 533);
            this.TitleElemTb.Name = "TitleElemTb";
            this.TitleElemTb.Size = new System.Drawing.Size(491, 38);
            this.TitleElemTb.TabIndex = 8;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 711);
            this.Controls.Add(this.TitleElemLb);
            this.Controls.Add(this.TitleElemBtn);
            this.Controls.Add(this.TitleElemTb);
            this.Controls.Add(this.AuthorElemLb);
            this.Controls.Add(this.AuthorElemBtn);
            this.Controls.Add(this.AuthorElemTb);
            this.Controls.Add(this.LessYearBtn);
            this.Controls.Add(this.MoreYearBtn);
            this.Controls.Add(this.YearPublicLb);
            this.Controls.Add(this.YearPublicTb);
            this.Controls.Add(this.InforomationLb);
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InforomationLb;
        private System.Windows.Forms.TextBox YearPublicTb;
        private System.Windows.Forms.Label YearPublicLb;
        private System.Windows.Forms.Button MoreYearBtn;
        private System.Windows.Forms.Button LessYearBtn;
        private System.Windows.Forms.TextBox AuthorElemTb;
        private System.Windows.Forms.Button AuthorElemBtn;
        private System.Windows.Forms.Label AuthorElemLb;
        private System.Windows.Forms.Label TitleElemLb;
        private System.Windows.Forms.Button TitleElemBtn;
        private System.Windows.Forms.TextBox TitleElemTb;
    }
}

