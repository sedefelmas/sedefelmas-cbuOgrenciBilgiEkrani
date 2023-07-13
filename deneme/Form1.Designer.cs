
namespace deneme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.anneSagEvet = new System.Windows.Forms.RadioButton();
            this.anneSigortaHayır = new System.Windows.Forms.RadioButton();
            this.anneSagHayır = new System.Windows.Forms.RadioButton();
            this.anneSigortaEvet = new System.Windows.Forms.RadioButton();
            this.anneSagLabel = new System.Windows.Forms.Label();
            this.anneSigortaLabel = new System.Windows.Forms.Label();
            this.anneGroupBox = new System.Windows.Forms.GroupBox();
            this.anneCepTelefonuValue = new System.Windows.Forms.TextBox();
            this.anneCepTelefonu = new System.Windows.Forms.Label();
            this.babaGroupBox = new System.Windows.Forms.GroupBox();
            this.babaCepTelefonuValue = new System.Windows.Forms.TextBox();
            this.babaCepTelefonu = new System.Windows.Forms.Label();
            this.babaSigortaLabel = new System.Windows.Forms.Label();
            this.babaSagLabel = new System.Windows.Forms.Label();
            this.babaSigortaEvet = new System.Windows.Forms.RadioButton();
            this.babaSagHayır = new System.Windows.Forms.RadioButton();
            this.babaSigortaHayır = new System.Windows.Forms.RadioButton();
            this.babaSagEvet = new System.Windows.Forms.RadioButton();
            this.aileGeliriLabel = new System.Windows.Forms.Label();
            this.sehitGaziLabel = new System.Windows.Forms.Label();
            this.anneBabaMedeniDurumuLabel = new System.Windows.Forms.Label();
            this.okuyanKardesSayısıLabel = new System.Windows.Forms.Label();
            this.kardesSayısıLabel = new System.Windows.Forms.Label();
            this.okuyanKardesSayısıValue = new System.Windows.Forms.TextBox();
            this.kardesSayısıValue = new System.Windows.Forms.TextBox();
            this.aileGeliriValue = new System.Windows.Forms.TextBox();
            this.anneBabaMedeniDurumuValue = new System.Windows.Forms.ComboBox();
            this.sehitGaziValue = new System.Windows.Forms.ComboBox();
            this.digerBilgilerGroupBox = new System.Windows.Forms.GroupBox();
            this.engelYüzdeLabel1 = new System.Windows.Forms.Label();
            this.engelYüzdeLabel3 = new System.Windows.Forms.Label();
            this.engelYüzdeLabel2 = new System.Windows.Forms.Label();
            this.engelYüzdeComboBox3 = new System.Windows.Forms.ComboBox();
            this.engelYüzdeComboBox2 = new System.Windows.Forms.ComboBox();
            this.engelYüzdeComboBox1 = new System.Windows.Forms.ComboBox();
            this.engelYüzdeValue3 = new System.Windows.Forms.TextBox();
            this.engelYüzdeValue2 = new System.Windows.Forms.TextBox();
            this.engelYüzdeValue1 = new System.Windows.Forms.TextBox();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.engelDurumuGroupBox = new System.Windows.Forms.GroupBox();
            this.kaydetButonu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.anneGroupBox.SuspendLayout();
            this.babaGroupBox.SuspendLayout();
            this.digerBilgilerGroupBox.SuspendLayout();
            this.engelDurumuGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // anneSagEvet
            // 
            this.anneSagEvet.AutoSize = true;
            this.anneSagEvet.BackColor = System.Drawing.SystemColors.Menu;
            this.anneSagEvet.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSagEvet.Location = new System.Drawing.Point(6, 14);
            this.anneSagEvet.Name = "anneSagEvet";
            this.anneSagEvet.Size = new System.Drawing.Size(67, 27);
            this.anneSagEvet.TabIndex = 0;
            this.anneSagEvet.TabStop = true;
            this.anneSagEvet.Text = "Evet";
            this.anneSagEvet.UseVisualStyleBackColor = false;
            this.anneSagEvet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // anneSigortaHayır
            // 
            this.anneSigortaHayır.AutoSize = true;
            this.anneSigortaHayır.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSigortaHayır.Location = new System.Drawing.Point(99, 0);
            this.anneSigortaHayır.Name = "anneSigortaHayır";
            this.anneSigortaHayır.Size = new System.Drawing.Size(73, 27);
            this.anneSigortaHayır.TabIndex = 1;
            this.anneSigortaHayır.TabStop = true;
            this.anneSigortaHayır.Text = "Hayır";
            this.anneSigortaHayır.UseVisualStyleBackColor = true;
            this.anneSigortaHayır.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // anneSagHayır
            // 
            this.anneSagHayır.AutoSize = true;
            this.anneSagHayır.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSagHayır.Location = new System.Drawing.Point(98, 14);
            this.anneSagHayır.Name = "anneSagHayır";
            this.anneSagHayır.Size = new System.Drawing.Size(73, 27);
            this.anneSagHayır.TabIndex = 2;
            this.anneSagHayır.TabStop = true;
            this.anneSagHayır.Text = "Hayır";
            this.anneSagHayır.UseVisualStyleBackColor = true;
            // 
            // anneSigortaEvet
            // 
            this.anneSigortaEvet.AutoSize = true;
            this.anneSigortaEvet.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSigortaEvet.Location = new System.Drawing.Point(3, 0);
            this.anneSigortaEvet.Name = "anneSigortaEvet";
            this.anneSigortaEvet.Size = new System.Drawing.Size(67, 27);
            this.anneSigortaEvet.TabIndex = 3;
            this.anneSigortaEvet.TabStop = true;
            this.anneSigortaEvet.Text = "Evet";
            this.anneSigortaEvet.UseVisualStyleBackColor = true;
            // 
            // anneSagLabel
            // 
            this.anneSagLabel.AutoSize = true;
            this.anneSagLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSagLabel.Location = new System.Drawing.Point(188, 58);
            this.anneSagLabel.Name = "anneSagLabel";
            this.anneSagLabel.Size = new System.Drawing.Size(46, 24);
            this.anneSagLabel.TabIndex = 5;
            this.anneSagLabel.Text = "Sağ:";
            // 
            // anneSigortaLabel
            // 
            this.anneSigortaLabel.AutoSize = true;
            this.anneSigortaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneSigortaLabel.Location = new System.Drawing.Point(2, 105);
            this.anneSigortaLabel.Name = "anneSigortaLabel";
            this.anneSigortaLabel.Size = new System.Drawing.Size(232, 24);
            this.anneSigortaLabel.TabIndex = 6;
            this.anneSigortaLabel.Text = "Sigorta Güvencesi var mı?:";
            // 
            // anneGroupBox
            // 
            this.anneGroupBox.Controls.Add(this.panel2);
            this.anneGroupBox.Controls.Add(this.panel1);
            this.anneGroupBox.Controls.Add(this.anneCepTelefonuValue);
            this.anneGroupBox.Controls.Add(this.anneCepTelefonu);
            this.anneGroupBox.Controls.Add(this.anneSigortaLabel);
            this.anneGroupBox.Controls.Add(this.anneSagLabel);
            this.anneGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneGroupBox.Location = new System.Drawing.Point(10, 27);
            this.anneGroupBox.Name = "anneGroupBox";
            this.anneGroupBox.Size = new System.Drawing.Size(461, 243);
            this.anneGroupBox.TabIndex = 7;
            this.anneGroupBox.TabStop = false;
            this.anneGroupBox.Text = "Anne";
            // 
            // anneCepTelefonuValue
            // 
            this.anneCepTelefonuValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.anneCepTelefonuValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneCepTelefonuValue.Location = new System.Drawing.Point(241, 155);
            this.anneCepTelefonuValue.Name = "anneCepTelefonuValue";
            this.anneCepTelefonuValue.Size = new System.Drawing.Size(169, 29);
            this.anneCepTelefonuValue.TabIndex = 8;
            // 
            // anneCepTelefonu
            // 
            this.anneCepTelefonu.AutoSize = true;
            this.anneCepTelefonu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneCepTelefonu.Location = new System.Drawing.Point(108, 156);
            this.anneCepTelefonu.Name = "anneCepTelefonu";
            this.anneCepTelefonu.Size = new System.Drawing.Size(126, 24);
            this.anneCepTelefonu.TabIndex = 7;
            this.anneCepTelefonu.Text = "Cep Telefonu:";
            this.anneCepTelefonu.Click += new System.EventHandler(this.anneCepTelefonu_Click);
            // 
            // babaGroupBox
            // 
            this.babaGroupBox.Controls.Add(this.panel4);
            this.babaGroupBox.Controls.Add(this.panel3);
            this.babaGroupBox.Controls.Add(this.babaCepTelefonuValue);
            this.babaGroupBox.Controls.Add(this.babaCepTelefonu);
            this.babaGroupBox.Controls.Add(this.babaSigortaLabel);
            this.babaGroupBox.Controls.Add(this.babaSagLabel);
            this.babaGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaGroupBox.Location = new System.Drawing.Point(495, 27);
            this.babaGroupBox.Name = "babaGroupBox";
            this.babaGroupBox.Size = new System.Drawing.Size(483, 243);
            this.babaGroupBox.TabIndex = 8;
            this.babaGroupBox.TabStop = false;
            this.babaGroupBox.Text = "Baba";
            // 
            // babaCepTelefonuValue
            // 
            this.babaCepTelefonuValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.babaCepTelefonuValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaCepTelefonuValue.Location = new System.Drawing.Point(240, 154);
            this.babaCepTelefonuValue.Name = "babaCepTelefonuValue";
            this.babaCepTelefonuValue.Size = new System.Drawing.Size(169, 29);
            this.babaCepTelefonuValue.TabIndex = 8;
            // 
            // babaCepTelefonu
            // 
            this.babaCepTelefonu.AutoSize = true;
            this.babaCepTelefonu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaCepTelefonu.Location = new System.Drawing.Point(108, 155);
            this.babaCepTelefonu.Name = "babaCepTelefonu";
            this.babaCepTelefonu.Size = new System.Drawing.Size(126, 24);
            this.babaCepTelefonu.TabIndex = 7;
            this.babaCepTelefonu.Text = "Cep Telefonu:";
            // 
            // babaSigortaLabel
            // 
            this.babaSigortaLabel.AutoSize = true;
            this.babaSigortaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSigortaLabel.Location = new System.Drawing.Point(2, 105);
            this.babaSigortaLabel.Name = "babaSigortaLabel";
            this.babaSigortaLabel.Size = new System.Drawing.Size(232, 24);
            this.babaSigortaLabel.TabIndex = 6;
            this.babaSigortaLabel.Text = "Sigorta Güvencesi var mı?:";
            // 
            // babaSagLabel
            // 
            this.babaSagLabel.AutoSize = true;
            this.babaSagLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSagLabel.Location = new System.Drawing.Point(188, 58);
            this.babaSagLabel.Name = "babaSagLabel";
            this.babaSagLabel.Size = new System.Drawing.Size(46, 24);
            this.babaSagLabel.TabIndex = 5;
            this.babaSagLabel.Text = "Sağ:";
            // 
            // babaSigortaEvet
            // 
            this.babaSigortaEvet.AutoSize = true;
            this.babaSigortaEvet.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSigortaEvet.Location = new System.Drawing.Point(10, 2);
            this.babaSigortaEvet.Name = "babaSigortaEvet";
            this.babaSigortaEvet.Size = new System.Drawing.Size(67, 27);
            this.babaSigortaEvet.TabIndex = 3;
            this.babaSigortaEvet.TabStop = true;
            this.babaSigortaEvet.Text = "Evet";
            this.babaSigortaEvet.UseVisualStyleBackColor = true;
            // 
            // babaSagHayır
            // 
            this.babaSagHayır.AutoSize = true;
            this.babaSagHayır.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSagHayır.Location = new System.Drawing.Point(95, 3);
            this.babaSagHayır.Name = "babaSagHayır";
            this.babaSagHayır.Size = new System.Drawing.Size(73, 27);
            this.babaSagHayır.TabIndex = 2;
            this.babaSagHayır.TabStop = true;
            this.babaSagHayır.Text = "Hayır";
            this.babaSagHayır.UseVisualStyleBackColor = true;
            // 
            // babaSigortaHayır
            // 
            this.babaSigortaHayır.AutoSize = true;
            this.babaSigortaHayır.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSigortaHayır.Location = new System.Drawing.Point(95, 2);
            this.babaSigortaHayır.Name = "babaSigortaHayır";
            this.babaSigortaHayır.Size = new System.Drawing.Size(73, 27);
            this.babaSigortaHayır.TabIndex = 1;
            this.babaSigortaHayır.TabStop = true;
            this.babaSigortaHayır.Text = "Hayır";
            this.babaSigortaHayır.UseVisualStyleBackColor = true;
            // 
            // babaSagEvet
            // 
            this.babaSagEvet.AutoSize = true;
            this.babaSagEvet.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaSagEvet.Location = new System.Drawing.Point(10, 3);
            this.babaSagEvet.Name = "babaSagEvet";
            this.babaSagEvet.Size = new System.Drawing.Size(67, 27);
            this.babaSagEvet.TabIndex = 0;
            this.babaSagEvet.TabStop = true;
            this.babaSagEvet.Text = "Evet";
            this.babaSagEvet.UseVisualStyleBackColor = true;
            // 
            // aileGeliriLabel
            // 
            this.aileGeliriLabel.AutoSize = true;
            this.aileGeliriLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aileGeliriLabel.Location = new System.Drawing.Point(162, 179);
            this.aileGeliriLabel.Name = "aileGeliriLabel";
            this.aileGeliriLabel.Size = new System.Drawing.Size(97, 24);
            this.aileGeliriLabel.TabIndex = 9;
            this.aileGeliriLabel.Text = "Aile Geliri:";
            // 
            // sehitGaziLabel
            // 
            this.sehitGaziLabel.AutoSize = true;
            this.sehitGaziLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehitGaziLabel.Location = new System.Drawing.Point(5, 221);
            this.sehitGaziLabel.Name = "sehitGaziLabel";
            this.sehitGaziLabel.Size = new System.Drawing.Size(254, 24);
            this.sehitGaziLabel.TabIndex = 10;
            this.sehitGaziLabel.Text = "Şehit/Gazi çocuğu musunuz?:";
            // 
            // anneBabaMedeniDurumuLabel
            // 
            this.anneBabaMedeniDurumuLabel.AutoSize = true;
            this.anneBabaMedeniDurumuLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneBabaMedeniDurumuLabel.Location = new System.Drawing.Point(9, 138);
            this.anneBabaMedeniDurumuLabel.Name = "anneBabaMedeniDurumuLabel";
            this.anneBabaMedeniDurumuLabel.Size = new System.Drawing.Size(250, 24);
            this.anneBabaMedeniDurumuLabel.TabIndex = 11;
            this.anneBabaMedeniDurumuLabel.Text = "Anne Baba Medeni Durumu:";
            // 
            // okuyanKardesSayısıLabel
            // 
            this.okuyanKardesSayısıLabel.AutoSize = true;
            this.okuyanKardesSayısıLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okuyanKardesSayısıLabel.Location = new System.Drawing.Point(63, 100);
            this.okuyanKardesSayısıLabel.Name = "okuyanKardesSayısıLabel";
            this.okuyanKardesSayısıLabel.Size = new System.Drawing.Size(196, 24);
            this.okuyanKardesSayısıLabel.TabIndex = 12;
            this.okuyanKardesSayısıLabel.Text = "Okuyan Kardeş Sayısı:";
            // 
            // kardesSayısıLabel
            // 
            this.kardesSayısıLabel.AutoSize = true;
            this.kardesSayısıLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardesSayısıLabel.Location = new System.Drawing.Point(133, 60);
            this.kardesSayısıLabel.Name = "kardesSayısıLabel";
            this.kardesSayısıLabel.Size = new System.Drawing.Size(126, 24);
            this.kardesSayısıLabel.TabIndex = 13;
            this.kardesSayısıLabel.Text = "Kardeş Sayısı:";
            this.kardesSayısıLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // okuyanKardesSayısıValue
            // 
            this.okuyanKardesSayısıValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.okuyanKardesSayısıValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okuyanKardesSayısıValue.Location = new System.Drawing.Point(265, 100);
            this.okuyanKardesSayısıValue.Name = "okuyanKardesSayısıValue";
            this.okuyanKardesSayısıValue.Size = new System.Drawing.Size(169, 29);
            this.okuyanKardesSayısıValue.TabIndex = 14;
            // 
            // kardesSayısıValue
            // 
            this.kardesSayısıValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kardesSayısıValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardesSayısıValue.Location = new System.Drawing.Point(265, 60);
            this.kardesSayısıValue.Name = "kardesSayısıValue";
            this.kardesSayısıValue.Size = new System.Drawing.Size(169, 29);
            this.kardesSayısıValue.TabIndex = 15;
            this.kardesSayısıValue.TextChanged += new System.EventHandler(this.kardesSayısıValue_TextChanged);
            // 
            // aileGeliriValue
            // 
            this.aileGeliriValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.aileGeliriValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aileGeliriValue.Location = new System.Drawing.Point(265, 178);
            this.aileGeliriValue.Name = "aileGeliriValue";
            this.aileGeliriValue.Size = new System.Drawing.Size(169, 29);
            this.aileGeliriValue.TabIndex = 16;
            // 
            // anneBabaMedeniDurumuValue
            // 
            this.anneBabaMedeniDurumuValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.anneBabaMedeniDurumuValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneBabaMedeniDurumuValue.FormattingEnabled = true;
            this.anneBabaMedeniDurumuValue.Items.AddRange(new object[] {
            "Evli",
            "Dul",
            "Boşanmış"});
            this.anneBabaMedeniDurumuValue.Location = new System.Drawing.Point(265, 141);
            this.anneBabaMedeniDurumuValue.Name = "anneBabaMedeniDurumuValue";
            this.anneBabaMedeniDurumuValue.Size = new System.Drawing.Size(169, 30);
            this.anneBabaMedeniDurumuValue.TabIndex = 17;
            // 
            // sehitGaziValue
            // 
            this.sehitGaziValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sehitGaziValue.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehitGaziValue.FormattingEnabled = true;
            this.sehitGaziValue.Items.AddRange(new object[] {
            "Şehit",
            "Gazi"});
            this.sehitGaziValue.Location = new System.Drawing.Point(265, 215);
            this.sehitGaziValue.Name = "sehitGaziValue";
            this.sehitGaziValue.Size = new System.Drawing.Size(169, 30);
            this.sehitGaziValue.TabIndex = 18;
            // 
            // digerBilgilerGroupBox
            // 
            this.digerBilgilerGroupBox.Controls.Add(this.sehitGaziValue);
            this.digerBilgilerGroupBox.Controls.Add(this.anneBabaMedeniDurumuValue);
            this.digerBilgilerGroupBox.Controls.Add(this.aileGeliriValue);
            this.digerBilgilerGroupBox.Controls.Add(this.kardesSayısıValue);
            this.digerBilgilerGroupBox.Controls.Add(this.okuyanKardesSayısıValue);
            this.digerBilgilerGroupBox.Controls.Add(this.kardesSayısıLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.okuyanKardesSayısıLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.anneBabaMedeniDurumuLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.sehitGaziLabel);
            this.digerBilgilerGroupBox.Controls.Add(this.aileGeliriLabel);
            this.digerBilgilerGroupBox.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digerBilgilerGroupBox.Location = new System.Drawing.Point(10, 295);
            this.digerBilgilerGroupBox.Name = "digerBilgilerGroupBox";
            this.digerBilgilerGroupBox.Size = new System.Drawing.Size(461, 274);
            this.digerBilgilerGroupBox.TabIndex = 19;
            this.digerBilgilerGroupBox.TabStop = false;
            this.digerBilgilerGroupBox.Text = "Diğer Bilgiler";
            // 
            // engelYüzdeLabel1
            // 
            this.engelYüzdeLabel1.AutoSize = true;
            this.engelYüzdeLabel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeLabel1.Location = new System.Drawing.Point(6, 59);
            this.engelYüzdeLabel1.Name = "engelYüzdeLabel1";
            this.engelYüzdeLabel1.Size = new System.Drawing.Size(136, 24);
            this.engelYüzdeLabel1.TabIndex = 20;
            this.engelYüzdeLabel1.Text = "Engel/Yüzde -1:";
            // 
            // engelYüzdeLabel3
            // 
            this.engelYüzdeLabel3.AutoSize = true;
            this.engelYüzdeLabel3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeLabel3.Location = new System.Drawing.Point(6, 141);
            this.engelYüzdeLabel3.Name = "engelYüzdeLabel3";
            this.engelYüzdeLabel3.Size = new System.Drawing.Size(138, 24);
            this.engelYüzdeLabel3.TabIndex = 21;
            this.engelYüzdeLabel3.Text = "Engel/Yüzde -3:";
            // 
            // engelYüzdeLabel2
            // 
            this.engelYüzdeLabel2.AutoSize = true;
            this.engelYüzdeLabel2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeLabel2.Location = new System.Drawing.Point(6, 100);
            this.engelYüzdeLabel2.Name = "engelYüzdeLabel2";
            this.engelYüzdeLabel2.Size = new System.Drawing.Size(139, 24);
            this.engelYüzdeLabel2.TabIndex = 22;
            this.engelYüzdeLabel2.Text = "Engel/Yüzde -2:";
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
            this.engelYüzdeComboBox3.Location = new System.Drawing.Point(148, 140);
            this.engelYüzdeComboBox3.Name = "engelYüzdeComboBox3";
            this.engelYüzdeComboBox3.Size = new System.Drawing.Size(169, 30);
            this.engelYüzdeComboBox3.TabIndex = 23;
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
            this.engelYüzdeComboBox2.Location = new System.Drawing.Point(148, 98);
            this.engelYüzdeComboBox2.Name = "engelYüzdeComboBox2";
            this.engelYüzdeComboBox2.Size = new System.Drawing.Size(169, 30);
            this.engelYüzdeComboBox2.TabIndex = 24;
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
            this.engelYüzdeComboBox1.Location = new System.Drawing.Point(148, 58);
            this.engelYüzdeComboBox1.Name = "engelYüzdeComboBox1";
            this.engelYüzdeComboBox1.Size = new System.Drawing.Size(169, 30);
            this.engelYüzdeComboBox1.TabIndex = 25;
            // 
            // engelYüzdeValue3
            // 
            this.engelYüzdeValue3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeValue3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeValue3.Location = new System.Drawing.Point(341, 139);
            this.engelYüzdeValue3.Name = "engelYüzdeValue3";
            this.engelYüzdeValue3.Size = new System.Drawing.Size(98, 29);
            this.engelYüzdeValue3.TabIndex = 26;
            // 
            // engelYüzdeValue2
            // 
            this.engelYüzdeValue2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeValue2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeValue2.Location = new System.Drawing.Point(341, 98);
            this.engelYüzdeValue2.Name = "engelYüzdeValue2";
            this.engelYüzdeValue2.Size = new System.Drawing.Size(98, 29);
            this.engelYüzdeValue2.TabIndex = 27;
            // 
            // engelYüzdeValue1
            // 
            this.engelYüzdeValue1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.engelYüzdeValue1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engelYüzdeValue1.Location = new System.Drawing.Point(341, 59);
            this.engelYüzdeValue1.Name = "engelYüzdeValue1";
            this.engelYüzdeValue1.Size = new System.Drawing.Size(98, 29);
            this.engelYüzdeValue1.TabIndex = 28;
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciklamaLabel.Location = new System.Drawing.Point(6, 181);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(460, 54);
            this.aciklamaLabel.TabIndex = 29;
            this.aciklamaLabel.Text = resources.GetString("aciklamaLabel.Text");
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
            this.engelDurumuGroupBox.Location = new System.Drawing.Point(495, 295);
            this.engelDurumuGroupBox.Name = "engelDurumuGroupBox";
            this.engelDurumuGroupBox.Size = new System.Drawing.Size(483, 274);
            this.engelDurumuGroupBox.TabIndex = 30;
            this.engelDurumuGroupBox.TabStop = false;
            this.engelDurumuGroupBox.Text = "Engel Durumu";
            // 
            // kaydetButonu
            // 
            this.kaydetButonu.BackColor = System.Drawing.Color.YellowGreen;
            this.kaydetButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetButonu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydetButonu.Location = new System.Drawing.Point(786, 641);
            this.kaydetButonu.Name = "kaydetButonu";
            this.kaydetButonu.Size = new System.Drawing.Size(136, 46);
            this.kaydetButonu.TabIndex = 31;
            this.kaydetButonu.Text = "Kaydet";
            this.kaydetButonu.UseVisualStyleBackColor = false;
            this.kaydetButonu.Click += new System.EventHandler(this.kaydetButonu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.anneSagEvet);
            this.panel1.Controls.Add(this.anneSagHayır);
            this.panel1.Location = new System.Drawing.Point(240, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 53);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.anneSigortaEvet);
            this.panel2.Controls.Add(this.anneSigortaHayır);
            this.panel2.Location = new System.Drawing.Point(240, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 44);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.babaSagEvet);
            this.panel3.Controls.Add(this.babaSagHayır);
            this.panel3.Location = new System.Drawing.Point(241, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 41);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.babaSigortaEvet);
            this.panel4.Controls.Add(this.babaSigortaHayır);
            this.panel4.Location = new System.Drawing.Point(241, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 45);
            this.panel4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(991, 733);
            this.Controls.Add(this.kaydetButonu);
            this.Controls.Add(this.engelDurumuGroupBox);
            this.Controls.Add(this.digerBilgilerGroupBox);
            this.Controls.Add(this.babaGroupBox);
            this.Controls.Add(this.anneGroupBox);
            this.Name = "Form1";
            this.Text = "CBÜ Öğrenci Bilgi Ekranı";
            this.anneGroupBox.ResumeLayout(false);
            this.anneGroupBox.PerformLayout();
            this.babaGroupBox.ResumeLayout(false);
            this.babaGroupBox.PerformLayout();
            this.digerBilgilerGroupBox.ResumeLayout(false);
            this.digerBilgilerGroupBox.PerformLayout();
            this.engelDurumuGroupBox.ResumeLayout(false);
            this.engelDurumuGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton anneSagEvet;
        private System.Windows.Forms.RadioButton anneSigortaHayır;
        private System.Windows.Forms.RadioButton anneSagHayır;
        private System.Windows.Forms.RadioButton anneSigortaEvet;
        private System.Windows.Forms.Label anneSagLabel;
        private System.Windows.Forms.Label anneSigortaLabel;
        private System.Windows.Forms.GroupBox anneGroupBox;
        private System.Windows.Forms.TextBox anneCepTelefonuValue;
        private System.Windows.Forms.Label anneCepTelefonu;
        private System.Windows.Forms.GroupBox babaGroupBox;
        private System.Windows.Forms.TextBox babaCepTelefonuValue;
        private System.Windows.Forms.Label babaCepTelefonu;
        private System.Windows.Forms.Label babaSigortaLabel;
        private System.Windows.Forms.Label babaSagLabel;
        private System.Windows.Forms.RadioButton babaSigortaEvet;
        private System.Windows.Forms.RadioButton babaSagHayır;
        private System.Windows.Forms.RadioButton babaSigortaHayır;
        private System.Windows.Forms.RadioButton babaSagEvet;
        private System.Windows.Forms.Label aileGeliriLabel;
        private System.Windows.Forms.Label sehitGaziLabel;
        private System.Windows.Forms.Label anneBabaMedeniDurumuLabel;
        private System.Windows.Forms.Label okuyanKardesSayısıLabel;
        private System.Windows.Forms.Label kardesSayısıLabel;
        private System.Windows.Forms.TextBox okuyanKardesSayısıValue;
        private System.Windows.Forms.TextBox kardesSayısıValue;
        private System.Windows.Forms.TextBox aileGeliriValue;
        private System.Windows.Forms.ComboBox anneBabaMedeniDurumuValue;
        private System.Windows.Forms.ComboBox sehitGaziValue;
        private System.Windows.Forms.GroupBox digerBilgilerGroupBox;
        private System.Windows.Forms.Label engelYüzdeLabel1;
        private System.Windows.Forms.Label engelYüzdeLabel3;
        private System.Windows.Forms.Label engelYüzdeLabel2;
        private System.Windows.Forms.ComboBox engelYüzdeComboBox3;
        private System.Windows.Forms.ComboBox engelYüzdeComboBox2;
        private System.Windows.Forms.ComboBox engelYüzdeComboBox1;
        private System.Windows.Forms.TextBox engelYüzdeValue3;
        private System.Windows.Forms.TextBox engelYüzdeValue2;
        private System.Windows.Forms.TextBox engelYüzdeValue1;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.GroupBox engelDurumuGroupBox;
        private System.Windows.Forms.Button kaydetButonu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

