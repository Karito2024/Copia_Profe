namespace ClasesINA.Formularios
{
    partial class Principal
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
            this.txtProducto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrecioUnitario = new MaterialSkin.Controls.MaterialTextBox2();
            this.slideUnidades = new MaterialSkin.Controls.MaterialSlider();
            this.btnProcesarCompra = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.AnimateReadOnly = false;
            this.txtProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProducto.Depth = 0;
            this.txtProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProducto.HideSelection = true;
            this.txtProducto.Hint = "Nombre del producto";
            this.txtProducto.LeadingIcon = null;
            this.txtProducto.Location = new System.Drawing.Point(24, 104);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.PrefixSuffixText = null;
            this.txtProducto.ReadOnly = false;
            this.txtProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.ShortcutsEnabled = true;
            this.txtProducto.Size = new System.Drawing.Size(250, 48);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TabStop = false;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProducto.TrailingIcon = null;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.AnimateReadOnly = false;
            this.txtPrecioUnitario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecioUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioUnitario.Depth = 0;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioUnitario.HideSelection = true;
            this.txtPrecioUnitario.Hint = "Precio unitario";
            this.txtPrecioUnitario.LeadingIcon = null;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(299, 104);
            this.txtPrecioUnitario.MaxLength = 32767;
            this.txtPrecioUnitario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.PasswordChar = '\0';
            this.txtPrecioUnitario.PrefixSuffixText = null;
            this.txtPrecioUnitario.ReadOnly = false;
            this.txtPrecioUnitario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioUnitario.SelectedText = "";
            this.txtPrecioUnitario.SelectionLength = 0;
            this.txtPrecioUnitario.SelectionStart = 0;
            this.txtPrecioUnitario.ShortcutsEnabled = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(250, 48);
            this.txtPrecioUnitario.TabIndex = 1;
            this.txtPrecioUnitario.TabStop = false;
            this.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioUnitario.TrailingIcon = null;
            this.txtPrecioUnitario.UseSystemPasswordChar = false;
            // 
            // slideUnidades
            // 
            this.slideUnidades.Depth = 0;
            this.slideUnidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slideUnidades.Location = new System.Drawing.Point(555, 112);
            this.slideUnidades.MouseState = MaterialSkin.MouseState.HOVER;
            this.slideUnidades.Name = "slideUnidades";
            this.slideUnidades.Size = new System.Drawing.Size(267, 40);
            this.slideUnidades.TabIndex = 2;
            this.slideUnidades.Text = "Unidades";
            // 
            // btnProcesarCompra
            // 
            this.btnProcesarCompra.AutoSize = false;
            this.btnProcesarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcesarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcesarCompra.Depth = 0;
            this.btnProcesarCompra.HighEmphasis = true;
            this.btnProcesarCompra.Icon = null;
            this.btnProcesarCompra.Location = new System.Drawing.Point(24, 251);
            this.btnProcesarCompra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcesarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcesarCompra.Name = "btnProcesarCompra";
            this.btnProcesarCompra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcesarCompra.Size = new System.Drawing.Size(270, 36);
            this.btnProcesarCompra.TabIndex = 3;
            this.btnProcesarCompra.Text = "Procesar compra";
            this.btnProcesarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcesarCompra.UseAccentColor = false;
            this.btnProcesarCompra.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.Hint = "0.0";
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(24, 182);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(250, 48);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // dtCompras
            // 
            this.dtCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Unidades,
            this.Total});
            this.dtCompras.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtCompras.Location = new System.Drawing.Point(24, 318);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.RowHeadersWidth = 62;
            this.dtCompras.RowTemplate.Height = 28;
            this.dtCompras.Size = new System.Drawing.Size(737, 150);
            this.dtCompras.TabIndex = 5;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(768, 318);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(73, 36);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "-";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(768, 366);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(73, 36);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "A";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Nombre producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio unitario";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades compradas";
            this.Unidades.MinimumWidth = 8;
            this.Unidades.Name = "Unidades";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 491);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.dtCompras);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnProcesarCompra);
            this.Controls.Add(this.slideUnidades);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtProducto);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtProducto;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioUnitario;
        private MaterialSkin.Controls.MaterialSlider slideUnidades;
        private MaterialSkin.Controls.MaterialButton btnProcesarCompra;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private System.Windows.Forms.DataGridView dtCompras;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}