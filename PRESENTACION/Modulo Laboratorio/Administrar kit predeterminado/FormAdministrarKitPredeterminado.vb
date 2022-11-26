Imports NEGOCIO

Public Class FormAdministrarKitPredeterminado

    'ATRIBUTOS LÓGICOS ----
    Private negocio As AdministracionKitPredeterminado

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G2
    Private clmSexoDgvRef As String

    Private clmEdadIniDgvRef As String
    Private clmEdadFinDgvRef As String

    Private clmValIniGenDgvRef As String
    Private clmValFinGenDgvRef As String

    Private clmValIniMasDgvRef As String
    Private clmValFinMasDgvRef As String

    Private clmValIniFemDgvRef As String
    Private clmValFinFemDgvRef As String




    'METODOS INICIO -----
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

    Private Sub FormAdministrarKitPredeterminado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        'If esFormHijo Then iniciarControlesInterfazFormSecundario()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        negocio = New AdministracionKitPredeterminado()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = False

        'ATRIBUTOS G0
        tituloFormulario = "Administrar kit/equipo predeterminado"

        'ATRIBUTOS G2
        clmSexoDgvRef = "clmSexoDgvRef"

        clmEdadIniDgvRef = "clmEdadIniDgvRef"
        clmEdadFinDgvRef = "clmEdadFinDgvRef"

        clmValIniGenDgvRef = "clmValIniGenDgvRef"
        clmValFinGenDgvRef = "clmValFinGenDgvRef"

        clmValIniMasDgvRef = "clmValIniMasDgvRef"
        clmValFinMasDgvRef = "clmValFinMasDgvRef"

        clmValIniFemDgvRef = "clmValIniFemDgvRef"
        clmValFinFemDgvRef = "clmValFinFemDgvRef"
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazMenu()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
    End Sub

    Private Sub iniciarControlesInterfazMenu()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        txtBuscarExamen.Enabled = True
        txtBuscarExamen.Visible = True
        txtBuscarExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarExamen.Text = ""
        txtBuscarExamen.CharacterCasing = CharacterCasing.Upper

        btnBuscarExamen.Enabled = True
        btnBuscarExamen.Visible = True
        btnBuscarExamen.Font = New Font("Microsoft Sans Serif", 9)
        'btnBuscarExamen.Text = ""

        cboxExamen.Enabled = True
        cboxExamen.Visible = True
        cboxExamen.Font = New Font("Microsoft Sans Serif", 9)
        cboxExamen.Items.Clear()
        cboxExamen.DropDownStyle = ComboBoxStyle.DropDownList

        hintExamen.Enabled = True
        hintExamen.Visible = True
        hintExamen.Font = New Font("Microsoft Sans Serif", 8)
        hintExamen.Text = "SELECCIONAR"
        hintExamen.BackColor = Color.Transparent

        txtKitPredeterminado.Enabled = True
        txtKitPredeterminado.Visible = True
        txtKitPredeterminado.ReadOnly = True
        txtKitPredeterminado.Font = New Font("Microsoft Sans Serif", 9)
        txtKitPredeterminado.Text = ""
        txtKitPredeterminado.CharacterCasing = CharacterCasing.Upper

        cboxKit.Enabled = True
        cboxKit.Visible = True
        cboxKit.Font = New Font("Microsoft Sans Serif", 9)
        cboxKit.Items.Clear()
        cboxKit.DropDownStyle = ComboBoxStyle.DropDownList

        hintKit.Enabled = True
        hintKit.Visible = True
        hintKit.Font = New Font("Microsoft Sans Serif", 8)
        hintKit.Text = "SELECCIONAR"
        hintKit.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        iniciarDgvGrupos()
    End Sub

    Private Sub iniciarDgvGrupos()
        'ENCABEZADOS LABELS

        'PROPIEDADES BASE
        dgvReferencias.Enabled = True
        dgvReferencias.Visible = True
        dgvReferencias.Font = New Font("Microsoft Sans Serif", 9)
        dgvReferencias.Rows.Clear()
        dgvReferencias.Columns.Clear()

        'PERMISOS EDITAR
        dgvReferencias.EditMode = DataGridViewEditMode.EditOnEnter
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False
        dgvReferencias.AllowUserToResizeRows = False
        dgvReferencias.AllowUserToOrderColumns = False
        dgvReferencias.AllowUserToResizeColumns = False
        dgvReferencias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvReferencias.MultiSelect = False
        dgvReferencias.ReadOnly = True

        'PROPIEDADES MODOS DE SELECCION
        dgvReferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvReferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvReferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvReferencias.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvReferencias.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvReferencias.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(48, 97, 255)
        dgvReferencias.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvReferencias.ScrollBars = ScrollBars.Both
        dgvReferencias.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvReferencias.Columns.Clear()

        dgvReferencias.Columns.Add(clmSexoDgvRef, "SEXO")
        dgvReferencias.Columns(clmSexoDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmEdadIniDgvRef, "EDAD INICIAL")
        dgvReferencias.Columns(clmEdadIniDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmEdadFinDgvRef, "EDAD FINAL")
        dgvReferencias.Columns(clmEdadFinDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmValIniGenDgvRef, "VALOR INICIAL")
        dgvReferencias.Columns(clmValIniGenDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmValFinGenDgvRef, "VALOR FINAL")
        dgvReferencias.Columns(clmValFinGenDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmValIniMasDgvRef, "VALOR INICIAL MASCULINO")
        dgvReferencias.Columns(clmValIniMasDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmValFinMasDgvRef, "VALOR FINAL MASCULINO")
        dgvReferencias.Columns(clmValFinMasDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmValIniFemDgvRef, "VALOR INICIAL FEMENINO")
        dgvReferencias.Columns(clmValIniFemDgvRef).Visible = False

        dgvReferencias.Columns.Add(clmValFinFemDgvRef, "VALOR FINAL FEMENINO")
        dgvReferencias.Columns(clmValFinFemDgvRef).Visible = False



        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'CONFIGURAR ANCHO COLUMNAS
        'dgvReferencias.Columns(clmCodGrupoDgvGru).FillWeight = 1
        'dgvReferencias.Columns(clmNomGrupoDgvGru).FillWeight = 99

        'FILAS
        dgvReferencias.Rows.Clear()
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










    'METODOS LOGICOS G1 -----
    Private Sub logTraerExamenes()
        Dim nombreExamen As String = txtBuscarExamen.Text.Trim()
        negocio.traerExamenes(nombreExamen)
    End Sub

    Private Sub logSeleccinoarExamen()
        Dim index As Short = cboxExamen.SelectedIndex
        negocio.examenSeleccionado = negocio.examenes(index)
    End Sub

    Private Sub logTraerKits()
        Dim codigoExamen As Long = negocio.examenSeleccionado.getCodigo()
        negocio.traerKits(codigoExamen)
    End Sub

    Private Sub logSeleccionarKit()
        Dim index As Short = cboxKit.SelectedIndex
        negocio.kitSeleccionado = negocio.kits(index)
    End Sub

    Private Sub logTraerReferencias()
        Dim codigoKit As Long = negocio.kitSeleccionado.getCodigo()
        negocio.traerReferencias(codigoKit)
    End Sub

    'METODOS LÓGICOS SUBTMIT
    Private Sub logValidarEntradas()
        Dim mensaje As String, kitSeleccionado As KitEquipoLaboratorio

        kitSeleccionado = negocio.kitSeleccionado

        mensaje = negocio.validarEntradasSubmit(kitSeleccionado)

        If Not mensaje = "" Then intMostrarMensaje(mensaje)
    End Sub

    Private Sub logEnviarObjetosADatabase()
        Try
            Dim examenSubmit As ExamenLaboratorio, codigoKit As Long, codigoExamen As Long

            examenSubmit = negocio.cargarObjetosParaSubmit()
            codigoKit = examenSubmit.getKitPredeterminado().getCodigo()
            codigoExamen = examenSubmit.getCodigo()

            negocio.updateKitPredeterminado(codigoKit, codigoExamen)

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub






    'METODOS INTERFAZ MENU -----
    Private Sub intMostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub

    'METODOS INTERFAZ G1
    Private Sub intOcultarHintExamen()
        hintExamen.Visible = False
    End Sub

    Private Sub intPoblarCboxExamen()
        cboxExamen.Items.Clear()

        For Each examen As ExamenLaboratorio In negocio.examenes
            Dim nombre As String

            nombre = examen.getNombre()
            cboxExamen.Items.Add(nombre)
        Next
    End Sub

    Private Sub intMostrarKitPredeterminado()
        Dim kit As KitEquipoLaboratorio, nombre As String

        kit = negocio.examenSeleccionado.getKitPredeterminado()

        If kit.getNombre() = "" Then
            nombre = "NO TIENE"
        Else
            nombre = kit.getNombre()
        End If

        txtKitPredeterminado.Text = nombre
    End Sub

    Private Sub intPoblarCboxKit()
        cboxKit.Items.Clear()

        For Each kit As KitEquipoLaboratorio In negocio.kits
            Dim nombre As String

            nombre = kit.getNombre()
            cboxKit.Items.Add(nombre)
        Next
    End Sub

    Private Sub intOcultarHintKit()
        hintKit.Visible = False
    End Sub



    'METODOS INTERFAZ G2
    Private Sub intPoblarDgvReferencias()
        dgvReferencias.Rows.Clear()


        Dim grupoReferenciasSexoYEdad As Short
        grupoReferenciasSexoYEdad = 0


        For Each referencia As ReferenciaResultadoLaboratorio In negocio.referencias
            Dim rowIndex As Short, rowAux As DataGridViewRow

            Dim codigoTipo As Short,
                sexo As String,
                edadInicial As String,
                edadFinal As String,
                valorInicial As String,
                valorFinal As String


            rowIndex = dgvReferencias.Rows.Add()
            rowAux = dgvReferencias.Rows(rowIndex)


            codigoTipo = referencia.getTipo().getCorrelativo()
            sexo = referencia.getSexo()

            edadInicial = referencia.getEdadInicio()
            edadFinal = referencia.getEdadFin()

            valorInicial = referencia.getValorInicio()
            valorFinal = referencia.getValorFin()

            intCambiarEstructuraDgv(codigoTipo)

            If codigoTipo = 1 Then
                intPoblarReferenciaComun(rowAux, valorInicial, valorFinal)

            ElseIf codigoTipo = 2 Then
                intPoblarReferenciaSexo(rowAux, valorInicial, valorFinal, sexo)

            ElseIf codigoTipo = 3 Then
                intPoblarReferenciaEdad(rowAux, valorInicial, valorFinal, edadInicial, edadFinal)

            ElseIf codigoTipo = 4 Then
                If grupoReferenciasSexoYEdad = 0 Then
                    intPoblarReferenciaSexoYEdad(rowAux, sexo, edadInicial, edadFinal, valorInicial, valorFinal)
                    grupoReferenciasSexoYEdad += 1


                ElseIf grupoReferenciasSexoYEdad = 1 Then
                    rowAux = dgvReferencias.Rows(rowIndex - 1)
                    intPoblarReferenciaSexoYEdad(rowAux, sexo, edadInicial, edadFinal, valorInicial, valorFinal)
                    grupoReferenciasSexoYEdad = 0
                End If
            End If
        Next
    End Sub

    Private Sub intPoblarReferenciaComun(ByRef _row As DataGridViewRow, valorInicial As String, valorFinal As String)

        _row.Cells(clmValIniGenDgvRef).Value = valorInicial
        _row.Cells(clmValFinGenDgvRef).Value = valorFinal
    End Sub

    Private Sub intPoblarReferenciaSexo(ByRef _row As DataGridViewRow, valorInicial As String, valorFinal As String,
                                               _sexo As Char)


        Dim sexoDescripcion As String
        sexoDescripcion = ""


        If _sexo = "M" Then
            sexoDescripcion = "MASCULINO"

        ElseIf _sexo = "F" Then
            sexoDescripcion = "FEMENINO"
        End If

        _row.Cells(clmSexoDgvRef).Value = sexoDescripcion

        _row.Cells(clmValIniGenDgvRef).Value = valorInicial
        _row.Cells(clmValFinGenDgvRef).Value = valorFinal
    End Sub

    Private Sub intPoblarReferenciaEdad(ByRef _row As DataGridViewRow, _edadInicial As String, _edadFinal As String,
                                                valorInicial As String, valorFinal As String)


        _row.Cells(clmEdadIniDgvRef).Value = _edadInicial
        _row.Cells(clmEdadFinDgvRef).Value = _edadFinal

        _row.Cells(clmValIniGenDgvRef).Value = valorInicial
        _row.Cells(clmValFinGenDgvRef).Value = valorFinal
    End Sub

    Private Sub intPoblarReferenciaSexoYEdad(ByRef _row As DataGridViewRow, _sexo As Char,
                                             _edadInicial As String, _edadFinal As String,
                                             _valorInicial As String, _valorFinal As String)


        Dim sexoDescripcion As String
        sexoDescripcion = ""


        If _sexo = "M" Then
            sexoDescripcion = "MASCULINO"

        ElseIf _sexo = "F" Then
            sexoDescripcion = "FEMENINO"
        End If


        _row.Cells(clmSexoDgvRef).Value = sexoDescripcion

        _row.Cells(clmEdadIniDgvRef).Value = _edadInicial
        _row.Cells(clmEdadFinDgvRef).Value = _edadFinal


        If _sexo = "M" Then
            _row.Cells(clmValIniMasDgvRef).Value = _valorInicial
            _row.Cells(clmValFinMasDgvRef).Value = _valorFinal

        ElseIf _sexo = "F" Then
            _row.Cells(clmValIniMasDgvRef).Value = _valorFinal
            _row.Cells(clmValFinMasDgvRef).Value = _valorFinal
        End If
    End Sub

    Private Sub intCambiarEstructuraDgv(_codigoTipoReferencia As Short)
        Dim tipo As Short
        tipo = _codigoTipoReferencia


        If tipo = 1 Then
            'MOSTRAR
            dgvReferencias.Columns(clmValIniGenDgvRef).Visible = True
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = True


            'OCULTAR
            dgvReferencias.Columns(clmSexoDgvRef).Visible = False

            dgvReferencias.Columns(clmEdadIniDgvRef).Visible = False
            dgvReferencias.Columns(clmEdadFinDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniMasDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniFemDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinFemDgvRef).Visible = False


        ElseIf tipo = 2 Then
            'MOSTRAR
            dgvReferencias.Columns(clmSexoDgvRef).Visible = True
            dgvReferencias.Columns(clmValIniGenDgvRef).Visible = True
            dgvReferencias.Columns(clmValFinGenDgvRef).Visible = True


            'OCULTAR
            dgvReferencias.Columns(clmEdadIniDgvRef).Visible = False
            dgvReferencias.Columns(clmEdadFinDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniMasDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniFemDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinFemDgvRef).Visible = False


        ElseIf tipo = 3 Then
            'MOSTRAR
            dgvReferencias.Columns(clmEdadIniDgvRef).Visible = True
            dgvReferencias.Columns(clmEdadFinDgvRef).Visible = True

            dgvReferencias.Columns(clmValIniGenDgvRef).Visible = True
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = True


            'OCULTAR
            dgvReferencias.Columns(clmSexoDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniMasDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniFemDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinFemDgvRef).Visible = False


        ElseIf tipo = 4 Then
            'MOSTRAR
            dgvReferencias.Columns(clmEdadIniDgvRef).Visible = True
            dgvReferencias.Columns(clmEdadFinDgvRef).Visible = True

            dgvReferencias.Columns(clmValIniMasDgvRef).Visible = True
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = True

            dgvReferencias.Columns(clmValIniFemDgvRef).Visible = True
            dgvReferencias.Columns(clmValFinFemDgvRef).Visible = True



            'OCULTAR
            dgvReferencias.Columns(clmSexoDgvRef).Visible = False

            dgvReferencias.Columns(clmValIniGenDgvRef).Visible = False
            dgvReferencias.Columns(clmValFinMasDgvRef).Visible = False
        End If
    End Sub








    'EVENTOS MENU ----
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
    Private Sub btnBuscarExamen_Click(sender As Object, e As EventArgs) Handles btnBuscarExamen.Click
        Try
            If txtBuscarExamen.Text.Trim() = "" Then
                Return
            End If

            logTraerExamenes()
            intPoblarCboxExamen()


        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub cboxExamen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxExamen.SelectionChangeCommitted
        Try
            If cboxExamen.SelectedIndex < 0 Then
                Return
            End If

            intOcultarHintExamen()
            logSeleccinoarExamen()
            intMostrarKitPredeterminado()
            logTraerKits()
            intPoblarCboxKit()


        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxKit_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxKit.SelectionChangeCommitted
        Try
            If cboxKit.SelectedIndex < 0 Then
                Return
            End If

            intOcultarHintKit()
            logSeleccionarKit()
            logTraerReferencias()
            intPoblarDgvReferencias()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    'EVENTOS G2
    Private Sub dgvReferencias_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvReferencias.RowPostPaint
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

    'EVENTOS SUBMIT
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try

            logValidarEntradas()

            If negocio.entradasValidadas Then

                logEnviarObjetosADatabase()

                If negocio.respuestaSubmitActualizarKit > 0 Then
                    intMostrarMensaje("Los cambios se guardaron correctamente.")
                    reiniciarFormulario()
                Else
                    intMostrarMensaje("Error. No se pudo guardar los cambios")
                End If
            End If


        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub



End Class