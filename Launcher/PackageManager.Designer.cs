﻿namespace Launcher
{
    partial class PackageManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManager));
            this.packageList = new System.Windows.Forms.ListBox();
            this.newPackageName = new System.Windows.Forms.TextBox();
            this.newPackage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListBox();
            this.itemButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.characterList = new System.Windows.Forms.ListBox();
            this.characterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.structureList = new System.Windows.Forms.ListBox();
            this.structureButton = new System.Windows.Forms.Button();
            this.jobButton = new System.Windows.Forms.Button();
            this.jobList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.characterFolder = new System.Windows.Forms.Button();
            this.itemFolder = new System.Windows.Forms.Button();
            this.structureFolder = new System.Windows.Forms.Button();
            this.jobFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // packageList
            // 
            this.packageList.FormattingEnabled = true;
            this.packageList.Location = new System.Drawing.Point(12, 73);
            this.packageList.Name = "packageList";
            this.packageList.Size = new System.Drawing.Size(180, 342);
            this.packageList.TabIndex = 3;
            this.packageList.SelectedIndexChanged += new System.EventHandler(this.packageList_SelectedIndexChanged);
            // 
            // newPackageName
            // 
            this.newPackageName.Location = new System.Drawing.Point(12, 421);
            this.newPackageName.Name = "newPackageName";
            this.newPackageName.Size = new System.Drawing.Size(129, 20);
            this.newPackageName.TabIndex = 4;
            this.newPackageName.TextChanged += new System.EventHandler(this.newPackageName_TextChanged);
            // 
            // newPackage
            // 
            this.newPackage.Enabled = false;
            this.newPackage.Location = new System.Drawing.Point(147, 421);
            this.newPackage.Name = "newPackage";
            this.newPackage.Size = new System.Drawing.Size(45, 20);
            this.newPackage.TabIndex = 5;
            this.newPackage.Text = "New";
            this.newPackage.UseVisualStyleBackColor = true;
            this.newPackage.Click += new System.EventHandler(this.newPackage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(215, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item files:";
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(218, 307);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(255, 134);
            this.itemList.TabIndex = 8;
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(301, 281);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(75, 23);
            this.itemButton.TabIndex = 9;
            this.itemButton.Text = "Add file";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(215, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Character files:";
            // 
            // characterList
            // 
            this.characterList.FormattingEnabled = true;
            this.characterList.Location = new System.Drawing.Point(218, 145);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(255, 121);
            this.characterList.TabIndex = 8;
            // 
            // characterButton
            // 
            this.characterButton.Location = new System.Drawing.Point(301, 116);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(75, 23);
            this.characterButton.TabIndex = 9;
            this.characterButton.Text = "Add file";
            this.characterButton.UseVisualStyleBackColor = true;
            this.characterButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(489, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Map structure files:";
            // 
            // structureList
            // 
            this.structureList.FormattingEnabled = true;
            this.structureList.Location = new System.Drawing.Point(492, 145);
            this.structureList.Name = "structureList";
            this.structureList.Size = new System.Drawing.Size(255, 121);
            this.structureList.TabIndex = 8;
            // 
            // structureButton
            // 
            this.structureButton.Location = new System.Drawing.Point(603, 116);
            this.structureButton.Name = "structureButton";
            this.structureButton.Size = new System.Drawing.Size(75, 23);
            this.structureButton.TabIndex = 9;
            this.structureButton.Text = "Add file";
            this.structureButton.UseVisualStyleBackColor = true;
            this.structureButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // jobButton
            // 
            this.jobButton.Location = new System.Drawing.Point(603, 281);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(75, 23);
            this.jobButton.TabIndex = 12;
            this.jobButton.Text = "Add file";
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // jobList
            // 
            this.jobList.FormattingEnabled = true;
            this.jobList.Location = new System.Drawing.Point(492, 307);
            this.jobList.Name = "jobList";
            this.jobList.Size = new System.Drawing.Size(255, 134);
            this.jobList.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(489, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Job files:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(623, 503);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(124, 37);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // characterFolder
            // 
            this.characterFolder.Location = new System.Drawing.Point(398, 116);
            this.characterFolder.Name = "characterFolder";
            this.characterFolder.Size = new System.Drawing.Size(75, 23);
            this.characterFolder.TabIndex = 9;
            this.characterFolder.Text = "Add folder";
            this.characterFolder.UseVisualStyleBackColor = true;
            this.characterFolder.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // itemFolder
            // 
            this.itemFolder.Location = new System.Drawing.Point(398, 280);
            this.itemFolder.Name = "itemFolder";
            this.itemFolder.Size = new System.Drawing.Size(75, 23);
            this.itemFolder.TabIndex = 14;
            this.itemFolder.Text = "Add folder";
            this.itemFolder.UseVisualStyleBackColor = true;
            this.itemFolder.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // structureFolder
            // 
            this.structureFolder.Location = new System.Drawing.Point(672, 116);
            this.structureFolder.Name = "structureFolder";
            this.structureFolder.Size = new System.Drawing.Size(75, 23);
            this.structureFolder.TabIndex = 15;
            this.structureFolder.Text = "Add folder";
            this.structureFolder.UseVisualStyleBackColor = true;
            this.structureFolder.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // jobFolder
            // 
            this.jobFolder.Location = new System.Drawing.Point(672, 281);
            this.jobFolder.Name = "jobFolder";
            this.jobFolder.Size = new System.Drawing.Size(75, 23);
            this.jobFolder.TabIndex = 16;
            this.jobFolder.Text = "Add folder";
            this.jobFolder.UseVisualStyleBackColor = true;
            this.jobFolder.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // PackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.jobFolder);
            this.Controls.Add(this.structureFolder);
            this.Controls.Add(this.itemFolder);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.jobButton);
            this.Controls.Add(this.jobList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.structureButton);
            this.Controls.Add(this.characterFolder);
            this.Controls.Add(this.characterButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.structureList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.characterList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPackage);
            this.Controls.Add(this.newPackageName);
            this.Controls.Add(this.packageList);
            this.DoubleBuffered = true;
            this.Name = "PackageManager";
            this.Text = "PackageManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox packageList;
        private System.Windows.Forms.TextBox newPackageName;
        private System.Windows.Forms.Button newPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox characterList;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox structureList;
        private System.Windows.Forms.Button structureButton;
        private System.Windows.Forms.Button jobButton;
        private System.Windows.Forms.ListBox jobList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button characterFolder;
        private System.Windows.Forms.Button itemFolder;
        private System.Windows.Forms.Button structureFolder;
        private System.Windows.Forms.Button jobFolder;

    }
}