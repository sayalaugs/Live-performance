namespace Vrachtschip_applicatie
{
    partial class Menu
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
            this.btnIndelen = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIndelen
            // 
            this.btnIndelen.Location = new System.Drawing.Point(89, 84);
            this.btnIndelen.Name = "btnIndelen";
            this.btnIndelen.Size = new System.Drawing.Size(80, 39);
            this.btnIndelen.TabIndex = 0;
            this.btnIndelen.Text = "Indelen";
            this.btnIndelen.UseVisualStyleBackColor = true;
            this.btnIndelen.Click += new System.EventHandler(this.btnIndelen_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(230, 83);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(89, 40);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Items toevoegen";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 245);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnIndelen);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIndelen;
        private System.Windows.Forms.Button btnAddItem;
    }
}