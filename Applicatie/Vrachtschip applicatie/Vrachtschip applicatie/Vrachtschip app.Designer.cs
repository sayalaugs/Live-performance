namespace Vrachtschip_applicatie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbShips = new System.Windows.Forms.ComboBox();
            this.btnGenerateLayout = new System.Windows.Forms.Button();
            this.tbGeneratedLayout = new System.Windows.Forms.TextBox();
            this.btnExportInfo = new System.Windows.Forms.Button();
            this.btnMarkContainers = new System.Windows.Forms.Button();
            this.tbLegend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDestinationName = new System.Windows.Forms.TextBox();
            this.tbDestinationCountry = new System.Windows.Forms.TextBox();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbShipType = new System.Windows.Forms.TextBox();
            this.tbShipHight = new System.Windows.Forms.TextBox();
            this.tbShipRows = new System.Windows.Forms.TextBox();
            this.tbShipContPerRow = new System.Windows.Forms.TextBox();
            this.tbShipAmountOfElectricty = new System.Windows.Forms.TextBox();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.tbCompanyKvknr = new System.Windows.Forms.TextBox();
            this.tbCompanyContactPerson = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestemming:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Vrachtschip:";
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(117, 40);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(121, 21);
            this.cbDestination.TabIndex = 2;
            // 
            // cbShips
            // 
            this.cbShips.FormattingEnabled = true;
            this.cbShips.Location = new System.Drawing.Point(117, 72);
            this.cbShips.Name = "cbShips";
            this.cbShips.Size = new System.Drawing.Size(121, 21);
            this.cbShips.TabIndex = 3;
            // 
            // btnGenerateLayout
            // 
            this.btnGenerateLayout.Location = new System.Drawing.Point(244, 40);
            this.btnGenerateLayout.Name = "btnGenerateLayout";
            this.btnGenerateLayout.Size = new System.Drawing.Size(75, 53);
            this.btnGenerateLayout.TabIndex = 4;
            this.btnGenerateLayout.Text = "Genereer indeling";
            this.btnGenerateLayout.UseVisualStyleBackColor = true;
            this.btnGenerateLayout.Click += new System.EventHandler(this.btnGenerateLayout_Click);
            // 
            // tbGeneratedLayout
            // 
            this.tbGeneratedLayout.Location = new System.Drawing.Point(325, 40);
            this.tbGeneratedLayout.Multiline = true;
            this.tbGeneratedLayout.Name = "tbGeneratedLayout";
            this.tbGeneratedLayout.Size = new System.Drawing.Size(323, 459);
            this.tbGeneratedLayout.TabIndex = 5;
            // 
            // btnExportInfo
            // 
            this.btnExportInfo.Location = new System.Drawing.Point(211, 166);
            this.btnExportInfo.Name = "btnExportInfo";
            this.btnExportInfo.Size = new System.Drawing.Size(108, 59);
            this.btnExportInfo.TabIndex = 6;
            this.btnExportInfo.Text = "Exporteer indelings gegevens";
            this.btnExportInfo.UseVisualStyleBackColor = true;
            // 
            // btnMarkContainers
            // 
            this.btnMarkContainers.Location = new System.Drawing.Point(211, 240);
            this.btnMarkContainers.Name = "btnMarkContainers";
            this.btnMarkContainers.Size = new System.Drawing.Size(108, 59);
            this.btnMarkContainers.TabIndex = 7;
            this.btnMarkContainers.Text = "Markeer containers als ingepland";
            this.btnMarkContainers.UseVisualStyleBackColor = true;
            this.btnMarkContainers.Visible = false;
            // 
            // tbLegend
            // 
            this.tbLegend.Location = new System.Drawing.Point(94, 334);
            this.tbLegend.Multiline = true;
            this.tbLegend.Name = "tbLegend";
            this.tbLegend.Size = new System.Drawing.Size(225, 165);
            this.tbLegend.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Legenda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gegenereerde indeling:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDestination);
            this.groupBox1.Controls.Add(this.tbDestinationCountry);
            this.groupBox1.Controls.Add(this.tbDestinationName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(673, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bestemming toevoegen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Naam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Land:";
            // 
            // tbDestinationName
            // 
            this.tbDestinationName.Location = new System.Drawing.Point(71, 17);
            this.tbDestinationName.Name = "tbDestinationName";
            this.tbDestinationName.Size = new System.Drawing.Size(100, 20);
            this.tbDestinationName.TabIndex = 2;
            // 
            // tbDestinationCountry
            // 
            this.tbDestinationCountry.Location = new System.Drawing.Point(71, 43);
            this.tbDestinationCountry.Name = "tbDestinationCountry";
            this.tbDestinationCountry.Size = new System.Drawing.Size(100, 20);
            this.tbDestinationCountry.TabIndex = 3;
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(178, 16);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(75, 47);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Voeg toe";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddShip);
            this.groupBox2.Controls.Add(this.tbShipAmountOfElectricty);
            this.groupBox2.Controls.Add(this.tbShipContPerRow);
            this.groupBox2.Controls.Add(this.tbShipRows);
            this.groupBox2.Controls.Add(this.tbShipHight);
            this.groupBox2.Controls.Add(this.tbShipType);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(673, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 207);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrachtschip toevoegen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Max. Hoogte:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Aantal Rijen:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Containers per rij:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Stroom aansluitingen:";
            // 
            // tbShipType
            // 
            this.tbShipType.Location = new System.Drawing.Point(139, 20);
            this.tbShipType.Name = "tbShipType";
            this.tbShipType.Size = new System.Drawing.Size(100, 20);
            this.tbShipType.TabIndex = 5;
            // 
            // tbShipHight
            // 
            this.tbShipHight.Location = new System.Drawing.Point(139, 46);
            this.tbShipHight.Name = "tbShipHight";
            this.tbShipHight.Size = new System.Drawing.Size(100, 20);
            this.tbShipHight.TabIndex = 6;
            // 
            // tbShipRows
            // 
            this.tbShipRows.Location = new System.Drawing.Point(139, 72);
            this.tbShipRows.Name = "tbShipRows";
            this.tbShipRows.Size = new System.Drawing.Size(100, 20);
            this.tbShipRows.TabIndex = 7;
            // 
            // tbShipContPerRow
            // 
            this.tbShipContPerRow.Location = new System.Drawing.Point(139, 98);
            this.tbShipContPerRow.Name = "tbShipContPerRow";
            this.tbShipContPerRow.Size = new System.Drawing.Size(100, 20);
            this.tbShipContPerRow.TabIndex = 8;
            // 
            // tbShipAmountOfElectricty
            // 
            this.tbShipAmountOfElectricty.Location = new System.Drawing.Point(139, 124);
            this.tbShipAmountOfElectricty.Name = "tbShipAmountOfElectricty";
            this.tbShipAmountOfElectricty.Size = new System.Drawing.Size(100, 20);
            this.tbShipAmountOfElectricty.TabIndex = 9;
            // 
            // btnAddShip
            // 
            this.btnAddShip.Location = new System.Drawing.Point(164, 150);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(75, 47);
            this.btnAddShip.TabIndex = 5;
            this.btnAddShip.Text = "Voeg toe";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddCompany);
            this.groupBox3.Controls.Add(this.tbCompanyKvknr);
            this.groupBox3.Controls.Add(this.tbCompanyContactPerson);
            this.groupBox3.Controls.Add(this.tbCompanyName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(673, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 153);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bedrijf toevoegen";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(164, 98);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 47);
            this.btnAddCompany.TabIndex = 5;
            this.btnAddCompany.Text = "Voeg toe";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // tbCompanyKvknr
            // 
            this.tbCompanyKvknr.Location = new System.Drawing.Point(139, 72);
            this.tbCompanyKvknr.Name = "tbCompanyKvknr";
            this.tbCompanyKvknr.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyKvknr.TabIndex = 7;
            // 
            // tbCompanyContactPerson
            // 
            this.tbCompanyContactPerson.Location = new System.Drawing.Point(139, 46);
            this.tbCompanyContactPerson.Name = "tbCompanyContactPerson";
            this.tbCompanyContactPerson.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyContactPerson.TabIndex = 6;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(139, 20);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyName.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "KVK nr:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Contact persoon:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Naam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLegend);
            this.Controls.Add(this.btnMarkContainers);
            this.Controls.Add(this.btnExportInfo);
            this.Controls.Add(this.tbGeneratedLayout);
            this.Controls.Add(this.btnGenerateLayout);
            this.Controls.Add(this.cbShips);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vrachtschip app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbShips;
        private System.Windows.Forms.Button btnGenerateLayout;
        private System.Windows.Forms.TextBox tbGeneratedLayout;
        private System.Windows.Forms.Button btnExportInfo;
        private System.Windows.Forms.Button btnMarkContainers;
        private System.Windows.Forms.TextBox tbLegend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.TextBox tbDestinationCountry;
        private System.Windows.Forms.TextBox tbDestinationName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.TextBox tbShipAmountOfElectricty;
        private System.Windows.Forms.TextBox tbShipContPerRow;
        private System.Windows.Forms.TextBox tbShipRows;
        private System.Windows.Forms.TextBox tbShipHight;
        private System.Windows.Forms.TextBox tbShipType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TextBox tbCompanyKvknr;
        private System.Windows.Forms.TextBox tbCompanyContactPerson;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

