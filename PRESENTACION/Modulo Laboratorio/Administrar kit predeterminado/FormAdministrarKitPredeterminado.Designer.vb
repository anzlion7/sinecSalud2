<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrarKitPredeterminado
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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelExamen = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKitPredeterminado = New System.Windows.Forms.TextBox()
        Me.hintKit = New System.Windows.Forms.Label()
        Me.cboxKit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarExamen = New System.Windows.Forms.Button()
        Me.txtBuscarExamen = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cboxExamen = New System.Windows.Forms.ComboBox()
        Me.dgvReferencias = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.hintExamen = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelExamen.SuspendLayout()
        CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1244, 24)
        Me.menuStrip.TabIndex = 133
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1200, 27)
        Me.TableLayoutPanel1.TabIndex = 134
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(394, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(412, 25)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "ASIGNAR KIT-EQUIPO PREDETERMINADO"
        '
        'panelExamen
        '
        Me.panelExamen.BackColor = System.Drawing.Color.White
        Me.panelExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelExamen.Controls.Add(Me.hintExamen)
        Me.panelExamen.Controls.Add(Me.Label4)
        Me.panelExamen.Controls.Add(Me.txtKitPredeterminado)
        Me.panelExamen.Controls.Add(Me.hintKit)
        Me.panelExamen.Controls.Add(Me.cboxKit)
        Me.panelExamen.Controls.Add(Me.Label1)
        Me.panelExamen.Controls.Add(Me.btnBuscarExamen)
        Me.panelExamen.Controls.Add(Me.txtBuscarExamen)
        Me.panelExamen.Controls.Add(Me.lblArea)
        Me.panelExamen.Controls.Add(Me.Label41)
        Me.panelExamen.Controls.Add(Me.cboxExamen)
        Me.panelExamen.Location = New System.Drawing.Point(20, 86)
        Me.panelExamen.Name = "panelExamen"
        Me.panelExamen.Size = New System.Drawing.Size(396, 233)
        Me.panelExamen.TabIndex = 135
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 16)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Kit-Equipo predeterminado actual"
        '
        'txtKitPredeterminado
        '
        Me.txtKitPredeterminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKitPredeterminado.Location = New System.Drawing.Point(25, 130)
        Me.txtKitPredeterminado.Name = "txtKitPredeterminado"
        Me.txtKitPredeterminado.Size = New System.Drawing.Size(279, 21)
        Me.txtKitPredeterminado.TabIndex = 102
        '
        'hintKit
        '
        Me.hintKit.AutoSize = True
        Me.hintKit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintKit.Location = New System.Drawing.Point(24, 191)
        Me.hintKit.Name = "hintKit"
        Me.hintKit.Size = New System.Drawing.Size(82, 13)
        Me.hintKit.TabIndex = 101
        Me.hintKit.Text = "SELECCIONAR"
        '
        'cboxKit
        '
        Me.cboxKit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxKit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxKit.FormattingEnabled = True
        Me.cboxKit.Location = New System.Drawing.Point(18, 185)
        Me.cboxKit.Name = "cboxKit"
        Me.cboxKit.Size = New System.Drawing.Size(286, 23)
        Me.cboxKit.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 16)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Nuevo Kit-Equipo predeterminado"
        '
        'btnBuscarExamen
        '
        Me.btnBuscarExamen.Location = New System.Drawing.Point(310, 45)
        Me.btnBuscarExamen.Name = "btnBuscarExamen"
        Me.btnBuscarExamen.Size = New System.Drawing.Size(57, 23)
        Me.btnBuscarExamen.TabIndex = 98
        Me.btnBuscarExamen.Text = "Buscar"
        Me.btnBuscarExamen.UseVisualStyleBackColor = True
        '
        'txtBuscarExamen
        '
        Me.txtBuscarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarExamen.Location = New System.Drawing.Point(76, 45)
        Me.txtBuscarExamen.Name = "txtBuscarExamen"
        Me.txtBuscarExamen.Size = New System.Drawing.Size(228, 21)
        Me.txtBuscarExamen.TabIndex = 97
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(15, 45)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(56, 16)
        Me.lblArea.TabIndex = 96
        Me.lblArea.Text = "Examen"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(15, 15)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(160, 18)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "1.- Seleccionar area"
        '
        'cboxExamen
        '
        Me.cboxExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxExamen.FormattingEnabled = True
        Me.cboxExamen.Location = New System.Drawing.Point(18, 75)
        Me.cboxExamen.Name = "cboxExamen"
        Me.cboxExamen.Size = New System.Drawing.Size(349, 23)
        Me.cboxExamen.TabIndex = 94
        '
        'dgvReferencias
        '
        Me.dgvReferencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReferencias.BackgroundColor = System.Drawing.Color.White
        Me.dgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column3, Me.Column4, Me.Column8, Me.Column9, Me.Column1, Me.Column2, Me.Column6, Me.Column7})
        Me.dgvReferencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvReferencias.Location = New System.Drawing.Point(432, 120)
        Me.dgvReferencias.Name = "dgvReferencias"
        Me.dgvReferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReferencias.Size = New System.Drawing.Size(788, 199)
        Me.dgvReferencias.TabIndex = 136
        '
        'Column5
        '
        Me.Column5.HeaderText = "SEXO"
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "EDAD INICIAL"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "EDAD FINAL"
        Me.Column4.Name = "Column4"
        '
        'Column8
        '
        Me.Column8.HeaderText = "VALOR INICIAL GENERAL"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "VALOR FINAL GENERAL"
        Me.Column9.Name = "Column9"
        '
        'Column1
        '
        Me.Column1.HeaderText = "VALOR INICIAL MASCULINO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "VALOR FINAL MASCULINO"
        Me.Column2.Name = "Column2"
        '
        'Column6
        '
        Me.Column6.HeaderText = "VALOR INICIAL FEMENINO"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "VALOR FINAL MENENINO"
        Me.Column7.Name = "Column7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(429, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 16)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "VALORES DE REFERENCIA"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(1047, 508)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(173, 28)
        Me.btnEnviarDatos.TabIndex = 138
        Me.btnEnviarDatos.Text = "Guardar cambios"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'hintExamen
        '
        Me.hintExamen.AutoSize = True
        Me.hintExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintExamen.Location = New System.Drawing.Point(23, 80)
        Me.hintExamen.Name = "hintExamen"
        Me.hintExamen.Size = New System.Drawing.Size(82, 13)
        Me.hintExamen.TabIndex = 104
        Me.hintExamen.Text = "SELECCIONAR"
        '
        'FormAdministrarKitPredeterminado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 561)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvReferencias)
        Me.Controls.Add(Me.panelExamen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.menuStrip)
        Me.Name = "FormAdministrarKitPredeterminado"
        Me.Text = "FormAdministrarKitPredeterminado"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelExamen.ResumeLayout(False)
        Me.panelExamen.PerformLayout()
        CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelExamen As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents cboxExamen As ComboBox
    Friend WithEvents btnBuscarExamen As Button
    Friend WithEvents txtBuscarExamen As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents hintKit As Label
    Friend WithEvents cboxKit As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReferencias As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKitPredeterminado As TextBox
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents hintExamen As Label
End Class
