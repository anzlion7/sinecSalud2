Imports NEGOCIO

Public Class FormSolicitudRayosX
#Region "Declaraciones"
    Private ReadOnly objetoRayosX As New FuncionesRayosX(False)
    Dim termino, creado, buscado, rellenado As Boolean
    Dim examen As String
    Dim codexamen, cantidad As Int16
#End Region
#Region "Principal"
    Private Sub FormSolicitudRayosX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
        Panel1.Visible = False
    End Sub
    Private Sub Inicializar()
        termino = False
        creado = False
        ConfiguracionVentana()
        RellenarDatos()
        CbxPaciente.Enabled = False
        CbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList
        CbxRadiografias.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub
    Private Sub ConfiguracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
#End Region
#Region "Funciones"
    Private Function ExisteDatoEnGrid(id As Long) As Boolean
        Dim existe As Boolean = DGVExamenes.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells("codExamen").Value) = id)

        If existe Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub RellenarDatosPaciente()
        Dim matricula = CbxPaciente.SelectedValue.ToString()
        Dim edadenmeses = objetoRayosX.ObtenerEdad(matricula)
        If edadenmeses < 12 Then
            LCP.Text = "Codigo:" + CbxPaciente.SelectedValue.ToString() + "       Edad: " + edadenmeses.ToString() + " meses"

        Else
            LCP.Text = "Codigo:" + CbxPaciente.SelectedValue.ToString() + "       Edad: " + (edadenmeses / 12).ToString + " años"

        End If
        LNP.Text = "Paciente:" + CbxPaciente.Text.ToString()
    End Sub
    Private Function TraerPacientes()
        Try

            LNP.Text = "Paciente:"
            LCP.Text = "Cod Paciente:"
            termino = False
            Dim Nombre As String = TxbBuscarPaciente.Text.ToString().Trim()
            Dim Tabla As DataTable
            If Not CheckBCP.Checked = True Then
                Tabla = objetoRayosX.BuscarPaciente(Nombre)
            Else
                Tabla = objetoRayosX.BuscarPacienteporCodigo(Nombre)
            End If

            If Tabla.Rows.Count < 1 Then
                Return False
            Else

                CbxPaciente.Enabled = True
                CbxPaciente.DataSource = Tabla
                CbxPaciente.DisplayMember = "ASEGURADO"
                CbxPaciente.ValueMember = "MATRICULA"

                Return True
            End If

        Catch ex As Exception
            LNP.Text = "Paciente:"
            LCP.Text = "Cod Paciente:"
            'MessageBox.Show(Err.Description)
            Return False
        End Try
    End Function

    Private Function Validardatos()
        Dim valor As Int16
        If buscado Then
            valor = -1
        Else
            valor = 0
        End If
        If CbxPaciente.SelectedIndex > -1 Then
            If CbxRadiografias.SelectedIndex > valor Then
                If IsNumeric(cantidad) Then
                    If cantidad > 0 Then
                        If (ExisteDatoEnGrid(codexamen)) Then
                            MessageBox.Show("El examen ya esta en lista")
                            Return False
                        Else

                            Return True
                        End If
                    Else
                        MessageBox.Show("Error: La cantidad no puede ser menor a 1 ")
                    End If
                Else
                    MessageBox.Show("Error: En cantidad solo se permiten numeros")
                    Return False
                End If
            Else
                MessageBox.Show("Error: No seleccionó un examen")
                Return False
            End If
        Else
            MessageBox.Show("Error: no hay pacienteseleccionado")
            Return False
        End If
    End Function
    Private Function CargarCarritoDgvRX()
        Try
            examen = CbxRadiografias.Text.ToString()
            codexamen = CbxRadiografias.SelectedValue.ToString()
            cantidad = txbCantidad.Text.Trim()

            If (Validardatos()) Then
                If creado = False Then
                    DGVExamenes.ColumnCount = 3
                    DGVExamenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    DGVExamenes.Columns(0).Name = "codExamen"
                    DGVExamenes.Columns(0).FillWeight = 9
                    DGVExamenes.Columns(0).ReadOnly = True

                    DGVExamenes.Columns(1).Name = "Examen"
                    DGVExamenes.Columns(1).FillWeight = 70
                    DGVExamenes.Columns(1).ReadOnly = True

                    DGVExamenes.Columns(2).Name = "Cantidad"
                    DGVExamenes.Columns(2).FillWeight = 20
                    DGVExamenes.Columns(2).ReadOnly = True
                    creado = True
                End If

                Dim row As String() = New String() {codexamen, examen, cantidad}
                DGVExamenes.Rows.Add(row)


                Return True
            Else
                Return False
            End If

            'MessageBox.Show(Tamaños.ToString())

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function RellenarCbTipoRadiografia()
        Try
            Dim Nombre As String = TxbBuscarTipoRadiografia.Text.ToString().Trim()
            If Len(Nombre) > 0 Then
                buscado = True
            Else
                buscado = False
            End If
            Dim Tabla As DataTable
            Tabla = objetoRayosX.BuscarYTraerTiposDeRadiografia(Nombre)
            If Tabla.Rows.Count < 1 Then
                CbxRadiografias.SelectedIndex = -1
                CbxRadiografias.Text = "Sin Resultados"
                CbxRadiografias.Enabled = False
            Else
                CbxRadiografias.Enabled = True
                CbxRadiografias.DataSource = Tabla
                CbxRadiografias.DisplayMember = "DESCRIPCION"
                CbxRadiografias.ValueMember = "COD"
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function Enviar()
        Try
            Dim proximoRegistro = objetoRayosX.ObtenerProximoRegistro()
            Dim codPaciente, codmedico, nombredeprocedimiento, cant As String
            codPaciente = CbxPaciente.SelectedValue.ToString()
            codmedico = Usuario.codUserLoggedSystem.ToString()
            If objetoRayosX.RegistrarCabezaRX(codPaciente, codmedico, proximoRegistro) = 2 Then
                For X As Integer = 0 To DGVExamenes.Rows.Count - 2
                    nombredeprocedimiento = Convert.ToString(DGVExamenes.Rows(X).Cells("Examen").Value)
                    cant = Convert.ToString(DGVExamenes.Rows(X).Cells("Cantidad").Value)
                    Dim repuesta = objetoRayosX.RegistrarDetalleRayosX(proximoRegistro, nombredeprocedimiento, cant)
                Next
                Return True
            Else
                MessageBox.Show("Error al ingresar datos de cabecera")
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Return False
        End Try
    End Function
    Private Sub ReiniciarForm()
        TxbBuscarPaciente.Text = ""
        TxbBuscarTipoRadiografia.Text = ""
        creado = False
        rellenado = False
        DGVExamenes.Rows.Clear()
        DGVExamenes.Columns.Clear()
        CbxPaciente.SelectedIndex = -1
        CbxPaciente.Enabled = False

        CbxRadiografias.SelectedIndex = -1

        txbCantidad.Text = 0
        Panel1.Visible = False
        LNP.Text = "Paciente:"
        LCP.Text = "Codigo:"
    End Sub

