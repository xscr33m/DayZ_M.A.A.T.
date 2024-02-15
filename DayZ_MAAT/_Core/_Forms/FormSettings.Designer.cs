namespace DayZ_MAAT._Core._Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.GroupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.ComboBox_Language = new System.Windows.Forms.ComboBox();
            this.PanelLanguage = new System.Windows.Forms.Panel();
            this.Button_Apply = new FontAwesome.Sharp.IconButton();
            this.Button_Deny = new FontAwesome.Sharp.IconButton();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.PanelEULA = new System.Windows.Forms.Panel();
            this.GroupBoxEULA = new System.Windows.Forms.GroupBox();
            this.Button_EULA = new FontAwesome.Sharp.IconButton();
            this.Panel_Update = new System.Windows.Forms.Panel();
            this.GroupBox_Update = new System.Windows.Forms.GroupBox();
            this.Button_Update = new FontAwesome.Sharp.IconButton();
            this.GroupBoxLanguage.SuspendLayout();
            this.PanelLanguage.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.PanelEULA.SuspendLayout();
            this.GroupBoxEULA.SuspendLayout();
            this.Panel_Update.SuspendLayout();
            this.GroupBox_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxLanguage
            // 
            this.GroupBoxLanguage.Controls.Add(this.ComboBox_Language);
            this.GroupBoxLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxLanguage.ForeColor = System.Drawing.Color.White;
            this.GroupBoxLanguage.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxLanguage.Name = "GroupBoxLanguage";
            this.GroupBoxLanguage.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.GroupBoxLanguage.Size = new System.Drawing.Size(374, 75);
            this.GroupBoxLanguage.TabIndex = 0;
            this.GroupBoxLanguage.TabStop = false;
            this.GroupBoxLanguage.Text = "Language";
            // 
            // ComboBox_Language
            // 
            this.ComboBox_Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ComboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Language.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Language.Location = new System.Drawing.Point(9, 35);
            this.ComboBox_Language.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Language.Name = "ComboBox_Language";
            this.ComboBox_Language.Size = new System.Drawing.Size(356, 25);
            this.ComboBox_Language.TabIndex = 0;
            this.ComboBox_Language.TabStop = false;
            this.ComboBox_Language.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Language_SelectionChangeCommitted);
            // 
            // PanelLanguage
            // 
            this.PanelLanguage.BackColor = System.Drawing.Color.Transparent;
            this.PanelLanguage.Controls.Add(this.GroupBoxLanguage);
            this.PanelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLanguage.Location = new System.Drawing.Point(5, 5);
            this.PanelLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLanguage.Name = "PanelLanguage";
            this.PanelLanguage.Size = new System.Drawing.Size(374, 75);
            this.PanelLanguage.TabIndex = 2;
            // 
            // Button_Apply
            // 
            this.Button_Apply.BackColor = System.Drawing.Color.Transparent;
            this.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Apply.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Apply.Enabled = false;
            this.Button_Apply.FlatAppearance.BorderSize = 0;
            this.Button_Apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Apply.ForeColor = System.Drawing.Color.White;
            this.Button_Apply.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Button_Apply.IconColor = System.Drawing.Color.Green;
            this.Button_Apply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Apply.IconSize = 50;
            this.Button_Apply.Location = new System.Drawing.Point(0, 0);
            this.Button_Apply.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(187, 50);
            this.Button_Apply.TabIndex = 18;
            this.Button_Apply.TabStop = false;
            this.Button_Apply.UseVisualStyleBackColor = false;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Button_Deny
            // 
            this.Button_Deny.BackColor = System.Drawing.Color.Transparent;
            this.Button_Deny.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Button_Deny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Deny.FlatAppearance.BorderSize = 0;
            this.Button_Deny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Deny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Deny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Deny.ForeColor = System.Drawing.Color.White;
            this.Button_Deny.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Button_Deny.IconColor = System.Drawing.Color.Red;
            this.Button_Deny.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Deny.IconSize = 50;
            this.Button_Deny.Location = new System.Drawing.Point(187, 0);
            this.Button_Deny.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Deny.Name = "Button_Deny";
            this.Button_Deny.Size = new System.Drawing.Size(187, 50);
            this.Button_Deny.TabIndex = 20;
            this.Button_Deny.TabStop = false;
            this.Button_Deny.UseVisualStyleBackColor = false;
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtons.Controls.Add(this.Button_Deny);
            this.PanelButtons.Controls.Add(this.Button_Apply);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(5, 311);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(374, 50);
            this.PanelButtons.TabIndex = 21;
            // 
            // PanelEULA
            // 
            this.PanelEULA.BackColor = System.Drawing.Color.Transparent;
            this.PanelEULA.Controls.Add(this.GroupBoxEULA);
            this.PanelEULA.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEULA.Location = new System.Drawing.Point(5, 80);
            this.PanelEULA.Margin = new System.Windows.Forms.Padding(0);
            this.PanelEULA.Name = "PanelEULA";
            this.PanelEULA.Size = new System.Drawing.Size(374, 75);
            this.PanelEULA.TabIndex = 22;
            // 
            // GroupBoxEULA
            // 
            this.GroupBoxEULA.Controls.Add(this.Button_EULA);
            this.GroupBoxEULA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxEULA.ForeColor = System.Drawing.Color.White;
            this.GroupBoxEULA.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxEULA.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxEULA.Name = "GroupBoxEULA";
            this.GroupBoxEULA.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.GroupBoxEULA.Size = new System.Drawing.Size(374, 75);
            this.GroupBoxEULA.TabIndex = 0;
            this.GroupBoxEULA.TabStop = false;
            this.GroupBoxEULA.Text = "Review EULA";
            // 
            // Button_EULA
            // 
            this.Button_EULA.BackColor = System.Drawing.Color.Transparent;
            this.Button_EULA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_EULA.FlatAppearance.BorderSize = 0;
            this.Button_EULA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_EULA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_EULA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EULA.ForeColor = System.Drawing.Color.White;
            this.Button_EULA.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.Button_EULA.IconColor = System.Drawing.Color.White;
            this.Button_EULA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_EULA.IconSize = 40;
            this.Button_EULA.Location = new System.Drawing.Point(10, 22);
            this.Button_EULA.Margin = new System.Windows.Forms.Padding(0);
            this.Button_EULA.Name = "Button_EULA";
            this.Button_EULA.Size = new System.Drawing.Size(354, 43);
            this.Button_EULA.TabIndex = 19;
            this.Button_EULA.TabStop = false;
            this.Button_EULA.UseVisualStyleBackColor = false;
            this.Button_EULA.Click += new System.EventHandler(this.Button_EULA_Click);
            // 
            // Panel_Update
            // 
            this.Panel_Update.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Update.Controls.Add(this.GroupBox_Update);
            this.Panel_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Update.Location = new System.Drawing.Point(5, 155);
            this.Panel_Update.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Update.Name = "Panel_Update";
            this.Panel_Update.Size = new System.Drawing.Size(374, 75);
            this.Panel_Update.TabIndex = 23;
            // 
            // GroupBox_Update
            // 
            this.GroupBox_Update.Controls.Add(this.Button_Update);
            this.GroupBox_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Update.ForeColor = System.Drawing.Color.White;
            this.GroupBox_Update.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Update.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox_Update.Name = "GroupBox_Update";
            this.GroupBox_Update.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.GroupBox_Update.Size = new System.Drawing.Size(374, 75);
            this.GroupBox_Update.TabIndex = 0;
            this.GroupBox_Update.TabStop = false;
            this.GroupBox_Update.Text = "Check for Update";
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.Transparent;
            this.Button_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Update.FlatAppearance.BorderSize = 0;
            this.Button_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.ForeColor = System.Drawing.Color.White;
            this.Button_Update.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.Button_Update.IconColor = System.Drawing.Color.White;
            this.Button_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Update.IconSize = 40;
            this.Button_Update.Location = new System.Drawing.Point(10, 22);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(354, 43);
            this.Button_Update.TabIndex = 19;
            this.Button_Update.TabStop = false;
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::DayZ_MAAT.Properties.Resources.xscr33mLabs_Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Update);
            this.Controls.Add(this.PanelEULA);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PanelLanguage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormSettings";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.GroupBoxLanguage.ResumeLayout(false);
            this.PanelLanguage.ResumeLayout(false);
            this.PanelButtons.ResumeLayout(false);
            this.PanelEULA.ResumeLayout(false);
            this.GroupBoxEULA.ResumeLayout(false);
            this.Panel_Update.ResumeLayout(false);
            this.GroupBox_Update.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxLanguage;
        private System.Windows.Forms.ComboBox ComboBox_Language;
        private System.Windows.Forms.Panel PanelLanguage;
        public FontAwesome.Sharp.IconButton Button_Apply;
        public FontAwesome.Sharp.IconButton Button_Deny;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelEULA;
        private System.Windows.Forms.GroupBox GroupBoxEULA;
        public FontAwesome.Sharp.IconButton Button_EULA;
        private System.Windows.Forms.Panel Panel_Update;
        private System.Windows.Forms.GroupBox GroupBox_Update;
        public FontAwesome.Sharp.IconButton Button_Update;
    }
}