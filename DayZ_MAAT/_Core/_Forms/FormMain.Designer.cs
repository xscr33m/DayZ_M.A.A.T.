using DayZ_MAAT.Properties;

namespace DayZ_MAAT._Core._Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Panel_Working = new System.Windows.Forms.Panel();
            this.Label_Working = new System.Windows.Forms.Label();
            this.Icon_Working = new FontAwesome.Sharp.IconPictureBox();
            this.Panel_Notifications = new System.Windows.Forms.Panel();
            this.Label_Notification = new System.Windows.Forms.Label();
            this.Icon_Notification = new FontAwesome.Sharp.IconPictureBox();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Button_Info = new FontAwesome.Sharp.IconButton();
            this.Button_Settings = new FontAwesome.Sharp.IconButton();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.Panel_Converter = new System.Windows.Forms.Panel();
            this.GroupBox_Converter = new System.Windows.Forms.GroupBox();
            this.Button_TraderConverter = new FontAwesome.Sharp.IconButton();
            this.Button_ConvertClassToType = new FontAwesome.Sharp.IconButton();
            this.Button_ConvertClassNameToTPPC = new FontAwesome.Sharp.IconButton();
            this.Button_ConvertTPVCToSpawnabletypes = new FontAwesome.Sharp.IconButton();
            this.Panel_ValidatorExtractor = new System.Windows.Forms.Panel();
            this.GroupBox_Extractor = new System.Windows.Forms.GroupBox();
            this.Button_ExtractFromTypes = new FontAwesome.Sharp.IconButton();
            this.Button_ExtractCpp = new FontAwesome.Sharp.IconButton();
            this.GroupBox_Validator = new System.Windows.Forms.GroupBox();
            this.Button_VerifyTPPriceCfg = new FontAwesome.Sharp.IconButton();
            this.Button_Validate = new FontAwesome.Sharp.IconButton();
            this.Panel_Info = new System.Windows.Forms.Panel();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Panel_Top.SuspendLayout();
            this.Panel_Working.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Working)).BeginInit();
            this.Panel_Notifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.Panel_Content.SuspendLayout();
            this.Panel_Converter.SuspendLayout();
            this.GroupBox_Converter.SuspendLayout();
            this.Panel_ValidatorExtractor.SuspendLayout();
            this.GroupBox_Extractor.SuspendLayout();
            this.GroupBox_Validator.SuspendLayout();
            this.Panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Top.Controls.Add(this.Panel_Working);
            this.Panel_Top.Controls.Add(this.Panel_Notifications);
            this.Panel_Top.Controls.Add(this.PictureBox_Logo);
            this.Panel_Top.Controls.Add(this.Button_Info);
            this.Panel_Top.Controls.Add(this.Button_Settings);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(774, 60);
            this.Panel_Top.TabIndex = 0;
            // 
            // Panel_Working
            // 
            this.Panel_Working.Controls.Add(this.Label_Working);
            this.Panel_Working.Controls.Add(this.Icon_Working);
            this.Panel_Working.Location = new System.Drawing.Point(280, 3);
            this.Panel_Working.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Working.Name = "Panel_Working";
            this.Panel_Working.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Working.Size = new System.Drawing.Size(316, 50);
            this.Panel_Working.TabIndex = 1;
            this.Panel_Working.Visible = false;
            // 
            // Label_Working
            // 
            this.Label_Working.AutoEllipsis = true;
            this.Label_Working.AutoSize = true;
            this.Label_Working.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Working.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Label_Working.Location = new System.Drawing.Point(48, 14);
            this.Label_Working.MaximumSize = new System.Drawing.Size(520, 0);
            this.Label_Working.Name = "Label_Working";
            this.Label_Working.Size = new System.Drawing.Size(105, 22);
            this.Label_Working.TabIndex = 3;
            this.Label_Working.Text = "Please Wait..";
            this.Label_Working.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Icon_Working
            // 
            this.Icon_Working.BackColor = System.Drawing.Color.Transparent;
            this.Icon_Working.IconChar = FontAwesome.Sharp.IconChar.Hourglass;
            this.Icon_Working.IconColor = System.Drawing.Color.White;
            this.Icon_Working.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_Working.IconSize = 40;
            this.Icon_Working.Location = new System.Drawing.Point(5, 5);
            this.Icon_Working.Margin = new System.Windows.Forms.Padding(0);
            this.Icon_Working.Name = "Icon_Working";
            this.Icon_Working.Size = new System.Drawing.Size(40, 40);
            this.Icon_Working.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icon_Working.TabIndex = 0;
            this.Icon_Working.TabStop = false;
            // 
            // Panel_Notifications
            // 
            this.Panel_Notifications.AutoSize = true;
            this.Panel_Notifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Panel_Notifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Notifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Notifications.Controls.Add(this.Label_Notification);
            this.Panel_Notifications.Controls.Add(this.Icon_Notification);
            this.Panel_Notifications.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Notifications.Location = new System.Drawing.Point(0, 0);
            this.Panel_Notifications.MaximumSize = new System.Drawing.Size(774, 60);
            this.Panel_Notifications.MinimumSize = new System.Drawing.Size(2, 60);
            this.Panel_Notifications.Name = "Panel_Notifications";
            this.Panel_Notifications.Size = new System.Drawing.Size(117, 60);
            this.Panel_Notifications.TabIndex = 2;
            this.Panel_Notifications.Visible = false;
            // 
            // Label_Notification
            // 
            this.Label_Notification.AutoEllipsis = true;
            this.Label_Notification.AutoSize = true;
            this.Label_Notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Notification.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Label_Notification.Location = new System.Drawing.Point(60, 0);
            this.Label_Notification.MaximumSize = new System.Drawing.Size(712, 60);
            this.Label_Notification.Name = "Label_Notification";
            this.Label_Notification.Size = new System.Drawing.Size(55, 22);
            this.Label_Notification.TabIndex = 2;
            this.Label_Notification.Text = "label7";
            this.Label_Notification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Notification.UseMnemonic = false;
            // 
            // Icon_Notification
            // 
            this.Icon_Notification.BackColor = System.Drawing.Color.Transparent;
            this.Icon_Notification.Dock = System.Windows.Forms.DockStyle.Left;
            this.Icon_Notification.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.Icon_Notification.IconColor = System.Drawing.Color.White;
            this.Icon_Notification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_Notification.IconSize = 60;
            this.Icon_Notification.Location = new System.Drawing.Point(0, 0);
            this.Icon_Notification.MaximumSize = new System.Drawing.Size(60, 60);
            this.Icon_Notification.MinimumSize = new System.Drawing.Size(60, 60);
            this.Icon_Notification.Name = "Icon_Notification";
            this.Icon_Notification.Size = new System.Drawing.Size(60, 60);
            this.Icon_Notification.TabIndex = 3;
            this.Icon_Notification.TabStop = false;
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Image = global::DayZ_MAAT.Properties.Resources.xscr33mLabs_Logo;
            this.PictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(214, 60);
            this.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Logo.TabIndex = 3;
            this.PictureBox_Logo.TabStop = false;
            this.PictureBox_Logo.DoubleClick += new System.EventHandler(this.PictureBox_Logo_DoubleClick);
            // 
            // Button_Info
            // 
            this.Button_Info.FlatAppearance.BorderSize = 0;
            this.Button_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Info.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.Button_Info.IconColor = System.Drawing.Color.White;
            this.Button_Info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Info.IconSize = 42;
            this.Button_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Info.Location = new System.Drawing.Point(665, 3);
            this.Button_Info.Name = "Button_Info";
            this.Button_Info.Size = new System.Drawing.Size(50, 50);
            this.Button_Info.TabIndex = 13;
            this.Button_Info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Info.UseMnemonic = false;
            this.Button_Info.UseVisualStyleBackColor = true;
            this.Button_Info.Click += new System.EventHandler(this.Button_Info_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Button_Settings.IconColor = System.Drawing.Color.White;
            this.Button_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Settings.IconSize = 42;
            this.Button_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Settings.Location = new System.Drawing.Point(721, 3);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(50, 50);
            this.Button_Settings.TabIndex = 11;
            this.Button_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Settings.UseMnemonic = false;
            this.Button_Settings.UseVisualStyleBackColor = true;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Panel_Content
            // 
            this.Panel_Content.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Content.Controls.Add(this.Panel_Converter);
            this.Panel_Content.Controls.Add(this.Panel_ValidatorExtractor);
            this.Panel_Content.Controls.Add(this.Panel_Top);
            this.Panel_Content.Controls.Add(this.Panel_Info);
            this.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Content.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Content.Location = new System.Drawing.Point(3, 3);
            this.Panel_Content.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(774, 454);
            this.Panel_Content.TabIndex = 1;
            // 
            // Panel_Converter
            // 
            this.Panel_Converter.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Converter.Controls.Add(this.GroupBox_Converter);
            this.Panel_Converter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Converter.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Converter.Location = new System.Drawing.Point(0, 210);
            this.Panel_Converter.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Converter.Name = "Panel_Converter";
            this.Panel_Converter.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Panel_Converter.Size = new System.Drawing.Size(774, 224);
            this.Panel_Converter.TabIndex = 14;
            // 
            // GroupBox_Converter
            // 
            this.GroupBox_Converter.Controls.Add(this.Button_TraderConverter);
            this.GroupBox_Converter.Controls.Add(this.Button_ConvertClassToType);
            this.GroupBox_Converter.Controls.Add(this.Button_ConvertClassNameToTPPC);
            this.GroupBox_Converter.Controls.Add(this.Button_ConvertTPVCToSpawnabletypes);
            this.GroupBox_Converter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Converter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Converter.ForeColor = System.Drawing.Color.White;
            this.GroupBox_Converter.Location = new System.Drawing.Point(0, 10);
            this.GroupBox_Converter.Name = "GroupBox_Converter";
            this.GroupBox_Converter.Padding = new System.Windows.Forms.Padding(15);
            this.GroupBox_Converter.Size = new System.Drawing.Size(774, 214);
            this.GroupBox_Converter.TabIndex = 0;
            this.GroupBox_Converter.TabStop = false;
            this.GroupBox_Converter.Text = "Converter";
            // 
            // Button_TraderConverter
            // 
            this.Button_TraderConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_TraderConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_TraderConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_TraderConverter.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.Button_TraderConverter.IconColor = System.Drawing.Color.White;
            this.Button_TraderConverter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_TraderConverter.IconSize = 32;
            this.Button_TraderConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_TraderConverter.Location = new System.Drawing.Point(406, 35);
            this.Button_TraderConverter.Name = "Button_TraderConverter";
            this.Button_TraderConverter.Size = new System.Drawing.Size(350, 40);
            this.Button_TraderConverter.TabIndex = 9;
            this.Button_TraderConverter.Text = "Dr.Jones Trader.txt → TraderPlusPriceConfig.json";
            this.Button_TraderConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_TraderConverter.UseMnemonic = false;
            this.Button_TraderConverter.UseVisualStyleBackColor = true;
            this.Button_TraderConverter.Click += new System.EventHandler(this.Button_TraderConverter_Click);
            // 
            // Button_ConvertClassToType
            // 
            this.Button_ConvertClassToType.Enabled = false;
            this.Button_ConvertClassToType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_ConvertClassToType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ConvertClassToType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ConvertClassToType.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.Button_ConvertClassToType.IconColor = System.Drawing.Color.White;
            this.Button_ConvertClassToType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ConvertClassToType.IconSize = 32;
            this.Button_ConvertClassToType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ConvertClassToType.Location = new System.Drawing.Point(18, 81);
            this.Button_ConvertClassToType.Name = "Button_ConvertClassToType";
            this.Button_ConvertClassToType.Size = new System.Drawing.Size(350, 40);
            this.Button_ConvertClassToType.TabIndex = 4;
            this.Button_ConvertClassToType.Text = "ClassNames.txt → types.xml";
            this.Button_ConvertClassToType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_ConvertClassToType.UseMnemonic = false;
            this.Button_ConvertClassToType.UseVisualStyleBackColor = true;
            // 
            // Button_ConvertClassNameToTPPC
            // 
            this.Button_ConvertClassNameToTPPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_ConvertClassNameToTPPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ConvertClassNameToTPPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ConvertClassNameToTPPC.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.Button_ConvertClassNameToTPPC.IconColor = System.Drawing.Color.White;
            this.Button_ConvertClassNameToTPPC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ConvertClassNameToTPPC.IconSize = 32;
            this.Button_ConvertClassNameToTPPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ConvertClassNameToTPPC.Location = new System.Drawing.Point(18, 35);
            this.Button_ConvertClassNameToTPPC.Name = "Button_ConvertClassNameToTPPC";
            this.Button_ConvertClassNameToTPPC.Size = new System.Drawing.Size(350, 40);
            this.Button_ConvertClassNameToTPPC.TabIndex = 6;
            this.Button_ConvertClassNameToTPPC.Text = "ClassNames.txt → TraderPlusPriceConfig.json";
            this.Button_ConvertClassNameToTPPC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_ConvertClassNameToTPPC.UseMnemonic = false;
            this.Button_ConvertClassNameToTPPC.UseVisualStyleBackColor = true;
            this.Button_ConvertClassNameToTPPC.Click += new System.EventHandler(this.Button_ConvertClassNameToTPPC_Click);
            // 
            // Button_ConvertTPVCToSpawnabletypes
            // 
            this.Button_ConvertTPVCToSpawnabletypes.Enabled = false;
            this.Button_ConvertTPVCToSpawnabletypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_ConvertTPVCToSpawnabletypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ConvertTPVCToSpawnabletypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ConvertTPVCToSpawnabletypes.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.Button_ConvertTPVCToSpawnabletypes.IconColor = System.Drawing.Color.White;
            this.Button_ConvertTPVCToSpawnabletypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ConvertTPVCToSpawnabletypes.IconSize = 32;
            this.Button_ConvertTPVCToSpawnabletypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ConvertTPVCToSpawnabletypes.Location = new System.Drawing.Point(406, 81);
            this.Button_ConvertTPVCToSpawnabletypes.Name = "Button_ConvertTPVCToSpawnabletypes";
            this.Button_ConvertTPVCToSpawnabletypes.Size = new System.Drawing.Size(350, 40);
            this.Button_ConvertTPVCToSpawnabletypes.TabIndex = 8;
            this.Button_ConvertTPVCToSpawnabletypes.Text = "TraderPlusVehicleConfig.json → spawnabletypes.xml";
            this.Button_ConvertTPVCToSpawnabletypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_ConvertTPVCToSpawnabletypes.UseMnemonic = false;
            this.Button_ConvertTPVCToSpawnabletypes.UseVisualStyleBackColor = true;
            // 
            // Panel_ValidatorExtractor
            // 
            this.Panel_ValidatorExtractor.BackColor = System.Drawing.Color.Transparent;
            this.Panel_ValidatorExtractor.Controls.Add(this.GroupBox_Extractor);
            this.Panel_ValidatorExtractor.Controls.Add(this.GroupBox_Validator);
            this.Panel_ValidatorExtractor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_ValidatorExtractor.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_ValidatorExtractor.Location = new System.Drawing.Point(0, 60);
            this.Panel_ValidatorExtractor.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ValidatorExtractor.Name = "Panel_ValidatorExtractor";
            this.Panel_ValidatorExtractor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Panel_ValidatorExtractor.Size = new System.Drawing.Size(774, 150);
            this.Panel_ValidatorExtractor.TabIndex = 16;
            // 
            // GroupBox_Extractor
            // 
            this.GroupBox_Extractor.Controls.Add(this.Button_ExtractFromTypes);
            this.GroupBox_Extractor.Controls.Add(this.Button_ExtractCpp);
            this.GroupBox_Extractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Extractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Extractor.ForeColor = System.Drawing.Color.White;
            this.GroupBox_Extractor.Location = new System.Drawing.Point(389, 10);
            this.GroupBox_Extractor.Name = "GroupBox_Extractor";
            this.GroupBox_Extractor.Padding = new System.Windows.Forms.Padding(15);
            this.GroupBox_Extractor.Size = new System.Drawing.Size(385, 140);
            this.GroupBox_Extractor.TabIndex = 0;
            this.GroupBox_Extractor.TabStop = false;
            this.GroupBox_Extractor.Text = "Extractor";
            // 
            // Button_ExtractFromTypes
            // 
            this.Button_ExtractFromTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_ExtractFromTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ExtractFromTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExtractFromTypes.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.Button_ExtractFromTypes.IconColor = System.Drawing.Color.White;
            this.Button_ExtractFromTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ExtractFromTypes.IconSize = 32;
            this.Button_ExtractFromTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ExtractFromTypes.Location = new System.Drawing.Point(17, 35);
            this.Button_ExtractFromTypes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Button_ExtractFromTypes.Name = "Button_ExtractFromTypes";
            this.Button_ExtractFromTypes.Size = new System.Drawing.Size(350, 40);
            this.Button_ExtractFromTypes.TabIndex = 3;
            this.Button_ExtractFromTypes.Text = "Extract ClassNames.txt from types.xml";
            this.Button_ExtractFromTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_ExtractFromTypes.UseMnemonic = false;
            this.Button_ExtractFromTypes.UseVisualStyleBackColor = true;
            this.Button_ExtractFromTypes.Click += new System.EventHandler(this.Button_ExtractFromTypes_Click);
            // 
            // Button_ExtractCpp
            // 
            this.Button_ExtractCpp.Enabled = false;
            this.Button_ExtractCpp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_ExtractCpp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ExtractCpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExtractCpp.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.Button_ExtractCpp.IconColor = System.Drawing.Color.White;
            this.Button_ExtractCpp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ExtractCpp.IconSize = 32;
            this.Button_ExtractCpp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ExtractCpp.Location = new System.Drawing.Point(17, 81);
            this.Button_ExtractCpp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Button_ExtractCpp.Name = "Button_ExtractCpp";
            this.Button_ExtractCpp.Size = new System.Drawing.Size(350, 40);
            this.Button_ExtractCpp.TabIndex = 2;
            this.Button_ExtractCpp.Text = "Extract ClassNames.txt from config.cpp";
            this.Button_ExtractCpp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_ExtractCpp.UseMnemonic = false;
            this.Button_ExtractCpp.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Validator
            // 
            this.GroupBox_Validator.Controls.Add(this.Button_VerifyTPPriceCfg);
            this.GroupBox_Validator.Controls.Add(this.Button_Validate);
            this.GroupBox_Validator.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox_Validator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Validator.ForeColor = System.Drawing.Color.White;
            this.GroupBox_Validator.Location = new System.Drawing.Point(0, 10);
            this.GroupBox_Validator.Name = "GroupBox_Validator";
            this.GroupBox_Validator.Padding = new System.Windows.Forms.Padding(15);
            this.GroupBox_Validator.Size = new System.Drawing.Size(389, 140);
            this.GroupBox_Validator.TabIndex = 0;
            this.GroupBox_Validator.TabStop = false;
            this.GroupBox_Validator.Text = "Validator";
            // 
            // Button_VerifyTPPriceCfg
            // 
            this.Button_VerifyTPPriceCfg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_VerifyTPPriceCfg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_VerifyTPPriceCfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_VerifyTPPriceCfg.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.Button_VerifyTPPriceCfg.IconColor = System.Drawing.Color.White;
            this.Button_VerifyTPPriceCfg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_VerifyTPPriceCfg.IconSize = 32;
            this.Button_VerifyTPPriceCfg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_VerifyTPPriceCfg.Location = new System.Drawing.Point(18, 81);
            this.Button_VerifyTPPriceCfg.Name = "Button_VerifyTPPriceCfg";
            this.Button_VerifyTPPriceCfg.Size = new System.Drawing.Size(350, 40);
            this.Button_VerifyTPPriceCfg.TabIndex = 12;
            this.Button_VerifyTPPriceCfg.Text = "Validate TraderPlusPriceConfig.json";
            this.Button_VerifyTPPriceCfg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_VerifyTPPriceCfg.UseMnemonic = false;
            this.Button_VerifyTPPriceCfg.UseVisualStyleBackColor = true;
            this.Button_VerifyTPPriceCfg.Click += new System.EventHandler(this.Button_VerifyTPPriceCfg_Click);
            // 
            // Button_Validate
            // 
            this.Button_Validate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_Validate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Validate.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.Button_Validate.IconColor = System.Drawing.Color.White;
            this.Button_Validate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Validate.IconSize = 32;
            this.Button_Validate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Validate.Location = new System.Drawing.Point(18, 35);
            this.Button_Validate.Name = "Button_Validate";
            this.Button_Validate.Size = new System.Drawing.Size(350, 40);
            this.Button_Validate.TabIndex = 10;
            this.Button_Validate.Text = "Validate & Beautify XML or JSON";
            this.Button_Validate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Validate.UseMnemonic = false;
            this.Button_Validate.UseVisualStyleBackColor = true;
            this.Button_Validate.Click += new System.EventHandler(this.Button_Validate_Click);
            // 
            // Panel_Info
            // 
            this.Panel_Info.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Info.Controls.Add(this.Label_Version);
            this.Panel_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Info.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Info.Location = new System.Drawing.Point(0, 434);
            this.Panel_Info.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Info.Name = "Panel_Info";
            this.Panel_Info.Size = new System.Drawing.Size(774, 20);
            this.Panel_Info.TabIndex = 17;
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_Version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Version.Location = new System.Drawing.Point(689, 0);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_Version.Size = new System.Drawing.Size(85, 17);
            this.Label_Version.TabIndex = 0;
            this.Label_Version.Text = "Label_Version";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.Panel_Content);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayZ M.A.A.T.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            this.Panel_Working.ResumeLayout(false);
            this.Panel_Working.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Working)).EndInit();
            this.Panel_Notifications.ResumeLayout(false);
            this.Panel_Notifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.Panel_Content.ResumeLayout(false);
            this.Panel_Converter.ResumeLayout(false);
            this.GroupBox_Converter.ResumeLayout(false);
            this.Panel_ValidatorExtractor.ResumeLayout(false);
            this.GroupBox_Extractor.ResumeLayout(false);
            this.GroupBox_Validator.ResumeLayout(false);
            this.Panel_Info.ResumeLayout(false);
            this.Panel_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Content;
        private FontAwesome.Sharp.IconButton Button_ExtractCpp;
        private FontAwesome.Sharp.IconButton Button_ConvertTPVCToSpawnabletypes;
        private FontAwesome.Sharp.IconButton Button_ConvertClassNameToTPPC;
        private FontAwesome.Sharp.IconButton Button_ConvertClassToType;
        private FontAwesome.Sharp.IconButton Button_Validate;
        private System.Windows.Forms.GroupBox GroupBox_Extractor;
        private System.Windows.Forms.Panel Panel_ValidatorExtractor;
        private System.Windows.Forms.GroupBox GroupBox_Validator;
        private System.Windows.Forms.Panel Panel_Converter;
        private System.Windows.Forms.GroupBox GroupBox_Converter;
        private System.Windows.Forms.Panel Panel_Notifications;
        private System.Windows.Forms.Label Label_Notification;
        private FontAwesome.Sharp.IconPictureBox Icon_Notification;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private FontAwesome.Sharp.IconButton Button_VerifyTPPriceCfg;
        private FontAwesome.Sharp.IconButton Button_TraderConverter;
        private FontAwesome.Sharp.IconButton Button_ExtractFromTypes;
        private FontAwesome.Sharp.IconButton Button_Settings;
        private System.Windows.Forms.Panel Panel_Working;
        private FontAwesome.Sharp.IconPictureBox Icon_Working;
        private System.Windows.Forms.Label Label_Working;
        private System.Windows.Forms.Panel Panel_Info;
        private System.Windows.Forms.Label Label_Version;
        private FontAwesome.Sharp.IconButton Button_Info;
    }
}