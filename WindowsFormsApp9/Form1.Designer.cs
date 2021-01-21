namespace WindowsFormsApp9
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
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.lblnamaitem = new System.Windows.Forms.Label();
            this.lblkategori = new System.Windows.Forms.Label();
            this.grupboxpanel = new System.Windows.Forms.GroupBox();
            this.radioButtonminum = new System.Windows.Forms.RadioButton();
            this.radioButtonmakan = new System.Windows.Forms.RadioButton();
            this.buttoninput = new System.Windows.Forms.Button();
            this.buttonpindah = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.groupBoxfilter = new System.Windows.Forms.GroupBox();
            this.cBoxMinuman = new System.Windows.Forms.CheckBox();
            this.cBoxMakanan = new System.Windows.Forms.CheckBox();
            this.listBoxpertama = new System.Windows.Forms.ListBox();
            this.listBoxkedua = new System.Windows.Forms.ListBox();
            this.grupboxpanel.SuspendLayout();
            this.groupBoxfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(255, 31);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(223, 26);
            this.textBoxinput.TabIndex = 0;
            // 
            // lblnamaitem
            // 
            this.lblnamaitem.AutoSize = true;
            this.lblnamaitem.Location = new System.Drawing.Point(92, 31);
            this.lblnamaitem.Name = "lblnamaitem";
            this.lblnamaitem.Size = new System.Drawing.Size(91, 20);
            this.lblnamaitem.TabIndex = 1;
            this.lblnamaitem.Text = "Nama Item ";
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Location = new System.Drawing.Point(92, 94);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(68, 20);
            this.lblkategori.TabIndex = 2;
            this.lblkategori.Text = "Ketegori";
            // 
            // grupboxpanel
            // 
            this.grupboxpanel.Controls.Add(this.radioButtonminum);
            this.grupboxpanel.Controls.Add(this.radioButtonmakan);
            this.grupboxpanel.Location = new System.Drawing.Point(255, 63);
            this.grupboxpanel.Name = "grupboxpanel";
            this.grupboxpanel.Size = new System.Drawing.Size(454, 69);
            this.grupboxpanel.TabIndex = 3;
            this.grupboxpanel.TabStop = false;
            // 
            // radioButtonminum
            // 
            this.radioButtonminum.AutoSize = true;
            this.radioButtonminum.Location = new System.Drawing.Point(233, 25);
            this.radioButtonminum.Name = "radioButtonminum";
            this.radioButtonminum.Size = new System.Drawing.Size(99, 24);
            this.radioButtonminum.TabIndex = 1;
            this.radioButtonminum.TabStop = true;
            this.radioButtonminum.Text = "Minuman";
            this.radioButtonminum.UseVisualStyleBackColor = true;
            // 
            // radioButtonmakan
            // 
            this.radioButtonmakan.AutoSize = true;
            this.radioButtonmakan.Location = new System.Drawing.Point(27, 25);
            this.radioButtonmakan.Name = "radioButtonmakan";
            this.radioButtonmakan.Size = new System.Drawing.Size(100, 24);
            this.radioButtonmakan.TabIndex = 0;
            this.radioButtonmakan.TabStop = true;
            this.radioButtonmakan.Text = "Makanan";
            this.radioButtonmakan.UseVisualStyleBackColor = true;
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(255, 138);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(96, 31);
            this.buttoninput.TabIndex = 4;
            this.buttoninput.Text = "Input";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // buttonpindah
            // 
            this.buttonpindah.Location = new System.Drawing.Point(352, 210);
            this.buttonpindah.Name = "buttonpindah";
            this.buttonpindah.Size = new System.Drawing.Size(96, 31);
            this.buttonpindah.TabIndex = 5;
            this.buttonpindah.Text = ">";
            this.buttonpindah.UseVisualStyleBackColor = true;
            this.buttonpindah.Click += new System.EventHandler(this.buttonpindah_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(352, 274);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(96, 31);
            this.buttonclear.TabIndex = 6;
            this.buttonclear.Text = "x";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // groupBoxfilter
            // 
            this.groupBoxfilter.Controls.Add(this.cBoxMinuman);
            this.groupBoxfilter.Controls.Add(this.cBoxMakanan);
            this.groupBoxfilter.Location = new System.Drawing.Point(320, 320);
            this.groupBoxfilter.Name = "groupBoxfilter";
            this.groupBoxfilter.Size = new System.Drawing.Size(141, 97);
            this.groupBoxfilter.TabIndex = 10;
            this.groupBoxfilter.TabStop = false;
            this.groupBoxfilter.Text = "Filter";
            // 
            // cBoxMinuman
            // 
            this.cBoxMinuman.AutoSize = true;
            this.cBoxMinuman.Location = new System.Drawing.Point(7, 55);
            this.cBoxMinuman.Name = "cBoxMinuman";
            this.cBoxMinuman.Size = new System.Drawing.Size(100, 24);
            this.cBoxMinuman.TabIndex = 1;
            this.cBoxMinuman.Text = "Minuman";
            this.cBoxMinuman.UseVisualStyleBackColor = true;
            this.cBoxMinuman.CheckedChanged += new System.EventHandler(this.cBoxMinuman_CheckedChanged);
            // 
            // cBoxMakanan
            // 
            this.cBoxMakanan.AutoSize = true;
            this.cBoxMakanan.Location = new System.Drawing.Point(6, 25);
            this.cBoxMakanan.Name = "cBoxMakanan";
            this.cBoxMakanan.Size = new System.Drawing.Size(101, 24);
            this.cBoxMakanan.TabIndex = 0;
            this.cBoxMakanan.Text = "Makanan";
            this.cBoxMakanan.UseVisualStyleBackColor = true;
            this.cBoxMakanan.CheckedChanged += new System.EventHandler(this.cBoxMakanan_CheckedChanged);
            // 
            // listBoxpertama
            // 
            this.listBoxpertama.FormattingEnabled = true;
            this.listBoxpertama.ItemHeight = 20;
            this.listBoxpertama.Location = new System.Drawing.Point(63, 210);
            this.listBoxpertama.Name = "listBoxpertama";
            this.listBoxpertama.Size = new System.Drawing.Size(214, 204);
            this.listBoxpertama.TabIndex = 12;
            this.listBoxpertama.SelectedIndexChanged += new System.EventHandler(this.listBoxpertama_SelectedIndexChanged);
            // 
            // listBoxkedua
            // 
            this.listBoxkedua.FormattingEnabled = true;
            this.listBoxkedua.ItemHeight = 20;
            this.listBoxkedua.Location = new System.Drawing.Point(536, 210);
            this.listBoxkedua.Name = "listBoxkedua";
            this.listBoxkedua.Size = new System.Drawing.Size(214, 204);
            this.listBoxkedua.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxkedua);
            this.Controls.Add(this.listBoxpertama);
            this.Controls.Add(this.groupBoxfilter);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonpindah);
            this.Controls.Add(this.buttoninput);
            this.Controls.Add(this.grupboxpanel);
            this.Controls.Add(this.lblkategori);
            this.Controls.Add(this.lblnamaitem);
            this.Controls.Add(this.textBoxinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupboxpanel.ResumeLayout(false);
            this.grupboxpanel.PerformLayout();
            this.groupBoxfilter.ResumeLayout(false);
            this.groupBoxfilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.Label lblnamaitem;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.GroupBox grupboxpanel;
        private System.Windows.Forms.RadioButton radioButtonmakan;
        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.RadioButton radioButtonminum;
        private System.Windows.Forms.Button buttonpindah;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.GroupBox groupBoxfilter;
        private System.Windows.Forms.CheckBox cBoxMinuman;
        private System.Windows.Forms.CheckBox cBoxMakanan;
        private System.Windows.Forms.ListBox listBoxpertama;
        private System.Windows.Forms.ListBox listBoxkedua;
    }
}

