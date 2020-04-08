namespace P4FormsTest2
{
    partial class viewResForm
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
            this.viewResCloseBtn = new System.Windows.Forms.Button();
            this.viewResNameLabel = new System.Windows.Forms.Label();
            this.viewResDeleteBtn = new System.Windows.Forms.Button();
            this.viewResEditBtn = new System.Windows.Forms.Button();
            this.viewResStaticNameLabel = new System.Windows.Forms.Label();
            this.viewResStaticIdLabel = new System.Windows.Forms.Label();
            this.viewResIdLabel = new System.Windows.Forms.Label();
            this.viewResStaticEmailLabel = new System.Windows.Forms.Label();
            this.viewResEmailLabel = new System.Windows.Forms.Label();
            this.viewResStaticPhoneLabel = new System.Windows.Forms.Label();
            this.viewResPhoneLabel = new System.Windows.Forms.Label();
            this.viewResStaticRoomLabel = new System.Windows.Forms.Label();
            this.viewResRoomLabel = new System.Windows.Forms.Label();
            this.viewResStaticGuestsLabel = new System.Windows.Forms.Label();
            this.viewResAdultsLabel = new System.Windows.Forms.Label();
            this.viewResChildrenLabel = new System.Windows.Forms.Label();
            this.viewResTotalLabel = new System.Windows.Forms.Label();
            this.viewResTotalGuestsAmount = new System.Windows.Forms.Label();
            this.viewResChildrenAmount = new System.Windows.Forms.Label();
            this.viewResAdultsAmount = new System.Windows.Forms.Label();
            this.viewResStaticStartLabel = new System.Windows.Forms.Label();
            this.viewResStartLabel = new System.Windows.Forms.Label();
            this.viewResStaticEndLabel = new System.Windows.Forms.Label();
            this.viewResEndLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewResCloseBtn
            // 
            this.viewResCloseBtn.Location = new System.Drawing.Point(12, 407);
            this.viewResCloseBtn.Name = "viewResCloseBtn";
            this.viewResCloseBtn.Size = new System.Drawing.Size(75, 31);
            this.viewResCloseBtn.TabIndex = 0;
            this.viewResCloseBtn.Text = "Close";
            this.viewResCloseBtn.UseVisualStyleBackColor = true;
            this.viewResCloseBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // viewResNameLabel
            // 
            this.viewResNameLabel.AutoSize = true;
            this.viewResNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResNameLabel.Location = new System.Drawing.Point(18, 103);
            this.viewResNameLabel.Name = "viewResNameLabel";
            this.viewResNameLabel.Size = new System.Drawing.Size(110, 15);
            this.viewResNameLabel.TabIndex = 1;
            this.viewResNameLabel.Text = "Placeholder Name";
            // 
            // viewResDeleteBtn
            // 
            this.viewResDeleteBtn.BackColor = System.Drawing.Color.Brown;
            this.viewResDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.viewResDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewResDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewResDeleteBtn.Location = new System.Drawing.Point(385, 407);
            this.viewResDeleteBtn.Name = "viewResDeleteBtn";
            this.viewResDeleteBtn.Size = new System.Drawing.Size(136, 31);
            this.viewResDeleteBtn.TabIndex = 2;
            this.viewResDeleteBtn.Text = "Delete Reservation";
            this.viewResDeleteBtn.UseVisualStyleBackColor = false;
            this.viewResDeleteBtn.Click += new System.EventHandler(this.viewResDeleteBtn_Click);
            // 
            // viewResEditBtn
            // 
            this.viewResEditBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.viewResEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.viewResEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewResEditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewResEditBtn.Location = new System.Drawing.Point(240, 407);
            this.viewResEditBtn.Name = "viewResEditBtn";
            this.viewResEditBtn.Size = new System.Drawing.Size(139, 31);
            this.viewResEditBtn.TabIndex = 3;
            this.viewResEditBtn.Text = "Edit Reservation";
            this.viewResEditBtn.UseVisualStyleBackColor = false;
            // 
            // viewResStaticNameLabel
            // 
            this.viewResStaticNameLabel.AutoSize = true;
            this.viewResStaticNameLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticNameLabel.Location = new System.Drawing.Point(18, 89);
            this.viewResStaticNameLabel.Name = "viewResStaticNameLabel";
            this.viewResStaticNameLabel.Size = new System.Drawing.Size(78, 15);
            this.viewResStaticNameLabel.TabIndex = 4;
            this.viewResStaticNameLabel.Text = "Full Name";
            // 
            // viewResStaticIdLabel
            // 
            this.viewResStaticIdLabel.AutoSize = true;
            this.viewResStaticIdLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticIdLabel.Location = new System.Drawing.Point(18, 19);
            this.viewResStaticIdLabel.Name = "viewResStaticIdLabel";
            this.viewResStaticIdLabel.Size = new System.Drawing.Size(153, 15);
            this.viewResStaticIdLabel.TabIndex = 6;
            this.viewResStaticIdLabel.Text = "Reservation Number";
            this.viewResStaticIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewResIdLabel
            // 
            this.viewResIdLabel.AutoSize = true;
            this.viewResIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResIdLabel.Location = new System.Drawing.Point(18, 34);
            this.viewResIdLabel.Name = "viewResIdLabel";
            this.viewResIdLabel.Size = new System.Drawing.Size(86, 15);
            this.viewResIdLabel.TabIndex = 5;
            this.viewResIdLabel.Text = "Placeholder Id";
            // 
            // viewResStaticEmailLabel
            // 
            this.viewResStaticEmailLabel.AutoSize = true;
            this.viewResStaticEmailLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticEmailLabel.Location = new System.Drawing.Point(18, 160);
            this.viewResStaticEmailLabel.Name = "viewResStaticEmailLabel";
            this.viewResStaticEmailLabel.Size = new System.Drawing.Size(44, 15);
            this.viewResStaticEmailLabel.TabIndex = 8;
            this.viewResStaticEmailLabel.Text = "Email";
            // 
            // viewResEmailLabel
            // 
            this.viewResEmailLabel.AutoSize = true;
            this.viewResEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResEmailLabel.Location = new System.Drawing.Point(18, 174);
            this.viewResEmailLabel.Name = "viewResEmailLabel";
            this.viewResEmailLabel.Size = new System.Drawing.Size(108, 15);
            this.viewResEmailLabel.TabIndex = 7;
            this.viewResEmailLabel.Text = "Placeholder Email";
            // 
            // viewResStaticPhoneLabel
            // 
            this.viewResStaticPhoneLabel.AutoSize = true;
            this.viewResStaticPhoneLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticPhoneLabel.Location = new System.Drawing.Point(19, 231);
            this.viewResStaticPhoneLabel.Name = "viewResStaticPhoneLabel";
            this.viewResStaticPhoneLabel.Size = new System.Drawing.Size(113, 15);
            this.viewResStaticPhoneLabel.TabIndex = 10;
            this.viewResStaticPhoneLabel.Text = "Phone Number";
            // 
            // viewResPhoneLabel
            // 
            this.viewResPhoneLabel.AutoSize = true;
            this.viewResPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResPhoneLabel.Location = new System.Drawing.Point(19, 245);
            this.viewResPhoneLabel.Name = "viewResPhoneLabel";
            this.viewResPhoneLabel.Size = new System.Drawing.Size(112, 15);
            this.viewResPhoneLabel.TabIndex = 9;
            this.viewResPhoneLabel.Text = "Placeholder Phone";
            // 
            // viewResStaticRoomLabel
            // 
            this.viewResStaticRoomLabel.AutoSize = true;
            this.viewResStaticRoomLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticRoomLabel.Location = new System.Drawing.Point(19, 309);
            this.viewResStaticRoomLabel.Name = "viewResStaticRoomLabel";
            this.viewResStaticRoomLabel.Size = new System.Drawing.Size(108, 15);
            this.viewResStaticRoomLabel.TabIndex = 12;
            this.viewResStaticRoomLabel.Text = "Room Number";
            // 
            // viewResRoomLabel
            // 
            this.viewResRoomLabel.AutoSize = true;
            this.viewResRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResRoomLabel.Location = new System.Drawing.Point(19, 323);
            this.viewResRoomLabel.Name = "viewResRoomLabel";
            this.viewResRoomLabel.Size = new System.Drawing.Size(110, 15);
            this.viewResRoomLabel.TabIndex = 11;
            this.viewResRoomLabel.Text = "Placeholder Room";
            // 
            // viewResStaticGuestsLabel
            // 
            this.viewResStaticGuestsLabel.AutoSize = true;
            this.viewResStaticGuestsLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticGuestsLabel.Location = new System.Drawing.Point(271, 19);
            this.viewResStaticGuestsLabel.Name = "viewResStaticGuestsLabel";
            this.viewResStaticGuestsLabel.Size = new System.Drawing.Size(57, 15);
            this.viewResStaticGuestsLabel.TabIndex = 14;
            this.viewResStaticGuestsLabel.Text = "Guests";
            // 
            // viewResAdultsLabel
            // 
            this.viewResAdultsLabel.AutoSize = true;
            this.viewResAdultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResAdultsLabel.Location = new System.Drawing.Point(272, 35);
            this.viewResAdultsLabel.Name = "viewResAdultsLabel";
            this.viewResAdultsLabel.Size = new System.Drawing.Size(43, 15);
            this.viewResAdultsLabel.TabIndex = 13;
            this.viewResAdultsLabel.Text = "Adults:";
            // 
            // viewResChildrenLabel
            // 
            this.viewResChildrenLabel.AutoSize = true;
            this.viewResChildrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResChildrenLabel.Location = new System.Drawing.Point(272, 55);
            this.viewResChildrenLabel.Name = "viewResChildrenLabel";
            this.viewResChildrenLabel.Size = new System.Drawing.Size(56, 15);
            this.viewResChildrenLabel.TabIndex = 15;
            this.viewResChildrenLabel.Text = "Children:";
            // 
            // viewResTotalLabel
            // 
            this.viewResTotalLabel.AutoSize = true;
            this.viewResTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResTotalLabel.Location = new System.Drawing.Point(272, 75);
            this.viewResTotalLabel.Name = "viewResTotalLabel";
            this.viewResTotalLabel.Size = new System.Drawing.Size(37, 15);
            this.viewResTotalLabel.TabIndex = 16;
            this.viewResTotalLabel.Text = "Total:";
            // 
            // viewResTotalGuestsAmount
            // 
            this.viewResTotalGuestsAmount.AutoSize = true;
            this.viewResTotalGuestsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResTotalGuestsAmount.Location = new System.Drawing.Point(337, 75);
            this.viewResTotalGuestsAmount.Name = "viewResTotalGuestsAmount";
            this.viewResTotalGuestsAmount.Size = new System.Drawing.Size(14, 15);
            this.viewResTotalGuestsAmount.TabIndex = 19;
            this.viewResTotalGuestsAmount.Text = "0";
            // 
            // viewResChildrenAmount
            // 
            this.viewResChildrenAmount.AutoSize = true;
            this.viewResChildrenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResChildrenAmount.Location = new System.Drawing.Point(337, 55);
            this.viewResChildrenAmount.Name = "viewResChildrenAmount";
            this.viewResChildrenAmount.Size = new System.Drawing.Size(14, 15);
            this.viewResChildrenAmount.TabIndex = 18;
            this.viewResChildrenAmount.Text = "0";
            // 
            // viewResAdultsAmount
            // 
            this.viewResAdultsAmount.AutoSize = true;
            this.viewResAdultsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResAdultsAmount.Location = new System.Drawing.Point(337, 35);
            this.viewResAdultsAmount.Name = "viewResAdultsAmount";
            this.viewResAdultsAmount.Size = new System.Drawing.Size(14, 15);
            this.viewResAdultsAmount.TabIndex = 17;
            this.viewResAdultsAmount.Text = "0";
            // 
            // viewResStaticStartLabel
            // 
            this.viewResStaticStartLabel.AutoSize = true;
            this.viewResStaticStartLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticStartLabel.Location = new System.Drawing.Point(272, 160);
            this.viewResStaticStartLabel.Name = "viewResStaticStartLabel";
            this.viewResStaticStartLabel.Size = new System.Drawing.Size(130, 15);
            this.viewResStaticStartLabel.TabIndex = 21;
            this.viewResStaticStartLabel.Text = "Reservation Start";
            // 
            // viewResStartLabel
            // 
            this.viewResStartLabel.AutoSize = true;
            this.viewResStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStartLabel.Location = new System.Drawing.Point(272, 174);
            this.viewResStartLabel.Name = "viewResStartLabel";
            this.viewResStartLabel.Size = new System.Drawing.Size(130, 15);
            this.viewResStartLabel.TabIndex = 20;
            this.viewResStartLabel.Text = "DateTime Placeholder";
            // 
            // viewResStaticEndLabel
            // 
            this.viewResStaticEndLabel.AutoSize = true;
            this.viewResStaticEndLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResStaticEndLabel.Location = new System.Drawing.Point(273, 231);
            this.viewResStaticEndLabel.Name = "viewResStaticEndLabel";
            this.viewResStaticEndLabel.Size = new System.Drawing.Size(124, 15);
            this.viewResStaticEndLabel.TabIndex = 23;
            this.viewResStaticEndLabel.Text = "Reservation End";
            // 
            // viewResEndLabel
            // 
            this.viewResEndLabel.AutoSize = true;
            this.viewResEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResEndLabel.Location = new System.Drawing.Point(273, 245);
            this.viewResEndLabel.Name = "viewResEndLabel";
            this.viewResEndLabel.Size = new System.Drawing.Size(130, 15);
            this.viewResEndLabel.TabIndex = 22;
            this.viewResEndLabel.Text = "DateTime Placeholder";
            // 
            // viewResForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.viewResStaticEndLabel);
            this.Controls.Add(this.viewResEndLabel);
            this.Controls.Add(this.viewResStaticStartLabel);
            this.Controls.Add(this.viewResStartLabel);
            this.Controls.Add(this.viewResTotalGuestsAmount);
            this.Controls.Add(this.viewResChildrenAmount);
            this.Controls.Add(this.viewResAdultsAmount);
            this.Controls.Add(this.viewResTotalLabel);
            this.Controls.Add(this.viewResChildrenLabel);
            this.Controls.Add(this.viewResStaticGuestsLabel);
            this.Controls.Add(this.viewResAdultsLabel);
            this.Controls.Add(this.viewResStaticRoomLabel);
            this.Controls.Add(this.viewResRoomLabel);
            this.Controls.Add(this.viewResStaticPhoneLabel);
            this.Controls.Add(this.viewResPhoneLabel);
            this.Controls.Add(this.viewResStaticEmailLabel);
            this.Controls.Add(this.viewResEmailLabel);
            this.Controls.Add(this.viewResStaticIdLabel);
            this.Controls.Add(this.viewResIdLabel);
            this.Controls.Add(this.viewResStaticNameLabel);
            this.Controls.Add(this.viewResEditBtn);
            this.Controls.Add(this.viewResDeleteBtn);
            this.Controls.Add(this.viewResNameLabel);
            this.Controls.Add(this.viewResCloseBtn);
            this.Name = "viewResForm";
            this.Text = "viewResForm";
            this.Load += new System.EventHandler(this.viewResForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewResCloseBtn;
        private System.Windows.Forms.Label viewResNameLabel;
        private System.Windows.Forms.Button viewResDeleteBtn;
        private System.Windows.Forms.Button viewResEditBtn;
        private System.Windows.Forms.Label viewResStaticNameLabel;
        private System.Windows.Forms.Label viewResStaticIdLabel;
        private System.Windows.Forms.Label viewResIdLabel;
        private System.Windows.Forms.Label viewResStaticEmailLabel;
        private System.Windows.Forms.Label viewResEmailLabel;
        private System.Windows.Forms.Label viewResStaticPhoneLabel;
        private System.Windows.Forms.Label viewResPhoneLabel;
        private System.Windows.Forms.Label viewResStaticRoomLabel;
        private System.Windows.Forms.Label viewResRoomLabel;
        private System.Windows.Forms.Label viewResStaticGuestsLabel;
        private System.Windows.Forms.Label viewResAdultsLabel;
        private System.Windows.Forms.Label viewResChildrenLabel;
        private System.Windows.Forms.Label viewResTotalLabel;
        private System.Windows.Forms.Label viewResTotalGuestsAmount;
        private System.Windows.Forms.Label viewResChildrenAmount;
        private System.Windows.Forms.Label viewResAdultsAmount;
        private System.Windows.Forms.Label viewResStaticStartLabel;
        private System.Windows.Forms.Label viewResStartLabel;
        private System.Windows.Forms.Label viewResStaticEndLabel;
        private System.Windows.Forms.Label viewResEndLabel;
    }
}