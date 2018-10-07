﻿namespace MyLibrarian.Forms
{
    partial class RecogniseFaceWindow
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
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.createGroupLabel = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.newUserTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.imageFolderLabel = new System.Windows.Forms.Label();
            this.imageFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.identifyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.identifiedUserListBox = new System.Windows.Forms.ListBox();
            this.addNewUserLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // facePictureBox
            // 
            this.facePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.facePictureBox.Location = new System.Drawing.Point(5, 2);
            this.facePictureBox.Name = "facePictureBox";
            this.facePictureBox.Size = new System.Drawing.Size(526, 657);
            this.facePictureBox.TabIndex = 0;
            this.facePictureBox.TabStop = false;
            // 
            // createGroupLabel
            // 
            this.createGroupLabel.AutoSize = true;
            this.createGroupLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGroupLabel.Location = new System.Drawing.Point(543, 74);
            this.createGroupLabel.Name = "createGroupLabel";
            this.createGroupLabel.Size = new System.Drawing.Size(137, 27);
            this.createGroupLabel.TabIndex = 1;
            this.createGroupLabel.Text = "Create group";
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.Location = new System.Drawing.Point(544, 116);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(106, 22);
            this.groupNameLabel.TabIndex = 2;
            this.groupNameLabel.Text = "Group name";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameTextBox.Location = new System.Drawing.Point(665, 116);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(173, 30);
            this.groupNameTextBox.TabIndex = 3;
            // 
            // createGroupButton
            // 
            this.createGroupButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGroupButton.Location = new System.Drawing.Point(550, 152);
            this.createGroupButton.Name = "createGroupButton";
            this.createGroupButton.Size = new System.Drawing.Size(132, 42);
            this.createGroupButton.TabIndex = 4;
            this.createGroupButton.Text = "Create group";
            this.createGroupButton.UseVisualStyleBackColor = true;
            this.createGroupButton.Click += new System.EventHandler(this.createGroupButton_ClickAsync);
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserLabel.Location = new System.Drawing.Point(544, 261);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(93, 22);
            this.newUserLabel.TabIndex = 5;
            this.newUserLabel.Text = "User name";
            // 
            // newUserTextBox
            // 
            this.newUserTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserTextBox.Location = new System.Drawing.Point(665, 253);
            this.newUserTextBox.Name = "newUserTextBox";
            this.newUserTextBox.Size = new System.Drawing.Size(173, 30);
            this.newUserTextBox.TabIndex = 6;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(548, 343);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(134, 42);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_ClickAsync);
            // 
            // imageFolderLabel
            // 
            this.imageFolderLabel.AutoSize = true;
            this.imageFolderLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageFolderLabel.Location = new System.Drawing.Point(544, 300);
            this.imageFolderLabel.Name = "imageFolderLabel";
            this.imageFolderLabel.Size = new System.Drawing.Size(115, 22);
            this.imageFolderLabel.TabIndex = 8;
            this.imageFolderLabel.Text = "Image Folder";
            // 
            // imageFolderTextBox
            // 
            this.imageFolderTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageFolderTextBox.Location = new System.Drawing.Point(665, 292);
            this.imageFolderTextBox.Name = "imageFolderTextBox";
            this.imageFolderTextBox.Size = new System.Drawing.Size(173, 30);
            this.imageFolderTextBox.TabIndex = 9;
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFolderButton.Location = new System.Drawing.Point(849, 287);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(144, 44);
            this.browseFolderButton.TabIndex = 10;
            this.browseFolderButton.Text = "Browse folder";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.Location = new System.Drawing.Point(548, 458);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(134, 42);
            this.trainButton.TabIndex = 11;
            this.trainButton.Text = "Train group";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_ClickAsync);
            // 
            // identifyButton
            // 
            this.identifyButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyButton.Location = new System.Drawing.Point(548, 586);
            this.identifyButton.Name = "identifyButton";
            this.identifyButton.Size = new System.Drawing.Size(134, 42);
            this.identifyButton.TabIndex = 12;
            this.identifyButton.Text = "Identify image";
            this.identifyButton.UseVisualStyleBackColor = true;
            this.identifyButton.Click += new System.EventHandler(this.identifyButton_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Identify image";
            // 
            // identifiedUserListBox
            // 
            this.identifiedUserListBox.FormattingEnabled = true;
            this.identifiedUserListBox.ItemHeight = 20;
            this.identifiedUserListBox.Location = new System.Drawing.Point(697, 586);
            this.identifiedUserListBox.Name = "identifiedUserListBox";
            this.identifiedUserListBox.Size = new System.Drawing.Size(277, 64);
            this.identifiedUserListBox.TabIndex = 14;
            // 
            // addNewUserLabel
            // 
            this.addNewUserLabel.AutoSize = true;
            this.addNewUserLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserLabel.Location = new System.Drawing.Point(537, 211);
            this.addNewUserLabel.Name = "addNewUserLabel";
            this.addNewUserLabel.Size = new System.Drawing.Size(145, 27);
            this.addNewUserLabel.TabIndex = 15;
            this.addNewUserLabel.Text = "Add new user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Train group to recognise images";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(664, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(174, 42);
            this.browseButton.TabIndex = 17;
            this.browseButton.Text = "Browse image";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // RecogniseFaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 662);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewUserLabel);
            this.Controls.Add(this.identifiedUserListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.identifyButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.browseFolderButton);
            this.Controls.Add(this.imageFolderTextBox);
            this.Controls.Add(this.imageFolderLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.newUserTextBox);
            this.Controls.Add(this.newUserLabel);
            this.Controls.Add(this.createGroupButton);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.createGroupLabel);
            this.Controls.Add(this.facePictureBox);
            this.Name = "RecogniseFaceWindow";
            this.Text = "RecogniseFaceWindow";
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox facePictureBox;
        private System.Windows.Forms.Label createGroupLabel;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.TextBox newUserTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label imageFolderLabel;
        private System.Windows.Forms.TextBox imageFolderTextBox;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button identifyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox identifiedUserListBox;
        private System.Windows.Forms.Label addNewUserLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseButton;
    }
}