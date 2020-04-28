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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resPanel = new System.Windows.Forms.Panel();
            this.hotPanel = new System.Windows.Forms.Panel();
            this.guePanel = new System.Windows.Forms.Panel();
            this.AllButton = new System.Windows.Forms.Button();
            this.FutureButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.GuestListGrid = new System.Windows.Forms.DataGridView();
            this.namecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkincolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resButton = new System.Windows.Forms.Button();
            this.hotButton = new System.Windows.Forms.Button();
            this.gueButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.resPanel.SuspendLayout();
            this.hotPanel.SuspendLayout();
            this.guePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestListGrid)).BeginInit();
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.guePanel.Controls.Add(this.button1);
            this.guePanel.Controls.Add(this.searchField);
            this.guePanel.Controls.Add(this.searchButton);
            this.guePanel.Controls.Add(this.AllButton);
            this.guePanel.Controls.Add(this.FutureButton);
            this.guePanel.Controls.Add(this.PreviousButton);
            this.guePanel.Controls.Add(this.CurrentButton);
            this.guePanel.Controls.Add(this.GuestListGrid);
            this.guePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guePanel.Location = new System.Drawing.Point(0, 0);
            this.guePanel.Name = "guePanel";
            this.guePanel.Size = new System.Drawing.Size(978, 580);
            this.guePanel.TabIndex = 2;
            // 
            // AllButton
            // 
            this.AllButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AllButton.Location = new System.Drawing.Point(18, 19);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(85, 34);
            this.AllButton.TabIndex = 4;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = false;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // FutureButton
            // 
            this.FutureButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FutureButton.Location = new System.Drawing.Point(299, 19);
            this.FutureButton.Name = "FutureButton";
            this.FutureButton.Size = new System.Drawing.Size(85, 34);
            this.FutureButton.TabIndex = 3;
            this.FutureButton.Text = "Future";
            this.FutureButton.UseVisualStyleBackColor = false;
            this.FutureButton.Click += new System.EventHandler(this.FutureButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.Gainsboro;
            this.PreviousButton.Location = new System.Drawing.Point(206, 19);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(85, 34);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // CurrentButton
            // 
            this.CurrentButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CurrentButton.Location = new System.Drawing.Point(112, 19);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(85, 34);
            this.CurrentButton.TabIndex = 1;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = false;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // GuestListGrid
            // 
            this.GuestListGrid.AllowUserToAddRows = false;
            this.GuestListGrid.AllowUserToResizeColumns = false;
            this.GuestListGrid.AllowUserToResizeRows = false;
            this.GuestListGrid.BackgroundColor = System.Drawing.Color.White;
            this.GuestListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namecolumn,
            this.roomcolumn,
            this.sizecolumn,
            this.checkincolumn,
            this.checkoutcolumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GuestListGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.GuestListGrid.GridColor = System.Drawing.Color.DarkGray;
            this.GuestListGrid.Location = new System.Drawing.Point(0, 73);
            this.GuestListGrid.Name = "GuestListGrid";
            this.GuestListGrid.RowHeadersVisible = false;
            this.GuestListGrid.RowTemplate.Height = 50;
            this.GuestListGrid.Size = new System.Drawing.Size(978, 504);
            this.GuestListGrid.TabIndex = 0;
            // 
            // namecolumn
            // 
            this.namecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namecolumn.HeaderText = "Name";
            this.namecolumn.Name = "namecolumn";
            this.namecolumn.ReadOnly = true;
            // 
            // roomcolumn
            // 
            this.roomcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomcolumn.FillWeight = 50F;
            this.roomcolumn.HeaderText = "Room";
            this.roomcolumn.Name = "roomcolumn";
            this.roomcolumn.ReadOnly = true;
            // 
            // sizecolumn
            // 
            this.sizecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizecolumn.FillWeight = 50F;
            this.sizecolumn.HeaderText = "Party Size";
            this.sizecolumn.Name = "sizecolumn";
            this.sizecolumn.ReadOnly = true;
            // 
            // checkincolumn
            // 
            this.checkincolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkincolumn.HeaderText = "Check In";
            this.checkincolumn.Name = "checkincolumn";
            this.checkincolumn.ReadOnly = true;
            // 
            // checkoutcolumn
            // 
            this.checkoutcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkoutcolumn.HeaderText = "Check Out";
            this.checkoutcolumn.Name = "checkoutcolumn";
            this.checkoutcolumn.ReadOnly = true;
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
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.searchButton.Location = new System.Drawing.Point(658, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 34);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(523, 27);
            this.searchField.Name = "searchField";
            this.searchField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchField.Size = new System.Drawing.Size(129, 20);
            this.searchField.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(878, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Print List";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GuestmanagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GuestmanagementForm";
            this.Text = "guestmanagement";
            this.Load += new System.EventHandler(this.GuestmanagementForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.resPanel.ResumeLayout(false);
            this.hotPanel.ResumeLayout(false);
            this.guePanel.ResumeLayout(false);
            this.guePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestListGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView GuestListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkincolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutcolumn;
        private System.Windows.Forms.Button AllButton;
        private System.Windows.Forms.Button FutureButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button CurrentButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button button1;
    }
}