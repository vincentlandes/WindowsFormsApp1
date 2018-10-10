namespace WindowsFormsApp1
{
    partial class UI
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
            this.startStation = new System.Windows.Forms.ComboBox();
            this.endStation = new System.Windows.Forms.ComboBox();
            this.payMethod = new System.Windows.Forms.ComboBox();
            this.wayType = new System.Windows.Forms.ComboBox();
            this.classType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bike = new System.Windows.Forms.CheckBox();
            this.railRunner = new System.Windows.Forms.CheckBox();
            this.pet = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.discountType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startStation
            // 
            this.startStation.FormattingEnabled = true;
            this.startStation.Items.AddRange(new object[] {
            "Station Halfweg-Zwanenburg",
            "Station Obdam",
            "Station Bovenkarspel-Grootebroek",
            "Station Purmerend Weidevenne",
            "Station Utrecht Centraal"});
            this.startStation.Location = new System.Drawing.Point(36, 51);
            this.startStation.Name = "startStation";
            this.startStation.Size = new System.Drawing.Size(239, 24);
            this.startStation.TabIndex = 0;
            // 
            // endStation
            // 
            this.endStation.FormattingEnabled = true;
            this.endStation.Items.AddRange(new object[] {
            "Station Halfweg-Zwanenburg",
            "Station Obdam",
            "Station Bovenkarspel-Grootebroek",
            "Station Purmerend Weidevenne",
            "Station Utrecht Centraal"});
            this.endStation.Location = new System.Drawing.Point(36, 120);
            this.endStation.Name = "endStation";
            this.endStation.Size = new System.Drawing.Size(239, 24);
            this.endStation.TabIndex = 1;
            // 
            // payMethod
            // 
            this.payMethod.FormattingEnabled = true;
            this.payMethod.Items.AddRange(new object[] {
            "Contant",
            "Credit Card"});
            this.payMethod.Location = new System.Drawing.Point(302, 251);
            this.payMethod.Name = "payMethod";
            this.payMethod.Size = new System.Drawing.Size(121, 24);
            this.payMethod.TabIndex = 2;
            // 
            // wayType
            // 
            this.wayType.FormattingEnabled = true;
            this.wayType.Items.AddRange(new object[] {
            "Enkele reis",
            "Retour"});
            this.wayType.Location = new System.Drawing.Point(36, 300);
            this.wayType.Name = "wayType";
            this.wayType.Size = new System.Drawing.Size(239, 24);
            this.wayType.TabIndex = 3;
            // 
            // classType
            // 
            this.classType.FormattingEnabled = true;
            this.classType.Items.AddRange(new object[] {
            "1e klasse",
            "2e klasse"});
            this.classType.Location = new System.Drawing.Point(36, 218);
            this.classType.Name = "classType";
            this.classType.Size = new System.Drawing.Size(239, 24);
            this.classType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Klasse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enkel/Retour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Betaalwijze";
            // 
            // bike
            // 
            this.bike.AutoSize = true;
            this.bike.Location = new System.Drawing.Point(302, 53);
            this.bike.Name = "bike";
            this.bike.Size = new System.Drawing.Size(60, 21);
            this.bike.TabIndex = 10;
            this.bike.Text = "Fiets";
            this.bike.UseVisualStyleBackColor = true;
            // 
            // railRunner
            // 
            this.railRunner.AutoSize = true;
            this.railRunner.Location = new System.Drawing.Point(302, 80);
            this.railRunner.Name = "railRunner";
            this.railRunner.Size = new System.Drawing.Size(96, 21);
            this.railRunner.TabIndex = 11;
            this.railRunner.Text = "Railrunner";
            this.railRunner.UseVisualStyleBackColor = true;
            // 
            // pet
            // 
            this.pet.AutoSize = true;
            this.pet.Location = new System.Drawing.Point(302, 109);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(82, 21);
            this.pet.TabIndex = 12;
            this.pet.Text = "Huisdier";
            this.pet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Extra\'s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Van";
            // 
            // discountType
            // 
            this.discountType.FormattingEnabled = true;
            this.discountType.Items.AddRange(new object[] {
            "Geen",
            "20%",
            "40%"});
            this.discountType.Location = new System.Drawing.Point(36, 370);
            this.discountType.Name = "discountType";
            this.discountType.Size = new System.Drawing.Size(239, 24);
            this.discountType.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Korting";
            // 
            // startTransaction
            // 
            this.startTransaction.Location = new System.Drawing.Point(302, 296);
            this.startTransaction.Name = "startTransaction";
            this.startTransaction.Size = new System.Drawing.Size(75, 23);
            this.startTransaction.TabIndex = 17;
            this.startTransaction.Text = "Betalen";
            this.startTransaction.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.startTransaction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.discountType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pet);
            this.Controls.Add(this.railRunner);
            this.Controls.Add(this.bike);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classType);
            this.Controls.Add(this.wayType);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.endStation);
            this.Controls.Add(this.startStation);
            this.Name = "UI";
            this.Text = "Ticket Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox startStation;
        private System.Windows.Forms.ComboBox endStation;
        private System.Windows.Forms.ComboBox payMethod;
        private System.Windows.Forms.ComboBox wayType;
        private System.Windows.Forms.ComboBox classType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox bike;
        private System.Windows.Forms.CheckBox railRunner;
        private System.Windows.Forms.CheckBox pet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox discountType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startTransaction;
    }
}

