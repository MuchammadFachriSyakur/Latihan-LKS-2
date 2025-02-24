namespace Latihan_LKS_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            logo = new PictureBox();
            label1 = new Label();
            buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            inputPassword = new Guna.UI2.WinForms.Guna2TextBox();
            inputUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoRoundedCorners = true;
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderRadius = 267;
            guna2Panel1.Controls.Add(logo);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(buttonLogin);
            guna2Panel1.Controls.Add(inputPassword);
            guna2Panel1.Controls.Add(inputUsername);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(275, 65);
            guna2Panel1.Margin = new Padding(2, 3, 2, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(536, 637);
            guna2Panel1.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Cursor = Cursors.Hand;
            logo.Location = new Point(165, 44);
            logo.Name = "logo";
            logo.Size = new Size(190, 190);
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(156, 510);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 4;
            label1.Text = "Masuk kehalaman customer";
            label1.Click += label1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BorderRadius = 28;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.CustomizableEdges = customizableEdges1;
            buttonLogin.DisabledState.BorderColor = Color.DarkGray;
            buttonLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonLogin.FillColor = Color.FromArgb(100, 88, 255);
            buttonLogin.Font = new Font("Segoe UI", 9F);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(68, 438);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.PressedColor = SystemColors.MenuHighlight;
            buttonLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buttonLogin.Size = new Size(411, 55);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.Click += buttonLogin_Click;
            // 
            // inputPassword
            // 
            inputPassword.BorderRadius = 28;
            inputPassword.CustomizableEdges = customizableEdges3;
            inputPassword.DefaultText = "";
            inputPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputPassword.Font = new Font("Segoe UI", 9F);
            inputPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputPassword.Location = new Point(68, 346);
            inputPassword.Margin = new Padding(5, 6, 5, 6);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '\0';
            inputPassword.PlaceholderText = "Password";
            inputPassword.SelectedText = "";
            inputPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            inputPassword.Size = new Size(411, 54);
            inputPassword.TabIndex = 2;
            inputPassword.TextOffset = new Point(8, 0);
            // 
            // inputUsername
            // 
            inputUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputUsername.BorderRadius = 28;
            inputUsername.CustomizableEdges = customizableEdges5;
            inputUsername.DefaultText = "";
            inputUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputUsername.Font = new Font("Segoe UI", 9F);
            inputUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputUsername.Location = new Point(68, 278);
            inputUsername.Margin = new Padding(5, 6, 5, 6);
            inputUsername.Name = "inputUsername";
            inputUsername.PasswordChar = '\0';
            inputUsername.PlaceholderText = "Username";
            inputUsername.SelectedText = "";
            inputUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            inputUsername.Size = new Size(411, 56);
            inputUsername.TabIndex = 1;
            inputUsername.TextOffset = new Point(8, 0);
            inputUsername.TextChanged += Username_TextChanged;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = guna2Panel1;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            guna2ContextMenuStrip1.Opening += guna2ContextMenuStrip1_Opening;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 200;
            guna2Elipse2.TargetControl = logo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1191, 766);
            Controls.Add(guna2Panel1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox inputUsername;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2TextBox inputPassword;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Label label1;
        private PictureBox logo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
