<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarOrdenLaboratorio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.clistExamenesSolicitables = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvExamenesSolicitables = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.lboxAreas = New System.Windows.Forms.ListBox()
        Me.btnAgregarExamenes = New System.Windows.Forms.Button()
        Me.cboxMedico = New System.Windows.Forms.ComboBox()
        Me.cboxAsegurado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelDatosExamen = New System.Windows.Forms.Panel()
        Me.btnBuscarAsegurado = New System.Windows.Forms.Button()
        Me.txtBuscarAsegurado = New System.Windows.Forms.TextBox()
        Me.hintAsegurado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarMedico = New System.Windows.Forms.Button()
        Me.txtBuscarMedico = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.hintMedico = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvExamenesSolicitables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosExamen.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1198, 22)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(436, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(326, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR ORDEN DE LABORATORIO"
        '
        'clistExamenesSolicitables
        '
        Me.clistExamenesSolicitables.CheckOnClick = True
        Me.clistExamenesSolicitables.FormattingEnabled = True
        Me.clistExamenesSolicitables.Location = New System.Drawing.Point(238, 36)
        Me.clistExamenesSolicitables.MultiColumn = True
        Me.clistExamenesSolicitables.Name = "clistExamenesSolicitables"
        Me.clistExamenesSolicitables.Size = New System.Drawing.Size(449, 214)
        Me.clistExamenesSolicitables.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Examenes"
        '
        'dgvExamenesSolicitables
        '
        Me.dgvExamenesSolicitables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExamenesSolicitables.BackgroundColor = System.Drawing.Color.White
        Me.dgvExamenesSolicitables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExamenesSolicitables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvExamenesSolicitables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvExamenesSolicitables.Location = New System.Drawing.Point(707, 36)
        Me.dgvExamenesSolicitables.Name = "dgvExamenesSolicitables"
        Me.dgvExamenesSolicitables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExamenesSolicitables.Size = New System.Drawing.Size(468, 185)
        Me.dgvExamenesSolicitables.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.FillWeight = 75.0!
        Me.Column1.HeaderText = "EXAMEN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.FillWeight = 25.0!
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(1055, 515)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(173, 28)
        Me.btnEnviarDatos.TabIndex = 9
        Me.btnEnviarDatos.Text = "Registrar orden"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'lboxAreas
        '
        Me.lboxAreas.FormattingEnabled = True
        Me.lboxAreas.Location = New System.Drawing.Point(18, 65)
        Me.lboxAreas.Name = "lboxAreas"
        Me.lboxAreas.Size = New System.Drawing.Size(200, 225)
        Me.lboxAreas.TabIndex = 5
        '
        'btnAgregarExamenes
        '
        Me.btnAgregarExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarExamenes.Location = New System.Drawing.Point(238, 262)
        Me.btnAgregarExamenes.Name = "btnAgregarExamenes"
        Me.btnAgregarExamenes.Size = New System.Drawing.Size(449, 28)
        Me.btnAgregarExamenes.TabIndex = 7
        Me.btnAgregarExamenes.Text = "AGREGAR EXAMENES"
        Me.btnAgregarExamenes.UseVisualStyleBackColor = True
        '
        'cboxMedico
        '
        Me.cboxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMedico.FormattingEnabled = True
        Me.cboxMedico.Location = New System.Drawing.Point(15, 75)
        Me.cboxMedico.Name = "cboxMedico"
        Me.cboxMedico.Size = New System.Drawing.Size(360, 23)
        Me.cboxMedico.TabIndex = 10
        '
        'cboxAsegurado
        '
        Me.cboxAsegurado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAsegurado.FormattingEnabled = True
        Me.cboxAsegurado.Location = New System.Drawing.Point(403, 75)
        Me.cboxAsegurado.Name = "cboxAsegurado"
        Me.cboxAsegurado.Size = New System.Drawing.Size(358, 23)
        Me.cboxAsegurado.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "1.- Asignar orden"
        '
        'panelDatosExamen
        '
        Me.panelDatosExamen.BackColor = System.Drawing.Color.White
        Me.panelDatosExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosExamen.Controls.Add(Me.btnBuscarAsegurado)
        Me.panelDatosExamen.Controls.Add(Me.txtBuscarAsegurado)
        Me.panelDatosExamen.Controls.Add(Me.hintAsegurado)
        Me.panelDatosExamen.Controls.Add(Me.Label4)
        Me.panelDatosExamen.Controls.Add(Me.btnBuscarMedico)
        Me.panelDatosExamen.Controls.Add(Me.txtBuscarMedico)
        Me.panelDatosExamen.Controls.Add(Me.lblArea)
        Me.panelDatosExamen.Controls.Add(Me.cboxAsegurado)
        Me.panelDatosExamen.Controls.Add(Me.hintMedico)
        Me.panelDatosExamen.Controls.Add(Me.cboxMedico)
        Me.panelDatosExamen.Controls.Add(Me.Label9)
        Me.panelDatosExamen.Location = New System.Drawing.Point(30, 65)
        Me.panelDatosExamen.Name = "panelDatosExamen"
        Me.panelDatosExamen.Size = New System.Drawing.Size(780, 115)
        Me.panelDatosExamen.TabIndex = 13
        '
        'btnBuscarAsegurado
        '
        Me.btnBuscarAsegurado.Location = New System.Drawing.Point(699, 45)
        Me.btnBuscarAsegurado.Name = "btnBuscarAsegurado"
        Me.btnBuscarAsegurado.Size = New System.Drawing.Size(62, 23)
        Me.btnBuscarAsegurado.TabIndex = 96
        Me.btnBuscarAsegurado.Text = "Buscar"
        Me.btnBuscarAsegurado.UseVisualStyleBackColor = True
        '
        'txtBuscarAsegurado
        '
        Me.txtBuscarAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarAsegurado.Location = New System.Drawing.Point(480, 45)
        Me.txtBuscarAsegurado.Name = "txtBuscarAsegurado"
        Me.txtBuscarAsegurado.Size = New System.Drawing.Size(213, 21)
        Me.txtBuscarAsegurado.TabIndex = 95
        '
        'hintAsegurado
        '
        Me.hintAsegurado.AutoSize = True
        Me.hintAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintAsegurado.Location = New System.Drawing.Point(408, 80)
        Me.hintAsegurado.Name = "hintAsegurado"
        Me.hintAsegurado.Size = New System.Drawing.Size(82, 13)
        Me.hintAsegurado.TabIndex = 94
        Me.hintAsegurado.Text = "SELECCIONAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Ásegurado"
        '
        'btnBuscarMedico
        '
        Me.btnBuscarMedico.Location = New System.Drawing.Point(318, 45)
        Me.btnBuscarMedico.Name = "btnBuscarMedico"
        Me.btnBuscarMedico.Size = New System.Drawing.Size(57, 23)
        Me.btnBuscarMedico.TabIndex = 75
        Me.btnBuscarMedico.Text = "Buscar"
        Me.btnBuscarMedico.UseVisualStyleBackColor = True
        '
        'txtBuscarMedico
        '
        Me.txtBuscarMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMedico.Location = New System.Drawing.Point(72, 45)
        Me.txtBuscarMedico.Name = "txtBuscarMedico"
        Me.txtBuscarMedico.Size = New System.Drawing.Size(238, 21)
        Me.txtBuscarMedico.TabIndex = 74
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(15, 47)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(52, 16)
        Me.lblArea.TabIndex = 73
        Me.lblArea.Text = "Médico"
        '
        'hintMedico
        '
        Me.hintMedico.AutoSize = True
        Me.hintMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintMedico.Location = New System.Drawing.Point(27, 80)
        Me.hintMedico.Name = "hintMedico"
        Me.hintMedico.Size = New System.Drawing.Size(82, 13)
        Me.hintMedico.TabIndex = 93
        Me.hintMedico.Text = "SELECCIONAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lboxAreas)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnAgregarExamenes)
        Me.Panel1.Controls.Add(Me.txtNota)
        Me.Panel1.Controls.Add(Me.dgvExamenesSolicitables)
        Me.Panel1.Controls.Add(Me.clistExamenesSolicitables)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(30, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 310)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(704, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Examenes agregados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(704, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "NOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Areas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(15, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "2.- Seleccionar examenes"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(707, 252)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(468, 38)
        Me.txtNota.TabIndex = 16
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1264, 24)
        Me.menuStrip.TabIndex = 15
        Me.menuStrip.Text = "MenuStrip1"
        '
        'menuStripMenu
        '
        Me.menuStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenuLaboratorio})
        Me.menuStripMenu.Name = "menuStripMenu"
        Me.menuStripMenu.Size = New System.Drawing.Size(50, 20)
        Me.menuStripMenu.Text = "Menu"
        '
        'menuStripMenuLaboratorio
        '
        Me.menuStripMenuLaboratorio.Name = "menuStripMenuLaboratorio"
        Me.menuStripMenuLaboratorio.Size = New System.Drawing.Size(166, 22)
        Me.menuStripMenuLaboratorio.Text = "Menu laboratorio"
        '
        'FormRegistrarOrdenLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelDatosExamen)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "FormRegistrarOrdenLaboratorio"
        Me.Text = "Registrar orden de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvExamenesSolicitables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosExamen.ResumeLayout(False)
        Me.panelDatosExamen.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents clistExamenesSolicitables As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvExamenesSolicitables As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnviarDatos As System.Windows.Forms.Button
    Friend WithEvents lboxAreas As System.Windows.Forms.ListBox
    Friend WithEvents btnAgregarExamenes As System.Windows.Forms.Button
    Friend WithEvents cboxMedico As ComboBox
    Friend WithEvents cboxAsegurado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents panelDatosExamen As Panel
    Friend WithEvents hintAsegurado As Label
    Friend WithEvents hintMedico As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNota As TextBox
    Friend WithEvents txtBuscarMedico As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents btnBuscarMedico As Button
    Friend WithEvents btnBuscarAsegurado As Button
    Friend WithEvents txtBuscarAsegurado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
