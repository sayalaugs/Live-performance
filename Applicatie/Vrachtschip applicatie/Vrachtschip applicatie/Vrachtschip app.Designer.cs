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
            this.btnExportInfo = new System.Windows.Forms.Button();
            this.btnMarkContainers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbGeneratedLayout = new System.Windows.Forms.ListBox();
            this.lbLegenda = new System.Windows.Forms.ListBox();
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
            // btnExportInfo
            // 
            this.btnExportInfo.Location = new System.Drawing.Point(211, 126);
            this.btnExportInfo.Name = "btnExportInfo";
            this.btnExportInfo.Size = new System.Drawing.Size(108, 59);
            this.btnExportInfo.TabIndex = 6;
            this.btnExportInfo.Text = "Exporteer indelings gegevens";
            this.btnExportInfo.UseVisualStyleBackColor = true;
            this.btnExportInfo.Click += new System.EventHandler(this.btnExportInfo_Click);
            // 
            // btnMarkContainers
            // 
            this.btnMarkContainers.Location = new System.Drawing.Point(211, 200);
            this.btnMarkContainers.Name = "btnMarkContainers";
            this.btnMarkContainers.Size = new System.Drawing.Size(108, 59);
            this.btnMarkContainers.TabIndex = 7;
            this.btnMarkContainers.Text = "Markeer containers als ingepland";
            this.btnMarkContainers.UseVisualStyleBackColor = true;
            this.btnMarkContainers.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 266);
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
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(6, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbGeneratedLayout
            // 
            this.lbGeneratedLayout.FormattingEnabled = true;
            this.lbGeneratedLayout.Location = new System.Drawing.Point(325, 40);
            this.lbGeneratedLayout.Name = "lbGeneratedLayout";
            this.lbGeneratedLayout.Size = new System.Drawing.Size(336, 407);
            this.lbGeneratedLayout.TabIndex = 13;
            // 
            // lbLegenda
            // 
            this.lbLegenda.FormattingEnabled = true;
            this.lbLegenda.Items.AddRange(new object[] {
            "_  = Lege positie",
            "C = Normale Container",
            "V = Waardevolle Container",
            "E = Actief gekoelde Container"});
            this.lbLegenda.Location = new System.Drawing.Point(94, 287);
            this.lbLegenda.Name = "lbLegenda";
            this.lbLegenda.Size = new System.Drawing.Size(225, 160);
            this.lbLegenda.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 466);
            this.Controls.Add(this.lbLegenda);
            this.Controls.Add(this.lbGeneratedLayout);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMarkContainers);
            this.Controls.Add(this.btnExportInfo);
            this.Controls.Add(this.btnGenerateLayout);
            this.Controls.Add(this.cbShips);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vrachtschip app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbShips;
        private System.Windows.Forms.Button btnGenerateLayout;
        private System.Windows.Forms.Button btnExportInfo;
        private System.Windows.Forms.Button btnMarkContainers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ListBox lbGeneratedLayout;
        private System.Windows.Forms.ListBox lbLegenda;
    }
}

