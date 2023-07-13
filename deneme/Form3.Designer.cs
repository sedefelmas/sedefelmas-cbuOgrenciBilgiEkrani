
namespace deneme
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.onaylaButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.anneGroupBox = new System.Windows.Forms.GroupBox();
            this.anneCepTelefonu = new System.Windows.Forms.Label();
            this.anneSigorta = new System.Windows.Forms.Label();
            this.anneSag = new System.Windows.Forms.Label();
            this.anneCepTelefonuLabel = new System.Windows.Forms.Label();
            this.anneSigortaLabel = new System.Windows.Forms.Label();
            this.anneSagLabel = new System.Windows.Forms.Label();
            this.babaGroupBox = new System.Windows.Forms.GroupBox();
            this.babaSag = new System.Windows.Forms.Label();
            this.babaSigorta = new System.Windows.Forms.Label();
            this.babaCepTelefonu = new System.Windows.Forms.Label();
            this.babaCepTelefonuLabel = new System.Windows.Forms.Label();
            this.babaSigortaLabel = new System.Windows.Forms.Label();
            this.babaSagLabel = new System.Windows.Forms.Label();
            this.digerBilgilerGroupBox = new System.Windows.Forms.GroupBox();
            this.aileGeliri = new System.Windows.Forms.Label();
            this.sehitGazi = new System.Windows.Forms.Label();
            this.kardesSayısı = new System.Windows.Forms.Label();
            this.okuyanKardesSayısı = new System.Windows.Forms.Label();
            this.anneBabaMedeniDurumu = new System.Windows.Forms.Label();
            this.kardesSayısıLabel = new System.Windows.Forms.Label();
            this.okuyanKardesSayısıLabel = new System.Windows.Forms.Label();
            this.anneBabaMedeniDurumuLabel = new System.Windows.Forms.Label();
            this.sehitGaziLabel = new System.Windows.Forms.Label();
            this.aileGeliriLabel = new System.Windows.Forms.Label();
            this.engelDurumuGroupBox = new System.Windows.Forms.GroupBox();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.engelYüzdeValue1 = new System.Windows.Forms.TextBox();
            this.engelYüzdeValue2 = new System.Windows.Forms.TextBox();
            this.engelYüzdeValue3 = new System.Windows.Forms.TextBox();
            this.engelYüzdeComboBox1 = new System.Windows.Forms.ComboBox();
            this.engelYüzdeComboBox2 = new System.Windows.Forms.ComboBox();
            this.engelYüzdeComboBox3 = new System.Windows.Forms.ComboBox();
            this.engelYüzdeLabel2 = new System.Windows.Forms.Label();
            this.engelYüzdeLabel3 = new System.Windows.Forms.Label();
            this.engelYüzdeLabel1 = new System.Windows.Forms.Label();
            this.anneGroupBox.SuspendLayout();
            this.babaGroupBox.SuspendLayout();
            this.digerBilgilerGroupBox.SuspendLayout();
            this.engelDurumuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgileriniz aşağıda gösterildiği gibi kaydedilmiştir. Bilgilerde yanlışlık varsa" +
    " \r\nformu tekrar açıp doğru bilgilerinizi giriniz.";
            // 
            // onaylaButton
            // 
            this.onaylaButton.BackColor = System.Drawing.Color.YellowGreen;
            this.onaylaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onaylaButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onaylaButton.Location = new System.Drawing.Point(806, 299);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(225, 49);
            this.onaylaButton.TabIndex = 2;
            this.onaylaButton.Text = "Onayla";
            this.onaylaButton.UseVisualStyleBackColor = false;
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.BackColor = System.Drawing.Color.YellowGreen;
            this.iptalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptalButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptalButton.Location = new System.Drawing.Point(806, 369);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(225, 49);
            this.iptalButton.TabIndex = 3;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = false;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // anneGroupBox
            // 
            this.anneGroupBox.Controls.Add(this.anneCepTelefonu);
            this.anneGroupBox.Controls.Add(this.anneSigorta);
            this.anneGroupBox.Controls.Add(this.anneSag);
            this.anneGroupBox.Controls.Add(this.anneCepTelefonuLabel);
            this.anneGroupBox.Controls.Add(this.anneSigortaLabel);
            this.anneGroupBox.Controls.Add(this.anneSagLabel);
            this.anneGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneGroupBox.Location = new System.Drawing.Point(17, 97);
            this.anneGroupBox.Name = "anneGroupBox";
            this.anneGroupBox.Size = new System.Drawing.Size(340, 127);
            this.anneGroupBox.TabIndex = 8;
            this.anneGroupBox.TabStop = false;
            this.anneGroupBox.Text = "Anne";
            this.anneGroupBox.Enter += new System.EventHandler(this.anneGroupBox_Enter);
            // 
            // anneCepTelefonu
            // 
            this.anneCepTelefonu.AutoSize = true;
            this.anneCepTelefonu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneCepTelefonu.Location = new System.Drawing.Point(145, 94);
            this.anneCepTelefonu.Name = "anneCepTelefonu";
            this.anneCepTelefonu.Size = new System.Drawing.Size(0, 24);
            this.anneCepTelefonu.TabIndex = 10;
            // 
            // anneSigorta
            // 
            this.anneSigorta.AutoSize = true;
            this.anneSigorta.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSigorta.Location = new System.Drawing.Point(258, 70);
            this.anneSigorta.Name = "anneSigorta";
            this.anneSigorta.Size = new System.Drawing.Size(0, 24);
            this.anneSigorta.TabIndex = 9;
            // 
            // anneSag
            // 
            this.anneSag.AutoSize = true;
            this.anneSag.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSag.Location = new System.Drawing.Point(72, 46);
            this.anneSag.Name = "anneSag";
            this.anneSag.Size = new System.Drawing.Size(79, 24);
            this.anneSag.TabIndex = 8;
            this.anneSag.Text = "deneme";
            // 
            // anneCepTelefonuLabel
            // 
            this.anneCepTelefonuLabel.AutoSize = true;
            this.anneCepTelefonuLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneCepTelefonuLabel.Location = new System.Drawing.Point(20, 94);
            this.anneCepTelefonuLabel.Name = "anneCepTelefonuLabel";
            this.anneCepTelefonuLabel.Size = new System.Drawing.Size(126, 24);
            this.anneCepTelefonuLabel.TabIndex = 7;
            this.anneCepTelefonuLabel.Text = "Cep Telefonu:";
            // 
            // anneSigortaLabel
            // 
            this.anneSigortaLabel.AutoSize = true;
            this.anneSigortaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSigortaLabel.Location = new System.Drawing.Point(20, 70);
            this.anneSigortaLabel.Name = "anneSigortaLabel";
            this.anneSigortaLabel.Size = new System.Drawing.Size(232, 24);
            this.anneSigortaLabel.TabIndex = 6;
            this.anneSigortaLabel.Text = "Sigorta Güvencesi var mı?:";
            // 
            // anneSagLabel
            // 
            this.anneSagLabel.AutoSize = true;
            this.anneSagLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSagLabel.Location = new System.Drawing.Point(20, 46);
            this.anneSagLabel.Name = "anneSagLabel";
            this.anneSagLabel.Size = new System.Drawing.Size(46, 24);
            this.anneSagLabel.TabIndex = 5;
            this.anneSagLabel.Text = "Sağ:";
            // 
            // babaGroupBox
            // 
            this.babaGroupBox.Controls.Add(this.babaSag);
            this.babaGroupBox.Controls.Add(this.babaSigorta);
            this.babaGroupBox.Controls.Add(this.babaCepTelefonu);
            this.babaGroupBox.Controls.Add(this.babaCepTelefonuLabel);
            this.babaGroupBox.Controls.Add(this.babaSigortaLabel);
            this.babaGroupBox.Controls.Add(this.babaSagLabel);
            this.babaGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaGroupBox.Location = new System.Drawing.Point(372, 97);
            this.babaGroupBox.Name = "babaGroupBox";
            this.babaGroupBox.Size = new System.Drawing.Size(340, 127);
            this.babaGroupBox.TabIndex = 9;
            this.babaGroupBox.TabStop = false;
            this.babaGroupBox.Text = "Baba";
            // 
            // babaSag
            // 
            this.babaSag.AutoSize = true;
            this.babaSag.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSag.Location = new System.Drawing.Point(72, 46);
            this.babaSag.Name = "babaSag";
            this.babaSag.Size = new System.Drawing.Size(0, 24);
            this.babaSag.TabIndex = 11;
            // 
            // babaSigorta
            // 
            this.babaSigorta.AutoSize = true;
            this.babaSigorta.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSigorta.Location = new System.Drawing.Point(258, 70);
            this.babaSigorta.Name = "babaSigorta";
            this.babaSigorta.Size = new System.Drawing.Size(0, 24);
            this.babaSigorta.TabIndex = 10;
            // 
            // babaCepTelefonu
            // 
            this.babaCepTelefonu.AutoSize = true;
            this.babaCepTelefonu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaCepTelefonu.Location = new System.Drawing.Point(145, 94);
            this.babaCepTelefonu.Name = "babaCepTelefonu";
            this.babaCepTelefonu.Size = new System.Drawing.Size(0, 24);
            this.babaCepTelefonu.TabIndex = 9;
            // 
            // babaCepTelefonuLabel
            // 
            this.babaCepTelefonuLabel.AutoSize = true;
            this.babaCepTelefonuLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaCepTelefonuLabel.Location = new System.Drawing.Point(20, 94);
            this.babaCepTelefonuLabel.Name = "babaCepTelefonuLabel";
            this.babaCepTelefonuLabel.Size = new System.Drawing.Size(126, 24);
            this.babaCepTelefonuLabel.TabIndex = 7;
            this.babaCepTelefonuLabel.Text = "Cep Telefonu:";
            // 
            // babaSigortaLabel
            // 
            this.babaSigortaLabel.AutoSize = true;
            this.babaSigortaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSigortaLabel.Location = new System.Drawing.Point(20, 70);
            this.babaSigortaLabel.Name = "babaSigortaLabel";
            this.babaSigortaLabel.Size = new System.Drawing.Size(232, 24);
            this.babaSigortaLabel.TabIndex = 6;
            this.babaSigortaLabel.Text = "Sigorta Güvencesi var mı?:";
            // 
            // babaSagLabel
            // 
            this.babaSagLabel.AutoSize = true;
            this.babaSagLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSagLabel.Location = new System.Drawing.Point(20, 46);
            this.babaSagLabel.Name = "babaSagLabel";
            this.babaSagLabel.Size = new System.Drawing.Size(46, 24);
            this.babaSagLabel.TabIndex = 5;
            this.babaSagLabel.Text = "Sağ:";
            // 
            // digerBilgilerGroupBox
            // 
            this.digerBilgilerGroupBox.Controls.Add(this.aileGeliri);
            this.digerBilgilerGroupBox.Controls.Add(this.sehitGazi);
            this.digerBilgilerGroupBox.Controls.Add(this.kardesSayısı);
            this.digerBilgilerGroupBox.Controls.Add(this.okuyanKardesSayısı);
            this.digerBilgilerGroupBox.Controls.Add(this.anneBabaMedeniDurumu);
            this.digerBilgilerGroupBox.Controls.Add(this.kardesSayısıLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.okuyanKardesSayısıLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.anneBabaMedeniDurumuLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.sehitGaziLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.aileGeliriLabel);
            this.digerBilgilerGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digerBilgilerGroupBox.Location = new System.Drawing.Point(738, 97);
            this.digerBilgilerGroupBox.Name = "digerBilgilerGroupBox";
            this.digerBilgilerGroupBox.Size = new System.Drawing.Size(340, 178);
            this.digerBilgilerGroupBox.TabIndex = 20;
            this.digerBilgilerGroupBox.TabStop = false;
            this.digerBilgilerGroupBox.Text = "Diğer Bilgiler";
            // 
            // aileGeliri
            // 
            this.aileGeliri.AutoSize = true;
            this.aileGeliri.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aileGeliri.Location = new System.Drawing.Point(114, 116);
            this.aileGeliri.Name = "aileGeliri";
            this.aileGeliri.Size = new System.Drawing.Size(0, 24);
            this.aileGeliri.TabIndex = 18;
            // 
            // sehitGazi
            // 
            this.sehitGazi.AutoSize = true;
            this.sehitGazi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehitGazi.Location = new System.Drawing.Point(280, 140);
            this.sehitGazi.Name = "sehitGazi";
            this.sehitGazi.Size = new System.Drawing.Size(0, 24);
            this.sehitGazi.TabIndex = 17;
            // 
            // kardesSayısı
            // 
            this.kardesSayısı.AutoSize = true;
            this.kardesSayısı.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardesSayısı.Location = new System.Drawing.Point(145, 44);
            this.kardesSayısı.Name = "kardesSayısı";
            this.kardesSayısı.Size = new System.Drawing.Size(0, 24);
            this.kardesSayısı.TabIndex = 16;
            // 
            // okuyanKardesSayısı
            // 
            this.okuyanKardesSayısı.AutoSize = true;
            this.okuyanKardesSayısı.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okuyanKardesSayısı.Location = new System.Drawing.Point(210, 68);
            this.okuyanKardesSayısı.Name = "okuyanKardesSayısı";
            this.okuyanKardesSayısı.Size = new System.Drawing.Size(0, 24);
            this.okuyanKardesSayısı.TabIndex = 15;
            // 
            // anneBabaMedeniDurumu
            // 
            this.anneBabaMedeniDurumu.AutoSize = true;
            this.anneBabaMedeniDurumu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneBabaMedeniDurumu.Location = new System.Drawing.Point(276, 92);
            this.anneBabaMedeniDurumu.Name = "anneBabaMedeniDurumu";
            this.anneBabaMedeniDurumu.Size = new System.Drawing.Size(0, 24);
            this.anneBabaMedeniDurumu.TabIndex = 14;
            // 
            // kardesSayısıLabel
            // 
            this.kardesSayısıLabel.AutoSize = true;
            this.kardesSayısıLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardesSayısıLabel.Location = new System.Drawing.Point(20, 44);
            this.kardesSayısıLabel.Name = "kardesSayısıLabel";
            this.kardesSayısıLabel.Size = new System.Drawing.Size(126, 24);
            this.kardesSayısıLabel.TabIndex = 13;
            this.kardesSayısıLabel.Text = "Kardeş Sayısı:";
            // 
            // okuyanKardesSayısıLabel
            // 
            this.okuyanKardesSayısıLabel.AutoSize = true;
            this.okuyanKardesSayısıLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okuyanKardesSayısıLabel.Location = new System.Drawing.Point(20, 68);
            this.okuyanKardesSayısıLabel.Name = "okuyanKardesSayısıLabel";
            this.okuyanKardesSayısıLabel.Size = new System.Drawing.Size(196, 24);
            this.okuyanKardesSayısıLabel.TabIndex = 12;
            this.okuyanKardesSayısıLabel.Text = "Okuyan Kardeş Sayısı:";
            // 
            // anneBabaMedeniDurumuLabel
            // 
            this.anneBabaMedeniDurumuLabel.AutoSize = true;
            this.anneBabaMedeniDurumuLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneBabaMedeniDurumuLabel.Location = new System.Drawing.Point(20, 92);
            this.anneBabaMedeniDurumuLabel.Name = "anneBabaMedeniDurumuLabel";
            this.anneBabaMedeniDurumuLabel.Size = new System.Drawing.Size(250, 24);
            this.anneBabaMedeniDurumuLabel.TabIndex = 11;
            this.anneBabaMedeniDurumuLabel.Text = "Anne Baba Medeni Durumu:";
            // 
            // sehitGaziLabel
            // 
            this.sehitGaziLabel.AutoSize = true;
            this.sehitGaziLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehitGaziLabel.Location = new System.Drawing.Point(20, 140);
            this.sehitGaziLabel.Name = "sehitGaziLabel";
            this.sehitGaziLabel.Size = new System.Drawing.Size(254, 24);
            this.sehitGaziLabel.TabIndex = 10;
            this.sehitGaziLabel.Text = "Şehit/Gazi çocuğu musunuz?:";
            // 
            // aileGeliriLabel
            // 
            this.aileGeliriLabel.AutoSize = true;
            this.aileGeliriLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aileGeliriLabel.Location = new System.Drawing.Point(20, 116);
            this.aileGeliriLabel.Name = "aileGeliriLabel";
            this.aileGeliriLabel.Size = new System.Drawing.Size(97, 24);
            this.aileGeliriLabel.TabIndex = 9;
            this.aileGeliriLabel.Text = "Aile Geliri:";
            // 
            // engelDurumuGroupBox
            // 
            this.engelDurumuGroupBox.Controls.Add(this.aciklamaLabel);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeValue1);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeValue2);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeValue3);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeComboBox1);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeComboBox2);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeComboBox3);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeLabel2);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeLabel3);
            this.engelDurumuGroupBox.Controls.Add(this.engelYüzdeLabel1);
            this.engelDurumuGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelDurumuGroupBox.Location = new System.Drawing.Point(17, 237);
            this.engelDurumuGroupBox.Name = "engelDurumuGroupBox";
            this.engelDurumuGroupBox.Size = new System.Drawing.Size(695, 274);
            this.engelDurumuGroupBox.TabIndex = 31;
            this.engelDurumuGroupBox.TabStop = false;
            this.engelDurumuGroupBox.Text = "Engel Durumu";
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciklamaLabel.Location = new System.Drawing.Point(17, 184);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(460, 54);
            this.aciklamaLabel.TabIndex = 29;
            this.aciklamaLabel.Text = resources.GetString("aciklamaLabel.Text");
            // 
            // engelYüzdeValue1
            // 
            this.engelYüzdeValue1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeValue1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeValue1.Location = new System.Drawing.Point(566, 61);
            this.engelYüzdeValue1.Name = "engelYüzdeValue1";
            this.engelYüzdeValue1.Size = new System.Drawing.Size(98, 29);
            this.engelYüzdeValue1.TabIndex = 28;
            // 
            // engelYüzdeValue2
            // 
            this.engelYüzdeValue2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeValue2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeValue2.Location = new System.Drawing.Point(566, 101);
            this.engelYüzdeValue2.Name = "engelYüzdeValue2";
            this.engelYüzdeValue2.Size = new System.Drawing.Size(98, 29);
            this.engelYüzdeValue2.TabIndex = 27;
            // 
            // engelYüzdeValue3
            // 
            this.engelYüzdeValue3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeValue3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeValue3.Location = new System.Drawing.Point(566, 142);
            this.engelYüzdeValue3.Name = "engelYüzdeValue3";
            this.engelYüzdeValue3.Size = new System.Drawing.Size(98, 29);
            this.engelYüzdeValue3.TabIndex = 26;
            // 
            // engelYüzdeComboBox1
            // 
            this.engelYüzdeComboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeComboBox1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeComboBox1.FormattingEnabled = true;
            this.engelYüzdeComboBox1.Items.AddRange(new object[] {
            "Görme",
            "İşitme",
            "Ortopedik",
            "Ruhsal ve Duygusal",
            "Dil ve Konuşma",
            "Zihinsel",
            "Süreğen Hastalıklar",
            "Sınıflanamayan",
            "Dikkat Eksikliği (Hiperaktif)",
            "Öğrenme Güçlüğü",
            "Asperger veya Yüksek Fonksiyonlu Otistik Bireyler",
            "Geçici Yetersizlikleri Olanlar"});
            this.engelYüzdeComboBox1.Location = new System.Drawing.Point(159, 61);
            this.engelYüzdeComboBox1.Name = "engelYüzdeComboBox1";
            this.engelYüzdeComboBox1.Size = new System.Drawing.Size(363, 30);
            this.engelYüzdeComboBox1.TabIndex = 25;
            // 
            // engelYüzdeComboBox2
            // 
            this.engelYüzdeComboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeComboBox2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeComboBox2.FormattingEnabled = true;
            this.engelYüzdeComboBox2.Items.AddRange(new object[] {
            "Görme",
            "İşitme",
            "Ortopedik",
            "Ruhsal ve Duygusal",
            "Dil ve Konuşma",
            "Zihinsel",
            "Süreğen Hastalıklar",
            "Sınıflanamayan",
            "Dikkat Eksikliği (Hiperaktif)",
            "Öğrenme Güçlüğü",
            "Asperger veya Yüksek Fonksiyonlu Otistik Bireyler",
            "Geçici Yetersizlikleri Olanlar"});
            this.engelYüzdeComboBox2.Location = new System.Drawing.Point(159, 101);
            this.engelYüzdeComboBox2.Name = "engelYüzdeComboBox2";
            this.engelYüzdeComboBox2.Size = new System.Drawing.Size(363, 30);
            this.engelYüzdeComboBox2.TabIndex = 24;
            // 
            // engelYüzdeComboBox3
            // 
            this.engelYüzdeComboBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeComboBox3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeComboBox3.FormattingEnabled = true;
            this.engelYüzdeComboBox3.Items.AddRange(new object[] {
            "Görme",
            "İşitme",
            "Ortopedik",
            "Ruhsal ve Duygusal",
            "Dil ve Konuşma",
            "Zihinsel",
            "Süreğen Hastalıklar",
            "Sınıflanamayan",
            "Dikkat Eksikliği (Hiperaktif)",
            "Öğrenme Güçlüğü",
            "Asperger veya Yüksek Fonksiyonlu Otistik Bireyler",
            "Geçici Yetersizlikleri Olanlar"});
            this.engelYüzdeComboBox3.Location = new System.Drawing.Point(159, 143);
            this.engelYüzdeComboBox3.Name = "engelYüzdeComboBox3";
            this.engelYüzdeComboBox3.Size = new System.Drawing.Size(363, 30);
            this.engelYüzdeComboBox3.TabIndex = 23;
            // 
            // engelYüzdeLabel2
            // 
            this.engelYüzdeLabel2.AutoSize = true;
            this.engelYüzdeLabel2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeLabel2.Location = new System.Drawing.Point(17, 103);
            this.engelYüzdeLabel2.Name = "engelYüzdeLabel2";
            this.engelYüzdeLabel2.Size = new System.Drawing.Size(139, 24);
            this.engelYüzdeLabel2.TabIndex = 22;
            this.engelYüzdeLabel2.Text = "Engel/Yüzde -2:";
            // 
            // engelYüzdeLabel3
            // 
            this.engelYüzdeLabel3.AutoSize = true;
            this.engelYüzdeLabel3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeLabel3.Location = new System.Drawing.Point(17, 144);
            this.engelYüzdeLabel3.Name = "engelYüzdeLabel3";
            this.engelYüzdeLabel3.Size = new System.Drawing.Size(138, 24);
            this.engelYüzdeLabel3.TabIndex = 21;
            this.engelYüzdeLabel3.Text = "Engel/Yüzde -3:";
            // 
            // engelYüzdeLabel1
            // 
            this.engelYüzdeLabel1.AutoSize = true;
            this.engelYüzdeLabel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeLabel1.Location = new System.Drawing.Point(17, 62);
            this.engelYüzdeLabel1.Name = "engelYüzdeLabel1";
            this.engelYüzdeLabel1.Size = new System.Drawing.Size(136, 24);
            this.engelYüzdeLabel1.TabIndex = 20;
            this.engelYüzdeLabel1.Text = "Engel/Yüzde -1:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1095, 520);
            this.Controls.Add(this.engelDurumuGroupBox);
            this.Controls.Add(this.digerBilgilerGroupBox);
            this.Controls.Add(this.babaGroupBox);
            this.Controls.Add(this.anneGroupBox);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.anneGroupBox.ResumeLayout(false);
            this.anneGroupBox.PerformLayout();
            this.babaGroupBox.ResumeLayout(false);
            this.babaGroupBox.PerformLayout();
            this.digerBilgilerGroupBox.ResumeLayout(false);
            this.digerBilgilerGroupBox.PerformLayout();
            this.engelDurumuGroupBox.ResumeLayout(false);
            this.engelDurumuGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox anneGroupBox;
        private System.Windows.Forms.Label anneCepTelefonuLabel;
        private System.Windows.Forms.Label anneSigortaLabel;
        private System.Windows.Forms.Label anneSagLabel;
        private System.Windows.Forms.GroupBox babaGroupBox;
        private System.Windows.Forms.Label babaCepTelefonuLabel;
        private System.Windows.Forms.Label babaSigortaLabel;
        private System.Windows.Forms.Label babaSagLabel;
        private System.Windows.Forms.GroupBox digerBilgilerGroupBox;
        private System.Windows.Forms.Label kardesSayısıLabel;
        private System.Windows.Forms.Label okuyanKardesSayısıLabel;
        private System.Windows.Forms.Label anneBabaMedeniDurumuLabel;
        private System.Windows.Forms.Label sehitGaziLabel;
        private System.Windows.Forms.Label aileGeliriLabel;
        private System.Windows.Forms.GroupBox engelDurumuGroupBox;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.Label engelYüzdeLabel2;
        private System.Windows.Forms.Label engelYüzdeLabel3;
        private System.Windows.Forms.Label engelYüzdeLabel1;
        public System.Windows.Forms.Button onaylaButton;
        public System.Windows.Forms.Button iptalButton;
        public System.Windows.Forms.TextBox engelYüzdeValue1;
        public System.Windows.Forms.TextBox engelYüzdeValue2;
        public System.Windows.Forms.TextBox engelYüzdeValue3;
        public System.Windows.Forms.ComboBox engelYüzdeComboBox1;
        public System.Windows.Forms.ComboBox engelYüzdeComboBox2;
        public System.Windows.Forms.ComboBox engelYüzdeComboBox3;
        public System.Windows.Forms.Label anneCepTelefonu;
        public System.Windows.Forms.Label anneSigorta;
        public System.Windows.Forms.Label anneSag;
        public System.Windows.Forms.Label babaSag;
        public System.Windows.Forms.Label babaSigorta;
        public System.Windows.Forms.Label babaCepTelefonu;
        public System.Windows.Forms.Label aileGeliri;
        public System.Windows.Forms.Label sehitGazi;
        public System.Windows.Forms.Label kardesSayısı;
        public System.Windows.Forms.Label okuyanKardesSayısı;
        public System.Windows.Forms.Label anneBabaMedeniDurumu;
    }
}