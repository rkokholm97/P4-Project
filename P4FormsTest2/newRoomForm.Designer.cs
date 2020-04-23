namespace P4FormsTest2
{
    partial class NewRoomForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.regularRadio = new System.Windows.Forms.RadioButton();
            this.suiteRadio = new System.Windows.Forms.RadioButton();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.roomNumberField = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.maxOccupantsField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxOccupantsField)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(98, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add New Room";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // regularRadio
            // 
            this.regularRadio.AutoSize = true;
            this.regularRadio.Location = new System.Drawing.Point(124, 175);
            this.regularRadio.Name = "regularRadio";
            this.regularRadio.Size = new System.Drawing.Size(62, 17);
            this.regularRadio.TabIndex = 1;
            this.regularRadio.TabStop = true;
            this.regularRadio.Text = "Regular";
            this.regularRadio.UseVisualStyleBackColor = true;
            // 
            // suiteRadio
            // 
            this.suiteRadio.AutoSize = true;
            this.suiteRadio.Location = new System.Drawing.Point(124, 194);
            this.suiteRadio.Name = "suiteRadio";
            this.suiteRadio.Size = new System.Drawing.Size(49, 17);
            this.suiteRadio.TabIndex = 2;
            this.suiteRadio.TabStop = true;
            this.suiteRadio.Text = "Suite";
            this.suiteRadio.UseVisualStyleBackColor = true;
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Location = new System.Drawing.Point(231, 307);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(86, 23);
            this.addRoomBtn.TabIndex = 3;
            this.addRoomBtn.Text = "Add";
            this.addRoomBtn.UseVisualStyleBackColor = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 307);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(114, 148);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(81, 17);
            this.roomTypeLabel.TabIndex = 5;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // roomNumberField
            // 
            this.roomNumberField.BackColor = System.Drawing.Color.Gainsboro;
            this.roomNumberField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roomNumberField.Location = new System.Drawing.Point(124, 97);
            this.roomNumberField.Name = "roomNumberField";
            this.roomNumberField.ReadOnly = true;
            this.roomNumberField.Size = new System.Drawing.Size(62, 20);
            this.roomNumberField.TabIndex = 6;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(109, 72);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(99, 17);
            this.roomNumberLabel.TabIndex = 7;
            this.roomNumberLabel.Text = "Room Number";
            // 
            // maxOccupantsField
            // 
            this.maxOccupantsField.Location = new System.Drawing.Point(122, 257);
            this.maxOccupantsField.Name = "maxOccupantsField";
            this.maxOccupantsField.Size = new System.Drawing.Size(62, 20);
            this.maxOccupantsField.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Maximum Occupants";
            // 
            // NewRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxOccupantsField);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.roomNumberField);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.suiteRadio);
            this.Controls.Add(this.regularRadio);
            this.Controls.Add(this.titleLabel);
            this.Name = "NewRoomForm";
            this.Text = "Add New Room";
            this.Load += new System.EventHandler(this.NewRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxOccupantsField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton regularRadio;
        private System.Windows.Forms.RadioButton suiteRadio;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.TextBox roomNumberField;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.NumericUpDown maxOccupantsField;
        private System.Windows.Forms.Label label1;
    }
}