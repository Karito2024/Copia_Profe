namespace ClasesINA.Formularios
{
    partial class CreaCuentas
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
            this.txtUsuarioCrear = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContrasennia = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRepiteContrasennia = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.AnimateReadOnly = false;
            this.txtUsuarioCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuarioCrear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuarioCrear.Depth = 0;
            this.txtUsuarioCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioCrear.HideSelection = true;
            this.txtUsuarioCrear.Hint = "Usuario a crear";
            this.txtUsuarioCrear.LeadingIcon = null;
            this.txtUsuarioCrear.Location = new System.Drawing.Point(25, 114);
            this.txtUsuarioCrear.MaxLength = 32767;
            this.txtUsuarioCrear.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.PasswordChar = '\0';
            this.txtUsuarioCrear.PrefixSuffixText = null;
            this.txtUsuarioCrear.ReadOnly = false;
            this.txtUsuarioCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioCrear.SelectedText = "";
            this.txtUsuarioCrear.SelectionLength = 0;
            this.txtUsuarioCrear.SelectionStart = 0;
            this.txtUsuarioCrear.ShortcutsEnabled = true;
            this.txtUsuarioCrear.Size = new System.Drawing.Size(376, 48);
            this.txtUsuarioCrear.TabIndex = 0;
            this.txtUsuarioCrear.TabStop = false;
            this.txtUsuarioCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioCrear.TrailingIcon = null;
            this.txtUsuarioCrear.UseSystemPasswordChar = false;
            // 
            // txtContrasennia
            // 
            this.txtContrasennia.AllowPromptAsInput = true;
            this.txtContrasennia.AnimateReadOnly = false;
            this.txtContrasennia.AsciiOnly = false;
            this.txtContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasennia.BeepOnError = false;
            this.txtContrasennia.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasennia.Depth = 0;
            this.txtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasennia.HidePromptOnLeave = false;
            this.txtContrasennia.HideSelection = true;
            this.txtContrasennia.Hint = "Contraseña a crear";
            this.txtContrasennia.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtContrasennia.LeadingIcon = null;
            this.txtContrasennia.Location = new System.Drawing.Point(25, 200);
            this.txtContrasennia.Mask = "";
            this.txtContrasennia.MaxLength = 32767;
            this.txtContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasennia.Name = "txtContrasennia";
            this.txtContrasennia.PasswordChar = '\0';
            this.txtContrasennia.PrefixSuffixText = null;
            this.txtContrasennia.PromptChar = '_';
            this.txtContrasennia.ReadOnly = false;
            this.txtContrasennia.RejectInputOnFirstFailure = false;
            this.txtContrasennia.ResetOnPrompt = true;
            this.txtContrasennia.ResetOnSpace = true;
            this.txtContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasennia.SelectedText = "";
            this.txtContrasennia.SelectionLength = 0;
            this.txtContrasennia.SelectionStart = 0;
            this.txtContrasennia.ShortcutsEnabled = true;
            this.txtContrasennia.Size = new System.Drawing.Size(376, 48);
            this.txtContrasennia.SkipLiterals = true;
            this.txtContrasennia.TabIndex = 1;
            this.txtContrasennia.TabStop = false;
            this.txtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasennia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasennia.TrailingIcon = null;
            this.txtContrasennia.UseSystemPasswordChar = false;
            this.txtContrasennia.ValidatingType = null;
            // 
            // txtRepiteContrasennia
            // 
            this.txtRepiteContrasennia.AllowPromptAsInput = true;
            this.txtRepiteContrasennia.AnimateReadOnly = false;
            this.txtRepiteContrasennia.AsciiOnly = false;
            this.txtRepiteContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRepiteContrasennia.BeepOnError = false;
            this.txtRepiteContrasennia.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRepiteContrasennia.Depth = 0;
            this.txtRepiteContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepiteContrasennia.HidePromptOnLeave = false;
            this.txtRepiteContrasennia.HideSelection = true;
            this.txtRepiteContrasennia.Hint = "Repita la contraseña";
            this.txtRepiteContrasennia.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRepiteContrasennia.LeadingIcon = null;
            this.txtRepiteContrasennia.Location = new System.Drawing.Point(25, 283);
            this.txtRepiteContrasennia.Mask = "";
            this.txtRepiteContrasennia.MaxLength = 32767;
            this.txtRepiteContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRepiteContrasennia.Name = "txtRepiteContrasennia";
            this.txtRepiteContrasennia.PasswordChar = '\0';
            this.txtRepiteContrasennia.PrefixSuffixText = null;
            this.txtRepiteContrasennia.PromptChar = '_';
            this.txtRepiteContrasennia.ReadOnly = false;
            this.txtRepiteContrasennia.RejectInputOnFirstFailure = false;
            this.txtRepiteContrasennia.ResetOnPrompt = true;
            this.txtRepiteContrasennia.ResetOnSpace = true;
            this.txtRepiteContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRepiteContrasennia.SelectedText = "";
            this.txtRepiteContrasennia.SelectionLength = 0;
            this.txtRepiteContrasennia.SelectionStart = 0;
            this.txtRepiteContrasennia.ShortcutsEnabled = true;
            this.txtRepiteContrasennia.Size = new System.Drawing.Size(376, 48);
            this.txtRepiteContrasennia.SkipLiterals = true;
            this.txtRepiteContrasennia.TabIndex = 2;
            this.txtRepiteContrasennia.TabStop = false;
            this.txtRepiteContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepiteContrasennia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRepiteContrasennia.TrailingIcon = null;
            this.txtRepiteContrasennia.UseSystemPasswordChar = false;
            this.txtRepiteContrasennia.ValidatingType = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(25, 361);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(128, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Crear cuenta";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // CreaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txtRepiteContrasennia);
            this.Controls.Add(this.txtContrasennia);
            this.Controls.Add(this.txtUsuarioCrear);
            this.Name = "CreaCuentas";
            this.Text = "CreaCuentas";
            this.Load += new System.EventHandler(this.CreaCuentas_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreaCuentas_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtUsuarioCrear;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContrasennia;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRepiteContrasennia;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}