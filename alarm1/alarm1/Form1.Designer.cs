namespace alarm1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2ComboBox hourCombo;
        private Guna.UI2.WinForms.Guna2ComboBox minuteCombo;
        private Guna.UI2.WinForms.Guna2TextBox alarmNameBox;
        private Guna.UI2.WinForms.Guna2TextBox filePathBox;
        private Guna.UI2.WinForms.Guna2Button browseButton;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Label nowLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.hourCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.minuteCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.alarmNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.filePathBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.browseButton = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.nowLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // hourCombo
            // 
            this.hourCombo.BackColor = System.Drawing.Color.Transparent;
            this.hourCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hourCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourCombo.FocusedColor = System.Drawing.Color.Empty;
            this.hourCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hourCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.hourCombo.ItemHeight = 30;
            this.hourCombo.Location = new System.Drawing.Point(30, 30);
            this.hourCombo.Name = "hourCombo";
            this.hourCombo.Size = new System.Drawing.Size(82, 36);
            this.hourCombo.TabIndex = 0;
            // 
            // minuteCombo
            // 
            this.minuteCombo.BackColor = System.Drawing.Color.Transparent;
            this.minuteCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.minuteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteCombo.FocusedColor = System.Drawing.Color.Empty;
            this.minuteCombo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.minuteCombo.ItemHeight = 30;
            this.minuteCombo.Location = new System.Drawing.Point(128, 30);
            this.minuteCombo.Name = "minuteCombo";
            this.minuteCombo.Size = new System.Drawing.Size(82, 36);
            this.minuteCombo.TabIndex = 1;
            // 
            // alarmNameBox
            // 
            this.alarmNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alarmNameBox.DefaultText = "";
            this.alarmNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.alarmNameBox.Location = new System.Drawing.Point(30, 80);
            this.alarmNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alarmNameBox.Name = "alarmNameBox";
            this.alarmNameBox.PlaceholderText = "Alarm name";
            this.alarmNameBox.SelectedText = "";
            this.alarmNameBox.Size = new System.Drawing.Size(260, 36);
            this.alarmNameBox.TabIndex = 2;
            // 
            // filePathBox
            // 
            this.filePathBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filePathBox.DefaultText = "";
            this.filePathBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filePathBox.Location = new System.Drawing.Point(30, 130);
            this.filePathBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.PlaceholderText = "";
            this.filePathBox.SelectedText = "";
            this.filePathBox.Size = new System.Drawing.Size(200, 36);
            this.filePathBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(240, 130);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(50, 36);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "...";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(30, 190);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 17);
            this.progressBar.TabIndex = 5;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // nowLabel
            // 
            this.nowLabel.ForeColor = System.Drawing.Color.White;
            this.nowLabel.Location = new System.Drawing.Point(30, 230);
            this.nowLabel.Name = "nowLabel";
            this.nowLabel.Size = new System.Drawing.Size(260, 20);
            this.nowLabel.TabIndex = 7;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftLabel.Location = new System.Drawing.Point(30, 210);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(260, 20);
            this.timeLeftLabel.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.FillColor = System.Drawing.Color.IndianRed;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(30, 280);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FillColor = System.Drawing.Color.Gray;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(170, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.Controls.Add(this.hourCombo);
            this.Controls.Add(this.minuteCombo);
            this.Controls.Add(this.alarmNameBox);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.nowLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Clock";
            this.ResumeLayout(false);

        }
    }
}