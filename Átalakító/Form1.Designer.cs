
namespace Átalakító
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_file_valaszt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BTN_file_iras = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_cim = new System.Windows.Forms.TextBox();
            this.txt_telefon1 = new System.Windows.Forms.TextBox();
            this.txt_telefon2 = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_cim = new System.Windows.Forms.Label();
            this.lbl_phone1 = new System.Windows.Forms.Label();
            this.lbl_phone2 = new System.Windows.Forms.Label();
            this.lbl_phone3 = new System.Windows.Forms.Label();
            this.txt_telefon3 = new System.Windows.Forms.TextBox();
            this.BTN_modosit = new System.Windows.Forms.Button();
            this.lbl_file = new System.Windows.Forms.Label();
            this.lbl_sor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_odt = new System.Windows.Forms.RadioButton();
            this.rb_xlsx = new System.Windows.Forms.RadioButton();
            this.rb_xls = new System.Windows.Forms.RadioButton();
            this.lbl_mentve = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pic_digi = new System.Windows.Forms.PictureBox();
            this.pic_invitel = new System.Windows.Forms.PictureBox();
            this.pic_voda = new System.Windows.Forms.PictureBox();
            this.pic_telenor = new System.Windows.Forms.PictureBox();
            this.pic_tcom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_invitel = new System.Windows.Forms.RadioButton();
            this.rb_digi = new System.Windows.Forms.RadioButton();
            this.rb_vodafone = new System.Windows.Forms.RadioButton();
            this.rb_telenor = new System.Windows.Forms.RadioButton();
            this.rb_telekom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_green = new System.Windows.Forms.PictureBox();
            this.figyeles_KI = new System.Windows.Forms.RadioButton();
            this.pic_red = new System.Windows.Forms.PictureBox();
            this.figyeles_BE = new System.Windows.Forms.RadioButton();
            this.lbl_figyeles = new System.Windows.Forms.Label();
            this.lbl_gombfigyel = new System.Windows.Forms.Label();
            this.BTN_lista_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_szolgaltato = new System.Windows.Forms.Label();
            this.lbl_telenor_cim = new System.Windows.Forms.Label();
            this.txt_telenor_cim = new System.Windows.Forms.TextBox();
            this.BTN_lista_clip = new System.Windows.Forms.Button();
            this.lbl_segedablak = new System.Windows.Forms.Label();
            this.check_topform = new System.Windows.Forms.CheckBox();
            this.back_arrow = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_digi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_invitel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_voda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tcom)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_file_valaszt
            // 
            this.BTN_file_valaszt.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_file_valaszt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_file_valaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BTN_file_valaszt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_file_valaszt.Location = new System.Drawing.Point(29, 90);
            this.BTN_file_valaszt.Name = "BTN_file_valaszt";
            this.BTN_file_valaszt.Size = new System.Drawing.Size(159, 41);
            this.BTN_file_valaszt.TabIndex = 0;
            this.BTN_file_valaszt.Text = "FÁJL KIVÁLASZTÁSA";
            this.BTN_file_valaszt.UseVisualStyleBackColor = false;
            this.BTN_file_valaszt.Click += new System.EventHandler(this.BTN_file_valaszt_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(30, 247);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(605, 289);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BTN_file_iras
            // 
            this.BTN_file_iras.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_file_iras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_file_iras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BTN_file_iras.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_file_iras.Location = new System.Drawing.Point(228, 90);
            this.BTN_file_iras.Name = "BTN_file_iras";
            this.BTN_file_iras.Size = new System.Drawing.Size(132, 41);
            this.BTN_file_iras.TabIndex = 2;
            this.BTN_file_iras.Text = "MENTÉS";
            this.BTN_file_iras.UseVisualStyleBackColor = false;
            this.BTN_file_iras.Click += new System.EventHandler(this.BTN_file_iras_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTN_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_delete.Location = new System.Drawing.Point(237, 576);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(190, 40);
            this.BTN_delete.TabIndex = 3;
            this.BTN_delete.Text = "Elem törlése";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // txt_nev
            // 
            this.txt_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_nev.Location = new System.Drawing.Point(657, 250);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(286, 22);
            this.txt_nev.TabIndex = 4;
            // 
            // txt_cim
            // 
            this.txt_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_cim.Location = new System.Drawing.Point(657, 316);
            this.txt_cim.Name = "txt_cim";
            this.txt_cim.Size = new System.Drawing.Size(286, 22);
            this.txt_cim.TabIndex = 5;
            // 
            // txt_telefon1
            // 
            this.txt_telefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_telefon1.Location = new System.Drawing.Point(656, 382);
            this.txt_telefon1.Name = "txt_telefon1";
            this.txt_telefon1.Size = new System.Drawing.Size(286, 22);
            this.txt_telefon1.TabIndex = 6;
            // 
            // txt_telefon2
            // 
            this.txt_telefon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_telefon2.Location = new System.Drawing.Point(657, 448);
            this.txt_telefon2.Name = "txt_telefon2";
            this.txt_telefon2.Size = new System.Drawing.Size(286, 22);
            this.txt_telefon2.TabIndex = 7;
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_nev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nev.Location = new System.Drawing.Point(653, 227);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(36, 20);
            this.lbl_nev.TabIndex = 8;
            this.lbl_nev.Text = "Név";
            // 
            // lbl_cim
            // 
            this.lbl_cim.AutoSize = true;
            this.lbl_cim.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_cim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_cim.Location = new System.Drawing.Point(653, 293);
            this.lbl_cim.Name = "lbl_cim";
            this.lbl_cim.Size = new System.Drawing.Size(36, 20);
            this.lbl_cim.TabIndex = 9;
            this.lbl_cim.Text = "Cím";
            // 
            // lbl_phone1
            // 
            this.lbl_phone1.AutoSize = true;
            this.lbl_phone1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_phone1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_phone1.Location = new System.Drawing.Point(653, 359);
            this.lbl_phone1.Name = "lbl_phone1";
            this.lbl_phone1.Size = new System.Drawing.Size(75, 20);
            this.lbl_phone1.TabIndex = 10;
            this.lbl_phone1.Text = "Telefon 1";
            // 
            // lbl_phone2
            // 
            this.lbl_phone2.AutoSize = true;
            this.lbl_phone2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_phone2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_phone2.Location = new System.Drawing.Point(653, 425);
            this.lbl_phone2.Name = "lbl_phone2";
            this.lbl_phone2.Size = new System.Drawing.Size(75, 20);
            this.lbl_phone2.TabIndex = 11;
            this.lbl_phone2.Text = "Telefon 2";
            // 
            // lbl_phone3
            // 
            this.lbl_phone3.AutoSize = true;
            this.lbl_phone3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_phone3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_phone3.Location = new System.Drawing.Point(653, 491);
            this.lbl_phone3.Name = "lbl_phone3";
            this.lbl_phone3.Size = new System.Drawing.Size(75, 20);
            this.lbl_phone3.TabIndex = 13;
            this.lbl_phone3.Text = "Telefon 3";
            // 
            // txt_telefon3
            // 
            this.txt_telefon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_telefon3.Location = new System.Drawing.Point(656, 514);
            this.txt_telefon3.Name = "txt_telefon3";
            this.txt_telefon3.Size = new System.Drawing.Size(286, 22);
            this.txt_telefon3.TabIndex = 12;
            // 
            // BTN_modosit
            // 
            this.BTN_modosit.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_modosit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_modosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTN_modosit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_modosit.Location = new System.Drawing.Point(656, 576);
            this.BTN_modosit.Name = "BTN_modosit";
            this.BTN_modosit.Size = new System.Drawing.Size(286, 40);
            this.BTN_modosit.TabIndex = 14;
            this.BTN_modosit.Text = "Módosítás";
            this.BTN_modosit.UseVisualStyleBackColor = false;
            this.BTN_modosit.Click += new System.EventHandler(this.BTN_modosit_Click);
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_file.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_file.Location = new System.Drawing.Point(26, 134);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(16, 16);
            this.lbl_file.TabIndex = 16;
            this.lbl_file.Text = "F";
            // 
            // lbl_sor
            // 
            this.lbl_sor.AutoSize = true;
            this.lbl_sor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_sor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_sor.Location = new System.Drawing.Point(30, 542);
            this.lbl_sor.Name = "lbl_sor";
            this.lbl_sor.Size = new System.Drawing.Size(0, 25);
            this.lbl_sor.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_odt);
            this.groupBox1.Controls.Add(this.rb_xlsx);
            this.groupBox1.Controls.Add(this.rb_xls);
            this.groupBox1.Controls.Add(this.lbl_mentve);
            this.groupBox1.Controls.Add(this.BTN_file_iras);
            this.groupBox1.Controls.Add(this.BTN_file_valaszt);
            this.groupBox1.Controls.Add(this.lbl_file);
            this.groupBox1.Location = new System.Drawing.Point(559, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 180);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "FÁJLBA ÍRÁS";
            // 
            // rb_odt
            // 
            this.rb_odt.AutoSize = true;
            this.rb_odt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_odt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_odt.Location = new System.Drawing.Point(140, 66);
            this.rb_odt.Name = "rb_odt";
            this.rb_odt.Size = new System.Drawing.Size(48, 17);
            this.rb_odt.TabIndex = 26;
            this.rb_odt.TabStop = true;
            this.rb_odt.Text = "ODT";
            this.rb_odt.UseVisualStyleBackColor = false;
            // 
            // rb_xlsx
            // 
            this.rb_xlsx.AutoSize = true;
            this.rb_xlsx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_xlsx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_xlsx.Location = new System.Drawing.Point(82, 66);
            this.rb_xlsx.Name = "rb_xlsx";
            this.rb_xlsx.Size = new System.Drawing.Size(52, 17);
            this.rb_xlsx.TabIndex = 25;
            this.rb_xlsx.TabStop = true;
            this.rb_xlsx.Text = "XLSX";
            this.rb_xlsx.UseVisualStyleBackColor = false;
            // 
            // rb_xls
            // 
            this.rb_xls.AutoSize = true;
            this.rb_xls.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_xls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_xls.Location = new System.Drawing.Point(31, 66);
            this.rb_xls.Name = "rb_xls";
            this.rb_xls.Size = new System.Drawing.Size(45, 17);
            this.rb_xls.TabIndex = 24;
            this.rb_xls.TabStop = true;
            this.rb_xls.Text = "XLS";
            this.rb_xls.UseVisualStyleBackColor = false;
            // 
            // lbl_mentve
            // 
            this.lbl_mentve.AutoSize = true;
            this.lbl_mentve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_mentve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_mentve.Location = new System.Drawing.Point(225, 134);
            this.lbl_mentve.Name = "lbl_mentve";
            this.lbl_mentve.Size = new System.Drawing.Size(19, 16);
            this.lbl_mentve.TabIndex = 19;
            this.lbl_mentve.Text = "M";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.pic_digi);
            this.groupBox3.Controls.Add(this.pic_invitel);
            this.groupBox3.Controls.Add(this.pic_voda);
            this.groupBox3.Controls.Add(this.pic_telenor);
            this.groupBox3.Controls.Add(this.pic_tcom);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rb_invitel);
            this.groupBox3.Controls.Add(this.rb_digi);
            this.groupBox3.Controls.Add(this.rb_vodafone);
            this.groupBox3.Controls.Add(this.rb_telenor);
            this.groupBox3.Controls.Add(this.rb_telekom);
            this.groupBox3.Location = new System.Drawing.Point(249, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 180);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // pic_digi
            // 
            this.pic_digi.Image = ((System.Drawing.Image)(resources.GetObject("pic_digi.Image")));
            this.pic_digi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_digi.Location = new System.Drawing.Point(54, 60);
            this.pic_digi.Name = "pic_digi";
            this.pic_digi.Size = new System.Drawing.Size(80, 71);
            this.pic_digi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_digi.TabIndex = 27;
            this.pic_digi.TabStop = false;
            // 
            // pic_invitel
            // 
            this.pic_invitel.Image = ((System.Drawing.Image)(resources.GetObject("pic_invitel.Image")));
            this.pic_invitel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_invitel.Location = new System.Drawing.Point(54, 60);
            this.pic_invitel.Name = "pic_invitel";
            this.pic_invitel.Size = new System.Drawing.Size(80, 71);
            this.pic_invitel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_invitel.TabIndex = 26;
            this.pic_invitel.TabStop = false;
            // 
            // pic_voda
            // 
            this.pic_voda.Image = ((System.Drawing.Image)(resources.GetObject("pic_voda.Image")));
            this.pic_voda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_voda.Location = new System.Drawing.Point(54, 60);
            this.pic_voda.Name = "pic_voda";
            this.pic_voda.Size = new System.Drawing.Size(80, 71);
            this.pic_voda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_voda.TabIndex = 25;
            this.pic_voda.TabStop = false;
            // 
            // pic_telenor
            // 
            this.pic_telenor.Image = ((System.Drawing.Image)(resources.GetObject("pic_telenor.Image")));
            this.pic_telenor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_telenor.Location = new System.Drawing.Point(54, 60);
            this.pic_telenor.Name = "pic_telenor";
            this.pic_telenor.Size = new System.Drawing.Size(80, 71);
            this.pic_telenor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_telenor.TabIndex = 24;
            this.pic_telenor.TabStop = false;
            // 
            // pic_tcom
            // 
            this.pic_tcom.Image = ((System.Drawing.Image)(resources.GetObject("pic_tcom.Image")));
            this.pic_tcom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_tcom.Location = new System.Drawing.Point(54, 60);
            this.pic_tcom.Name = "pic_tcom";
            this.pic_tcom.Size = new System.Drawing.Size(80, 71);
            this.pic_tcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_tcom.TabIndex = 23;
            this.pic_tcom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "SZOLGÁLTATÓ";
            // 
            // rb_invitel
            // 
            this.rb_invitel.AutoSize = true;
            this.rb_invitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_invitel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_invitel.Location = new System.Drawing.Point(197, 66);
            this.rb_invitel.Name = "rb_invitel";
            this.rb_invitel.Size = new System.Drawing.Size(60, 20);
            this.rb_invitel.TabIndex = 6;
            this.rb_invitel.TabStop = true;
            this.rb_invitel.Text = "Invitel";
            this.rb_invitel.UseVisualStyleBackColor = true;
            this.rb_invitel.CheckedChanged += new System.EventHandler(this.rb_invitel_CheckedChanged);
            // 
            // rb_digi
            // 
            this.rb_digi.AutoSize = true;
            this.rb_digi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_digi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_digi.Location = new System.Drawing.Point(197, 42);
            this.rb_digi.Name = "rb_digi";
            this.rb_digi.Size = new System.Drawing.Size(50, 20);
            this.rb_digi.TabIndex = 5;
            this.rb_digi.TabStop = true;
            this.rb_digi.Text = "Digi";
            this.rb_digi.UseVisualStyleBackColor = true;
            this.rb_digi.CheckedChanged += new System.EventHandler(this.rb_digi_CheckedChanged);
            // 
            // rb_vodafone
            // 
            this.rb_vodafone.AutoSize = true;
            this.rb_vodafone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_vodafone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_vodafone.Location = new System.Drawing.Point(197, 138);
            this.rb_vodafone.Name = "rb_vodafone";
            this.rb_vodafone.Size = new System.Drawing.Size(85, 20);
            this.rb_vodafone.TabIndex = 4;
            this.rb_vodafone.TabStop = true;
            this.rb_vodafone.Text = "Vodafone";
            this.rb_vodafone.UseVisualStyleBackColor = true;
            this.rb_vodafone.CheckedChanged += new System.EventHandler(this.rb_vodafone_CheckedChanged);
            // 
            // rb_telenor
            // 
            this.rb_telenor.AutoSize = true;
            this.rb_telenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_telenor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_telenor.Location = new System.Drawing.Point(197, 114);
            this.rb_telenor.Name = "rb_telenor";
            this.rb_telenor.Size = new System.Drawing.Size(73, 20);
            this.rb_telenor.TabIndex = 3;
            this.rb_telenor.TabStop = true;
            this.rb_telenor.Text = "Telenor";
            this.rb_telenor.UseVisualStyleBackColor = true;
            this.rb_telenor.CheckedChanged += new System.EventHandler(this.rb_telenor_CheckedChanged);
            // 
            // rb_telekom
            // 
            this.rb_telekom.AutoSize = true;
            this.rb_telekom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rb_telekom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_telekom.Location = new System.Drawing.Point(197, 90);
            this.rb_telekom.Name = "rb_telekom";
            this.rb_telekom.Size = new System.Drawing.Size(80, 20);
            this.rb_telekom.TabIndex = 2;
            this.rb_telekom.TabStop = true;
            this.rb_telekom.Text = "Telekom";
            this.rb_telekom.UseVisualStyleBackColor = true;
            this.rb_telekom.CheckedChanged += new System.EventHandler(this.rb_telekom_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.pic_green);
            this.groupBox2.Controls.Add(this.figyeles_KI);
            this.groupBox2.Controls.Add(this.pic_red);
            this.groupBox2.Controls.Add(this.figyeles_BE);
            this.groupBox2.Controls.Add(this.lbl_figyeles);
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 180);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // pic_green
            // 
            this.pic_green.Image = ((System.Drawing.Image)(resources.GetObject("pic_green.Image")));
            this.pic_green.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_green.Location = new System.Drawing.Point(19, 60);
            this.pic_green.Name = "pic_green";
            this.pic_green.Size = new System.Drawing.Size(79, 71);
            this.pic_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_green.TabIndex = 22;
            this.pic_green.TabStop = false;
            // 
            // figyeles_KI
            // 
            this.figyeles_KI.AutoSize = true;
            this.figyeles_KI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.figyeles_KI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.figyeles_KI.Location = new System.Drawing.Point(127, 108);
            this.figyeles_KI.Name = "figyeles_KI";
            this.figyeles_KI.Size = new System.Drawing.Size(44, 28);
            this.figyeles_KI.TabIndex = 1;
            this.figyeles_KI.TabStop = true;
            this.figyeles_KI.Text = "KI";
            this.figyeles_KI.UseVisualStyleBackColor = true;
            this.figyeles_KI.CheckedChanged += new System.EventHandler(this.figyeles_KI_CheckedChanged);
            // 
            // pic_red
            // 
            this.pic_red.Image = ((System.Drawing.Image)(resources.GetObject("pic_red.Image")));
            this.pic_red.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_red.Location = new System.Drawing.Point(19, 60);
            this.pic_red.Name = "pic_red";
            this.pic_red.Size = new System.Drawing.Size(79, 71);
            this.pic_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_red.TabIndex = 23;
            this.pic_red.TabStop = false;
            // 
            // figyeles_BE
            // 
            this.figyeles_BE.AutoSize = true;
            this.figyeles_BE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.figyeles_BE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.figyeles_BE.Location = new System.Drawing.Point(127, 60);
            this.figyeles_BE.Name = "figyeles_BE";
            this.figyeles_BE.Size = new System.Drawing.Size(53, 28);
            this.figyeles_BE.TabIndex = 0;
            this.figyeles_BE.TabStop = true;
            this.figyeles_BE.Text = "BE";
            this.figyeles_BE.UseVisualStyleBackColor = true;
            this.figyeles_BE.CheckedChanged += new System.EventHandler(this.figyeles_BE_CheckedChanged);
            // 
            // lbl_figyeles
            // 
            this.lbl_figyeles.AutoSize = true;
            this.lbl_figyeles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_figyeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_figyeles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_figyeles.Location = new System.Drawing.Point(6, 16);
            this.lbl_figyeles.Name = "lbl_figyeles";
            this.lbl_figyeles.Size = new System.Drawing.Size(108, 24);
            this.lbl_figyeles.TabIndex = 21;
            this.lbl_figyeles.Text = "FIGYELÉS";
            // 
            // lbl_gombfigyel
            // 
            this.lbl_gombfigyel.AutoSize = true;
            this.lbl_gombfigyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_gombfigyel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_gombfigyel.Location = new System.Drawing.Point(136, 374);
            this.lbl_gombfigyel.Name = "lbl_gombfigyel";
            this.lbl_gombfigyel.Size = new System.Drawing.Size(179, 31);
            this.lbl_gombfigyel.TabIndex = 20;
            this.lbl_gombfigyel.Text = "Gomb_BE_KI";
            // 
            // BTN_lista_delete
            // 
            this.BTN_lista_delete.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_lista_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_lista_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTN_lista_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_lista_delete.Location = new System.Drawing.Point(445, 576);
            this.BTN_lista_delete.Name = "BTN_lista_delete";
            this.BTN_lista_delete.Size = new System.Drawing.Size(190, 40);
            this.BTN_lista_delete.TabIndex = 21;
            this.BTN_lista_delete.Text = "Lista törlése";
            this.BTN_lista_delete.UseVisualStyleBackColor = false;
            this.BTN_lista_delete.Click += new System.EventHandler(this.BTN_lista_delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(857, 658);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_szolgaltato
            // 
            this.lbl_szolgaltato.AutoSize = true;
            this.lbl_szolgaltato.BackColor = System.Drawing.Color.Transparent;
            this.lbl_szolgaltato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_szolgaltato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_szolgaltato.Location = new System.Drawing.Point(24, 209);
            this.lbl_szolgaltato.Name = "lbl_szolgaltato";
            this.lbl_szolgaltato.Size = new System.Drawing.Size(95, 31);
            this.lbl_szolgaltato.TabIndex = 23;
            this.lbl_szolgaltato.Text = "LISTA";
            // 
            // lbl_telenor_cim
            // 
            this.lbl_telenor_cim.AutoSize = true;
            this.lbl_telenor_cim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_telenor_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_telenor_cim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_telenor_cim.Location = new System.Drawing.Point(296, 215);
            this.lbl_telenor_cim.Name = "lbl_telenor_cim";
            this.lbl_telenor_cim.Size = new System.Drawing.Size(55, 25);
            this.lbl_telenor_cim.TabIndex = 24;
            this.lbl_telenor_cim.Text = "Cím:";
            // 
            // txt_telenor_cim
            // 
            this.txt_telenor_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_telenor_cim.Location = new System.Drawing.Point(357, 219);
            this.txt_telenor_cim.Name = "txt_telenor_cim";
            this.txt_telenor_cim.Size = new System.Drawing.Size(278, 22);
            this.txt_telenor_cim.TabIndex = 25;
            // 
            // BTN_lista_clip
            // 
            this.BTN_lista_clip.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_lista_clip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_lista_clip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTN_lista_clip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_lista_clip.Location = new System.Drawing.Point(30, 576);
            this.BTN_lista_clip.Name = "BTN_lista_clip";
            this.BTN_lista_clip.Size = new System.Drawing.Size(190, 40);
            this.BTN_lista_clip.TabIndex = 26;
            this.BTN_lista_clip.Text = "Lista vágólapra";
            this.BTN_lista_clip.UseVisualStyleBackColor = false;
            this.BTN_lista_clip.Click += new System.EventHandler(this.BTN_lista_clip_Click);
            // 
            // lbl_segedablak
            // 
            this.lbl_segedablak.AutoSize = true;
            this.lbl_segedablak.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_segedablak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_segedablak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_segedablak.Location = new System.Drawing.Point(31, 642);
            this.lbl_segedablak.Name = "lbl_segedablak";
            this.lbl_segedablak.Size = new System.Drawing.Size(119, 20);
            this.lbl_segedablak.TabIndex = 27;
            this.lbl_segedablak.Text = "SEGÉDABLAK";
            // 
            // check_topform
            // 
            this.check_topform.AutoSize = true;
            this.check_topform.Checked = true;
            this.check_topform.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_topform.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.check_topform.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.check_topform.Location = new System.Drawing.Point(157, 641);
            this.check_topform.Name = "check_topform";
            this.check_topform.Size = new System.Drawing.Size(15, 14);
            this.check_topform.TabIndex = 28;
            this.check_topform.UseVisualStyleBackColor = true;
            this.check_topform.CheckedChanged += new System.EventHandler(this.check_topform_CheckedChanged);
            // 
            // back_arrow
            // 
            this.back_arrow.BackColor = System.Drawing.Color.Transparent;
            this.back_arrow.Image = ((System.Drawing.Image)(resources.GetObject("back_arrow.Image")));
            this.back_arrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.back_arrow.Location = new System.Drawing.Point(590, 622);
            this.back_arrow.Name = "back_arrow";
            this.back_arrow.Size = new System.Drawing.Size(45, 40);
            this.back_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_arrow.TabIndex = 29;
            this.back_arrow.TabStop = false;
            this.back_arrow.Click += new System.EventHandler(this.back_arrow_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(30, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(917, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(30, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(917, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 757);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_arrow);
            this.Controls.Add(this.check_topform);
            this.Controls.Add(this.lbl_segedablak);
            this.Controls.Add(this.BTN_lista_clip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_telenor_cim);
            this.Controls.Add(this.lbl_telenor_cim);
            this.Controls.Add(this.lbl_szolgaltato);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_lista_delete);
            this.Controls.Add(this.lbl_gombfigyel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_sor);
            this.Controls.Add(this.BTN_modosit);
            this.Controls.Add(this.lbl_phone3);
            this.Controls.Add(this.txt_telefon3);
            this.Controls.Add(this.lbl_phone2);
            this.Controls.Add(this.lbl_phone1);
            this.Controls.Add(this.lbl_cim);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.txt_telefon2);
            this.Controls.Add(this.txt_telefon1);
            this.Controls.Add(this.txt_cim);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Átalakító";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_digi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_invitel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_voda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tcom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_file_valaszt;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BTN_file_iras;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_cim;
        private System.Windows.Forms.TextBox txt_telefon1;
        private System.Windows.Forms.TextBox txt_telefon2;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_cim;
        private System.Windows.Forms.Label lbl_phone1;
        private System.Windows.Forms.Label lbl_phone2;
        private System.Windows.Forms.Label lbl_phone3;
        private System.Windows.Forms.TextBox txt_telefon3;
        private System.Windows.Forms.Button BTN_modosit;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.Label lbl_sor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mentve;
        private System.Windows.Forms.Label lbl_gombfigyel;
        private System.Windows.Forms.Label lbl_figyeles;
        private System.Windows.Forms.Button BTN_lista_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_szolgaltato;
        private System.Windows.Forms.Label lbl_telenor_cim;
        private System.Windows.Forms.TextBox txt_telenor_cim;
        private System.Windows.Forms.RadioButton rb_xlsx;
        private System.Windows.Forms.RadioButton rb_xls;
        private System.Windows.Forms.RadioButton rb_odt;
        private System.Windows.Forms.Button BTN_lista_clip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rb_telenor;
        public System.Windows.Forms.RadioButton rb_telekom;
        public System.Windows.Forms.RadioButton rb_vodafone;
        public System.Windows.Forms.RadioButton rb_invitel;
        public System.Windows.Forms.RadioButton rb_digi;
        public System.Windows.Forms.PictureBox pic_green;
        public System.Windows.Forms.PictureBox pic_red;
        public System.Windows.Forms.PictureBox pic_voda;
        public System.Windows.Forms.PictureBox pic_telenor;
        public System.Windows.Forms.PictureBox pic_tcom;
        public System.Windows.Forms.PictureBox pic_digi;
        public System.Windows.Forms.PictureBox pic_invitel;
        public System.Windows.Forms.RadioButton figyeles_BE;
        public System.Windows.Forms.RadioButton figyeles_KI;
        private System.Windows.Forms.Label lbl_segedablak;
        private System.Windows.Forms.PictureBox back_arrow;
        public System.Windows.Forms.CheckBox check_topform;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Timer timer1;
    }
}

