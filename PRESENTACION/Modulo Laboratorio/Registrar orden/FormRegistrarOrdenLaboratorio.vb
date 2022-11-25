Imports NEGOCIO

Public Class FormRegistrarOrdenLaboratorio

    'ATRIBUTOS LÓGICOS -----
    Private negocio As RegistroOrdenLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private medicoSeleccionado As Medico
    Private aseguradoSeleccionado As Asegurado

    'ATRIBUTOS G2
    Private areaSeleccionada As AreaLaboratorio

    'ATRIBUTOS G3
    Private examenesMarcados As ExamenSolicitableLaboratorio()

    'ATRIBUTOS G4
    Private clmCodigo As String
    Private clmCodTipo As String
    Private clmNomExamen As String
    Private clmAccion As String

    'ATRIBUTOS SUBMIT   
    Private nuevosExamenesSolicitables As ListaEnlazadaExamenSolicitableLaboratorio
    Private nuevaOrden As OrdenLaboratorio




    'METODOS INICIO ----
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormRegistrarOrdenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        estadoFormGuardado = False
        esFormHijo = _esHijo

        If _esHijo Then

        Else

        End If
    End Sub

    Public Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()

        logTraerAreas()
        negocio.traerExamenesSolictablesPorArea()
        negocio.traerExamenesIndividualesPorGrupo()

        intPoblarLboxAreas()

        'If esFormHijo Then iniciarControlesInterfazFormSecundario()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        negocio = New RegistroOrdenLaboratorio()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = False
        'esFormHijo = False

        'ATRIBUTOS G0
        tituloFormulario = "Registrar orden de laboratorio"

        'ATRIBUTOS G1
        medicoSeleccionado = New Medico()
        aseguradoSeleccionado = New Asegurado()

        'ATRIBUTOS G2
        areaSeleccionada = New AreaLaboratorio()

        'ATRIBUTOS G3
        examenesMarcados = New ExamenSolicitableLaboratorio(-1) {}

        'ATRIBUTOS G4
        clmCodigo = "clmCodGrupo"
        clmCodTipo = "clmCodExamen"
        clmNomExamen = "clmExamen"
        clmAccion = "clmAccion"

        'ATRIBUTOS SUBMIT
        nuevosExamenesSolicitables = New ListaEnlazadaExamenSolicitableLaboratorio()
        nuevaOrden = New OrdenLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
        iniciarControlesInterfazGrupo3()
        iniciarControlesInterfazGrupo9()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        txtBuscarMedico.Enabled = True
        txtBuscarMedico.Visible = True
        txtBuscarMedico.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarMedico.Text = ""
        txtBuscarMedico.CharacterCasing = CharacterCasing.Upper

        cboxMedico.Enabled = True
        cboxMedico.Visible = True
        cboxMedico.Font = New Font("Microsoft Sans Serif", 9)
        cboxMedico.Items.Clear()
        cboxMedico.DropDownStyle = ComboBoxStyle.DropDownList

        hintMedico.Enabled = True
        hintMedico.Visible = True
        hintMedico.Font = New Font("Microsoft Sans Serif", 8)
        hintMedico.Text = "SELECCIONAR"
        hintMedico.BackColor = Color.Transparent

        txtBuscarAsegurado.Enabled = True
        txtBuscarAsegurado.Visible = True
        txtBuscarAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarAsegurado.Text = ""
        txtBuscarAsegurado.CharacterCasing = CharacterCasing.Upper

        cboxAsegurado.Enabled = True
        cboxAsegurado.Visible = True
        cboxAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cboxAsegurado.Items.Clear()
        cboxAsegurado.DropDownStyle = ComboBoxStyle.DropDownList

        hintAsegurado.Enabled = True
        hintAsegurado.Visible = True
        hintAsegurado.Font = New Font("Microsoft Sans Serif", 8)
        hintAsegurado.Text = "SELECCIONAR"
        hintAsegurado.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        lboxAreas.Enabled = True
        lboxAreas.Visible = True
        lboxAreas.Font = New Font("Microsoft Sans Serif", 9)
        lboxAreas.Items.Clear()

        clistExamenesSolicitables.Enabled = True
        clistExamenesSolicitables.Visible = True
        clistExamenesSolicitables.MultiColumn = True
        clistExamenesSolicitables.ColumnWidth = clistExamenesSolicitables.Width * 0.5
        clistExamenesSolicitables.Font = New Font("Microsoft Sans Serif", 9)
        clistExamenesSolicitables.DataSource = Nothing
        clistExamenesSolicitables.Items.Clear()

        btnAgregarExamenes.Enabled = True
        btnAgregarExamenes.Visible = True
        btnAgregarExamenes.Font = New Font("Microsoft Sans Serif", 9)
        btnAgregarExamenes.Text = "Agregar Examenes"
    End Sub

    Private Sub iniciarControlesInterfazGrupo3()
        iniciarDgvExamenes()


        txtNota.Enabled = True
        txtNota.Visible = True
        txtNota.ReadOnly = False
        txtNota.Font = New Font("Microsoft Sans Serif", 9)
        txtNota.Text = ""
        txtNota.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarDgvExamenes()
        'ENCABEZADOS LABELS

        'PROPIEDADES BASE
        dgvExamenesSolicitables.Enabled = True
        dgvExamenesSolicitables.Visible = True
        dgvExamenesSolicitables.Font = New Font("Microsoft Sans Serif", 9)
        dgvExamenesSolicitables.Rows.Clear()
        dgvExamenesSolicitables.Columns.Clear()

        'PERMISOS EDITAR
        dgvExamenesSolicitables.EditMode = DataGridViewEditMode.EditOnEnter
        dgvExamenesSolicitables.AllowUserToAddRows = False
        dgvExamenesSolicitables.AllowUserToDeleteRows = False
        dgvExamenesSolicitables.AllowUserToResizeRows = False
        dgvExamenesSolicitables.AllowUserToOrderColumns = False
        dgvExamenesSolicitables.AllowUserToResizeColumns = False
        dgvExamenesSolicitables.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvExamenesSolicitables.MultiSelect = False
        dgvExamenesSolicitables.ReadOnly = True

        'PROPIEDADES MODOS DE SELECCION
        dgvExamenesSolicitables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExamenesSolicitables.SelectionMode = DataGridViewSelectionMode.CellSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvExamenesSolicitables.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvExamenesSolicitables.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvExamenesSolicitables.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesSolicitables.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvExamenesSolicitables.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvExamenesSolicitables.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesSolicitables.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvExamenesSolicitables.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenesSolicitables.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvExamenesSolicitables.ScrollBars = ScrollBars.Both
        dgvExamenesSolicitables.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvExamenesSolicitables.Columns.Add(clmCodigo, "CODIGO")
        dgvExamenesSolicitables.Columns(clmCodigo).Visible = False

        dgvExamenesSolicitables.Columns.Add(clmCodTipo, "CODIGO TIPO")
        dgvExamenesSolicitables.Columns(clmCodTipo).Visible = False

        dgvExamenesSolicitables.Columns.Add(clmNomExamen, "EXAMEN")
        dgvExamenesSolicitables.Columns(clmNomExamen).Visible = True

        Dim clmButtonAccion As New DataGridViewButtonColumn()
        clmButtonAccion.Name = clmAccion
        clmButtonAccion.HeaderText = ""
        clmButtonAccion.Text = "ELIMINAR"
        clmButtonAccion.UseColumnTextForButtonValue = True
        dgvExamenesSolicitables.Columns.Add(clmButtonAccion)
        dgvExamenesSolicitables.Columns(clmAccion).Visible = True


        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvExamenesSolicitables.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvExamenesSolicitables.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'CONFIGURAR ANCHO COLUMNAS
        dgvExamenesSolicitables.Columns(clmCodigo).FillWeight = 10
        dgvExamenesSolicitables.Columns(clmCodTipo).FillWeight = 10
        dgvExamenesSolicitables.Columns(clmNomExamen).FillWeight = 60
        dgvExamenesSolicitables.Columns(clmAccion).FillWeight = 20


        'FILAS
        dgvExamenesSolicitables.Rows.Clear()
    End Sub

    Private Sub iniciarControlesInterfazGrupo9()
        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviarDatos.Text = "Registrar Orden"
    End Sub

    Private Sub establecerDisplay()
        '    Dim ejeX As Short, ejeY As Short
        '    ejeX = Utilitarios.resolucionEstandarEjeX
        '    ejeY = Utilitarios.resolucionEstandarEjeY

        '    Size = New Size(ejeX, ejeY)
        '    MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        '    MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub









    'METODOS LÓGICOS G1 -----
    Private Sub logTraerMedicos()
        Dim nombre As String = txtBuscarMedico.Text.Trim()
        negocio.traerMedicos(nombre)
    End Sub

    Private Sub logSeleccionarMedico()
        Dim index As Short = cboxMedico.SelectedIndex
        medicoSeleccionado = negocio.medicos(index)
    End Sub

    Private Sub logTraerAsegurados()
        Dim nombre As String = txtBuscarAsegurado.Text.Trim()
        negocio.traerAsegurados(nombre)
    End Sub

    Private Sub logSeleccionarAsegurado()
        Dim index As Int16 = cboxAsegurado.SelectedIndex
        aseguradoSeleccionado = negocio.asegurados(index)
    End Sub


    'METODOS LÓGICOS G2
    Private Sub logTraerAreas()
        negocio.traerAreas()
    End Sub

    Private Sub logSeleccionarArea()
        Dim index As Short = lboxAreas.SelectedIndex
        areaSeleccionada = negocio.areas(index)
    End Sub

    'METODOS LÓGICOS G3
    Private Sub logCargarExamenesMarcados()
        Dim dimension As Short, index As Short

        dimension = clistExamenesSolicitables.CheckedItems.Count
        examenesMarcados = New ExamenSolicitableLaboratorio(dimension - 1) {}

        index = 0
        For Each examenSolicitable As ExamenSolicitableLaboratorio In clistExamenesSolicitables.CheckedItems
            examenesMarcados(index) = examenSolicitable
            index += 1
        Next
    End Sub

    Private Function logValidarEntradasExamenesMarcados() As String
        Dim mensaje As String = ""

        mensaje = negocio.validarExamenesMarcados(examenesMarcados, nuevosExamenesSolicitables)
        Return mensaje
    End Function

    Private Sub logAgregarExamenesMarcados()
        negocio.agregarExamenesMarcados(examenesMarcados, nuevosExamenesSolicitables)
    End Sub

    Private Sub logEliminarExamen(_filaIndex As Short)
        Dim row As DataGridViewRow, codigo As Long, codigoTipoExamen As Short

        row = dgvExamenesSolicitables.Rows(_filaIndex)
        codigo = row.Cells(clmCodigo).Value
        codigoTipoExamen = row.Cells(clmCodTipo).Value
        negocio.eliminarExamenSolicitable(nuevosExamenesSolicitables, codigo, codigoTipoExamen)
    End Sub


    'METODOS LÓGICOS SUBTMIT
    Private Function logValidarEntradas() As String
        Dim mensaje As String

        mensaje = negocio.validarEntradasFrontEnd(medicoSeleccionado, aseguradoSeleccionado)
        If Not mensaje = "" Then Return mensaje

        mensaje = negocio.validarEntradasBackEnd(nuevosExamenesSolicitables)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function logCargarObjetosParaSubmit() As OrdenLaboratorio
        Dim nota As String, nuevaOrden As OrdenLaboratorio

        nota = txtNota.Text.Trim()

        nuevaOrden = New OrdenLaboratorio()
        nuevaOrden.setAsegurado(aseguradoSeleccionado)
        nuevaOrden.setMedico(medicoSeleccionado)
        nuevaOrden.setNota(nota)

        Return nuevaOrden
    End Function

    Private Sub logEnviarObjetosADatabase()
        Try
            Dim nuevaOrden As OrdenLaboratorio, nuevosDetalles As DetalleLaboratorio()

            nuevaOrden = logCargarObjetosParaSubmit()
            nuevosDetalles = negocio.generarListaDetalles(nuevosExamenesSolicitables)

            negocio.insertarOrden(nuevaOrden)
            negocio.insertarDetalles(nuevosDetalles)

            Me.nuevaOrden = nuevaOrden

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Function logAbrirFormularioConfirmacion() As Boolean
        Dim form As FormConfimarOrdenLaboratorio, registroConfirmado As Boolean

        nuevaOrden.setAsegurado(aseguradoSeleccionado)
        nuevaOrden.setMedico(medicoSeleccionado)

        form = New FormConfimarOrdenLaboratorio(True, nuevaOrden, nuevosExamenesSolicitables)
        form.ShowDialog()
        registroConfirmado = form.registroConfirmado

        Return registroConfirmado
    End Function













    'METODOS INTERFAZ G1 ----
    Private Sub intPoblarCboxMedico()
        cboxMedico.Items.Clear()

        For Each medico As Medico In negocio.medicos
            Dim usuario As Usuario, nombreCompleto As String

            usuario = medico.getUsuario()
            nombreCompleto = Trim(usuario.getApellidoPaterno()) + " " + Trim(usuario.getApellidoMaterno()) + " " + Trim(usuario.getNombres())
            nombreCompleto.Trim()

            cboxMedico.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub intMostrarHintMedico()
        hintMedico.Visible = True
    End Sub

    Private Sub intOcultarHintMedico()
        hintMedico.Visible = False
    End Sub

    Private Sub intPoblarCboxAsegurado()
        cboxAsegurado.Items.Clear()

        For Each asegurado As Asegurado In negocio.asegurados
            Dim nombreCompleto As String

            nombreCompleto = Trim(asegurado.getApellidoPaterno()) + " " + Trim(asegurado.getApellidoMaterno()) + " " + Trim(asegurado.getNombres)
            nombreCompleto = nombreCompleto.Trim()

            cboxAsegurado.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub intMostrarHintAsegurado()
        hintAsegurado.Visible = True
    End Sub

    Private Sub intOcultarHintAsegurado()
        hintAsegurado.Visible = False
    End Sub

    'METODOS INTERFAZ G2
    Private Sub intPoblarLboxAreas()
        lboxAreas.Items.Clear()

        For Each area As AreaLaboratorio In negocio.areas
            lboxAreas.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub intMostrarExamenesSolicitables()
        clistExamenesSolicitables.DataSource = Nothing

        Dim examenesSolicitables As ExamenSolicitableLaboratorio()

        examenesSolicitables = areaSeleccionada.getExamenesSolicitables()

        clistExamenesSolicitables.DisplayMember = "nombre"
        clistExamenesSolicitables.ValueMember = "codigo"
        clistExamenesSolicitables.DataSource = examenesSolicitables
        clistExamenesSolicitables.DisplayMember = "nombre"
    End Sub

    'METODOS INTERFAZ G3    
    Private Sub intDesmarcarItemsExamenesSolicitables()
        Dim dimension As Short

        dimension = clistExamenesSolicitables.Items.Count
        For index = 0 To dimension - 1
            clistExamenesSolicitables.SetItemChecked(index, False)
        Next

    End Sub

    Private Sub intPoblarDgvExamenesSolicitables()
        dgvExamenesSolicitables.Rows.Clear()

        Dim nodoActual As NodoExamenSolicitableLaboratorio
        nodoActual = nuevosExamenesSolicitables.raiz

        While Not IsNothing(nodoActual)
            Dim examenSolicitable As ExamenSolicitableLaboratorio, rowIndex As Short, rowAux As DataGridViewRow,
                codigo As String, codigoTipo As String, nombre As String

            examenSolicitable = nodoActual.examenSolicitable

            rowIndex = dgvExamenesSolicitables.Rows.Add()
            rowAux = dgvExamenesSolicitables.Rows(rowIndex)
            codigo = examenSolicitable.getCodigo()
            If TypeOf examenSolicitable Is ExamenLaboratorio Then codigoTipo = 1 Else codigoTipo = 2
            nombre = examenSolicitable.getNombre()

            rowAux.Cells(clmCodigo).Value = codigo
            rowAux.Cells(clmCodTipo).Value = codigoTipo
            rowAux.Cells(clmNomExamen).Value = nombre

            nodoActual = nodoActual.siguiente
        End While

    End Sub

    'METODOS INTERFAZ MENU
    Private Sub intMostrarMensaje(_mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub










    'EVENTOS MENU -----
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Try
            Dim form As FormMenuLaboratorio

            form = New FormMenuLaboratorio()
            form.Show()
            Me.Close()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    'EVENTOS G1 
    Private Sub btnBuscarMedico_Click(sender As Object, e As EventArgs) Handles btnBuscarMedico.Click
        Try
            If txtBuscarMedico.Text.Trim = "" Then Return
            logTraerMedicos()
            intPoblarCboxMedico()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxMedico_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxMedico.SelectionChangeCommitted
        Try
            logSeleccionarMedico()
            intOcultarHintMedico()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarAsegurado_Click(sender As Object, e As EventArgs) Handles btnBuscarAsegurado.Click
        Try
            If txtBuscarAsegurado.Text.Trim = "" Then Return
            logTraerAsegurados()
            intPoblarCboxAsegurado()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxAsegurado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxAsegurado.SelectionChangeCommitted
        Try
            logSeleccionarAsegurado()
            intOcultarHintAsegurado()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G2
    Private Sub lboxAreas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxAreas.SelectedIndexChanged
        Try
            logSeleccionarArea()
            intMostrarExamenesSolicitables()
            clistExamenesSolicitables.ClearSelected()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarExamenes_Click(sender As Object, e As EventArgs) Handles btnAgregarExamenes.Click
        Try
            Dim mensaje As String

            logCargarExamenesMarcados()
            mensaje = logValidarEntradasExamenesMarcados()

            If mensaje = "" Then
                logAgregarExamenesMarcados()
                intDesmarcarItemsExamenesSolicitables()
                clistExamenesSolicitables.ClearSelected()


            Else
                intMostrarMensaje(mensaje)
            End If

            intPoblarDgvExamenesSolicitables()


        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G3
    Private Sub dgvExamenesSolicitables_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvExamenesSolicitables.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvExamenesSolicitables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExamenesSolicitables.CellClick
        Try
            Dim clmAccionIndex As Short, clmClickIndex As Short, rowIndex As Short

            clmAccionIndex = dgvExamenesSolicitables.Columns(clmAccion).Index
            clmClickIndex = e.ColumnIndex
            rowIndex = e.RowIndex

            If Not clmAccionIndex = clmClickIndex Or rowIndex < 0 Then
                Return
            Else
                logEliminarExamen(rowIndex)
                intPoblarDgvExamenesSolicitables()
            End If

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS SUBMIT
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            Dim mensaje As String, respuesta As Short, confirmado As Boolean


            mensaje = logValidarEntradas()
            If Not mensaje = "" Then
                intMostrarMensaje(mensaje)
                Return
            End If




            confirmado = logAbrirFormularioConfirmacion()
            If confirmado Then
                logEnviarObjetosADatabase()
                respuesta = negocio.respuestaInsercionDetalles

                If respuesta > 0 Then
                    intMostrarMensaje("La orden se guardó correctamente.")
                    reiniciarFormulario()
                End If
            End If



        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub



End Class
