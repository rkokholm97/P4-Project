﻿namespace P4FormsTest2
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
            this.label1 = new System.Windows.Forms.Label();
            this.gueButton = new System.Windows.Forms.Button();
            this.hotButton = new System.Windows.Forms.Button();
            this.resButton = new System.Windows.Forms.Button();
            this.resPanel = new System.Windows.Forms.Panel();
            this.hotPanel = new System.Windows.Forms.Panel();
            this.guePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.floorButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resPanel.SuspendLayout();
            this.hotPanel.SuspendLayout();
            this.guePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.floorButtonPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
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
            // resPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.resPanel, 5);
            this.resPanel.Controls.Add(this.hotPanel);
            this.resPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resPanel.Location = new System.Drawing.Point(3, 78);
            this.resPanel.Name = "resPanel";
            this.resPanel.Size = new System.Drawing.Size(978, 580);
            this.resPanel.TabIndex = 0;
            // 
            // hotPanel
            // 
            this.hotPanel.Controls.Add(this.guePanel);
            this.hotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotPanel.Location = new System.Drawing.Point(0, 0);
            this.hotPanel.Name = "hotPanel";
            this.hotPanel.Size = new System.Drawing.Size(978, 580);
            this.hotPanel.TabIndex = 1;
            // 
            // guePanel
            // 
            this.guePanel.Controls.Add(this.tableLayoutPanel2);
            this.guePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guePanel.Location = new System.Drawing.Point(0, 0);
            this.guePanel.Name = "guePanel";
            this.guePanel.Size = new System.Drawing.Size(978, 580);
            this.guePanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.floorButtonPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 580);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // floorButtonPanel
            // 
            this.floorButtonPanel.Controls.Add(this.button1);
            this.floorButtonPanel.Controls.Add(this.button2);
            this.floorButtonPanel.Controls.Add(this.button3);
            this.floorButtonPanel.Controls.Add(this.button4);
            this.floorButtonPanel.Controls.Add(this.button5);
            this.floorButtonPanel.Controls.Add(this.button6);
            this.floorButtonPanel.Controls.Add(this.button7);
            this.floorButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floorButtonPanel.Location = new System.Drawing.Point(891, 3);
            this.floorButtonPanel.Name = "floorButtonPanel";
            this.floorButtonPanel.Size = new System.Drawing.Size(84, 574);
            this.floorButtonPanel.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 519);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 80);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 80);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 80);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 80);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "1st Floor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "2nd Floor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
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
            this.resPanel.ResumeLayout(false);
            this.hotPanel.ResumeLayout(false);
            this.guePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.floorButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newRoomBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gueButton;
        private System.Windows.Forms.Button hotButton;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Panel resPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel hotPanel;
        private System.Windows.Forms.Panel guePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel floorButtonPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}