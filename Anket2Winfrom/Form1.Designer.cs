namespace Anket2Winfrom
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
            listBox1 = new ListBox();
            fileNameTextBox = new TextBox();
            saveButton = new Button();
            loadButton = new Button();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            phoneLabel = new Label();
            mailLabel = new Label();
            surnameLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            birthdayLabel = new Label();
            phonetb = new TextBox();
            mailtb = new TextBox();
            surnametb = new TextBox();
            updateButton = new Button();
            addButton = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(603, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(185, 284);
            listBox1.TabIndex = 0;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(603, 345);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(185, 27);
            fileNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(703, 391);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(85, 29);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(603, 391);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(94, 29);
            loadButton.TabIndex = 3;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(174, 49);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(185, 27);
            nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(75, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(75, 177);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(50, 20);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(75, 139);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(38, 20);
            mailLabel.TabIndex = 9;
            mailLabel.Text = "Mail";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(75, 95);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(67, 20);
            surnameLabel.TabIndex = 10;
            surnameLabel.Text = "Surname";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 224);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(185, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(75, 229);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(64, 20);
            birthdayLabel.TabIndex = 12;
            birthdayLabel.Text = "Birthday";
            // 
            // phonetb
            // 
            phonetb.Location = new Point(174, 174);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(185, 27);
            phonetb.TabIndex = 14;
            // 
            // mailtb
            // 
            mailtb.Location = new Point(174, 132);
            mailtb.Name = "mailtb";
            mailtb.Size = new Size(185, 27);
            mailtb.TabIndex = 15;
            // 
            // surnametb
            // 
            surnametb.Location = new Point(174, 92);
            surnametb.Name = "surnametb";
            surnametb.Size = new Size(185, 27);
            surnametb.TabIndex = 16;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(408, 287);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(408, 335);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 18;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(surnametb);
            groupBox1.Controls.Add(mailLabel);
            groupBox1.Controls.Add(mailtb);
            groupBox1.Controls.Add(surnameLabel);
            groupBox1.Controls.Add(phonetb);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(birthdayLabel);
            groupBox1.Location = new Point(28, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 384);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 455);
            Controls.Add(groupBox1);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(fileNameTextBox);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox fileNameTextBox;
        private Button saveButton;
        private Button loadButton;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label phoneLabel;
        private Label mailLabel;
        private Label surnameLabel;
        private DateTimePicker dateTimePicker1;
        private Label birthdayLabel;
        private TextBox phonetb;
        private TextBox mailtb;
        private TextBox surnametb;
        private Button updateButton;
        private Button addButton;
        private GroupBox groupBox1;
    }
}