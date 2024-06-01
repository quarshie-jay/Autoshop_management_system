<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_return = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvCart = New Guna.UI.WinForms.GunaDataGridView()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnAddToCart = New Guna.UI2.WinForms.Guna2Button()
        Me.cboTools = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboCarCare = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboSafety = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboAutomotive = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboAccessories = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.btnRemoveFromCart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProceedToCheckout = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.lblTotal = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_name = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel7)
        Me.Guna2Panel1.Controls.Add(Me.btn_return)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(943, 80)
        Me.Guna2Panel1.TabIndex = 0
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel7.Location = New System.Drawing.Point(286, 21)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(461, 37)
        Me.GunaLabel7.TabIndex = 21
        Me.GunaLabel7.Text = "SILVER PLATTER AUTOS SHOP 🛒"
        '
        'btn_return
        '
        Me.btn_return.Animated = True
        Me.btn_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_return.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_return.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_return.Location = New System.Drawing.Point(23, 21)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(180, 45)
        Me.btn_return.TabIndex = 7
        Me.btn_return.Text = "< < < RETURN"
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCart.ColumnHeadersHeight = 33
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCart.EnableHeadersVisualStyles = False
        Me.dgvCart.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.Location = New System.Drawing.Point(542, 135)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(373, 469)
        Me.dgvCart.TabIndex = 2
        Me.dgvCart.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCart.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.dgvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCart.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCart.ThemeStyle.HeaderStyle.Height = 33
        Me.dgvCart.ThemeStyle.ReadOnly = False
        Me.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCart.ThemeStyle.RowsStyle.Height = 22
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(466, 558)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalCost.TabIndex = 3
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BorderRadius = 2
        Me.btnAddToCart.BorderThickness = 1
        Me.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddToCart.FillColor = System.Drawing.Color.Black
        Me.btnAddToCart.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(13, 684)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(180, 45)
        Me.btnAddToCart.TabIndex = 4
        Me.btnAddToCart.Text = "Add To Cart"
        '
        'cboTools
        '
        Me.cboTools.BackColor = System.Drawing.Color.Transparent
        Me.cboTools.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTools.FillColor = System.Drawing.Color.Silver
        Me.cboTools.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTools.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTools.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboTools.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboTools.ItemHeight = 30
        Me.cboTools.Location = New System.Drawing.Point(12, 276)
        Me.cboTools.Name = "cboTools"
        Me.cboTools.Size = New System.Drawing.Size(190, 36)
        Me.cboTools.TabIndex = 7
        '
        'cboCarCare
        '
        Me.cboCarCare.BackColor = System.Drawing.Color.Transparent
        Me.cboCarCare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCarCare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarCare.FillColor = System.Drawing.Color.Silver
        Me.cboCarCare.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCarCare.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCarCare.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboCarCare.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCarCare.ItemHeight = 30
        Me.cboCarCare.Location = New System.Drawing.Point(12, 389)
        Me.cboCarCare.Name = "cboCarCare"
        Me.cboCarCare.Size = New System.Drawing.Size(190, 36)
        Me.cboCarCare.TabIndex = 8
        '
        'cboSafety
        '
        Me.cboSafety.BackColor = System.Drawing.Color.Transparent
        Me.cboSafety.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSafety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSafety.FillColor = System.Drawing.Color.Silver
        Me.cboSafety.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSafety.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSafety.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboSafety.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboSafety.ItemHeight = 30
        Me.cboSafety.Location = New System.Drawing.Point(12, 502)
        Me.cboSafety.Name = "cboSafety"
        Me.cboSafety.Size = New System.Drawing.Size(190, 36)
        Me.cboSafety.TabIndex = 9
        '
        'cboAutomotive
        '
        Me.cboAutomotive.BackColor = System.Drawing.Color.Transparent
        Me.cboAutomotive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAutomotive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAutomotive.FillColor = System.Drawing.Color.Silver
        Me.cboAutomotive.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAutomotive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAutomotive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboAutomotive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboAutomotive.ItemHeight = 30
        Me.cboAutomotive.Location = New System.Drawing.Point(249, 276)
        Me.cboAutomotive.Name = "cboAutomotive"
        Me.cboAutomotive.Size = New System.Drawing.Size(198, 36)
        Me.cboAutomotive.TabIndex = 10
        '
        'cboAccessories
        '
        Me.cboAccessories.BackColor = System.Drawing.Color.Transparent
        Me.cboAccessories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAccessories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccessories.FillColor = System.Drawing.Color.Silver
        Me.cboAccessories.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAccessories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAccessories.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboAccessories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboAccessories.ItemHeight = 30
        Me.cboAccessories.Location = New System.Drawing.Point(249, 389)
        Me.cboAccessories.Name = "cboAccessories"
        Me.cboAccessories.Size = New System.Drawing.Size(198, 36)
        Me.cboAccessories.TabIndex = 11
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(19, 237)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(173, 21)
        Me.GunaLabel1.TabIndex = 12
        Me.GunaLabel1.Text = "Tools And Equipment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(263, 237)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(143, 21)
        Me.GunaLabel3.TabIndex = 14
        Me.GunaLabel3.Text = "Automotive Parts"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(19, 356)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(73, 21)
        Me.GunaLabel2.TabIndex = 15
        Me.GunaLabel2.Text = "Car Care"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(263, 356)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(97, 21)
        Me.GunaLabel4.TabIndex = 16
        Me.GunaLabel4.Text = "Accessories"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(19, 478)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(146, 21)
        Me.GunaLabel5.TabIndex = 17
        Me.GunaLabel5.Text = "Safety Equipment"
        '
        'btnRemoveFromCart
        '
        Me.btnRemoveFromCart.BorderRadius = 2
        Me.btnRemoveFromCart.BorderThickness = 1
        Me.btnRemoveFromCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveFromCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveFromCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveFromCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemoveFromCart.FillColor = System.Drawing.Color.Black
        Me.btnRemoveFromCart.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFromCart.ForeColor = System.Drawing.Color.White
        Me.btnRemoveFromCart.Location = New System.Drawing.Point(500, 684)
        Me.btnRemoveFromCart.Name = "btnRemoveFromCart"
        Me.btnRemoveFromCart.Size = New System.Drawing.Size(180, 45)
        Me.btnRemoveFromCart.TabIndex = 18
        Me.btnRemoveFromCart.Text = "Remove From Cart"
        '
        'btnProceedToCheckout
        '
        Me.btnProceedToCheckout.BorderRadius = 2
        Me.btnProceedToCheckout.BorderThickness = 1
        Me.btnProceedToCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProceedToCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProceedToCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProceedToCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProceedToCheckout.FillColor = System.Drawing.Color.Black
        Me.btnProceedToCheckout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceedToCheckout.ForeColor = System.Drawing.Color.White
        Me.btnProceedToCheckout.Location = New System.Drawing.Point(712, 684)
        Me.btnProceedToCheckout.Name = "btnProceedToCheckout"
        Me.btnProceedToCheckout.Size = New System.Drawing.Size(203, 45)
        Me.btnProceedToCheckout.TabIndex = 19
        Me.btnProceedToCheckout.Text = "Proceed To Checkout"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(24, 135)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(423, 37)
        Me.GunaLabel6.TabIndex = 20
        Me.GunaLabel6.Text = "AVAILABLE ON SALE! 20% OFF!!"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(720, 107)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(59, 25)
        Me.GunaLabel8.TabIndex = 21
        Me.GunaLabel8.Text = "CART" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(535, 627)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 37)
        Me.lblTotal.TabIndex = 22
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(24, 83)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(0, 37)
        Me.lbl_name.TabIndex = 23
        '
        'Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 775)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.btnProceedToCheckout)
        Me.Controls.Add(Me.btnRemoveFromCart)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.cboAccessories)
        Me.Controls.Add(Me.cboAutomotive)
        Me.Controls.Add(Me.cboSafety)
        Me.Controls.Add(Me.cboCarCare)
        Me.Controls.Add(Me.cboTools)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "shop"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvCart As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnAddToCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cboTools As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboCarCare As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboSafety As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboAutomotive As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboAccessories As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnRemoveFromCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProceedToCheckout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTotal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_name As Guna.UI.WinForms.GunaLabel
End Class
