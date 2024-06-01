<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mechanic_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mechanic_Form))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_name = New Guna.UI.WinForms.GunaLabel()
        Me.btn_clockin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_clockout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_logout = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvClockRecords = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hours = New Guna.UI.WinForms.GunaLabel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClockRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, 55)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(118, 117)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(36, 189)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(0, 21)
        Me.lbl_name.TabIndex = 1
        '
        'btn_clockin
        '
        Me.btn_clockin.Animated = True
        Me.btn_clockin.BorderRadius = 2
        Me.btn_clockin.BorderThickness = 1
        Me.btn_clockin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_clockin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_clockin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clockin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clockin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_clockin.FillColor = System.Drawing.Color.White
        Me.btn_clockin.FillColor2 = System.Drawing.Color.Silver
        Me.btn_clockin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btn_clockin.ForeColor = System.Drawing.Color.Black
        Me.btn_clockin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_clockin.Location = New System.Drawing.Point(315, 196)
        Me.btn_clockin.Name = "btn_clockin"
        Me.btn_clockin.Size = New System.Drawing.Size(192, 145)
        Me.btn_clockin.TabIndex = 2
        Me.btn_clockin.Text = "CLOCK-IN"
        '
        'btn_clockout
        '
        Me.btn_clockout.BorderRadius = 2
        Me.btn_clockout.BorderThickness = 1
        Me.btn_clockout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_clockout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_clockout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clockout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clockout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_clockout.FillColor = System.Drawing.Color.Black
        Me.btn_clockout.FillColor2 = System.Drawing.Color.Gray
        Me.btn_clockout.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btn_clockout.ForeColor = System.Drawing.Color.White
        Me.btn_clockout.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_clockout.Location = New System.Drawing.Point(541, 196)
        Me.btn_clockout.Name = "btn_clockout"
        Me.btn_clockout.Size = New System.Drawing.Size(191, 145)
        Me.btn_clockout.TabIndex = 3
        Me.btn_clockout.Text = "CLOCK-OUT"
        '
        'btn_logout
        '
        Me.btn_logout.BorderRadius = 2
        Me.btn_logout.BorderThickness = 1
        Me.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_logout.FillColor = System.Drawing.Color.White
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.ForeColor = System.Drawing.Color.Black
        Me.btn_logout.Location = New System.Drawing.Point(21, 540)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(180, 45)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "LOGOUT"
        '
        'dgvClockRecords
        '
        Me.dgvClockRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClockRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClockRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvClockRecords.ColumnHeadersHeight = 31
        Me.dgvClockRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClockRecords.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvClockRecords.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClockRecords.Location = New System.Drawing.Point(315, 375)
        Me.dgvClockRecords.Name = "dgvClockRecords"
        Me.dgvClockRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClockRecords.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvClockRecords.RowHeadersVisible = False
        Me.dgvClockRecords.Size = New System.Drawing.Size(417, 150)
        Me.dgvClockRecords.TabIndex = 5
        Me.dgvClockRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvClockRecords.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClockRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvClockRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgvClockRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClockRecords.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvClockRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClockRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.dgvClockRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClockRecords.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClockRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvClockRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvClockRecords.ThemeStyle.HeaderStyle.Height = 31
        Me.dgvClockRecords.ThemeStyle.ReadOnly = False
        Me.dgvClockRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvClockRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClockRecords.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClockRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvClockRecords.ThemeStyle.RowsStyle.Height = 22
        Me.dgvClockRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgvClockRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Animated = True
        Me.Guna2DateTimePicker1.BorderRadius = 2
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.Black
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(424, 94)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShowUpDown = True
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(203, 63)
        Me.Guna2DateTimePicker1.TabIndex = 6
        Me.Guna2DateTimePicker1.Value = New Date(2024, 5, 19, 16, 30, 42, 901)
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(723, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(30, 29)
        Me.Guna2ControlBox2.TabIndex = 15
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(759, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(35, 29)
        Me.Guna2ControlBox1.TabIndex = 14
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.lbl_hours)
        Me.GunaGradient2Panel1.Controls.Add(Me.Label1)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.LightGray
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.DimGray
        Me.GunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(12, 273)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 10
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(206, 133)
        Me.GunaGradient2Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOURS WORKED IN WEEK"
        '
        'lbl_hours
        '
        Me.lbl_hours.AutoSize = True
        Me.lbl_hours.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hours.Location = New System.Drawing.Point(78, 61)
        Me.lbl_hours.Name = "lbl_hours"
        Me.lbl_hours.Size = New System.Drawing.Size(0, 37)
        Me.lbl_hours.TabIndex = 1
        '
        'Mechanic_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 625)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.dgvClockRecords)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_clockout)
        Me.Controls.Add(Me.btn_clockin)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mechanic_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mechanic_form"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClockRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_clockin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_clockout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvClockRecords As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents lbl_hours As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
End Class
