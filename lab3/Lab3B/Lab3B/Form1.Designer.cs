namespace Lab3B
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
            this.hairDresserComboBox = new System.Windows.Forms.ComboBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.hairDressergroupBox = new System.Windows.Forms.GroupBox();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsGroupbox = new System.Windows.Forms.GroupBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateTotalPriceButton = new System.Windows.Forms.Button();
            this.totalPriceListBox = new System.Windows.Forms.ListBox();
            this.hairDressergroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.itemsGroupbox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairDresserComboBox
            // 
            this.hairDresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hairDresserComboBox.FormattingEnabled = true;
            this.hairDresserComboBox.Location = new System.Drawing.Point(6, 31);
            this.hairDresserComboBox.Name = "hairDresserComboBox";
            this.hairDresserComboBox.Size = new System.Drawing.Size(224, 28);
            this.hairDresserComboBox.TabIndex = 0;
            // 
            // serviceListBox
            // 
            this.serviceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 20;
            this.serviceListBox.Location = new System.Drawing.Point(9, 36);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(217, 164);
            this.serviceListBox.TabIndex = 5;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.serviceListBox_SelectedIndexChanged);
            // 
            // itemsListBox
            // 
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(9, 31);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(253, 164);
            this.itemsListBox.TabIndex = 6;
            // 
            // hairDressergroupBox
            // 
            this.hairDressergroupBox.Controls.Add(this.hairDresserComboBox);
            this.hairDressergroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairDressergroupBox.Location = new System.Drawing.Point(12, 53);
            this.hairDressergroupBox.Name = "hairDressergroupBox";
            this.hairDressergroupBox.Size = new System.Drawing.Size(236, 206);
            this.hairDressergroupBox.TabIndex = 8;
            this.hairDressergroupBox.TabStop = false;
            this.hairDressergroupBox.Text = "Select a Hairdresser:";
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.serviceListBox);
            this.serviceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceGroupBox.Location = new System.Drawing.Point(254, 53);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(235, 206);
            this.serviceGroupBox.TabIndex = 9;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select a Service:";
            // 
            // itemsGroupbox
            // 
            this.itemsGroupbox.Controls.Add(this.itemsListBox);
            this.itemsGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsGroupbox.Location = new System.Drawing.Point(495, 53);
            this.itemsGroupbox.Name = "itemsGroupbox";
            this.itemsGroupbox.Size = new System.Drawing.Size(268, 206);
            this.itemsGroupbox.TabIndex = 9;
            this.itemsGroupbox.TabStop = false;
            this.itemsGroupbox.Text = "Charged Items:";
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGroupBox.Location = new System.Drawing.Point(769, 53);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(157, 206);
            this.priceGroupBox.TabIndex = 10;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // priceListBox
            // 
            this.priceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 20;
            this.priceListBox.Location = new System.Drawing.Point(6, 25);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceListBox.Size = new System.Drawing.Size(145, 164);
            this.priceListBox.TabIndex = 6;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(672, 275);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(91, 20);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "Total Price: ";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceButton.Location = new System.Drawing.Point(100, 333);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(202, 39);
            this.addServiceButton.TabIndex = 12;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(724, 333);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(202, 39);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(516, 333);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(202, 39);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateTotalPriceButton
            // 
            this.calculateTotalPriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalPriceButton.Location = new System.Drawing.Point(308, 333);
            this.calculateTotalPriceButton.Name = "calculateTotalPriceButton";
            this.calculateTotalPriceButton.Size = new System.Drawing.Size(202, 39);
            this.calculateTotalPriceButton.TabIndex = 15;
            this.calculateTotalPriceButton.Text = "Calculate Total Price";
            this.calculateTotalPriceButton.UseVisualStyleBackColor = true;
            this.calculateTotalPriceButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalPriceListBox
            // 
            this.totalPriceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceListBox.FormattingEnabled = true;
            this.totalPriceListBox.ItemHeight = 20;
            this.totalPriceListBox.Location = new System.Drawing.Point(775, 271);
            this.totalPriceListBox.Name = "totalPriceListBox";
            this.totalPriceListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceListBox.Size = new System.Drawing.Size(151, 24);
            this.totalPriceListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 379);
            this.Controls.Add(this.totalPriceListBox);
            this.Controls.Add(this.calculateTotalPriceButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.itemsGroupbox);
            this.Controls.Add(this.serviceGroupBox);
            this.Controls.Add(this.hairDressergroupBox);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.hairDressergroupBox.ResumeLayout(false);
            this.serviceGroupBox.ResumeLayout(false);
            this.itemsGroupbox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hairDresserComboBox;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.GroupBox hairDressergroupBox;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.GroupBox itemsGroupbox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateTotalPriceButton;
        private System.Windows.Forms.ListBox totalPriceListBox;
    }
}

