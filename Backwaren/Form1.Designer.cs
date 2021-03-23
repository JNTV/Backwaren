
namespace Backwaren
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLoadData = new System.Windows.Forms.Button();
            this.lblSweet = new System.Windows.Forms.Label();
            this.dgvSweet = new System.Windows.Forms.DataGridView();
            this.dgvHearty = new System.Windows.Forms.DataGridView();
            this.lblHearty = new System.Windows.Forms.Label();
            this.lblCaloriesSweet = new System.Windows.Forms.Label();
            this.lblCaloriesHearty = new System.Windows.Forms.Label();
            this.lblNewProdukt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblHeartyTrueFalse = new System.Windows.Forms.Label();
            this.cmdNewEntry = new System.Windows.Forms.Button();
            this.txtCaloriesSweet = new System.Windows.Forms.TextBox();
            this.txtCaloriesHearty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.cbHearty = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSweet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHearty)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLoadData
            // 
            this.cmdLoadData.Location = new System.Drawing.Point(13, 13);
            this.cmdLoadData.Name = "cmdLoadData";
            this.cmdLoadData.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadData.TabIndex = 0;
            this.cmdLoadData.Text = "Daten laden";
            this.cmdLoadData.UseVisualStyleBackColor = true;
            this.cmdLoadData.Click += new System.EventHandler(this.cmdLoadData_Click);
            // 
            // lblSweet
            // 
            this.lblSweet.AutoSize = true;
            this.lblSweet.Location = new System.Drawing.Point(13, 58);
            this.lblSweet.Name = "lblSweet";
            this.lblSweet.Size = new System.Drawing.Size(26, 13);
            this.lblSweet.TabIndex = 1;
            this.lblSweet.Text = "Süß";
            // 
            // dgvSweet
            // 
            this.dgvSweet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSweet.Location = new System.Drawing.Point(12, 73);
            this.dgvSweet.Name = "dgvSweet";
            this.dgvSweet.Size = new System.Drawing.Size(507, 250);
            this.dgvSweet.TabIndex = 2;
            // 
            // dgvHearty
            // 
            this.dgvHearty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHearty.Location = new System.Drawing.Point(543, 73);
            this.dgvHearty.Name = "dgvHearty";
            this.dgvHearty.Size = new System.Drawing.Size(507, 250);
            this.dgvHearty.TabIndex = 3;
            // 
            // lblHearty
            // 
            this.lblHearty.AutoSize = true;
            this.lblHearty.Location = new System.Drawing.Point(543, 54);
            this.lblHearty.Name = "lblHearty";
            this.lblHearty.Size = new System.Drawing.Size(47, 13);
            this.lblHearty.TabIndex = 4;
            this.lblHearty.Text = "Herzhaft";
            // 
            // lblCaloriesSweet
            // 
            this.lblCaloriesSweet.AutoSize = true;
            this.lblCaloriesSweet.Location = new System.Drawing.Point(16, 341);
            this.lblCaloriesSweet.Name = "lblCaloriesSweet";
            this.lblCaloriesSweet.Size = new System.Drawing.Size(125, 13);
            this.lblCaloriesSweet.TabIndex = 5;
            this.lblCaloriesSweet.Text = "Kalorien durchschnittlich:";
            // 
            // lblCaloriesHearty
            // 
            this.lblCaloriesHearty.AutoSize = true;
            this.lblCaloriesHearty.Location = new System.Drawing.Point(546, 341);
            this.lblCaloriesHearty.Name = "lblCaloriesHearty";
            this.lblCaloriesHearty.Size = new System.Drawing.Size(125, 13);
            this.lblCaloriesHearty.TabIndex = 6;
            this.lblCaloriesHearty.Text = "Kalorien durchschnittlich:";
            // 
            // lblNewProdukt
            // 
            this.lblNewProdukt.AutoSize = true;
            this.lblNewProdukt.Location = new System.Drawing.Point(16, 383);
            this.lblNewProdukt.Name = "lblNewProdukt";
            this.lblNewProdukt.Size = new System.Drawing.Size(78, 13);
            this.lblNewProdukt.TabIndex = 7;
            this.lblNewProdukt.Text = "Neues Produkt";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 409);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Bezeichnung";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 436);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Preis";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(16, 463);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(45, 13);
            this.lblCalories.TabIndex = 10;
            this.lblCalories.Text = "Kalorien";
            // 
            // lblHeartyTrueFalse
            // 
            this.lblHeartyTrueFalse.AutoSize = true;
            this.lblHeartyTrueFalse.Location = new System.Drawing.Point(16, 492);
            this.lblHeartyTrueFalse.Name = "lblHeartyTrueFalse";
            this.lblHeartyTrueFalse.Size = new System.Drawing.Size(47, 13);
            this.lblHeartyTrueFalse.TabIndex = 11;
            this.lblHeartyTrueFalse.Text = "Herzhaft";
            // 
            // cmdNewEntry
            // 
            this.cmdNewEntry.Location = new System.Drawing.Point(19, 521);
            this.cmdNewEntry.Name = "cmdNewEntry";
            this.cmdNewEntry.Size = new System.Drawing.Size(173, 23);
            this.cmdNewEntry.TabIndex = 12;
            this.cmdNewEntry.Text = "OK";
            this.cmdNewEntry.UseVisualStyleBackColor = true;
            this.cmdNewEntry.Click += new System.EventHandler(this.cmdNewEntry_Click);
            // 
            // txtCaloriesSweet
            // 
            this.txtCaloriesSweet.Location = new System.Drawing.Point(147, 338);
            this.txtCaloriesSweet.Name = "txtCaloriesSweet";
            this.txtCaloriesSweet.ReadOnly = true;
            this.txtCaloriesSweet.Size = new System.Drawing.Size(78, 20);
            this.txtCaloriesSweet.TabIndex = 13;
            // 
            // txtCaloriesHearty
            // 
            this.txtCaloriesHearty.Location = new System.Drawing.Point(674, 338);
            this.txtCaloriesHearty.Name = "txtCaloriesHearty";
            this.txtCaloriesHearty.ReadOnly = true;
            this.txtCaloriesHearty.Size = new System.Drawing.Size(78, 20);
            this.txtCaloriesHearty.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 406);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(92, 433);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(92, 460);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(100, 20);
            this.txtCalories.TabIndex = 17;
            // 
            // cbHearty
            // 
            this.cbHearty.AutoSize = true;
            this.cbHearty.Location = new System.Drawing.Point(92, 491);
            this.cbHearty.Name = "cbHearty";
            this.cbHearty.Size = new System.Drawing.Size(66, 17);
            this.cbHearty.TabIndex = 18;
            this.cbHearty.Text = "Herzhaft";
            this.cbHearty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 690);
            this.Controls.Add(this.cbHearty);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCaloriesHearty);
            this.Controls.Add(this.txtCaloriesSweet);
            this.Controls.Add(this.cmdNewEntry);
            this.Controls.Add(this.lblHeartyTrueFalse);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNewProdukt);
            this.Controls.Add(this.lblCaloriesHearty);
            this.Controls.Add(this.lblCaloriesSweet);
            this.Controls.Add(this.lblHearty);
            this.Controls.Add(this.dgvHearty);
            this.Controls.Add(this.dgvSweet);
            this.Controls.Add(this.lblSweet);
            this.Controls.Add(this.cmdLoadData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSweet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHearty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLoadData;
        private System.Windows.Forms.Label lblSweet;
        private System.Windows.Forms.DataGridView dgvSweet;
        private System.Windows.Forms.DataGridView dgvHearty;
        private System.Windows.Forms.Label lblHearty;
        private System.Windows.Forms.Label lblCaloriesSweet;
        private System.Windows.Forms.Label lblCaloriesHearty;
        private System.Windows.Forms.Label lblNewProdukt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblHeartyTrueFalse;
        private System.Windows.Forms.Button cmdNewEntry;
        private System.Windows.Forms.TextBox txtCaloriesSweet;
        private System.Windows.Forms.TextBox txtCaloriesHearty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.CheckBox cbHearty;
    }
}

