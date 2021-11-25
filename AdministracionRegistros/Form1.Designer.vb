<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cb_municipio = New System.Windows.Forms.ComboBox()
        Me.cb_depto = New System.Windows.Forms.ComboBox()
        Me.cb_nacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.dgv_registros = New System.Windows.Forms.DataGridView()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nacionalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_depto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_registros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_municipio
        '
        Me.cb_municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_municipio.FormattingEnabled = True
        Me.cb_municipio.Location = New System.Drawing.Point(573, 91)
        Me.cb_municipio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_municipio.Name = "cb_municipio"
        Me.cb_municipio.Size = New System.Drawing.Size(151, 24)
        Me.cb_municipio.TabIndex = 0
        '
        'cb_depto
        '
        Me.cb_depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_depto.FormattingEnabled = True
        Me.cb_depto.Location = New System.Drawing.Point(395, 91)
        Me.cb_depto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_depto.Name = "cb_depto"
        Me.cb_depto.Size = New System.Drawing.Size(151, 24)
        Me.cb_depto.TabIndex = 0
        '
        'cb_nacionalidad
        '
        Me.cb_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_nacionalidad.FormattingEnabled = True
        Me.cb_nacionalidad.Location = New System.Drawing.Point(222, 91)
        Me.cb_nacionalidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_nacionalidad.Name = "cb_nacionalidad"
        Me.cb_nacionalidad.Size = New System.Drawing.Size(151, 24)
        Me.cb_nacionalidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(573, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Depto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nacionalidad"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(48, 91)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(125, 22)
        Me.txt_name.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(48, 66)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(58, 17)
        Me.Nombre.TabIndex = 1
        Me.Nombre.Text = "Nombre"
        '
        'dgv_registros
        '
        Me.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_nacionalidad, Me.col_depto, Me.col_municipio})
        Me.dgv_registros.Location = New System.Drawing.Point(48, 186)
        Me.dgv_registros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_registros.Name = "dgv_registros"
        Me.dgv_registros.RowHeadersWidth = 51
        Me.dgv_registros.RowTemplate.Height = 29
        Me.dgv_registros.Size = New System.Drawing.Size(688, 272)
        Me.dgv_registros.TabIndex = 3
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(629, 145)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(94, 26)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.MinimumWidth = 6
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Width = 125
        '
        'col_nacionalidad
        '
        Me.col_nacionalidad.HeaderText = "Nacionalidad"
        Me.col_nacionalidad.MinimumWidth = 6
        Me.col_nacionalidad.Name = "col_nacionalidad"
        Me.col_nacionalidad.Width = 125
        '
        'col_depto
        '
        Me.col_depto.HeaderText = "Depto"
        Me.col_depto.MinimumWidth = 6
        Me.col_depto.Name = "col_depto"
        Me.col_depto.Width = 125
        '
        'col_municipio
        '
        Me.col_municipio.HeaderText = "Municipio"
        Me.col_municipio.MinimumWidth = 6
        Me.col_municipio.Name = "col_municipio"
        Me.col_municipio.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 538)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_registros)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_nacionalidad)
        Me.Controls.Add(Me.cb_depto)
        Me.Controls.Add(Me.cb_municipio)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_registros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_municipio As ComboBox
    Friend WithEvents cb_depto As ComboBox
    Friend WithEvents cb_nacionalidad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents dgv_registros As DataGridView
    Friend WithEvents btn_agregar As Button
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_nacionalidad As DataGridViewTextBoxColumn
    Friend WithEvents col_depto As DataGridViewTextBoxColumn
    Friend WithEvents col_municipio As DataGridViewTextBoxColumn
End Class
