namespace SISTEMA
{
    partial class frmNuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaVenta));
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblCliDir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCliTel = new System.Windows.Forms.Label();
            this.lblCliApe = new System.Windows.Forms.Label();
            this.lblCliNom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarDUI = new System.Windows.Forms.Button();
            this.mskDui = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.cmbSaldo = new System.Windows.Forms.ComboBox();
            this.cmbIdProducto = new System.Windows.Forms.ComboBox();
            this.cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this.cmbPrecioxProducto = new System.Windows.Forms.ComboBox();
            this.btnProceder = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCantProducto = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.chkDescuento = new System.Windows.Forms.CheckBox();
            this.numDescuento = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblMensajePago = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCliente.SuspendLayout();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblCliDir);
            this.grpCliente.Controls.Add(this.label5);
            this.grpCliente.Controls.Add(this.lblCliTel);
            this.grpCliente.Controls.Add(this.lblCliApe);
            this.grpCliente.Controls.Add(this.lblCliNom);
            this.grpCliente.Controls.Add(this.label4);
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.label2);
            this.grpCliente.Controls.Add(this.btnBuscarDUI);
            this.grpCliente.Controls.Add(this.mskDui);
            this.grpCliente.Controls.Add(this.label1);
            this.grpCliente.Location = new System.Drawing.Point(11, 10);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(2);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(2);
            this.grpCliente.Size = new System.Drawing.Size(209, 159);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos Cliente";
            // 
            // lblCliDir
            // 
            this.lblCliDir.AutoSize = true;
            this.lblCliDir.Location = new System.Drawing.Point(60, 133);
            this.lblCliDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliDir.Name = "lblCliDir";
            this.lblCliDir.Size = new System.Drawing.Size(0, 13);
            this.lblCliDir.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Direccion:";
            // 
            // lblCliTel
            // 
            this.lblCliTel.AutoSize = true;
            this.lblCliTel.Location = new System.Drawing.Point(58, 112);
            this.lblCliTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliTel.Name = "lblCliTel";
            this.lblCliTel.Size = new System.Drawing.Size(0, 13);
            this.lblCliTel.TabIndex = 18;
            // 
            // lblCliApe
            // 
            this.lblCliApe.AutoSize = true;
            this.lblCliApe.Location = new System.Drawing.Point(58, 89);
            this.lblCliApe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliApe.Name = "lblCliApe";
            this.lblCliApe.Size = new System.Drawing.Size(0, 13);
            this.lblCliApe.TabIndex = 17;
            // 
            // lblCliNom
            // 
            this.lblCliNom.AutoSize = true;
            this.lblCliNom.Location = new System.Drawing.Point(58, 67);
            this.lblCliNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliNom.Name = "lblCliNom";
            this.lblCliNom.Size = new System.Drawing.Size(0, 13);
            this.lblCliNom.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // btnBuscarDUI
            // 
            this.btnBuscarDUI.BackColor = System.Drawing.Color.Pink;
            this.btnBuscarDUI.FlatAppearance.BorderSize = 0;
            this.btnBuscarDUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBuscarDUI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarDUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDUI.Location = new System.Drawing.Point(147, 27);
            this.btnBuscarDUI.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarDUI.Name = "btnBuscarDUI";
            this.btnBuscarDUI.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarDUI.TabIndex = 12;
            this.btnBuscarDUI.Text = "Buscar";
            this.btnBuscarDUI.UseVisualStyleBackColor = false;
            this.btnBuscarDUI.Click += new System.EventHandler(this.btnBuscarDUI_Click);
            // 
            // mskDui
            // 
            this.mskDui.Location = new System.Drawing.Point(35, 30);
            this.mskDui.Margin = new System.Windows.Forms.Padding(2);
            this.mskDui.Mask = "000000000";
            this.mskDui.Name = "mskDui";
            this.mskDui.Size = new System.Drawing.Size(108, 20);
            this.mskDui.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.cmbSaldo);
            this.grpProducto.Controls.Add(this.cmbIdProducto);
            this.grpProducto.Controls.Add(this.cmbIdCategoria);
            this.grpProducto.Controls.Add(this.cmbPrecioxProducto);
            this.grpProducto.Controls.Add(this.btnProceder);
            this.grpProducto.Controls.Add(this.btnLimpiar);
            this.grpProducto.Controls.Add(this.btnEliminar);
            this.grpProducto.Controls.Add(this.btnAgregar);
            this.grpProducto.Controls.Add(this.cmbCantProducto);
            this.grpProducto.Controls.Add(this.numCantidad);
            this.grpProducto.Controls.Add(this.label8);
            this.grpProducto.Controls.Add(this.cmbDescripcion);
            this.grpProducto.Controls.Add(this.label7);
            this.grpProducto.Controls.Add(this.cmbProducto);
            this.grpProducto.Controls.Add(this.cmbCategoria);
            this.grpProducto.Controls.Add(this.label6);
            this.grpProducto.Enabled = false;
            this.grpProducto.Location = new System.Drawing.Point(11, 221);
            this.grpProducto.Margin = new System.Windows.Forms.Padding(2);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Padding = new System.Windows.Forms.Padding(2);
            this.grpProducto.Size = new System.Drawing.Size(209, 218);
            this.grpProducto.TabIndex = 1;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Productos";
            // 
            // cmbSaldo
            // 
            this.cmbSaldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaldo.FormattingEnabled = true;
            this.cmbSaldo.Location = new System.Drawing.Point(176, 201);
            this.cmbSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSaldo.Name = "cmbSaldo";
            this.cmbSaldo.Size = new System.Drawing.Size(19, 21);
            this.cmbSaldo.TabIndex = 14;
            this.cmbSaldo.Visible = false;
            // 
            // cmbIdProducto
            // 
            this.cmbIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdProducto.FormattingEnabled = true;
            this.cmbIdProducto.Location = new System.Drawing.Point(147, 201);
            this.cmbIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdProducto.Name = "cmbIdProducto";
            this.cmbIdProducto.Size = new System.Drawing.Size(19, 21);
            this.cmbIdProducto.TabIndex = 13;
            this.cmbIdProducto.Visible = false;
            // 
            // cmbIdCategoria
            // 
            this.cmbIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCategoria.FormattingEnabled = true;
            this.cmbIdCategoria.Location = new System.Drawing.Point(117, 201);
            this.cmbIdCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdCategoria.Name = "cmbIdCategoria";
            this.cmbIdCategoria.Size = new System.Drawing.Size(19, 21);
            this.cmbIdCategoria.TabIndex = 12;
            this.cmbIdCategoria.Visible = false;
            // 
            // cmbPrecioxProducto
            // 
            this.cmbPrecioxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrecioxProducto.FormattingEnabled = true;
            this.cmbPrecioxProducto.Location = new System.Drawing.Point(56, 198);
            this.cmbPrecioxProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPrecioxProducto.Name = "cmbPrecioxProducto";
            this.cmbPrecioxProducto.Size = new System.Drawing.Size(23, 21);
            this.cmbPrecioxProducto.TabIndex = 11;
            this.cmbPrecioxProducto.Visible = false;
            // 
            // btnProceder
            // 
            this.btnProceder.BackColor = System.Drawing.Color.Pink;
            this.btnProceder.Enabled = false;
            this.btnProceder.FlatAppearance.BorderSize = 0;
            this.btnProceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnProceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceder.Location = new System.Drawing.Point(53, 147);
            this.btnProceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnProceder.Name = "btnProceder";
            this.btnProceder.Size = new System.Drawing.Size(141, 28);
            this.btnProceder.TabIndex = 10;
            this.btnProceder.Text = "Proceder al pago";
            this.btnProceder.UseVisualStyleBackColor = false;
            this.btnProceder.Click += new System.EventHandler(this.btnProceder_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::SISTEMA.Properties.Resources.icons8_clear_shopping_cart_80;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(125, 102);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 41);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::SISTEMA.Properties.Resources.icons8_return_purchase_80;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(83, 102);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(38, 41);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::SISTEMA.Properties.Resources.icons8_buy_80;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(41, 102);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(38, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCantProducto
            // 
            this.cmbCantProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantProducto.FormattingEnabled = true;
            this.cmbCantProducto.Location = new System.Drawing.Point(35, 198);
            this.cmbCantProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCantProducto.Name = "cmbCantProducto";
            this.cmbCantProducto.Size = new System.Drawing.Size(18, 21);
            this.cmbCantProducto.TabIndex = 8;
            this.cmbCantProducto.Visible = false;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(64, 75);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numCantidad.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.ReadOnly = true;
            this.numCantidad.Size = new System.Drawing.Size(130, 20);
            this.numCantidad.TabIndex = 5;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Producto:";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(10, 198);
            this.cmbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(21, 21);
            this.cmbDescripcion.TabIndex = 7;
            this.cmbDescripcion.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Enabled = false;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(64, 50);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(131, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(64, 25);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(131, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Categoria:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colDescripcion,
            this.colPrecio,
            this.colCantidad,
            this.colCatId,
            this.colProdId,
            this.colLimite,
            this.colCategoria});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.Location = new System.Drawing.Point(225, 11);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(447, 428);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCambiar.Enabled = false;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Location = new System.Drawing.Point(56, 189);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(118, 27);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar Cliente";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.lblMail);
            this.grpPago.Controls.Add(this.btnNueva);
            this.grpPago.Controls.Add(this.txtTotal);
            this.grpPago.Controls.Add(this.btnCancelarPago);
            this.grpPago.Controls.Add(this.chkDescuento);
            this.grpPago.Controls.Add(this.numDescuento);
            this.grpPago.Controls.Add(this.label15);
            this.grpPago.Controls.Add(this.btnPagar);
            this.grpPago.Controls.Add(this.txtEmail);
            this.grpPago.Controls.Add(this.label14);
            this.grpPago.Controls.Add(this.label13);
            this.grpPago.Controls.Add(this.rdbNo);
            this.grpPago.Controls.Add(this.rdbSi);
            this.grpPago.Controls.Add(this.lblMensajePago);
            this.grpPago.Controls.Add(this.txtPago);
            this.grpPago.Controls.Add(this.label11);
            this.grpPago.Controls.Add(this.txtSubtotal);
            this.grpPago.Controls.Add(this.label10);
            this.grpPago.Controls.Add(this.label9);
            this.grpPago.Enabled = false;
            this.grpPago.Location = new System.Drawing.Point(676, 11);
            this.grpPago.Margin = new System.Windows.Forms.Padding(2);
            this.grpPago.Name = "grpPago";
            this.grpPago.Padding = new System.Windows.Forms.Padding(2);
            this.grpPago.Size = new System.Drawing.Size(226, 428);
            this.grpPago.TabIndex = 4;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Pago";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(53, 399);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(586, 65);
            this.lblMail.TabIndex = 20;
            this.lblMail.Text = resources.GetString("lblMail.Text");
            this.lblMail.Visible = false;
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Location = new System.Drawing.Point(56, 299);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(2);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(122, 30);
            this.btnNueva.TabIndex = 5;
            this.btnNueva.Text = "Nueva venta";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(79, 84);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelarPago.FlatAppearance.BorderSize = 0;
            this.btnCancelarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPago.Location = new System.Drawing.Point(119, 196);
            this.btnCancelarPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(102, 27);
            this.btnCancelarPago.TabIndex = 18;
            this.btnCancelarPago.Text = "Cancelar Compra";
            this.btnCancelarPago.UseVisualStyleBackColor = false;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // chkDescuento
            // 
            this.chkDescuento.AutoSize = true;
            this.chkDescuento.Location = new System.Drawing.Point(178, 61);
            this.chkDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.chkDescuento.Name = "chkDescuento";
            this.chkDescuento.Size = new System.Drawing.Size(15, 14);
            this.chkDescuento.TabIndex = 16;
            this.chkDescuento.UseVisualStyleBackColor = true;
            this.chkDescuento.CheckedChanged += new System.EventHandler(this.chkDescuento_CheckedChanged);
            // 
            // numDescuento
            // 
            this.numDescuento.Enabled = false;
            this.numDescuento.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDescuento.Location = new System.Drawing.Point(79, 57);
            this.numDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.numDescuento.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDescuento.Name = "numDescuento";
            this.numDescuento.ReadOnly = true;
            this.numDescuento.Size = new System.Drawing.Size(94, 20);
            this.numDescuento.TabIndex = 15;
            this.numDescuento.ValueChanged += new System.EventHandler(this.numDescuento_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Descuento:";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Pink;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Location = new System.Drawing.Point(32, 196);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(83, 27);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(79, 156);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(96, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 155);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "E-mail:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Factura:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(127, 134);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 10;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(92, 134);
            this.rdbSi.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 9;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // lblMensajePago
            // 
            this.lblMensajePago.AutoSize = true;
            this.lblMensajePago.ForeColor = System.Drawing.Color.Red;
            this.lblMensajePago.Location = new System.Drawing.Point(26, 248);
            this.lblMensajePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajePago.Name = "lblMensajePago";
            this.lblMensajePago.Size = new System.Drawing.Size(0, 13);
            this.lblMensajePago.TabIndex = 8;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(79, 107);
            this.txtPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(96, 20);
            this.txtPago.TabIndex = 6;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Pago:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(79, 34);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(96, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Subtotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total a pagar:";
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio U";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colCatId
            // 
            this.colCatId.HeaderText = "IdCat";
            this.colCatId.Name = "colCatId";
            this.colCatId.ReadOnly = true;
            this.colCatId.Visible = false;
            // 
            // colProdId
            // 
            this.colProdId.HeaderText = "IdPro";
            this.colProdId.Name = "colProdId";
            this.colProdId.ReadOnly = true;
            this.colProdId.Visible = false;
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Limite";
            this.colLimite.Name = "colLimite";
            this.colLimite.ReadOnly = true;
            this.colLimite.Visible = false;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Visible = false;
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(908, 448);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.grpCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmNuevaVenta_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescuento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnBuscarDUI;
        private System.Windows.Forms.MaskedTextBox mskDui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCliTel;
        private System.Windows.Forms.Label lblCliApe;
        private System.Windows.Forms.Label lblCliNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.ComboBox cmbCantProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbPrecioxProducto;
        private System.Windows.Forms.Button btnProceder;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.CheckBox chkDescuento;
        private System.Windows.Forms.NumericUpDown numDescuento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblMensajePago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cmbIdProducto;
        private System.Windows.Forms.ComboBox cmbIdCategoria;
        private System.Windows.Forms.ComboBox cmbSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
    }
}