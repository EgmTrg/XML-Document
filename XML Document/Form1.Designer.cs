
namespace XML_Document
{
    partial class Form1
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
            this.filmAdi_label = new System.Windows.Forms.Label();
            this.filmAdi_textBox = new System.Windows.Forms.TextBox();
            this.filmTuru_comboBox = new System.Windows.Forms.ComboBox();
            this.yapimYili_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oyuncuEkle_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.filmTuru_label = new System.Windows.Forms.Label();
            this.yapimYili_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yonetmen_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.oyuncu_textBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filmEkle_button = new System.Windows.Forms.Button();
            this.dbToXML_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmAdi_label
            // 
            this.filmAdi_label.AutoSize = true;
            this.filmAdi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmAdi_label.Location = new System.Drawing.Point(12, 32);
            this.filmAdi_label.Name = "filmAdi_label";
            this.filmAdi_label.Size = new System.Drawing.Size(65, 20);
            this.filmAdi_label.TabIndex = 0;
            this.filmAdi_label.Text = "Film Adı";
            // 
            // filmAdi_textBox
            // 
            this.filmAdi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmAdi_textBox.Location = new System.Drawing.Point(12, 55);
            this.filmAdi_textBox.Name = "filmAdi_textBox";
            this.filmAdi_textBox.Size = new System.Drawing.Size(216, 26);
            this.filmAdi_textBox.TabIndex = 0;
            // 
            // filmTuru_comboBox
            // 
            this.filmTuru_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmTuru_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmTuru_comboBox.FormattingEnabled = true;
            this.filmTuru_comboBox.Items.AddRange(new object[] {
            "Aksiyon",
            "Gerilim",
            "Macera",
            "Komedi",
            "Bilim kurgu",
            "Romantik",
            "Romantik komedi",
            "Korku",
            "Dram"});
            this.filmTuru_comboBox.Location = new System.Drawing.Point(234, 53);
            this.filmTuru_comboBox.Name = "filmTuru_comboBox";
            this.filmTuru_comboBox.Size = new System.Drawing.Size(187, 28);
            this.filmTuru_comboBox.TabIndex = 1;
            // 
            // yapimYili_dateTimePicker
            // 
            this.yapimYili_dateTimePicker.CustomFormat = "yyyy";
            this.yapimYili_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapimYili_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yapimYili_dateTimePicker.Location = new System.Drawing.Point(427, 55);
            this.yapimYili_dateTimePicker.Name = "yapimYili_dateTimePicker";
            this.yapimYili_dateTimePicker.Size = new System.Drawing.Size(100, 26);
            this.yapimYili_dateTimePicker.TabIndex = 2;
            // 
            // oyuncuEkle_button
            // 
            this.oyuncuEkle_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.oyuncuEkle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oyuncuEkle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncuEkle_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oyuncuEkle_button.Location = new System.Drawing.Point(12, 156);
            this.oyuncuEkle_button.Name = "oyuncuEkle_button";
            this.oyuncuEkle_button.Size = new System.Drawing.Size(216, 37);
            this.oyuncuEkle_button.TabIndex = 7;
            this.oyuncuEkle_button.Text = "Oyuncu Ekle";
            this.oyuncuEkle_button.UseVisualStyleBackColor = false;
            this.oyuncuEkle_button.Click += new System.EventHandler(this.oyuncuEkle_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 404);
            this.listBox1.TabIndex = 6;
            // 
            // filmTuru_label
            // 
            this.filmTuru_label.AutoSize = true;
            this.filmTuru_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmTuru_label.Location = new System.Drawing.Point(234, 32);
            this.filmTuru_label.Name = "filmTuru_label";
            this.filmTuru_label.Size = new System.Drawing.Size(74, 20);
            this.filmTuru_label.TabIndex = 0;
            this.filmTuru_label.Text = "Film Türü";
            // 
            // yapimYili_label
            // 
            this.yapimYili_label.AutoSize = true;
            this.yapimYili_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapimYili_label.Location = new System.Drawing.Point(423, 32);
            this.yapimYili_label.Name = "yapimYili_label";
            this.yapimYili_label.Size = new System.Drawing.Size(78, 20);
            this.yapimYili_label.TabIndex = 0;
            this.yapimYili_label.Text = "Yapım Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(534, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yönetmen";
            // 
            // yonetmen_textBox
            // 
            this.yonetmen_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetmen_textBox.Location = new System.Drawing.Point(533, 55);
            this.yonetmen_textBox.Name = "yonetmen_textBox";
            this.yonetmen_textBox.Size = new System.Drawing.Size(217, 26);
            this.yonetmen_textBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(756, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "IMDB Puani";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(756, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuncu Adi";
            // 
            // oyuncu_textBox
            // 
            this.oyuncu_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu_textBox.Location = new System.Drawing.Point(12, 124);
            this.oyuncu_textBox.Name = "oyuncu_textBox";
            this.oyuncu_textBox.Size = new System.Drawing.Size(217, 26);
            this.oyuncu_textBox.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 486);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film Adı";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Türü";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapım Yılı";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yönetmen";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IMDB Puanı";
            this.columnHeader5.Width = 135;
            // 
            // filmEkle_button
            // 
            this.filmEkle_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmEkle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmEkle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmEkle_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filmEkle_button.Location = new System.Drawing.Point(856, 44);
            this.filmEkle_button.Name = "filmEkle_button";
            this.filmEkle_button.Size = new System.Drawing.Size(108, 37);
            this.filmEkle_button.TabIndex = 5;
            this.filmEkle_button.Text = "Film Ekle";
            this.filmEkle_button.UseVisualStyleBackColor = false;
            this.filmEkle_button.Click += new System.EventHandler(this.filmEkle_button_Click);
            // 
            // dbToXML_button
            // 
            this.dbToXML_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dbToXML_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbToXML_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbToXML_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dbToXML_button.Location = new System.Drawing.Point(856, 87);
            this.dbToXML_button.Name = "dbToXML_button";
            this.dbToXML_button.Size = new System.Drawing.Size(108, 31);
            this.dbToXML_button.TabIndex = 5;
            this.dbToXML_button.Text = "dbToXML";
            this.dbToXML_button.UseVisualStyleBackColor = false;
            this.dbToXML_button.Click += new System.EventHandler(this.dbToXML_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 624);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dbToXML_button);
            this.Controls.Add(this.filmEkle_button);
            this.Controls.Add(this.oyuncuEkle_button);
            this.Controls.Add(this.yapimYili_dateTimePicker);
            this.Controls.Add(this.filmTuru_comboBox);
            this.Controls.Add(this.oyuncu_textBox);
            this.Controls.Add(this.yonetmen_textBox);
            this.Controls.Add(this.filmAdi_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmTuru_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yapimYili_label);
            this.Controls.Add(this.filmAdi_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filmAdi_label;
        private System.Windows.Forms.TextBox filmAdi_textBox;
        private System.Windows.Forms.ComboBox filmTuru_comboBox;
        private System.Windows.Forms.DateTimePicker yapimYili_dateTimePicker;
        private System.Windows.Forms.Button oyuncuEkle_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label filmTuru_label;
        private System.Windows.Forms.Label yapimYili_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yonetmen_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oyuncu_textBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button filmEkle_button;
        private System.Windows.Forms.Button dbToXML_button;
    }
}

