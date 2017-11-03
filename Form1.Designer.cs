namespace Travelmanegementsystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfristname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtpostcode = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdeparture = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdestination = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtaccommodation = new System.Windows.Forms.ComboBox();
            this.chairporttax = new System.Windows.Forms.CheckBox();
            this.chairmilesover = new System.Windows.Forms.CheckBox();
            this.chtravelinsurance = new System.Windows.Forms.CheckBox();
            this.chextluggage = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rbstandard = new System.Windows.Forms.RadioButton();
            this.rbeconomy = new System.Windows.Forms.RadioButton();
            this.rbfristclass = new System.Windows.Forms.RadioButton();
            this.chsingle = new System.Windows.Forms.CheckBox();
            this.chreturn = new System.Windows.Forms.CheckBox();
            this.chspecialneeds = new System.Windows.Forms.CheckBox();
            this.chadult = new System.Windows.Forms.CheckBox();
            this.chchild = new System.Windows.Forms.CheckBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel Management system";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txttelephone);
            this.panel1.Controls.Add(this.txtpostcode);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtsurname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtfristname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(19, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 316);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chextluggage);
            this.panel2.Controls.Add(this.chtravelinsurance);
            this.panel2.Controls.Add(this.chairmilesover);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chairporttax);
            this.panel2.Controls.Add(this.txtaccommodation);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtdestination);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtdeparture);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(360, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 316);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 168);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.chchild);
            this.panel5.Controls.Add(this.chadult);
            this.panel5.Controls.Add(this.chspecialneeds);
            this.panel5.Controls.Add(this.chreturn);
            this.panel5.Controls.Add(this.chsingle);
            this.panel5.Controls.Add(this.rbfristclass);
            this.panel5.Controls.Add(this.rbeconomy);
            this.panel5.Controls.Add(this.rbstandard);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(19, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 168);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnreset);
            this.panel6.Controls.Add(this.btnexit);
            this.panel6.Controls.Add(this.btntotal);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txttotal);
            this.panel6.Controls.Add(this.txttax);
            this.panel6.Controls.Add(this.txtsubtotal);
            this.panel6.Location = new System.Drawing.Point(425, 420);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 168);
            this.panel6.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fristname";
            // 
            // txtfristname
            // 
            this.txtfristname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtfristname.Location = new System.Drawing.Point(102, 28);
            this.txtfristname.Multiline = true;
            this.txtfristname.Name = "txtfristname";
            this.txtfristname.Size = new System.Drawing.Size(206, 30);
            this.txtfristname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Post Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // txtsurname
            // 
            this.txtsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsurname.Location = new System.Drawing.Point(102, 72);
            this.txtsurname.Multiline = true;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(206, 30);
            this.txtsurname.TabIndex = 13;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtaddress.Location = new System.Drawing.Point(102, 120);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(206, 30);
            this.txtaddress.TabIndex = 14;
            // 
            // txtpostcode
            // 
            this.txtpostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpostcode.Location = new System.Drawing.Point(102, 164);
            this.txtpostcode.Multiline = true;
            this.txtpostcode.Name = "txtpostcode";
            this.txtpostcode.Size = new System.Drawing.Size(206, 30);
            this.txtpostcode.TabIndex = 15;
            // 
            // txttelephone
            // 
            this.txttelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txttelephone.Location = new System.Drawing.Point(102, 210);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(206, 30);
            this.txttelephone.TabIndex = 16;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtemail.Location = new System.Drawing.Point(102, 261);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(206, 30);
            this.txtemail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Departure";
            // 
            // txtdeparture
            // 
            this.txtdeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtdeparture.FormattingEnabled = true;
            this.txtdeparture.Items.AddRange(new object[] {
            "None",
            "Mumbai",
            "Dubai",
            "Male",
            "Kuala Lumpur",
            "Chengdu",
            "Melbourne",
            "Hong Knog",
            "Chennai",
            "Singapore",
            "Bangalore",
            "Bangkok",
            "Guangzhou",
            "Doha",
            "Hyderabad",
            "Muscat"});
            this.txtdeparture.Location = new System.Drawing.Point(169, 28);
            this.txtdeparture.Name = "txtdeparture";
            this.txtdeparture.Size = new System.Drawing.Size(215, 33);
            this.txtdeparture.TabIndex = 8;
            this.txtdeparture.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Destination";
            // 
            // txtdestination
            // 
            this.txtdestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtdestination.FormattingEnabled = true;
            this.txtdestination.Items.AddRange(new object[] {
            "None",
            "Mumbai  - 1day",
            "Dubai - 1day",
            "Male - 1day",
            "Kuala Lumpur - 1day",
            "Chengdu - 1day",
            "Melbourne - 1day",
            "Hong Knog - 1day",
            "Chennai - 1day",
            "Singapore - 1day",
            "Bangalore - 1day",
            "Bangkok - 1day",
            "Guangzhou - 1day",
            "Doha - 1day",
            "Hyderabad - 1day",
            "Muscat - 1day"});
            this.txtdestination.Location = new System.Drawing.Point(168, 111);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(215, 33);
            this.txtdestination.TabIndex = 10;
            this.txtdestination.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Accommodation";
            // 
            // txtaccommodation
            // 
            this.txtaccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtaccommodation.FormattingEnabled = true;
            this.txtaccommodation.Items.AddRange(new object[] {
            "None",
            "Single",
            "Double",
            "Extra"});
            this.txtaccommodation.Location = new System.Drawing.Point(169, 190);
            this.txtaccommodation.Name = "txtaccommodation";
            this.txtaccommodation.Size = new System.Drawing.Size(215, 33);
            this.txtaccommodation.TabIndex = 12;
            this.txtaccommodation.Text = "None";
            // 
            // chairporttax
            // 
            this.chairporttax.AutoSize = true;
            this.chairporttax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chairporttax.Location = new System.Drawing.Point(16, 244);
            this.chairporttax.Name = "chairporttax";
            this.chairporttax.Size = new System.Drawing.Size(103, 20);
            this.chairporttax.TabIndex = 13;
            this.chairporttax.Text = "Airport Tax";
            this.chairporttax.UseVisualStyleBackColor = true;
            // 
            // chairmilesover
            // 
            this.chairmilesover.AutoSize = true;
            this.chairmilesover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chairmilesover.Location = new System.Drawing.Point(210, 244);
            this.chairmilesover.Name = "chairmilesover";
            this.chairmilesover.Size = new System.Drawing.Size(168, 20);
            this.chairmilesover.TabIndex = 14;
            this.chairmilesover.Text = "Air Miles Over 20000";
            this.chairmilesover.UseVisualStyleBackColor = true;
            // 
            // chtravelinsurance
            // 
            this.chtravelinsurance.AutoSize = true;
            this.chtravelinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chtravelinsurance.Location = new System.Drawing.Point(16, 286);
            this.chtravelinsurance.Name = "chtravelinsurance";
            this.chtravelinsurance.Size = new System.Drawing.Size(143, 20);
            this.chtravelinsurance.TabIndex = 15;
            this.chtravelinsurance.Text = "Travel Insurance";
            this.chtravelinsurance.UseVisualStyleBackColor = true;
            // 
            // chextluggage
            // 
            this.chextluggage.AutoSize = true;
            this.chextluggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chextluggage.Location = new System.Drawing.Point(235, 286);
            this.chextluggage.Name = "chextluggage";
            this.chextluggage.Size = new System.Drawing.Size(113, 20);
            this.chextluggage.TabIndex = 16;
            this.chextluggage.Text = "Ext Luggage";
            this.chextluggage.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(11, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Flight";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(152, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ticket";
            // 
            // rbstandard
            // 
            this.rbstandard.AutoSize = true;
            this.rbstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbstandard.Location = new System.Drawing.Point(15, 56);
            this.rbstandard.Name = "rbstandard";
            this.rbstandard.Size = new System.Drawing.Size(89, 20);
            this.rbstandard.TabIndex = 2;
            this.rbstandard.TabStop = true;
            this.rbstandard.Text = "Standard";
            this.rbstandard.UseVisualStyleBackColor = true;
            // 
            // rbeconomy
            // 
            this.rbeconomy.AutoSize = true;
            this.rbeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbeconomy.Location = new System.Drawing.Point(15, 92);
            this.rbeconomy.Name = "rbeconomy";
            this.rbeconomy.Size = new System.Drawing.Size(90, 20);
            this.rbeconomy.TabIndex = 3;
            this.rbeconomy.TabStop = true;
            this.rbeconomy.Text = "Economy";
            this.rbeconomy.UseVisualStyleBackColor = true;
            // 
            // rbfristclass
            // 
            this.rbfristclass.AutoSize = true;
            this.rbfristclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbfristclass.Location = new System.Drawing.Point(15, 129);
            this.rbfristclass.Name = "rbfristclass";
            this.rbfristclass.Size = new System.Drawing.Size(99, 20);
            this.rbfristclass.TabIndex = 4;
            this.rbfristclass.TabStop = true;
            this.rbfristclass.Text = "Frist Class";
            this.rbfristclass.UseVisualStyleBackColor = true;
            // 
            // chsingle
            // 
            this.chsingle.AutoSize = true;
            this.chsingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chsingle.Location = new System.Drawing.Point(156, 57);
            this.chsingle.Name = "chsingle";
            this.chsingle.Size = new System.Drawing.Size(71, 20);
            this.chsingle.TabIndex = 17;
            this.chsingle.Text = "Single";
            this.chsingle.UseVisualStyleBackColor = true;
            // 
            // chreturn
            // 
            this.chreturn.AutoSize = true;
            this.chreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chreturn.Location = new System.Drawing.Point(156, 93);
            this.chreturn.Name = "chreturn";
            this.chreturn.Size = new System.Drawing.Size(72, 20);
            this.chreturn.TabIndex = 18;
            this.chreturn.Text = "Return";
            this.chreturn.UseVisualStyleBackColor = true;
            // 
            // chspecialneeds
            // 
            this.chspecialneeds.AutoSize = true;
            this.chspecialneeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chspecialneeds.Location = new System.Drawing.Point(156, 130);
            this.chspecialneeds.Name = "chspecialneeds";
            this.chspecialneeds.Size = new System.Drawing.Size(130, 20);
            this.chspecialneeds.TabIndex = 19;
            this.chspecialneeds.Text = "Special Needs";
            this.chspecialneeds.UseVisualStyleBackColor = true;
            // 
            // chadult
            // 
            this.chadult.AutoSize = true;
            this.chadult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chadult.Location = new System.Drawing.Point(300, 57);
            this.chadult.Name = "chadult";
            this.chadult.Size = new System.Drawing.Size(62, 20);
            this.chadult.TabIndex = 20;
            this.chadult.Text = "Adult";
            this.chadult.UseVisualStyleBackColor = true;
            // 
            // chchild
            // 
            this.chchild.AutoSize = true;
            this.chchild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chchild.Location = new System.Drawing.Point(300, 93);
            this.chchild.Name = "chchild";
            this.chchild.Size = new System.Drawing.Size(62, 20);
            this.chchild.TabIndex = 21;
            this.chchild.Text = "Child";
            this.chchild.UseVisualStyleBackColor = true;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsubtotal.Location = new System.Drawing.Point(130, 13);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(206, 30);
            this.txtsubtotal.TabIndex = 18;
            // 
            // txttax
            // 
            this.txttax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txttax.Location = new System.Drawing.Point(130, 49);
            this.txttax.Multiline = true;
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(206, 30);
            this.txttax.TabIndex = 19;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txttotal.Location = new System.Drawing.Point(130, 85);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(206, 30);
            this.txttotal.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(17, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Subtotal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(17, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Tax";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(17, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Total";
            // 
            // btntotal
            // 
            this.btntotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntotal.Location = new System.Drawing.Point(9, 123);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(85, 33);
            this.btntotal.TabIndex = 23;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnreset.Location = new System.Drawing.Point(130, 123);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(85, 33);
            this.btnreset.TabIndex = 24;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnexit.Location = new System.Drawing.Point(251, 123);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 33);
            this.btnexit.TabIndex = 26;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 594);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SD Travel manegement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfristname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtpostcode;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.CheckBox chextluggage;
        private System.Windows.Forms.CheckBox chtravelinsurance;
        private System.Windows.Forms.CheckBox chairmilesover;
        private System.Windows.Forms.CheckBox chairporttax;
        private System.Windows.Forms.ComboBox txtaccommodation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtdestination;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtdeparture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chchild;
        private System.Windows.Forms.CheckBox chadult;
        private System.Windows.Forms.CheckBox chspecialneeds;
        private System.Windows.Forms.CheckBox chreturn;
        private System.Windows.Forms.CheckBox chsingle;
        private System.Windows.Forms.RadioButton rbfristclass;
        private System.Windows.Forms.RadioButton rbeconomy;
        private System.Windows.Forms.RadioButton rbstandard;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
    }
}

