namespace P4FormsTest2
{
    partial class HoteloverviewForm
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
            this.newRoomBtn = new System.Windows.Forms.Button();
            this.gueButton = new System.Windows.Forms.Button();
            this.hotButton = new System.Windows.Forms.Button();
            this.resButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.floorTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.resPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newRoomBtn
            // 
            this.newRoomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newRoomBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.newRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.newRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newRoomBtn.Location = new System.Drawing.Point(3, 41);
            this.newRoomBtn.Name = "newRoomBtn";
            this.newRoomBtn.Size = new System.Drawing.Size(87, 31);
            this.newRoomBtn.TabIndex = 7;
            this.newRoomBtn.Text = "Add Room";
            this.newRoomBtn.UseVisualStyleBackColor = false;
            this.newRoomBtn.Click += new System.EventHandler(this.newRoomBtn_Click);
            // 
            // gueButton
            // 
            this.gueButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.gueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gueButton.ForeColor = System.Drawing.Color.White;
            this.gueButton.Location = new System.Drawing.Point(591, 3);
            this.gueButton.Name = "gueButton";
            this.gueButton.Size = new System.Drawing.Size(190, 69);
            this.gueButton.TabIndex = 4;
            this.gueButton.Text = "Guest Management";
            this.gueButton.UseVisualStyleBackColor = false;
            this.gueButton.Click += new System.EventHandler(this.gueButton_Click);
            // 
            // hotButton
            // 
            this.hotButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.hotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotButton.ForeColor = System.Drawing.Color.White;
            this.hotButton.Location = new System.Drawing.Point(395, 3);
            this.hotButton.Name = "hotButton";
            this.hotButton.Size = new System.Drawing.Size(190, 69);
            this.hotButton.TabIndex = 3;
            this.hotButton.Text = "Hotel Overview";
            this.hotButton.UseVisualStyleBackColor = false;
            this.hotButton.Click += new System.EventHandler(this.hotButton_Click);
            // 
            // resButton
            // 
            this.resButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.resButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resButton.ForeColor = System.Drawing.Color.White;
            this.resButton.Location = new System.Drawing.Point(199, 3);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(190, 69);
            this.resButton.TabIndex = 2;
            this.resButton.Text = "Reservations";
            this.resButton.UseVisualStyleBackColor = false;
            this.resButton.Click += new System.EventHandler(this.resButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.resPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.resButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hotButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gueButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.newRoomBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // resPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.resPanel, 5);
            this.resPanel.Controls.Add(this.floorTablePanel);
            this.resPanel.Controls.Add(this.tableLayoutPanel2);
            this.resPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resPanel.Location = new System.Drawing.Point(3, 78);
            this.resPanel.Name = "resPanel";
            this.resPanel.Size = new System.Drawing.Size(978, 580);
            this.resPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.79755F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.202454F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(872, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(106, 580);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // floorTablePanel
            // 
            this.floorTablePanel.AutoScroll = true;
            this.floorTablePanel.ColumnCount = 1;
            this.floorTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.floorTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.floorTablePanel.Location = new System.Drawing.Point(0, 3);
            this.floorTablePanel.Name = "floorTablePanel";
            this.floorTablePanel.RowCount = 2;
            this.floorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.floorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.floorTablePanel.Size = new System.Drawing.Size(873, 577);
            this.floorTablePanel.TabIndex = 1;
            // 
            // HoteloverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HoteloverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "hoteloverview";
            this.Load += new System.EventHandler(this.HoteloverviewForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.resPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newRoomBtn;
        private System.Windows.Forms.Button gueButton;
        private System.Windows.Forms.Button hotButton;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel resPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel floorTablePanel;
    }
}