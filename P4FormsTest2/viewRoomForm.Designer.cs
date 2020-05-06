namespace P4FormsTest2
{
    partial class viewRoomForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.deleteRoom_btn = new System.Windows.Forms.Button();
            this.roomTitleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editRoomButton = new System.Windows.Forms.Button();
            this.maxOccupantsLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.floorNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(12, 342);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(81, 30);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // deleteRoom_btn
            // 
            this.deleteRoom_btn.BackColor = System.Drawing.Color.Brown;
            this.deleteRoom_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.deleteRoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoom_btn.ForeColor = System.Drawing.Color.White;
            this.deleteRoom_btn.Location = new System.Drawing.Point(255, 342);
            this.deleteRoom_btn.Name = "deleteRoom_btn";
            this.deleteRoom_btn.Size = new System.Drawing.Size(104, 30);
            this.deleteRoom_btn.TabIndex = 1;
            this.deleteRoom_btn.Text = "Delete Room";
            this.deleteRoom_btn.UseVisualStyleBackColor = false;
            this.deleteRoom_btn.Click += new System.EventHandler(this.deleteRoom_btn_Click);
            // 
            // roomTitleLabel
            // 
            this.roomTitleLabel.AutoSize = true;
            this.roomTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTitleLabel.Location = new System.Drawing.Point(144, 21);
            this.roomTitleLabel.Name = "roomTitleLabel";
            this.roomTitleLabel.Size = new System.Drawing.Size(51, 20);
            this.roomTitleLabel.TabIndex = 2;
            this.roomTitleLabel.Text = "label1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(14, 274);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max Occupants";
            // 
            // editRoomButton
            // 
            this.editRoomButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.editRoomButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.editRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoomButton.ForeColor = System.Drawing.Color.White;
            this.editRoomButton.Location = new System.Drawing.Point(148, 342);
            this.editRoomButton.Name = "editRoomButton";
            this.editRoomButton.Size = new System.Drawing.Size(101, 30);
            this.editRoomButton.TabIndex = 8;
            this.editRoomButton.Text = "Edit Room";
            this.editRoomButton.UseVisualStyleBackColor = false;
            this.editRoomButton.Click += new System.EventHandler(this.editRoomButton_Click);
            // 
            // maxOccupantsLabel
            // 
            this.maxOccupantsLabel.AutoSize = true;
            this.maxOccupantsLabel.Location = new System.Drawing.Point(14, 205);
            this.maxOccupantsLabel.Name = "maxOccupantsLabel";
            this.maxOccupantsLabel.Size = new System.Drawing.Size(35, 13);
            this.maxOccupantsLabel.TabIndex = 9;
            this.maxOccupantsLabel.Text = "label1";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(14, 142);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.roomTypeLabel.TabIndex = 10;
            this.roomTypeLabel.Text = "label1";
            // 
            // floorNumberLabel
            // 
            this.floorNumberLabel.AutoSize = true;
            this.floorNumberLabel.Location = new System.Drawing.Point(14, 77);
            this.floorNumberLabel.Name = "floorNumberLabel";
            this.floorNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.floorNumberLabel.TabIndex = 11;
            this.floorNumberLabel.Text = "label1";
            // 
            // viewRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 384);
            this.Controls.Add(this.floorNumberLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.maxOccupantsLabel);
            this.Controls.Add(this.editRoomButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.roomTitleLabel);
            this.Controls.Add(this.deleteRoom_btn);
            this.Controls.Add(this.cancel_btn);
            this.Name = "viewRoomForm";
            this.Text = "viewRoomForm";
            this.Load += new System.EventHandler(this.viewRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button deleteRoom_btn;
        private System.Windows.Forms.Label roomTitleLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editRoomButton;
        private System.Windows.Forms.Label maxOccupantsLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label floorNumberLabel;
    }
}