#End Region
#Region "Eventos"
    Private Sub TxbBuscarPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarPaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (TraerPacientes()) Then
                termino = True
                CbxPaciente.SelectedIndex = 0
                RellenarDatosPaciente()
            Else

                LNP.Text = "Paciente:"
                LCP.Text = "Cod Paciente:"
            End If


        End If
    End Sub
    Private Sub TxbBuscarTipoRadiografia_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarTipoRadiografia.KeyDown
        If e.KeyCode = Keys.Enter Then
            RellenarCbTipoRadiografia()
        End If
    End Sub
    Private Sub CbxPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxPaciente.SelectedIndexChanged
        Try
            If termino Then
                RellenarDatosPaciente()
                If CbxPaciente.SelectedIndex > -1 Then
                    Panel1.Visible = True
                    If rellenado = False Then
                        rellenado = RellenarCbTipoRadiografia()
                    End If

                Else
                    Panel1.Visible = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DGVExamenes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExamenes.CellContentDoubleClick
        Try
            Dim FilaSeleccionada As DataGridViewRow = DGVExamenes.CurrentRow
            Dim valor As Integer = Val(FilaSeleccionada.Index)
            If DGVExamenes.RowCount - 1 > 0 Then
                DGVExamenes.Rows.Remove(DGVExamenes.Rows(valor))
            Else
                MessageBox.Show("La lista esta vacia no hay nada que eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error" + ex.ToString())
        End Try
    End Sub
    Private Sub TxbCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If txbCantidad.Text = "0" Then
            txbCantidad.Text = ""
        End If
    End Sub
    Private Sub TxbCantidad_GotFocus(sender As Object, e As EventArgs) Handles txbCantidad.GotFocus
        If txbCantidad.Text = 0 Then
            txbCantidad.Text = ""
        End If
    End Sub
    Private Sub TxbCantidad_TextChanged(sender As Object, e As EventArgs) Handles txbCantidad.TextChanged
        If Not IsNumeric(txbCantidad.Text) And Not txbCantidad.Text = "" Then
            txbCantidad.Text = 0
        End If
    End Sub

    Private Sub TxbCantidad_LostFocus(sender As Object, e As EventArgs) Handles txbCantidad.LostFocus
        If txbCantidad.Text = "" Then
            txbCantidad.Text = 0
        End If
    End Sub
#End Region
#Region "Botones"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuPrincipal.Show()
        Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        CargarCarritoDgvRX()
        txbCantidad.Text = 0
    End Sub

    Private Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click
        If DGVExamenes.Rows.Count > 0 Then
            If Enviar() Then
                MessageBox.Show("Solicitud Realizada")
                ReiniciarForm()
            Else
                MessageBox.Show("ERROR: OCURRIO UN ERROR AL ENVIAR")
            End If
        Else
            MessageBox.Show("No agregó ninguna solicitud ")
        End If

    End Sub

#End Region

#Region "pruebas"


#End Region
End Class