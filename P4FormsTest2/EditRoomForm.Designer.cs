namespace P4FormsTest2
{
    partial class EditRoomForm
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
            this.roomNumberField = new System.Windows.Forms.NumericUpDown();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.maxOccupantsField = new System.Windows.Forms.NumericUpDown();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editRoomBtn = new System.Windows.Forms.Button();
            this.suiteRadio = new System.Windows.Forms.RadioButton();
            this.regularRadio = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOccupantsField)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNumberField
            // 
            this.roomNumberField.Location = new System.Drawing.Point(136, 155);
            this.roomNumberField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomNumberField.Name = "roomNumberField";
            this.roomNumberField.Size = new System.Drawing.Size(62, 20);
            this.roomNumberField.TabIndex = 24;
            this.roomNumberField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorLabel.Location = new System.Drawing.Point(147, 62);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(40, 17);
            this.floorLabel.TabIndex = 23;
            this.floorLabel.Text = "Floor";
            // 
            // floorField
            // 
            this.floorField.Location = new System.Drawing.Point(136, 85);
            this.floorField.Name = "floorField";
            this.floorField.Size = new System.Drawing.Size(62, 20);
            this.floorField.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Maximum Occupants";
            // 
            // maxOccupantsField
            // 
            this.maxOccupantsField.Location = new System.Drawing.Point(136, 307);
            this.maxOccupantsField.Name = "maxOccupantsField";
            this.maxOccupantsField.Size = new System.Drawing.Size(62, 20);
            this.maxOccupantsField.TabIndex = 20;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(123, 130);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(99, 17);
            this.roomNumberLabel.TabIndex = 19;
            this.roomNumberLabel.Text = "Room Number";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(128, 200);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(81, 17);
            this.roomTypeLabel.TabIndex = 18;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 418);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editRoomBtn
            // 
            this.editRoomBtn.Location = new System.Drawing.Point(231, 418);
            this.editRoomBtn.Name = "editRoomBtn";
            this.editRoomBtn.Size = new System.Drawing.Size(86, 23);
            this.editRoomBtn.TabIndex = 16;
            this.editRoomBtn.Text = "Confirm";
            this.editRoomBtn.UseVisualStyleBackColor = true;
            this.editRoomBtn.Click += new System.EventHandler(this.editRoomBtn_Click);
            // 
            // suiteRadio
            // 
            this.suiteRadio.AutoSize = true;
            this.suiteRadio.Location = new System.Drawing.Point(138, 246);
            this.suiteRadio.Name = "suiteRadio";
            this.suiteRadio.Size = new System.Drawing.Size(49, 17);
            this.suiteRadio.TabIndex = 15;
            this.suiteRadio.TabStop = true;
            this.suiteRadio.Text = "Suite";
            this.suiteRadio.UseVisualStyleBackColor = true;
            // 
            // regularRadio
            // 
            this.regularRadio.AutoSize = true;
            this.regularRadio.Location = new System.Drawing.Point(138, 227);
            this.regularRadio.Name = "regularRadio";
            this.regularRadio.Size = new System.Drawing.Size(62, 17);
            this.regularRadio.TabIndex = 14;
            this.regularRadio.TabStop = true;
            this.regularRadio.Text = "Regular";
            this.regularRadio.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(123, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(84, 20);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Edit Room";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Status";
            // 
            // statusDropDown
            // 
            this.statusDropDown.FormattingEnabled = true;
            this.statusDropDown.Location = new System.Drawing.Point(105, 368);
            this.statusDropDown.Name = "statusDropDown";
            this.statusDropDown.Size = new System.Drawing.Size(121, 21);
            this.statusDropDown.TabIndex = 27;
            // 
            // EditRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 454);
            this.Controls.Add(this.statusDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomNumberField);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.floorField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxOccupantsField);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editRoomBtn);
            this.Controls.Add(this.suiteRadio);
            this.Controls.Add(this.regularRadio);
            this.Controls.Add(this.titleLabel);
            this.Name = "EditRoomForm";
            this.Text = "EditRoomForm";
            this.Load += new System.EventHandler(this.EditRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOccupantsField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown roomNumberField;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.NumericUpDown floorField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxOccupantsField;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editRoomBtn;
        private System.Windows.Forms.RadioButton suiteRadio;
        private System.Windows.Forms.RadioButton regularRadio;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusDropDown;
    }
}