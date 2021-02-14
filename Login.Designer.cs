
namespace FormLogin
{
    partial class Login
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
            this.pnContainer = new System.Windows.Forms.Panel();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTitulo = new UIDC.UI_TitleBanner();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.lbNuevo = new System.Windows.Forms.LinkLabel();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnContainer.Controls.Add(this.lbNuevo);
            this.pnContainer.Controls.Add(this.btnIngresar);
            this.pnContainer.Controls.Add(this.guna2TextBox1);
            this.pnContainer.Controls.Add(this.txtUser);
            this.pnContainer.Controls.Add(this.tbTitulo);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(299, 295);
            this.pnContainer.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderRadius = 20;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.Transparent;
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.HoverState.Parent = this.txtUser;
            this.txtUser.IconLeft = global::FormLogin.Properties.Resources.Usuario;
            this.txtUser.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtUser.Location = new System.Drawing.Point(30, 62);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "Nombre de Usuario";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.BorderRadius = 20;
            this.txtUser.ShadowDecoration.Color = System.Drawing.Color.White;
            this.txtUser.ShadowDecoration.Enabled = true;
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(234, 35);
            this.txtUser.TabIndex = 1;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Animate = UIDC.UI_TitleBanner.Anim.AnimateON;
            this.tbTitulo.BackColor = System.Drawing.Color.Black;
            this.tbTitulo.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff;
            this.tbTitulo.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close;
            this.tbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTitulo.FlatAppearance.BorderSize = 0;
            this.tbTitulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.tbTitulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.tbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbTitulo.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.tbTitulo.ForeColor = System.Drawing.Color.White;
            this.tbTitulo.Location = new System.Drawing.Point(0, 0);
            this.tbTitulo.MoveActive = true;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tbTitulo.ParentControl = this;
            this.tbTitulo.Size = new System.Drawing.Size(299, 54);
            this.tbTitulo.TabIndex = 0;
            this.tbTitulo.Text = "Accede a tu cuenta";
            this.tbTitulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tbTitulo.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.tbTitulo.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = global::FormLogin.Properties.Resources.Clave;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(30, 131);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Clave de acceso";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.BorderRadius = 20;
            this.guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2TextBox1.ShadowDecoration.Enabled = true;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(234, 35);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.CheckedState.Parent = this.btnIngresar;
            this.btnIngresar.CustomImages.Parent = this.btnIngresar;
            this.btnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.HoverState.Parent = this.btnIngresar;
            this.btnIngresar.Location = new System.Drawing.Point(30, 190);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.ShadowDecoration.BorderRadius = 20;
            this.btnIngresar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIngresar.ShadowDecoration.Parent = this.btnIngresar;
            this.btnIngresar.Size = new System.Drawing.Size(234, 45);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            // 
            // lbNuevo
            // 
            this.lbNuevo.AutoSize = true;
            this.lbNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lbNuevo.LinkColor = System.Drawing.Color.White;
            this.lbNuevo.Location = new System.Drawing.Point(50, 250);
            this.lbNuevo.Name = "lbNuevo";
            this.lbNuevo.Size = new System.Drawing.Size(189, 17);
            this.lbNuevo.TabIndex = 3;
            this.lbNuevo.TabStop = true;
            this.lbNuevo.Text = "Aún no tengo una cuenta";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormLogin.Properties.Resources.Puente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(299, 295);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accede a tu cuenta";
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private UIDC.UI_TitleBanner tbTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.LinkLabel lbNuevo;
    }
}