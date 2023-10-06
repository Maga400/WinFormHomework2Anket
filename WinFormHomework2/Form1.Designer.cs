using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace WinFormHomework2
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
            panel1 = new Panel();
            loadButton = new Button();
            checkTextBox = new TextBox();
            panel2 = new Panel();
            informationLabel = new Label();
            label8 = new Label();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            label7 = new Label();
            birthdayDateTime = new DateTimePicker();
            label6 = new Label();
            phoneTextBox = new TextBox();
            label3 = new Label();
            cityTextBox = new TextBox();
            label4 = new Label();
            countryTextBox = new TextBox();
            label5 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            surnameTextBox = new TextBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            saveButton = new Button();
            anketLabel = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(checkTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 40);
            panel1.TabIndex = 0;
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(323, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(94, 29);
            loadButton.TabIndex = 1;
            loadButton.Text = "LOAD";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // checkTextBox
            // 
            checkTextBox.Location = new Point(103, 3);
            checkTextBox.Name = "checkTextBox";
            checkTextBox.Size = new Size(169, 27);
            checkTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(informationLabel);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(femaleRadioButton);
            panel2.Controls.Add(maleRadioButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(birthdayDateTime);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(phoneTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cityTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(countryTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(emailTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(surnameTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(nameLabel);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 435);
            panel2.TabIndex = 20;
            // 
            // informationLabel
            // 
            informationLabel.AutoSize = true;
            informationLabel.BackColor = SystemColors.ButtonFace;
            informationLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            informationLabel.ForeColor = SystemColors.ActiveCaptionText;
            informationLabel.Location = new Point(3, 380);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(0, 16);
            informationLabel.TabIndex = 39;
            informationLabel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(0, 380);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 38;
            label8.Visible = false;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            femaleRadioButton.Location = new Point(220, 348);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(99, 24);
            femaleRadioButton.TabIndex = 37;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            maleRadioButton.Location = new Point(121, 348);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(77, 24);
            maleRadioButton.TabIndex = 36;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(24, 347);
            label7.Name = "label7";
            label7.Size = new Size(81, 23);
            label7.TabIndex = 35;
            label7.Text = "Gender:";
            // 
            // birthdayDateTime
            // 
            birthdayDateTime.Location = new Point(121, 297);
            birthdayDateTime.Name = "birthdayDateTime";
            birthdayDateTime.Size = new Size(250, 27);
            birthdayDateTime.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(20, 301);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 33;
            label6.Text = "Birthday:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(121, 245);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(311, 27);
            phoneTextBox.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(24, 249);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 31;
            label3.Text = "Phone:";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(121, 212);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(311, 27);
            cityTextBox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(24, 216);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 29;
            label4.Text = "City:";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(121, 179);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(311, 27);
            countryTextBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(24, 183);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 27;
            label5.Text = "Country:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(121, 102);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(311, 27);
            emailTextBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 106);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 25;
            label2.Text = "Email:";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(121, 69);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(311, 27);
            surnameTextBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 73);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 23;
            label1.Text = "Surname:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(121, 36);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(311, 27);
            nameTextBox.TabIndex = 22;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = SystemColors.ButtonFace;
            nameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ActiveCaptionText;
            nameLabel.Location = new Point(24, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(66, 23);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Name:";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(32, 536);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(433, 29);
            saveButton.TabIndex = 38;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // anketLabel
            // 
            anketLabel.AutoSize = true;
            anketLabel.BackColor = SystemColors.ActiveCaptionText;
            anketLabel.Font = new Font("Stencil", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            anketLabel.ForeColor = SystemColors.ButtonHighlight;
            anketLabel.Location = new Point(198, 48);
            anketLabel.Name = "anketLabel";
            anketLabel.Size = new Size(90, 27);
            anketLabel.TabIndex = 20;
            anketLabel.Text = "ANKET";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(341, 46);
            button1.Name = "button1";
            button1.Size = new Size(149, 35);
            button1.TabIndex = 39;
            button1.Text = "anketi sifirlamaq";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 572);
            Controls.Add(button1);
            Controls.Add(saveButton);
            Controls.Add(panel2);
            Controls.Add(anketLabel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button loadButton;
        private TextBox checkTextBox;
        private Panel panel2;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private Label label7;
        private DateTimePicker birthdayDateTime;
        private Label label6;
        private TextBox phoneTextBox;
        private Label label3;
        private TextBox cityTextBox;
        private Label label4;
        private TextBox countryTextBox;
        private Label label5;
        private TextBox emailTextBox;
        private Label label2;
        private TextBox surnameTextBox;
        private Label label1;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Button saveButton;
        private Label anketLabel;
        private Label label8;
        private Label informationLabel;
        private Button button1;
    }
}