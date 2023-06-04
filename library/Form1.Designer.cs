namespace library
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.request1 = new System.Windows.Forms.Button();
            this.request2 = new System.Windows.Forms.Button();
            this.request3 = new System.Windows.Forms.Button();
            this.request4 = new System.Windows.Forms.Button();
            this.request5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AllDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(730, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Запрос 1. Найти автора, у которого книга имеет самый ранний год издания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Запрос2.  Найти все книги, изданные более одного раза";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(837, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Запрос 3.  Найти все книги, изданные в заданном издательстве за последние десять " +
    "лет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Запрос 4.  Найти все книги заданного автора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(679, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Запрос 5.  Найти все книги, цена которых превышает заданную сумму";
            // 
            // request1
            // 
            this.request1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request1.Location = new System.Drawing.Point(880, 96);
            this.request1.Name = "request1";
            this.request1.Size = new System.Drawing.Size(194, 40);
            this.request1.TabIndex = 9;
            this.request1.Text = "Запрос";
            this.request1.UseVisualStyleBackColor = true;
            this.request1.Click += new System.EventHandler(this.request1_Click);
            // 
            // request2
            // 
            this.request2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request2.Location = new System.Drawing.Point(880, 142);
            this.request2.Name = "request2";
            this.request2.Size = new System.Drawing.Size(194, 40);
            this.request2.TabIndex = 10;
            this.request2.Text = "Запрос";
            this.request2.UseVisualStyleBackColor = true;
            this.request2.Click += new System.EventHandler(this.request2_Click);
            // 
            // request3
            // 
            this.request3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request3.Location = new System.Drawing.Point(880, 188);
            this.request3.Name = "request3";
            this.request3.Size = new System.Drawing.Size(194, 40);
            this.request3.TabIndex = 11;
            this.request3.Text = "Запрос";
            this.request3.UseVisualStyleBackColor = true;
            this.request3.Click += new System.EventHandler(this.request3_Click);
            // 
            // request4
            // 
            this.request4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request4.Location = new System.Drawing.Point(880, 234);
            this.request4.Name = "request4";
            this.request4.Size = new System.Drawing.Size(194, 40);
            this.request4.TabIndex = 12;
            this.request4.Text = "Запрос";
            this.request4.UseVisualStyleBackColor = true;
            this.request4.Click += new System.EventHandler(this.request4_Click);
            // 
            // request5
            // 
            this.request5.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request5.Location = new System.Drawing.Point(880, 280);
            this.request5.Name = "request5";
            this.request5.Size = new System.Drawing.Size(194, 40);
            this.request5.TabIndex = 13;
            this.request5.Text = "Запрос";
            this.request5.UseVisualStyleBackColor = true;
            this.request5.Click += new System.EventHandler(this.request5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.Location = new System.Drawing.Point(41, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Все базы данных";
            // 
            // AllDB
            // 
            this.AllDB.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDB.Location = new System.Drawing.Point(880, 35);
            this.AllDB.Name = "AllDB";
            this.AllDB.Size = new System.Drawing.Size(194, 40);
            this.AllDB.TabIndex = 15;
            this.AllDB.Text = "Просмотреть";
            this.AllDB.UseVisualStyleBackColor = true;
            this.AllDB.Click += new System.EventHandler(this.AllDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 349);
            this.Controls.Add(this.AllDB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.request5);
            this.Controls.Add(this.request4);
            this.Controls.Add(this.request3);
            this.Controls.Add(this.request2);
            this.Controls.Add(this.request1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button request1;
        private System.Windows.Forms.Button request2;
        private System.Windows.Forms.Button request3;
        private System.Windows.Forms.Button request4;
        private System.Windows.Forms.Button request5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AllDB;
    }
}

