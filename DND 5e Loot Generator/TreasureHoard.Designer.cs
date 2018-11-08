namespace DND_5e_Loot_Generator
{
    partial class TreasureHoard
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
            this.crDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.evenCheck = new System.Windows.Forms.CheckBox();
            this.exclusionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crDropDown
            // 
            this.crDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crDropDown.FormattingEnabled = true;
            this.crDropDown.Items.AddRange(new object[] {
            "0-4",
            "5-10",
            "11-16",
            "17+"});
            this.crDropDown.Location = new System.Drawing.Point(247, 80);
            this.crDropDown.Name = "crDropDown";
            this.crDropDown.Size = new System.Drawing.Size(45, 21);
            this.crDropDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CR:";
            // 
            // evenCheck
            // 
            this.evenCheck.AutoSize = true;
            this.evenCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.evenCheck.Checked = true;
            this.evenCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.evenCheck.Location = new System.Drawing.Point(144, 107);
            this.evenCheck.Name = "evenCheck";
            this.evenCheck.Size = new System.Drawing.Size(148, 17);
            this.evenCheck.TabIndex = 2;
            this.evenCheck.Text = "Even Amounts of Money?";
            this.evenCheck.UseVisualStyleBackColor = true;
            // 
            // exclusionListBox
            // 
            this.exclusionListBox.FormattingEnabled = true;
            this.exclusionListBox.Items.AddRange(new object[] {
            "DMG"});
            this.exclusionListBox.Location = new System.Drawing.Point(212, 130);
            this.exclusionListBox.Name = "exclusionListBox";
            this.exclusionListBox.Size = new System.Drawing.Size(80, 69);
            this.exclusionListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exclusions:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(144, 249);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(225, 249);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Preset";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // TreasureHoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 352);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exclusionListBox);
            this.Controls.Add(this.evenCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crDropDown);
            this.Name = "TreasureHoard";
            this.Text = "Treasure Hoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox crDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox evenCheck;
        private System.Windows.Forms.ListBox exclusionListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button saveButton;
    }
}