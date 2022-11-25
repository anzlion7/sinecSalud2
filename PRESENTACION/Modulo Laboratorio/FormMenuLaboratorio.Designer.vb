<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuLaboratorio
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
        Me.btnSubarea = New System.Windows.Forms.Button()
        Me.btnExamen = New System.Windows.Forms.Button()
        Me.btnConjuntoOpciones = New System.Windows.Forms.Button()
        Me.btnOrden = New System.Windows.Forms.Button()
        Me.btnResultados = New System.Windows.Forms.Button()
        Me.btnImprimirResultados = New System.Windows.Forms.Button()
        Me.btnReferencias = New System.Windows.Forms.Button()
        Me.btnKitEquipoQuimico = New System.Windows.Forms.Button()
        Me.btnAsignarAreasPermisos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdministrarGrupos = New System.Windows.Forms.Button()
        Me.btnAdministrarExamen = New System.Windows.Forms.Button()
        Me.btnExamenGrupal = New System.Windows.Forms.Button()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRegistrarMarca = New System.Windows.Forms.Button()
        Me.btnKitEquipoPredeterminado = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubarea
        '
        Me.btnSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubarea.Location = New System.Drawing.Point(18, 80)
        Me.btnSubarea.Name = "btnSubarea"
        Me.btnSubarea.Size = New System.Drawing.Size(155, 28)
        Me.btnSubarea.TabIndex = 2
        Me.btnSubarea.Text = "Registrar Subarea"
        Me.btnSubarea.UseVisualStyleBackColor = True
        '
        'btnExamen
        '
        Me.btnExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamen.Location = New System.Drawing.Point(18, 115)
        Me.btnExamen.Name = "btnExamen"
        Me.btnExamen.Size = New System.Drawing.Size(155, 28)
        Me.btnExamen.TabIndex = 3
        Me.btnExamen.Text = "Registrar examen"
        Me.btnExamen.UseVisualStyleBackColor = True
        '
        'btnConjuntoOpciones
        '
        Me.btnConjuntoOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConjuntoOpciones.Location = New System.Drawing.Point(15, 45)
        Me.btnConjuntoOpciones.Name = "btnConjuntoOpciones"
        Me.btnConjuntoOpciones.Size = New System.Drawing.Size(251, 28)
        Me.btnConjuntoOpciones.TabIndex = 1
        Me.btnConjuntoOpciones.Text = "Registrar conjunto opciones de resultado"
        Me.btnConjuntoOpciones.UseVisualStyleBackColor = True
        '
        'btnOrden
        '
        Me.btnOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrden.Location = New System.Drawing.Point(15, 45)
        Me.btnOrden.Name = "btnOrden"
        Me.btnOrden.Size = New System.Drawing.Size(156, 28)
        Me.btnOrden.TabIndex = 1
        Me.btnOrden.Text = "Registrar orden"
        Me.btnOrden.UseVisualStyleBackColor = True
        '
        'btnResultados
        '
        Me.btnResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultados.Location = New System.Drawing.Point(15, 115)
        Me.btnResultados.Name = "btnResultados"
        Me.btnResultados.Size = New System.Drawing.Size(156, 28)
        Me.btnResultados.TabIndex = 3
        Me.btnResultados.Text = "Registrar resultados"
        Me.btnResultados.UseVisualStyleBackColor = True
        '
        'btnImprimirResultados
        '
        Me.btnImprimirResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirResultados.Location = New System.Drawing.Point(15, 150)
        Me.btnImprimirResultados.Name = "btnImprimirResultados"
        Me.btnImprimirResultados.Size = New System.Drawing.Size(156, 28)
        Me.btnImprimirResultados.TabIndex = 4
        Me.btnImprimirResultados.Text = "Imprimir resultados "
        Me.btnImprimirResultados.UseVisualStyleBackColor = True
        '
        'btnReferencias
        '
        Me.btnReferencias.Enabled = False
        Me.btnReferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReferencias.Location = New System.Drawing.Point(15, 185)
        Me.btnReferencias.Name = "btnReferencias"
        Me.btnReferencias.Size = New System.Drawing.Size(191, 28)
        Me.btnReferencias.TabIndex = 4
        Me.btnReferencias.Text = "Registrar valores de referencia"
        Me.btnReferencias.UseVisualStyleBackColor = True
        '
        'btnKitEquipoQuimico
        '
        Me.btnKitEquipoQuimico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKitEquipoQuimico.Location = New System.Drawing.Point(15, 150)
        Me.btnKitEquipoQuimico.Name = "btnKitEquipoQuimico"
        Me.btnKitEquipoQuimico.Size = New System.Drawing.Size(191, 28)
        Me.btnKitEquipoQuimico.TabIndex = 3
        Me.btnKitEquipoQuimico.Text = "Registrar kit-equipo químico"
        Me.btnKitEquipoQuimico.UseVisualStyleBackColor = True
        '
        'btnAsignarAreasPermisos
        '
        Me.btnAsignarAreasPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarAreasPermisos.Location = New System.Drawing.Point(15, 80)
        Me.btnAsignarAreasPermisos.Name = "btnAsignarAreasPermisos"
        Me.btnAsignarAreasPermisos.Size = New System.Drawing.Size(245, 28)
        Me.btnAsignarAreasPermisos.TabIndex = 2
        Me.btnAsignarAreasPermisos.Text = "Asignar areas/permiso de bioquímico"
        Me.btnAsignarAreasPermisos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(34, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1204, 26)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(524, 0)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(156, 25)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "LABORATORIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR / DEFINIR EXAMEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "REGISTRAR ORDEN Y RESULTADOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DEFINIR RESULTADOS DE EXAMEN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnAdministrarGrupos)
        Me.Panel1.Controls.Add(Me.btnAdministrarExamen)
        Me.Panel1.Controls.Add(Me.btnExamenGrupal)
        Me.Panel1.Controls.Add(Me.btnExamen)
        Me.Panel1.Controls.Add(Me.btnSubarea)
        Me.Panel1.Controls.Add(Me.btnArea)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(35, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 260)
        Me.Panel1.TabIndex = 1
        '
        'btnAdministrarGrupos
        '
        Me.btnAdministrarGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrarGrupos.Location = New System.Drawing.Point(18, 218)
        Me.btnAdministrarGrupos.Name = "btnAdministrarGrupos"
        Me.btnAdministrarGrupos.Size = New System.Drawing.Size(155, 28)
        Me.btnAdministrarGrupos.TabIndex = 6
        Me.btnAdministrarGrupos.Text = "Administrar grupos"
        Me.btnAdministrarGrupos.UseVisualStyleBackColor = True
        '
        'btnAdministrarExamen
        '
        Me.btnAdministrarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrarExamen.Location = New System.Drawing.Point(18, 184)
        Me.btnAdministrarExamen.Name = "btnAdministrarExamen"
        Me.btnAdministrarExamen.Size = New System.Drawing.Size(155, 28)
        Me.btnAdministrarExamen.TabIndex = 5
        Me.btnAdministrarExamen.Text = "Administrar examen"
        Me.btnAdministrarExamen.UseVisualStyleBackColor = True
        '
        'btnExamenGrupal
        '
        Me.btnExamenGrupal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamenGrupal.Location = New System.Drawing.Point(18, 150)
        Me.btnExamenGrupal.Name = "btnExamenGrupal"
        Me.btnExamenGrupal.Size = New System.Drawing.Size(155, 28)
        Me.btnExamenGrupal.TabIndex = 4
        Me.btnExamenGrupal.Text = "Registrar examen grupal"
        Me.btnExamenGrupal.UseVisualStyleBackColor = True
        '
        'btnArea
        '
        Me.btnArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.Location = New System.Drawing.Point(18, 45)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(155, 28)
        Me.btnArea.TabIndex = 1
        Me.btnArea.Text = "Registrar Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnImprimirResultados)
        Me.Panel2.Controls.Add(Me.btnResultados)
        Me.Panel2.Controls.Add(Me.btnAsignarAreasPermisos)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnOrden)
        Me.Panel2.Location = New System.Drawing.Point(685, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 196)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnRegistrarMarca)
        Me.Panel3.Controls.Add(Me.btnKitEquipoPredeterminado)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnReferencias)
        Me.Panel3.Controls.Add(Me.btnKitEquipoQuimico)
        Me.Panel3.Controls.Add(Me.btnConjuntoOpciones)
        Me.Panel3.Location = New System.Drawing.Point(359, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 247)
        Me.Panel3.TabIndex = 2
        '
        'btnRegistrarMarca
        '
        Me.btnRegistrarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarMarca.Location = New System.Drawing.Point(18, 116)
        Me.btnRegistrarMarca.Name = "btnRegistrarMarca"
        Me.btnRegistrarMarca.Size = New System.Drawing.Size(188, 28)
        Me.btnRegistrarMarca.TabIndex = 6
        Me.btnRegistrarMarca.Text = "Registrar Marca Kit-Equipo"
        Me.btnRegistrarMarca.UseVisualStyleBackColor = True
        '
        'btnKitEquipoPredeterminado
        '
        Me.btnKitEquipoPredeterminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKitEquipoPredeterminado.Location = New System.Drawing.Point(15, 79)
        Me.btnKitEquipoPredeterminado.Name = "btnKitEquipoPredeterminado"
        Me.btnKitEquipoPredeterminado.Size = New System.Drawing.Size(251, 28)
        Me.btnKitEquipoPredeterminado.TabIndex = 5
        Me.btnKitEquipoPredeterminado.Text = "Administrar Kit-Equipo predeterminado"
        Me.btnKitEquipoPredeterminado.UseVisualStyleBackColor = True
        '
        'FormMenuLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormMenuLaboratorio"
        Me.Text = "Menu laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOrden As System.Windows.Forms.Button
    Friend WithEvents btnKitEquipoQuimico As System.Windows.Forms.Button
    Friend WithEvents btnResultados As System.Windows.Forms.Button
    Friend WithEvents btnImprimirResultados As Button
    Friend WithEvents btnConjuntoOpciones As Button
    Friend WithEvents btnExamen As Button
    Friend WithEvents btnSubarea As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents btnAsignarAreasPermisos As Button
    Friend WithEvents btnReferencias As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExamenGrupal As Button
    Friend WithEvents btnArea As Button
    Friend WithEvents btnAdministrarExamen As Button
    Friend WithEvents btnAdministrarGrupos As Button
    Friend WithEvents btnKitEquipoPredeterminado As Button
    Friend WithEvents btnRegistrarMarca As Button
End Class
