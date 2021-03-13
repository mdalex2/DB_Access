<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpConex = New System.Windows.Forms.GroupBox()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.btn_abrir = New System.Windows.Forms.Button()
        Me.txt_db = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listTablas = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listCampos = New System.Windows.Forms.ListBox()
        Me.dlg_open = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.TabResult = New System.Windows.Forms.TabControl()
        Me.TabPrincipal = New System.Windows.Forms.TabPage()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.TabResultado = New System.Windows.Forms.TabControl()
        Me.TabGrid = New System.Windows.Forms.TabPage()
        Me.dgResult = New System.Windows.Forms.DataGridView()
        Me.TabMSG = New System.Windows.Forms.TabPage()
        Me.txtMSG = New System.Windows.Forms.RichTextBox()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opcInsert = New System.Windows.Forms.RadioButton()
        Me.opcDelete = New System.Windows.Forms.RadioButton()
        Me.opcUpdate = New System.Windows.Forms.RadioButton()
        Me.opcSelect = New System.Windows.Forms.RadioButton()
        Me.lblNotifiy = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.grpConex.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabPrincipal.SuspendLayout()
        Me.TabResultado.SuspendLayout()
        Me.TabGrid.SuspendLayout()
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMSG.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConex
        '
        Me.grpConex.Controls.Add(Me.btn_conectar)
        Me.grpConex.Controls.Add(Me.btn_abrir)
        Me.grpConex.Controls.Add(Me.txt_db)
        Me.grpConex.Controls.Add(Me.Label1)
        Me.grpConex.Location = New System.Drawing.Point(12, 12)
        Me.grpConex.Name = "grpConex"
        Me.grpConex.Size = New System.Drawing.Size(485, 85)
        Me.grpConex.TabIndex = 0
        Me.grpConex.TabStop = False
        Me.grpConex.Text = "Conexión"
        '
        'btn_conectar
        '
        Me.btn_conectar.Location = New System.Drawing.Point(398, 56)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(75, 23)
        Me.btn_conectar.TabIndex = 3
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'btn_abrir
        '
        Me.btn_abrir.Location = New System.Drawing.Point(445, 22)
        Me.btn_abrir.Name = "btn_abrir"
        Me.btn_abrir.Size = New System.Drawing.Size(28, 20)
        Me.btn_abrir.TabIndex = 2
        Me.btn_abrir.Text = "..."
        Me.btn_abrir.UseVisualStyleBackColor = True
        '
        'txt_db
        '
        Me.txt_db.Location = New System.Drawing.Point(90, 22)
        Me.txt_db.Name = "txt_db"
        Me.txt_db.Size = New System.Drawing.Size(349, 20)
        Me.txt_db.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de datos:"
        '
        'listTablas
        '
        Me.listTablas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listTablas.FormattingEnabled = True
        Me.listTablas.Location = New System.Drawing.Point(12, 126)
        Me.listTablas.Name = "listTablas"
        Me.listTablas.Size = New System.Drawing.Size(221, 251)
        Me.listTablas.Sorted = True
        Me.listTablas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tablas"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Campos"
        '
        'listCampos
        '
        Me.listCampos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listCampos.FormattingEnabled = True
        Me.listCampos.Location = New System.Drawing.Point(12, 394)
        Me.listCampos.Name = "listCampos"
        Me.listCampos.Size = New System.Drawing.Size(221, 160)
        Me.listCampos.TabIndex = 4
        '
        'dlg_open
        '
        Me.dlg_open.FileName = "open_file"
        Me.dlg_open.Filter = "Archivos de BD Access|*.mdb"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(112, 56)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.ToolTip1.SetToolTip(Me.btnGenerar, "Generar Consulta")
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'TabResult
        '
        Me.TabResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabResult.Controls.Add(Me.TabPrincipal)
        Me.TabResult.Location = New System.Drawing.Point(239, 110)
        Me.TabResult.Name = "TabResult"
        Me.TabResult.SelectedIndex = 0
        Me.TabResult.Size = New System.Drawing.Size(828, 444)
        Me.TabResult.TabIndex = 6
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.btnLimpiar)
        Me.TabPrincipal.Controls.Add(Me.btnEjecutar)
        Me.TabPrincipal.Controls.Add(Me.TabResultado)
        Me.TabPrincipal.Controls.Add(Me.txtSQL)
        Me.TabPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrincipal.Size = New System.Drawing.Size(820, 418)
        Me.TabPrincipal.TabIndex = 0
        Me.TabPrincipal.Text = "Consulta SQL"
        Me.TabPrincipal.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Location = New System.Drawing.Point(739, 134)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEjecutar.Enabled = False
        Me.btnEjecutar.Location = New System.Drawing.Point(658, 134)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 5
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'TabResultado
        '
        Me.TabResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabResultado.Controls.Add(Me.TabGrid)
        Me.TabResultado.Controls.Add(Me.TabMSG)
        Me.TabResultado.Location = New System.Drawing.Point(6, 152)
        Me.TabResultado.Name = "TabResultado"
        Me.TabResultado.SelectedIndex = 0
        Me.TabResultado.Size = New System.Drawing.Size(808, 260)
        Me.TabResultado.TabIndex = 7
        '
        'TabGrid
        '
        Me.TabGrid.Controls.Add(Me.dgResult)
        Me.TabGrid.Location = New System.Drawing.Point(4, 22)
        Me.TabGrid.Name = "TabGrid"
        Me.TabGrid.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGrid.Size = New System.Drawing.Size(800, 234)
        Me.TabGrid.TabIndex = 0
        Me.TabGrid.Text = "Resultado"
        Me.TabGrid.UseVisualStyleBackColor = True
        '
        'dgResult
        '
        Me.dgResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResult.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgResult.Location = New System.Drawing.Point(6, 6)
        Me.dgResult.Name = "dgResult"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResult.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgResult.Size = New System.Drawing.Size(788, 222)
        Me.dgResult.TabIndex = 2
        '
        'TabMSG
        '
        Me.TabMSG.Controls.Add(Me.txtMSG)
        Me.TabMSG.Location = New System.Drawing.Point(4, 22)
        Me.TabMSG.Name = "TabMSG"
        Me.TabMSG.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMSG.Size = New System.Drawing.Size(800, 234)
        Me.TabMSG.TabIndex = 1
        Me.TabMSG.Text = "Mensajes"
        Me.TabMSG.UseVisualStyleBackColor = True
        '
        'txtMSG
        '
        Me.txtMSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMSG.Location = New System.Drawing.Point(0, 0)
        Me.txtMSG.Name = "txtMSG"
        Me.txtMSG.Size = New System.Drawing.Size(800, 231)
        Me.txtMSG.TabIndex = 0
        Me.txtMSG.Text = ""
        '
        'txtSQL
        '
        Me.txtSQL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQL.Location = New System.Drawing.Point(6, 6)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(808, 122)
        Me.txtSQL.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opcInsert)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.opcDelete)
        Me.GroupBox1.Controls.Add(Me.opcUpdate)
        Me.GroupBox1.Controls.Add(Me.opcSelect)
        Me.GroupBox1.Location = New System.Drawing.Point(517, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generador de consultas"
        '
        'opcInsert
        '
        Me.opcInsert.AutoSize = True
        Me.opcInsert.Location = New System.Drawing.Point(11, 48)
        Me.opcInsert.Name = "opcInsert"
        Me.opcInsert.Size = New System.Drawing.Size(51, 17)
        Me.opcInsert.TabIndex = 5
        Me.opcInsert.Text = "Insert"
        Me.opcInsert.UseVisualStyleBackColor = True
        '
        'opcDelete
        '
        Me.opcDelete.AutoSize = True
        Me.opcDelete.Location = New System.Drawing.Point(121, 25)
        Me.opcDelete.Name = "opcDelete"
        Me.opcDelete.Size = New System.Drawing.Size(56, 17)
        Me.opcDelete.TabIndex = 2
        Me.opcDelete.Text = "Delete"
        Me.opcDelete.UseVisualStyleBackColor = True
        '
        'opcUpdate
        '
        Me.opcUpdate.AutoSize = True
        Me.opcUpdate.Location = New System.Drawing.Point(11, 71)
        Me.opcUpdate.Name = "opcUpdate"
        Me.opcUpdate.Size = New System.Drawing.Size(60, 17)
        Me.opcUpdate.TabIndex = 1
        Me.opcUpdate.Text = "Update"
        Me.opcUpdate.UseVisualStyleBackColor = True
        '
        'opcSelect
        '
        Me.opcSelect.AutoSize = True
        Me.opcSelect.Checked = True
        Me.opcSelect.Location = New System.Drawing.Point(11, 24)
        Me.opcSelect.Name = "opcSelect"
        Me.opcSelect.Size = New System.Drawing.Size(55, 17)
        Me.opcSelect.TabIndex = 0
        Me.opcSelect.TabStop = True
        Me.opcSelect.Text = "Select"
        Me.opcSelect.UseVisualStyleBackColor = True
        '
        'lblNotifiy
        '
        Me.lblNotifiy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotifiy.BackColor = System.Drawing.Color.White
        Me.lblNotifiy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotifiy.Location = New System.Drawing.Point(732, 17)
        Me.lblNotifiy.Name = "lblNotifiy"
        Me.lblNotifiy.Size = New System.Drawing.Size(328, 95)
        Me.lblNotifiy.TabIndex = 8
        Me.lblNotifiy.Text = "..."
        Me.lblNotifiy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotifiy.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(982, 43)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 51)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 566)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lblNotifiy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listCampos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listTablas)
        Me.Controls.Add(Me.grpConex)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB Access Managent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpConex.ResumeLayout(False)
        Me.grpConex.PerformLayout()
        Me.TabResult.ResumeLayout(False)
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPrincipal.PerformLayout()
        Me.TabResultado.ResumeLayout(False)
        Me.TabGrid.ResumeLayout(False)
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMSG.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpConex As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_abrir As Button
    Friend WithEvents txt_db As TextBox
    Friend WithEvents listTablas As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listCampos As ListBox
    Friend WithEvents dlg_open As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_conectar As Button
    Friend WithEvents TabResult As TabControl
    Friend WithEvents TabPrincipal As TabPage
    Friend WithEvents txtSQL As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents opcDelete As RadioButton
    Friend WithEvents opcUpdate As RadioButton
    Friend WithEvents opcSelect As RadioButton
    Friend WithEvents btnGenerar As Button
    Friend WithEvents lblNotifiy As Label
    Friend WithEvents opcInsert As RadioButton
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents TabResultado As TabControl
    Friend WithEvents TabGrid As TabPage
    Friend WithEvents dgResult As DataGridView
    Friend WithEvents TabMSG As TabPage
    Friend WithEvents txtMSG As RichTextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btn_salir As Button
End Class
