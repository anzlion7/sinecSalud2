<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrarExamenLab
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
        Me.panelExamen = New System.Windows.Forms.Panel()
        Me.lboxGrupos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hintArea = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxArea = New System.Windows.Forms.ComboBox()
        Me.chIndividual = New System.Windows.Forms.CheckBox()
        Me.hintExamen = New System.Windows.Forms.Label()
        Me.cboxExamen = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelExamen.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelExamen
        '
        Me.panelExamen.BackColor = System.Drawing.Color.White
        Me.panelExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelExamen.Controls.Add(Me.lboxGrupos)
        Me.panelExamen.Controls.Add(Me.Label4)
        Me.panelExamen.Controls.Add(Me.Label3)
        Me.panelExamen.Controls.Add(Me.hintArea)
        Me.panelExamen.Controls.Add(Me.Label2)
        Me.panelExamen.Controls.Add(Me.cboxArea)
        Me.panelExamen.Controls.Add(Me.chIndividual)
        Me.panelExamen.Controls.Add(Me.hintExamen)
        Me.panelExamen.Controls.Add(Me.cboxExamen)
        Me.panelExamen.Controls.Add(Me.Label9)
        Me.panelExamen.Location = New System.Drawing.Point(30, 75)
        Me.panelExamen.Name = "panelExamen"
        Me.panelExamen.Size = New System.Drawing.Size(690, 157)
        Me.panelExamen.TabIndex = 100
        '
        'lboxGrupos
        '
        Me.lboxGrupos.FormattingEnabled = True
        Me.lboxGrupos.Location = New System.Drawing.Point(349, 68)
        Me.lboxGrupos.Name = "lboxGrupos"
        Me.lboxGrupos.Size = New System.Drawing.Size(321, 69)
        Me.lboxGrupos.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 16)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Grupos a los que pertenece el examen seleccionado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Examen"
        '
        'hintArea
        '
        Me.hintArea.AutoSize = True
        Me.hintArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintArea.Location = New System.Drawing.Point(82, 50)
        Me.hintArea.Name = "hintArea"
        Me.hintArea.Size = New System.Drawing.Size(82, 13)
        Me.hintArea.TabIndex = 103
        Me.hintArea.Text = "SELECCIONAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Area"
        '
        'cboxArea
        '
        Me.cboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxArea.FormattingEnabled = True
        Me.cboxArea.Location = New System.Drawing.Point(77, 45)
        Me.cboxArea.Name = "cboxArea"
        Me.cboxArea.Size = New System.Drawing.Size(239, 23)
        Me.cboxArea.TabIndex = 102
        '
        'chIndividual
        '
        Me.chIndividual.AutoSize = True
        Me.chIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chIndividual.Location = New System.Drawing.Point(77, 118)
        Me.chIndividual.Name = "chIndividual"
        Me.chIndividual.Size = New System.Drawing.Size(239, 20)
        Me.chIndividual.TabIndex = 99
        Me.chIndividual.Text = "Se puede solicitar individualemente"
        Me.chIndividual.UseVisualStyleBackColor = True
        '
        'hintExamen
        '
        Me.hintExamen.AutoSize = True
        Me.hintExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintExamen.Location = New System.Drawing.Point(82, 85)
        Me.hintExamen.Name = "hintExamen"
        Me.hintExamen.Size = New System.Drawing.Size(82, 13)
        Me.hintExamen.TabIndex = 93
        Me.hintExamen.Text = "SELECCIONAR"
        '
        'cboxExamen
        '
        Me.cboxExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxExamen.FormattingEnabled = True
        Me.cboxExamen.Location = New System.Drawing.Point(77, 80)
        Me.cboxExamen.Name = "cboxExamen"
        Me.cboxExamen.Size = New System.Drawing.Size(239, 23)
        Me.cboxExamen.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "1.- Administrar examen"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(571, 249)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(149, 28)
        Me.btnEnviarDatos.TabIndex = 100
        Me.btnEnviarDatos.Text = "Aplicar cambios"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(684, 27)
        Me.TableLayoutPanel1.TabIndex = 101
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(132, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(419, 25)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "ADMINISTRAR EXAMEN DE LABORATORIO"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(751, 24)
        Me.menuStrip.TabIndex = 102
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
        Me.menuStripMenuLaboratorio.Size = New System.Drawing.Size(180, 22)
        Me.menuStripMenuLaboratorio.Text = "Menu laboratorio"
        '
        'FormAdministrarExamenLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 297)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panelExamen)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Name = "FormAdministrarExamenLab"
        Me.Text = "Administrar examen de laboratorio"
        Me.panelExamen.ResumeLayout(False)
        Me.panelExamen.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelExamen As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents hintExamen As Label
    Friend WithEvents cboxExamen As ComboBox
    Friend WithEvents chIndividual As CheckBox
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents hintArea As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxArea As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lboxGrupos As ListBox
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
