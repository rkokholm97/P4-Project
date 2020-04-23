namespace P4FormsTest2
{
    partial class GuestmanagementForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resPanel = new System.Windows.Forms.Panel();
            this.hotPanel = new System.Windows.Forms.Panel();
            this.guePanel = new System.Windows.Forms.Panel();
            this.resButton = new System.Windows.Forms.Button();
            this.hotButton = new System.Windows.Forms.Button();
            this.gueButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.resPanel.SuspendLayout();
            this.hotPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.testLabel, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.guePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guePanel.Location = new System.Drawing.Point(0, 0);
            this.guePanel.Name = "guePanel";
            this.guePanel.Size = new System.Drawing.Size(978, 580);
            this.guePanel.TabIndex = 2;
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
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(787, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 13);
            this.testLabel.TabIndex = 5;
            // 
            // GuestmanagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GuestmanagementForm";
            this.Text = "guestmanagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.resPanel.ResumeLayout(false);
            this.hotPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel resPanel;
        private System.Windows.Forms.Panel hotPanel;
        private System.Windows.Forms.Panel guePanel;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Button hotButton;
        private System.Windows.Forms.Button gueButton;
        private System.Windows.Forms.Label testLabel;
    }
}