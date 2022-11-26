<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministrarGrupoExamenLab
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hintArea = New System.Windows.Forms.Label()
        Me.cboxArea = New System.Windows.Forms.ComboBox()
        Me.dgvGrupos = New System.Windows.Forms.DataGridView()
        Me.panelEliminarExamen = New System.Windows.Forms.Panel()
        Me.btnGuardarEliExa = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.dgvExamenesEliExa = New System.Windows.Forms.DataGridView()
        Me.btnAgregarAgrExa = New System.Windows.Forms.Button()
        Me.hintExamenAgrExa = New System.Windows.Forms.Label()
        Me.cboxExamenAgrExa = New System.Windows.Forms.ComboBox()
        Me.panelArea = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.panelGrupo = New System.Windows.Forms.Panel()
        Me.hintAccion = New System.Windows.Forms.Label()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.cboxAccion = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panelAgregarExamen = New System.Windows.Forms.Panel()
        Me.dgvExamenesAgrExa = New System.Windows.Forms.DataGridView()
        Me.btnGuardarAgrExa = New System.Windows.Forms.Button()
        Me.dgvNuevosExamenesAgrExa = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEliminarExamen.SuspendLayout()
        CType(Me.dgvExamenesEliExa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelArea.SuspendLayout()
        Me.panelGrupo.SuspendLayout()
        Me.panelAgregarExamen.SuspendLayout()
        CType(Me.dgvExamenesAgrExa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNuevosExamenesAgrExa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1208, 27)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(365, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(477, 25)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "ADMINISTRAR GRUPOS EXAMEN LABORATORIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Area"
        '
        'hintArea
        '
        Me.hintArea.AutoSize = True
        Me.hintArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintArea.Location = New System.Drawing.Point(65, 50)
        Me.hintArea.Name = "hintArea"
        Me.hintArea.Size = New System.Drawing.Size(82, 13)
        Me.hintArea.TabIndex = 95
        Me.hintArea.Text = "SELECCIONAR"
        '
        'cboxArea
        '
        Me.cboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxArea.FormattingEnabled = True
        Me.cboxArea.Location = New System.Drawing.Point(60, 45)
        Me.cboxArea.Name = "cboxArea"
        Me.cboxArea.Size = New System.Drawing.Size(276, 23)
        Me.cboxArea.TabIndex = 94
        '
        'dgvGrupos
        '
        Me.dgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrupos.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvGrupos.Location = New System.Drawing.Point(18, 45)
        Me.dgvGrupos.Name = "dgvGrupos"
        Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupos.Size = New System.Drawing.Size(318, 152)
        Me.dgvGrupos.TabIndex = 96
        '
        'panelEliminarExamen
        '
        Me.panelEliminarExamen.BackColor = System.Drawing.Color.White
        Me.panelEliminarExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEliminarExamen.Controls.Add(Me.btnGuardarEliExa)
        Me.panelEliminarExamen.Controls.Add(Me.Label35)
        Me.panelEliminarExamen.Controls.Add(Me.dgvExamenesEliExa)
        Me.panelEliminarExamen.Location = New System.Drawing.Point(400, 70)
        Me.panelEliminarExamen.Name = "panelEliminarExamen"
        Me.panelEliminarExamen.Size = New System.Drawing.Size(838, 226)
        Me.panelEliminarExamen.TabIndex = 101
        '
        'btnGuardarEliExa
        '
        Me.btnGuardarEliExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEliExa.Location = New System.Drawing.Point(555, 182)
        Me.btnGuardarEliExa.Name = "btnGuardarEliExa"
        Me.btnGuardarEliExa.Size = New System.Drawing.Size(263, 28)
        Me.btnGuardarEliExa.TabIndex = 131
        Me.btnGuardarEliExa.Text = "ELIMINAR EXAMENES SELECCIONADOS"
        Me.btnGuardarEliExa.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(15, 15)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(250, 18)
        Me.Label35.TabIndex = 128
        Me.Label35.Text = "3.- Eliminar examenes del grupo"
        '
        'dgvExamenesEliExa
        '
        Me.dgvExamenesEliExa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExamenesEliExa.BackgroundColor = System.Drawing.Color.White
        Me.dgvExamenesEliExa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExamenesEliExa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvExamenesEliExa.Location = New System.Drawing.Point(15, 45)
        Me.dgvExamenesEliExa.Name = "dgvExamenesEliExa"
        Me.dgvExamenesEliExa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExamenesEliExa.Size = New System.Drawing.Size(803, 122)
        Me.dgvExamenesEliExa.TabIndex = 103
        '
        'btnAgregarAgrExa
        '
        Me.btnAgregarAgrExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.259!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAgrExa.Location = New System.Drawing.Point(727, 74)
        Me.btnAgregarAgrExa.Name = "btnAgregarAgrExa"
        Me.btnAgregarAgrExa.Size = New System.Drawing.Size(91, 24)
        Me.btnAgregarAgrExa.TabIndex = 126
        Me.btnAgregarAgrExa.Text = "Agregar"
        Me.btnAgregarAgrExa.UseVisualStyleBackColor = True
        '
        'hintExamenAgrExa
        '
        Me.hintExamenAgrExa.AutoSize = True
        Me.hintExamenAgrExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintExamenAgrExa.Location = New System.Drawing.Point(456, 50)
        Me.hintExamenAgrExa.Name = "hintExamenAgrExa"
        Me.hintExamenAgrExa.Size = New System.Drawing.Size(82, 13)
        Me.hintExamenAgrExa.TabIndex = 118
        Me.hintExamenAgrExa.Text = "SELECCIONAR"
        '
        'cboxExamenAgrExa
        '
        Me.cboxExamenAgrExa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExamenAgrExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxExamenAgrExa.FormattingEnabled = True
        Me.cboxExamenAgrExa.Location = New System.Drawing.Point(451, 45)
        Me.cboxExamenAgrExa.Name = "cboxExamenAgrExa"
        Me.cboxExamenAgrExa.Size = New System.Drawing.Size(367, 23)
        Me.cboxExamenAgrExa.TabIndex = 117
        '
        'panelArea
        '
        Me.panelArea.BackColor = System.Drawing.Color.White
        Me.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelArea.Controls.Add(Me.hintArea)
        Me.panelArea.Controls.Add(Me.Label41)
        Me.panelArea.Controls.Add(Me.Label3)
        Me.panelArea.Controls.Add(Me.cboxArea)
        Me.panelArea.Location = New System.Drawing.Point(27, 70)
        Me.panelArea.Name = "panelArea"
        Me.panelArea.Size = New System.Drawing.Size(355, 81)
        Me.panelArea.TabIndex = 102
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
        'panelGrupo
        '
        Me.panelGrupo.BackColor = System.Drawing.Color.White
        Me.panelGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGrupo.Controls.Add(Me.hintAccion)
        Me.panelGrupo.Controls.Add(Me.lblAccion)
        Me.panelGrupo.Controls.Add(Me.cboxAccion)
        Me.panelGrupo.Controls.Add(Me.Label26)
        Me.panelGrupo.Controls.Add(Me.dgvGrupos)
        Me.panelGrupo.Location = New System.Drawing.Point(27, 172)
        Me.panelGrupo.Name = "panelGrupo"
        Me.panelGrupo.Size = New System.Drawing.Size(355, 259)
        Me.panelGrupo.TabIndex = 103
        '
        'hintAccion
        '
        Me.hintAccion.AutoSize = True
        Me.hintAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintAccion.Location = New System.Drawing.Point(73, 215)
        Me.hintAccion.Name = "hintAccion"
        Me.hintAccion.Size = New System.Drawing.Size(82, 13)
        Me.hintAccion.TabIndex = 99
        Me.hintAccion.Text = "SELECCIONAR"
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.Location = New System.Drawing.Point(15, 213)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(48, 16)
        Me.lblAccion.TabIndex = 97
        Me.lblAccion.Text = "Acción"
        '
        'cboxAccion
        '
        Me.cboxAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAccion.FormattingEnabled = True
        Me.cboxAccion.Location = New System.Drawing.Point(68, 210)
        Me.cboxAccion.Name = "cboxAccion"
        Me.cboxAccion.Size = New System.Drawing.Size(268, 23)
        Me.cboxAccion.TabIndex = 98
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(15, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(175, 18)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "2.- Seleccionar grupo "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(389, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "Examen"
        '
        'panelAgregarExamen
        '
        Me.panelAgregarExamen.BackColor = System.Drawing.Color.White
        Me.panelAgregarExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAgregarExamen.Controls.Add(Me.dgvExamenesAgrExa)
        Me.panelAgregarExamen.Controls.Add(Me.btnGuardarAgrExa)
        Me.panelAgregarExamen.Controls.Add(Me.dgvNuevosExamenesAgrExa)
        Me.panelAgregarExamen.Controls.Add(Me.hintExamenAgrExa)
        Me.panelAgregarExamen.Controls.Add(Me.Label20)
        Me.panelAgregarExamen.Controls.Add(Me.btnAgregarAgrExa)
        Me.panelAgregarExamen.Controls.Add(Me.Label12)
        Me.panelAgregarExamen.Controls.Add(Me.cboxExamenAgrExa)
        Me.panelAgregarExamen.Location = New System.Drawing.Point(400, 70)
        Me.panelAgregarExamen.Name = "panelAgregarExamen"
        Me.panelAgregarExamen.Size = New System.Drawing.Size(838, 361)
        Me.panelAgregarExamen.TabIndex = 131
        '
        'dgvExamenesAgrExa
        '
        Me.dgvExamenesAgrExa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExamenesAgrExa.BackgroundColor = System.Drawing.Color.White
        Me.dgvExamenesAgrExa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExamenesAgrExa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvExamenesAgrExa.Location = New System.Drawing.Point(15, 45)
        Me.dgvExamenesAgrExa.Name = "dgvExamenesAgrExa"
        Me.dgvExamenesAgrExa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExamenesAgrExa.Size = New System.Drawing.Size(349, 298)
        Me.dgvExamenesAgrExa.TabIndex = 133
        '
        'btnGuardarAgrExa
        '
        Me.btnGuardarAgrExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAgrExa.Location = New System.Drawing.Point(392, 317)
        Me.btnGuardarAgrExa.Name = "btnGuardarAgrExa"
        Me.btnGuardarAgrExa.Size = New System.Drawing.Size(426, 28)
        Me.btnGuardarAgrExa.TabIndex = 132
        Me.btnGuardarAgrExa.Text = "AGREGAR NUEVOS EXAMENES AL GRUPO"
        Me.btnGuardarAgrExa.UseVisualStyleBackColor = True
        '
        'dgvNuevosExamenesAgrExa
        '
        Me.dgvNuevosExamenesAgrExa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNuevosExamenesAgrExa.BackgroundColor = System.Drawing.Color.White
        Me.dgvNuevosExamenesAgrExa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNuevosExamenesAgrExa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvNuevosExamenesAgrExa.Location = New System.Drawing.Point(392, 105)
        Me.dgvNuevosExamenesAgrExa.Name = "dgvNuevosExamenesAgrExa"
        Me.dgvNuevosExamenesAgrExa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNuevosExamenesAgrExa.Size = New System.Drawing.Size(426, 206)
        Me.dgvNuevosExamenesAgrExa.TabIndex = 130
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(15, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(238, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "3.- Agregar examenes al grupo"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1264, 24)
        Me.menuStrip.TabIndex = 132
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
        'FormAdministrarGrupoExamenLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.panelAgregarExamen)
        Me.Controls.Add(Me.panelGrupo)
        Me.Controls.Add(Me.panelArea)
        Me.Controls.Add(Me.panelEliminarExamen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormAdministrarGrupoExamenLab"
        Me.Text = "ADMINISTRAR GRUPOS EXAMEN LABORATORIOADMINISTRAR GRUPOS EXAMEN LABORATORIO"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEliminarExamen.ResumeLayout(False)
        Me.panelEliminarExamen.PerformLayout()
        CType(Me.dgvExamenesEliExa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelArea.ResumeLayout(False)
        Me.panelArea.PerformLayout()
        Me.panelGrupo.ResumeLayout(False)
        Me.panelGrupo.PerformLayout()
        Me.panelAgregarExamen.ResumeLayout(False)
        Me.panelAgregarExamen.PerformLayout()
        CType(Me.dgvExamenesAgrExa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNuevosExamenesAgrExa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hintArea As Label
    Friend WithEvents cboxArea As ComboBox
    Friend WithEvents dgvGrupos As DataGridView
    Friend WithEvents panelEliminarExamen As Panel
    Friend WithEvents dgvExamenesEliExa As DataGridView
    Friend WithEvents hintExamenAgrExa As Label
    Friend WithEvents cboxExamenAgrExa As ComboBox
    Friend WithEvents btnAgregarAgrExa As Button
    Friend WithEvents panelArea As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents panelGrupo As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents btnGuardarEliExa As Button
    Friend WithEvents panelAgregarExamen As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
    Friend WithEvents dgvNuevosExamenesAgrExa As DataGridView
    Friend WithEvents btnGuardarAgrExa As Button
    Friend WithEvents hintAccion As Label
    Friend WithEvents lblAccion As Label
    Friend WithEvents cboxAccion As ComboBox
    Friend WithEvents dgvExamenesAgrExa As DataGridView
End Class
