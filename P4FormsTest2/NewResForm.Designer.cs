namespace P4FormsTest2
{
    partial class NewResForm
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
            this.newResNameField = new System.Windows.Forms.TextBox();
            this.newResLabel = new System.Windows.Forms.Label();
            this.resNameLabel = new System.Windows.Forms.Label();
            this.newResConfirmButton = new System.Windows.Forms.Button();
            this.newResCancelButton = new System.Windows.Forms.Button();
            this.newResStartField = new System.Windows.Forms.MonthCalendar();
            this.newResEndField = new System.Windows.Forms.MonthCalendar();
            this.newResEmailField = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.newResPhoneField = new System.Windows.Forms.TextBox();
            this.newResAdultsField = new System.Windows.Forms.NumericUpDown();
            this.adultsLabel = new System.Windows.Forms.Label();
            this.childrenLabel = new System.Windows.Forms.Label();
            this.newResChildrenField = new System.Windows.Forms.NumericUpDown();
            this.resStartLabel = new System.Windows.Forms.Label();
            this.resEndLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newResAdultsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newResChildrenField)).BeginInit();
            this.SuspendLayout();
            // 
            // newResNameField
            // 
            this.newResNameField.Location = new System.Drawing.Point(12, 62);
            this.newResNameField.Name = "newResNameField";
            this.newResNameField.Size = new System.Drawing.Size(277, 20);
            this.newResNameField.TabIndex = 0;
            // 
            // newResLabel
            // 
            this.newResLabel.AutoSize = true;
            this.newResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newResLabel.Location = new System.Drawing.Point(174, 9);
            this.newResLabel.Name = "newResLabel";
            this.newResLabel.Size = new System.Drawing.Size(174, 22);
            this.newResLabel.TabIndex = 1;
            this.newResLabel.Text = "Add new reservation";
            this.newResLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // resNameLabel
            // 
            this.resNameLabel.AutoSize = true;
            this.resNameLabel.Location = new System.Drawing.Point(9, 46);
            this.resNameLabel.Name = "resNameLabel";
            this.resNameLabel.Size = new System.Drawing.Size(35, 13);
            this.resNameLabel.TabIndex = 2;
            this.resNameLabel.Text = "Name";
            // 
            // newResConfirmButton
            // 
            this.newResConfirmButton.Location = new System.Drawing.Point(410, 466);
            this.newResConfirmButton.Name = "newResConfirmButton";
            this.newResConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.newResConfirmButton.TabIndex = 3;
            this.newResConfirmButton.Text = "Add";
            this.newResConfirmButton.UseVisualStyleBackColor = true;
            this.newResConfirmButton.Click += new System.EventHandler(this.newResConfirmButton_Click);
            // 
            // newResCancelButton
            // 
            this.newResCancelButton.Location = new System.Drawing.Point(12, 466);
            this.newResCancelButton.Name = "newResCancelButton";
            this.newResCancelButton.Size = new System.Drawing.Size(75, 23);
            this.newResCancelButton.TabIndex = 4;
            this.newResCancelButton.Text = "Cancel";
            this.newResCancelButton.UseVisualStyleBackColor = true;
            this.newResCancelButton.Click += new System.EventHandler(this.newResCancelButton_Click);
            // 
            // newResStartField
            // 
            this.newResStartField.Location = new System.Drawing.Point(314, 62);
            this.newResStartField.Name = "newResStartField";
            this.newResStartField.TabIndex = 5;
            // 
            // newResEndField
            // 
            this.newResEndField.Location = new System.Drawing.Point(314, 288);
            this.newResEndField.Name = "newResEndField";
            this.newResEndField.TabIndex = 6;
            // 
            // newResEmailField
            // 
            this.newResEmailField.Location = new System.Drawing.Point(13, 114);
            this.newResEmailField.Name = "newResEmailField";
            this.newResEmailField.Size = new System.Drawing.Size(276, 20);
            this.newResEmailField.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 98);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(10, 151);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone Number";
            this.phoneLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // newResPhoneField
            // 
            this.newResPhoneField.Location = new System.Drawing.Point(13, 167);
            this.newResPhoneField.Name = "newResPhoneField";
            this.newResPhoneField.Size = new System.Drawing.Size(276, 20);
            this.newResPhoneField.TabIndex = 9;
            // 
            // newResAdultsField
            // 
            this.newResAdultsField.Location = new System.Drawing.Point(15, 228);
            this.newResAdultsField.Name = "newResAdultsField";
            this.newResAdultsField.Size = new System.Drawing.Size(131, 20);
            this.newResAdultsField.TabIndex = 11;
            // 
            // adultsLabel
            // 
            this.adultsLabel.AutoSize = true;
            this.adultsLabel.Location = new System.Drawing.Point(12, 212);
            this.adultsLabel.Name = "adultsLabel";
            this.adultsLabel.Size = new System.Drawing.Size(36, 13);
            this.adultsLabel.TabIndex = 12;
            this.adultsLabel.Text = "Adults";
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Location = new System.Drawing.Point(158, 212);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(45, 13);
            this.childrenLabel.TabIndex = 14;
            this.childrenLabel.Text = "Children";
            this.childrenLabel.UseWaitCursor = true;
            // 
            // newResChildrenField
            // 
            this.newResChildrenField.Location = new System.Drawing.Point(161, 228);
            this.newResChildrenField.Name = "newResChildrenField";
            this.newResChildrenField.Size = new System.Drawing.Size(128, 20);
            this.newResChildrenField.TabIndex = 13;
            // 
            // resStartLabel
            // 
            this.resStartLabel.AutoSize = true;
            this.resStartLabel.Location = new System.Drawing.Point(311, 46);
            this.resStartLabel.Name = "resStartLabel";
            this.resStartLabel.Size = new System.Drawing.Size(89, 13);
            this.resStartLabel.TabIndex = 15;
            this.resStartLabel.Text = "Reservation Start";
            // 
            // resEndLabel
            // 
            this.resEndLabel.AutoSize = true;
            this.resEndLabel.Location = new System.Drawing.Point(311, 270);
            this.resEndLabel.Name = "resEndLabel";
            this.resEndLabel.Size = new System.Drawing.Size(86, 13);
            this.resEndLabel.TabIndex = 16;
            this.resEndLabel.Text = "Reservation End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Room";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NewResForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resEndLabel);
            this.Controls.Add(this.resStartLabel);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.newResChildrenField);
            this.Controls.Add(this.adultsLabel);
            this.Controls.Add(this.newResAdultsField);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.newResPhoneField);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.newResEmailField);
            this.Controls.Add(this.newResEndField);
            this.Controls.Add(this.newResStartField);
            this.Controls.Add(this.newResCancelButton);
            this.Controls.Add(this.newResConfirmButton);
            this.Controls.Add(this.resNameLabel);
            this.Controls.Add(this.newResLabel);
            this.Controls.Add(this.newResNameField);
            this.Name = "NewResForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_load);
            ((System.ComponentModel.ISupportInitialize)(this.newResAdultsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newResChildrenField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newResNameField;
        private System.Windows.Forms.Label newResLabel;
        private System.Windows.Forms.Label resNameLabel;
        private System.Windows.Forms.Button newResConfirmButton;
        private System.Windows.Forms.Button newResCancelButton;
        private System.Windows.Forms.MonthCalendar newResStartField;
        private System.Windows.Forms.MonthCalendar newResEndField;
        private System.Windows.Forms.TextBox newResEmailField;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox newResPhoneField;
        private System.Windows.Forms.NumericUpDown newResAdultsField;
        private System.Windows.Forms.Label adultsLabel;
        private System.Windows.Forms.Label childrenLabel;
        private System.Windows.Forms.NumericUpDown newResChildrenField;
        private System.Windows.Forms.Label resStartLabel;
        private System.Windows.Forms.Label resEndLabel;
        private System.Windows.Forms.Label label1;
    }
}