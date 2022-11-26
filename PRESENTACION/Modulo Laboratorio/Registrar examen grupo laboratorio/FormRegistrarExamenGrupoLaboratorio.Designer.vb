<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarExamenGrupoLaboratorio
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
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelExamen = New System.Windows.Forms.Panel()
        Me.hintArea = New System.Windows.Forms.Label()
        Me.cboxArea = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExamen = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.menuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelExamen.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(484, 24)
        Me.menuStrip.TabIndex = 11
        Me.menuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmItemMenuLaboratorio})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'tsmItemMenuLaboratorio
        '
        Me.tsmItemMenuLaboratorio.Name = "tsmItemMenuLaboratorio"
        Me.tsmItemMenuLaboratorio.Size = New System.Drawing.Size(169, 22)
        Me.tsmItemMenuLaboratorio.Text = "Menu Laboratorio"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(424, 23)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(8, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(407, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR EXANEN GRUPAL DE LABORATORIO"
        '
        'panelExamen
        '
        Me.panelExamen.BackColor = System.Drawing.Color.White
        Me.panelExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelExamen.Controls.Add(Me.hintArea)
        Me.panelExamen.Controls.Add(Me.cboxArea)
        Me.panelExamen.Controls.Add(Me.Label2)
        Me.panelExamen.Controls.Add(Me.txtExamen)
        Me.panelExamen.Controls.Add(Me.label10)
        Me.panelExamen.Controls.Add(Me.Label4)
        Me.panelExamen.Location = New System.Drawing.Point(30, 68)
        Me.panelExamen.Name = "panelExamen"
        Me.panelExamen.Size = New System.Drawing.Size(424, 120)
        Me.panelExamen.TabIndex = 13
        '
        'hintArea
        '
        Me.hintArea.AutoSize = True
        Me.hintArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintArea.Location = New System.Drawing.Point(154, 85)
        Me.hintArea.Name = "hintArea"
        Me.hintArea.Size = New System.Drawing.Size(82, 13)
        Me.hintArea.TabIndex = 21
        Me.hintArea.Text = "SELECCIONAR"
        '
        'cboxArea
        '
        Me.cboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxArea.FormattingEnabled = True
        Me.cboxArea.Location = New System.Drawing.Point(150, 80)
        Me.cboxArea.Name = "cboxArea"
        Me.cboxArea.Size = New System.Drawing.Size(255, 23)
        Me.cboxArea.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Area"
        '
        'txtExamen
        '
        Me.txtExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExamen.Location = New System.Drawing.Point(150, 45)
        Me.txtExamen.Name = "txtExamen"
        Me.txtExamen.Size = New System.Drawing.Size(255, 21)
        Me.txtExamen.TabIndex = 7
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(15, 45)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(129, 16)
        Me.label10.TabIndex = 6
        Me.label10.Text = "Nombre del examen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Datos del exanen grupal"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarDatos.Location = New System.Drawing.Point(334, 194)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(120, 28)
        Me.btnEnviarDatos.TabIndex = 14
        Me.btnEnviarDatos.Text = "Registrar examen"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'FormRegistrarExamenGrupoLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 248)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.panelExamen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.menuStrip)
        Me.Name = "FormRegistrarExamenGrupoLaboratorio"
        Me.Text = "Registrar examen grupal de laboratorio"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelExamen.ResumeLayout(False)
        Me.panelExamen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmItemMenuLaboratorio As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelExamen As Panel
    Friend WithEvents txtExamen As TextBox
    Friend WithEvents label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents hintArea As Label
    Friend WithEvents cboxArea As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnviarDatos As Button
End Class
