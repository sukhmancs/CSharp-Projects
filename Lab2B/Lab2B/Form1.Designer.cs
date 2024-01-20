namespace Lab2B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            janeRadioButton = new RadioButton();
            hairDresserGroupBox = new GroupBox();
            lauraRadioButton = new RadioButton();
            sueRadioButton = new RadioButton();
            ronRadioButton = new RadioButton();
            patRadioButton = new RadioButton();
            clientTypeGroupBox = new GroupBox();
            seniorRadioButton = new RadioButton();
            studentRadioButton = new RadioButton();
            childRadioButton = new RadioButton();
            standardAdultRadioButton = new RadioButton();
            radioButton2 = new RadioButton();
            servicesGroupBox = new GroupBox();
            colourCheckBox = new CheckBox();
            extensionsCheckBox = new CheckBox();
            highlightsCheckBox = new CheckBox();
            cutCheckBox = new CheckBox();
            clientVisitsGroupBox = new GroupBox();
            firstLabel = new Label();
            clientVisitsTextBox = new TextBox();
            totalPriceLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            hairDresserGroupBox.SuspendLayout();
            clientTypeGroupBox.SuspendLayout();
            servicesGroupBox.SuspendLayout();
            clientVisitsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // janeRadioButton
            // 
            janeRadioButton.AutoSize = true;
            janeRadioButton.Location = new Point(6, 28);
            janeRadioButton.Name = "janeRadioButton";
            janeRadioButton.Size = new Size(124, 27);
            janeRadioButton.TabIndex = 0;
            janeRadioButton.TabStop = true;
            janeRadioButton.Text = "Jane Samley";
            janeRadioButton.UseVisualStyleBackColor = true;
            // 
            // hairDresserGroupBox
            // 
            hairDresserGroupBox.Controls.Add(lauraRadioButton);
            hairDresserGroupBox.Controls.Add(sueRadioButton);
            hairDresserGroupBox.Controls.Add(ronRadioButton);
            hairDresserGroupBox.Controls.Add(patRadioButton);
            hairDresserGroupBox.Controls.Add(janeRadioButton);
            hairDresserGroupBox.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            hairDresserGroupBox.Location = new Point(12, 22);
            hairDresserGroupBox.Name = "hairDresserGroupBox";
            hairDresserGroupBox.Size = new Size(194, 220);
            hairDresserGroupBox.TabIndex = 1;
            hairDresserGroupBox.TabStop = false;
            hairDresserGroupBox.Text = "Hairdresser";
            hairDresserGroupBox.Enter += Hairdresser_Enter;
            // 
            // lauraRadioButton
            // 
            lauraRadioButton.AutoSize = true;
            lauraRadioButton.Location = new Point(6, 161);
            lauraRadioButton.Name = "lauraRadioButton";
            lauraRadioButton.Size = new Size(138, 27);
            lauraRadioButton.TabIndex = 6;
            lauraRadioButton.TabStop = true;
            lauraRadioButton.Text = "Laura Renkins";
            lauraRadioButton.UseVisualStyleBackColor = true;
            lauraRadioButton.CheckedChanged += lauraRadioButton_CheckedChanged;
            // 
            // sueRadioButton
            // 
            sueRadioButton.AutoSize = true;
            sueRadioButton.Location = new Point(6, 128);
            sueRadioButton.Name = "sueRadioButton";
            sueRadioButton.Size = new Size(110, 27);
            sueRadioButton.TabIndex = 5;
            sueRadioButton.TabStop = true;
            sueRadioButton.Text = "Sue Pallon";
            sueRadioButton.UseVisualStyleBackColor = true;
            // 
            // ronRadioButton
            // 
            ronRadioButton.AutoSize = true;
            ronRadioButton.Location = new Point(6, 95);
            ronRadioButton.Name = "ronRadioButton";
            ronRadioButton.Size = new Size(142, 27);
            ronRadioButton.TabIndex = 4;
            ronRadioButton.TabStop = true;
            ronRadioButton.Text = "Ron Chambers";
            ronRadioButton.UseVisualStyleBackColor = true;
            ronRadioButton.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // patRadioButton
            // 
            patRadioButton.AutoSize = true;
            patRadioButton.Location = new Point(6, 62);
            patRadioButton.Name = "patRadioButton";
            patRadioButton.Size = new Size(122, 27);
            patRadioButton.TabIndex = 3;
            patRadioButton.TabStop = true;
            patRadioButton.Text = "Pat Johnson";
            patRadioButton.UseVisualStyleBackColor = true;
            // 
            // clientTypeGroupBox
            // 
            clientTypeGroupBox.AutoSize = true;
            clientTypeGroupBox.Controls.Add(seniorRadioButton);
            clientTypeGroupBox.Controls.Add(studentRadioButton);
            clientTypeGroupBox.Controls.Add(childRadioButton);
            clientTypeGroupBox.Controls.Add(standardAdultRadioButton);
            clientTypeGroupBox.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clientTypeGroupBox.Location = new Point(12, 263);
            clientTypeGroupBox.Name = "clientTypeGroupBox";
            clientTypeGroupBox.Size = new Size(200, 181);
            clientTypeGroupBox.TabIndex = 2;
            clientTypeGroupBox.TabStop = false;
            clientTypeGroupBox.Text = "Client Type";
            // 
            // seniorRadioButton
            // 
            seniorRadioButton.AutoSize = true;
            seniorRadioButton.Location = new Point(6, 124);
            seniorRadioButton.Name = "seniorRadioButton";
            seniorRadioButton.Size = new Size(155, 27);
            seniorRadioButton.TabIndex = 6;
            seniorRadioButton.TabStop = true;
            seniorRadioButton.Text = "Senior (over 65)";
            seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            studentRadioButton.AutoSize = true;
            studentRadioButton.Location = new Point(6, 90);
            studentRadioButton.Name = "studentRadioButton";
            studentRadioButton.Size = new Size(91, 27);
            studentRadioButton.TabIndex = 4;
            studentRadioButton.TabStop = true;
            studentRadioButton.Text = "Student";
            studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // childRadioButton
            // 
            childRadioButton.AutoSize = true;
            childRadioButton.Location = new Point(6, 56);
            childRadioButton.Name = "childRadioButton";
            childRadioButton.Size = new Size(188, 27);
            childRadioButton.TabIndex = 3;
            childRadioButton.TabStop = true;
            childRadioButton.Text = "Child (12 and under)";
            childRadioButton.UseVisualStyleBackColor = true;
            // 
            // standardAdultRadioButton
            // 
            standardAdultRadioButton.AutoSize = true;
            standardAdultRadioButton.Location = new Point(6, 22);
            standardAdultRadioButton.Name = "standardAdultRadioButton";
            standardAdultRadioButton.Size = new Size(147, 27);
            standardAdultRadioButton.TabIndex = 0;
            standardAdultRadioButton.TabStop = true;
            standardAdultRadioButton.Text = "Standard Adult";
            standardAdultRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 421);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sue Pallon";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // servicesGroupBox
            // 
            servicesGroupBox.Controls.Add(colourCheckBox);
            servicesGroupBox.Controls.Add(extensionsCheckBox);
            servicesGroupBox.Controls.Add(highlightsCheckBox);
            servicesGroupBox.Controls.Add(cutCheckBox);
            servicesGroupBox.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            servicesGroupBox.Location = new Point(224, 22);
            servicesGroupBox.Name = "servicesGroupBox";
            servicesGroupBox.Size = new Size(213, 198);
            servicesGroupBox.TabIndex = 6;
            servicesGroupBox.TabStop = false;
            servicesGroupBox.Text = "Services";
            servicesGroupBox.Enter += groupBox2_Enter;
            // 
            // colourCheckBox
            // 
            colourCheckBox.AutoSize = true;
            colourCheckBox.Location = new Point(6, 62);
            colourCheckBox.Name = "colourCheckBox";
            colourCheckBox.Size = new Size(81, 27);
            colourCheckBox.TabIndex = 3;
            colourCheckBox.Text = "Colour";
            colourCheckBox.UseVisualStyleBackColor = true;
            // 
            // extensionsCheckBox
            // 
            extensionsCheckBox.AutoSize = true;
            extensionsCheckBox.Location = new Point(6, 128);
            extensionsCheckBox.Name = "extensionsCheckBox";
            extensionsCheckBox.Size = new Size(115, 27);
            extensionsCheckBox.TabIndex = 2;
            extensionsCheckBox.Text = "Extensions";
            extensionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // highlightsCheckBox
            // 
            highlightsCheckBox.AutoSize = true;
            highlightsCheckBox.Location = new Point(6, 95);
            highlightsCheckBox.Name = "highlightsCheckBox";
            highlightsCheckBox.Size = new Size(109, 27);
            highlightsCheckBox.TabIndex = 1;
            highlightsCheckBox.Text = "Highlights";
            highlightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // cutCheckBox
            // 
            cutCheckBox.AutoSize = true;
            cutCheckBox.Location = new Point(6, 30);
            cutCheckBox.Name = "cutCheckBox";
            cutCheckBox.Size = new Size(56, 27);
            cutCheckBox.TabIndex = 0;
            cutCheckBox.Text = "Cut";
            cutCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientVisitsGroupBox
            // 
            clientVisitsGroupBox.Controls.Add(firstLabel);
            clientVisitsGroupBox.Controls.Add(clientVisitsTextBox);
            clientVisitsGroupBox.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clientVisitsGroupBox.Location = new Point(224, 263);
            clientVisitsGroupBox.Name = "clientVisitsGroupBox";
            clientVisitsGroupBox.Size = new Size(213, 177);
            clientVisitsGroupBox.TabIndex = 7;
            clientVisitsGroupBox.TabStop = false;
            clientVisitsGroupBox.Text = "Client Visits";
            // 
            // firstLabel
            // 
            firstLabel.AutoSize = true;
            firstLabel.Location = new Point(6, 30);
            firstLabel.Name = "firstLabel";
            firstLabel.Size = new Size(199, 23);
            firstLabel.TabIndex = 1;
            firstLabel.Text = "Number of Client Visits:";
            firstLabel.Click += label1_Click;
            // 
            // clientVisitsTextBox
            // 
            clientVisitsTextBox.Location = new Point(6, 56);
            clientVisitsTextBox.Name = "clientVisitsTextBox";
            clientVisitsTextBox.Size = new Size(188, 31);
            clientVisitsTextBox.TabIndex = 0;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(165, 459);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(101, 23);
            totalPriceLabel.TabIndex = 8;
            totalPriceLabel.Text = "Total Price: ";
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.Location = new Point(18, 498);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(91, 38);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(165, 498);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(93, 38);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(323, 498);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(95, 38);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 551);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(totalPriceLabel);
            Controls.Add(clientVisitsGroupBox);
            Controls.Add(servicesGroupBox);
            Controls.Add(clientTypeGroupBox);
            Controls.Add(radioButton2);
            Controls.Add(hairDresserGroupBox);
            Name = "Form1";
            Text = "Form1";
            hairDresserGroupBox.ResumeLayout(false);
            hairDresserGroupBox.PerformLayout();
            clientTypeGroupBox.ResumeLayout(false);
            clientTypeGroupBox.PerformLayout();
            servicesGroupBox.ResumeLayout(false);
            servicesGroupBox.PerformLayout();
            clientVisitsGroupBox.ResumeLayout(false);
            clientVisitsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton janeRadioButton;
        private GroupBox hairDresserGroupBox;
        private RadioButton lauraRadioButton;
        private RadioButton sueRadioButton;
        private RadioButton ronRadioButton;
        private RadioButton patRadioButton;
        private GroupBox clientTypeGroupBox;
        private RadioButton seniorRadioButton;
        private RadioButton radioButton2;
        private RadioButton studentRadioButton;
        private RadioButton childRadioButton;
        private RadioButton standardAdultRadioButton;
        private GroupBox servicesGroupBox;
        private CheckBox colourCheckBox;
        private CheckBox extensionsCheckBox;
        private CheckBox highlightsCheckBox;
        private CheckBox cutCheckBox;
        private GroupBox clientVisitsGroupBox;
        private Label firstLabel;
        private TextBox clientVisitsTextBox;
        private Label totalPriceLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}