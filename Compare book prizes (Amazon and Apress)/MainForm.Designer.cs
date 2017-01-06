namespace CompareBookPrizesForAmazonAndApress
{
    partial class MainForm
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
            this.isbnEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isbnGoButton = new System.Windows.Forms.Button();
            this.isbnResetButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.amazonPriceLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amazonTitleLabel = new System.Windows.Forms.Label();
            this.amazonStoreButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amazonPanel = new System.Windows.Forms.Panel();
            this.apressPanel = new System.Windows.Forms.Panel();
            this.apressStoreButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apressPriceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.apressTitleLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.amazonPanel.SuspendLayout();
            this.apressPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // isbnEntry
            // 
            this.isbnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isbnEntry.Location = new System.Drawing.Point(69, 8);
            this.isbnEntry.Name = "isbnEntry";
            this.isbnEntry.Size = new System.Drawing.Size(243, 29);
            this.isbnEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            // 
            // isbnGoButton
            // 
            this.isbnGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isbnGoButton.Location = new System.Drawing.Point(318, 8);
            this.isbnGoButton.Name = "isbnGoButton";
            this.isbnGoButton.Size = new System.Drawing.Size(81, 29);
            this.isbnGoButton.TabIndex = 2;
            this.isbnGoButton.Text = "Go";
            this.isbnGoButton.UseVisualStyleBackColor = true;
            this.isbnGoButton.Click += new System.EventHandler(this.isbnButtonClick);
            // 
            // isbnResetButton
            // 
            this.isbnResetButton.Enabled = false;
            this.isbnResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isbnResetButton.Location = new System.Drawing.Point(405, 8);
            this.isbnResetButton.Name = "isbnResetButton";
            this.isbnResetButton.Size = new System.Drawing.Size(81, 29);
            this.isbnResetButton.TabIndex = 4;
            this.isbnResetButton.Text = "Reset";
            this.isbnResetButton.UseVisualStyleBackColor = true;
            this.isbnResetButton.Click += new System.EventHandler(this.isbnResetButtonClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.amazonPriceLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(10, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(814, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // amazonPriceLabel
            // 
            this.amazonPriceLabel.AutoSize = true;
            this.amazonPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amazonPriceLabel.Location = new System.Drawing.Point(6, 19);
            this.amazonPriceLabel.Name = "amazonPriceLabel";
            this.amazonPriceLabel.Size = new System.Drawing.Size(21, 24);
            this.amazonPriceLabel.TabIndex = 4;
            this.amazonPriceLabel.Text = " -";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.amazonTitleLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(10, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Title";
            // 
            // amazonTitleLabel
            // 
            this.amazonTitleLabel.AutoSize = true;
            this.amazonTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amazonTitleLabel.Location = new System.Drawing.Point(6, 19);
            this.amazonTitleLabel.Name = "amazonTitleLabel";
            this.amazonTitleLabel.Size = new System.Drawing.Size(21, 24);
            this.amazonTitleLabel.TabIndex = 5;
            this.amazonTitleLabel.Text = " -";
            // 
            // amazonStoreButton
            // 
            this.amazonStoreButton.Enabled = false;
            this.amazonStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amazonStoreButton.Location = new System.Drawing.Point(670, 12);
            this.amazonStoreButton.Name = "amazonStoreButton";
            this.amazonStoreButton.Size = new System.Drawing.Size(154, 37);
            this.amazonStoreButton.TabIndex = 4;
            this.amazonStoreButton.Text = "Go to store";
            this.amazonStoreButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amazon.com";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.isbnResetButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.isbnEntry);
            this.panel1.Controls.Add(this.isbnGoButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 48);
            this.panel1.TabIndex = 5;
            // 
            // amazonPanel
            // 
            this.amazonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amazonPanel.Controls.Add(this.amazonStoreButton);
            this.amazonPanel.Controls.Add(this.groupBox4);
            this.amazonPanel.Controls.Add(this.label2);
            this.amazonPanel.Controls.Add(this.groupBox3);
            this.amazonPanel.Location = new System.Drawing.Point(12, 72);
            this.amazonPanel.Name = "amazonPanel";
            this.amazonPanel.Size = new System.Drawing.Size(836, 182);
            this.amazonPanel.TabIndex = 6;
            // 
            // apressPanel
            // 
            this.apressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apressPanel.Controls.Add(this.apressStoreButton);
            this.apressPanel.Controls.Add(this.groupBox1);
            this.apressPanel.Controls.Add(this.label4);
            this.apressPanel.Controls.Add(this.groupBox2);
            this.apressPanel.Location = new System.Drawing.Point(12, 267);
            this.apressPanel.Name = "apressPanel";
            this.apressPanel.Size = new System.Drawing.Size(836, 182);
            this.apressPanel.TabIndex = 7;
            // 
            // apressStoreButton
            // 
            this.apressStoreButton.Enabled = false;
            this.apressStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apressStoreButton.Location = new System.Drawing.Point(670, 12);
            this.apressStoreButton.Name = "apressStoreButton";
            this.apressStoreButton.Size = new System.Drawing.Size(154, 37);
            this.apressStoreButton.TabIndex = 4;
            this.apressStoreButton.Text = "Go to store";
            this.apressStoreButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apressPriceLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(10, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // apressPriceLabel
            // 
            this.apressPriceLabel.AutoSize = true;
            this.apressPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apressPriceLabel.Location = new System.Drawing.Point(6, 19);
            this.apressPriceLabel.Name = "apressPriceLabel";
            this.apressPriceLabel.Size = new System.Drawing.Size(21, 24);
            this.apressPriceLabel.TabIndex = 4;
            this.apressPriceLabel.Text = " -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apress.com";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.apressTitleLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(10, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Title";
            // 
            // apressTitleLabel
            // 
            this.apressTitleLabel.AutoSize = true;
            this.apressTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apressTitleLabel.Location = new System.Drawing.Point(6, 19);
            this.apressTitleLabel.Name = "apressTitleLabel";
            this.apressTitleLabel.Size = new System.Drawing.Size(21, 24);
            this.apressTitleLabel.TabIndex = 5;
            this.apressTitleLabel.Text = " -";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 460);
            this.Controls.Add(this.apressPanel);
            this.Controls.Add(this.amazonPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Compare book prizes (Amazon and Apress)";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.amazonPanel.ResumeLayout(false);
            this.amazonPanel.PerformLayout();
            this.apressPanel.ResumeLayout(false);
            this.apressPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox isbnEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button isbnGoButton;
        private System.Windows.Forms.Button isbnResetButton;
        private System.Windows.Forms.Button amazonStoreButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label amazonPriceLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label amazonTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel amazonPanel;
        private System.Windows.Forms.Panel apressPanel;
        private System.Windows.Forms.Button apressStoreButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label apressPriceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label apressTitleLabel;
    }
}

