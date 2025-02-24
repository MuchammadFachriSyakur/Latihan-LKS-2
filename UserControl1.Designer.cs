namespace Latihan_LKS_2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            hero_section = new Guna.UI2.WinForms.Guna2Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            header_text = new Label();
            form = new Guna.UI2.WinForms.Guna2Panel();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            hero_section.SuspendLayout();
            form.SuspendLayout();
            SuspendLayout();
            // 
            // hero_section
            // 
            hero_section.BackColor = SystemColors.AppWorkspace;
            hero_section.BackgroundImage = (Image)resources.GetObject("hero_section.BackgroundImage");
            hero_section.BackgroundImageLayout = ImageLayout.Stretch;
            hero_section.Controls.Add(header_text);
            hero_section.CustomizableEdges = customizableEdges1;
            hero_section.Location = new Point(31, 22);
            hero_section.Margin = new Padding(0);
            hero_section.Name = "hero_section";
            hero_section.ShadowDecoration.CustomizableEdges = customizableEdges2;
            hero_section.Size = new Size(1046, 525);
            hero_section.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = hero_section;
            // 
            // header_text
            // 
            header_text.BackColor = Color.Transparent;
            header_text.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            header_text.ForeColor = SystemColors.ButtonFace;
            header_text.Location = new Point(179, 174);
            header_text.Name = "header_text";
            header_text.Size = new Size(679, 137);
            header_text.TabIndex = 0;
            header_text.Text = "Hallo, Selamat datang di layanan travel agent kami!";
            header_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form
            // 
            form.BorderColor = Color.FromArgb(224, 224, 224);
            form.BorderThickness = 4;
            form.Controls.Add(label2);
            form.CustomizableEdges = customizableEdges3;
            form.Location = new Point(31, 590);
            form.Name = "form";
            form.ShadowDecoration.CustomizableEdges = customizableEdges4;
            form.Size = new Size(630, 376);
            form.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = form;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 0;
            label2.Text = "Pemesanan Tiket";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(form);
            Controls.Add(hero_section);
            Name = "UserControl1";
            Size = new Size(1112, 1121);
            hero_section.ResumeLayout(false);
            form.ResumeLayout(false);
            form.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel hero_section;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label header_text;
        private Guna.UI2.WinForms.Guna2Panel form;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label2;
        private Label label1;
    }
}
