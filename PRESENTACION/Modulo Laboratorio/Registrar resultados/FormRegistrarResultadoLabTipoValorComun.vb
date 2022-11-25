Imports NEGOCIO

Public Class FormRegistrarResultadoLabTipoValorComun

    'ATRIBUTOS LÓGICOS ---- 
    Private negocio As RegistroResultadosEnValoresReferencia
    Public formIniciado As Boolean

    'ATRIBUTOS G0
    Private tituloDeFormulario As String

    'ATRIBUTOS G3
    Private clmSexoDgvReferencias As String
    Private clmEdadDesdeDgvReferencias As String
    Private clmEdadHastaDgvReferencias As String
    Private clmValorDesdeDgvReferencias As String
    Private clmValorHastaDgvReferencias As String




    'METODOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        negocio = New RegistroResultadosEnValoresReferencia()
        preIniciarAtributosFormHijo(False, Nothing, Nothing, 0)
        iniciarFormulario()
    End Sub

    Public Sub New(ByRef _resultado As ResultadoLaboratorio, ByRef _asegurado As Asegurado, _modoTipoUsuario As Short)
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        negocio = New RegistroResultadosEnValoresReferencia()
        preIniciarAtributosFormHijo(True, _resultado, _asegurado, _modoTipoUsuario)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormGuardarResultadoVReferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean, ByRef _resultado As ResultadoLaboratorio,
                                            ByRef _asegurado As Asegurado, _modoTipoUsuario As Short)
        negocio.estadoFormGuardado = False

        If _esHijo Then
            negocio.esFormHijo = True
            negocio.pResultado = _resultado
            negocio.pAsegurado = _asegurado
            negocio.modoTipoUsuario = _modoTipoUsuario
            negocio.pExamen = _resultado.getExamen()

        Else
            negocio.esFormHijo = False
            negocio.pResultado = Nothing
            negocio.pAsegurado = Nothing
            negocio.modoTipoUsuario = 0
            negocio.pExamen = Nothing
        End If
    End Sub

    Private Sub iniciarFormulario()
        Dim codigoExamen As Short, codigoKit As Short, codigoTipoReferencia As Short
        Dim asegurado As Asegurado
        Dim kitNoAsignado As Boolean


        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()
        iniciarInterfazSegunTipoUsuario()


        intMostrarDatosExamen()
        intMostrarDatosAsegurado()


        codigoExamen = negocio.pExamen.getCodigo()
        negocio.traerKitPredeterminado(codigoExamen)


        kitNoAsignado = negocio.revisarKitPredeterminadoSinAsignar()

        If kitNoAsignado Then
            cerrarFormlarioFaltaDatos("Error. Este examen no tiene asignado un Kit-Equipo predeterminado. Asigne uno y vuelva a intentar.")
            Return
        Else

            intMostrarKitPredeterminado()

            codigoKit = negocio.kitPredeterminado.getCodigo()
            negocio.traerReferencias(codigoKit)


            codigoTipoReferencia = negocio.kitPredeterminado.getTipoReferencia().getCorrelativo()
            asegurado = negocio.pAsegurado
            negocio.asignarReferenciaAsegurado(codigoTipoReferencia, asegurado)


            intAjustarInterfazDgvReferencias()
            intPoblarDgvReferencias()

            intDeseleccionarEnDgvReferencias()
            intDespintarObservacionFilaDgv()

            intDespintarObersvacionNumResultado()

            intHabilitarNumResultado()
            intReiniciarNumResultado()

            negocio.traerProcesadores()
            poblarCboxProcesador()
        End If


    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS ---- 
        formIniciado = True

        'ATRIBUTOS G0
        tituloDeFormulario = "Registrar resultados de tipo valor numérico"

        'ATRIBUTOS G3
        clmSexoDgvReferencias = "clmSexo"
        clmEdadDesdeDgvReferencias = "clmEdadDesde"
        clmEdadHastaDgvReferencias = "clmEdadHasta"
        clmValorDesdeDgvReferencias = "clmDesde"
        clmValorHastaDgvReferencias = "clmHasta"
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
        iniciarInterfazGrupo2()
        iniciarInterfazGrupo3()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloDeFormulario

        lblTituloPrincipal.Text = tituloDeFormulario.ToUpper()
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelDatosExamen.Enabled = True
        panelDatosExamen.Visible = True

        lblExamen.Enabled = False
        lblExamen.Visible = True

        txtExamen.Enabled = False
        txtExamen.Visible = True
        txtExamen.ReadOnly = True
        txtExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtExamen.Text = ""
        txtExamen.CharacterCasing = CharacterCasing.Upper

        lblArea.Enabled = False
        lblArea.Visible = True

        txtArea.Enabled = False
        txtArea.Visible = True
        txtArea.ReadOnly = True
        txtArea.Font = New Font("Microsoft Sans Serif", 9)
        txtArea.Text = ""
        txtArea.CharacterCasing = CharacterCasing.Upper

        lblUnidad.Enabled = False
        lblUnidad.Visible = True

        txtUnidad.Enabled = False
        txtUnidad.Visible = True
        txtUnidad.ReadOnly = True
        txtUnidad.Font = New Font("Microsoft Sans Serif", 9)
        txtUnidad.Text = ""
        txtUnidad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarInterfazGrupo2()
        panelDatosAsegurado.Enabled = True
        panelDatosAsegurado.Visible = True

        lblNombreAsegurado.Enabled = False
        lblNombreAsegurado.Visible = True

        txtAsegurado.Enabled = False
        txtAsegurado.Visible = True
        txtAsegurado.ReadOnly = True
        txtAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtAsegurado.Text = ""
        txtAsegurado.CharacterCasing = CharacterCasing.Upper

        lblMatricula.Enabled = False
        lblMatricula.Visible = True

        txtMatricula.Enabled = False
        txtMatricula.Visible = True
        txtMatricula.ReadOnly = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""
        txtMatricula.CharacterCasing = CharacterCasing.Upper

        lblSexo.Enabled = False
        lblSexo.Visible = True

        txtSexo.Enabled = False
        txtSexo.Visible = True
        txtSexo.ReadOnly = True
        txtSexo.Font = New Font("Microsoft Sans Serif", 9)
        txtSexo.Text = ""
        txtSexo.CharacterCasing = CharacterCasing.Upper

        lblEdad.Enabled = False
        lblEdad.Visible = True

        txtEdad.Enabled = False
        txtEdad.Visible = True
        txtEdad.ReadOnly = True
        txtEdad.Font = New Font("Microsoft Sans Serif", 9)
        txtEdad.Text = ""
        txtEdad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarInterfazGrupo3()
        panelDatosResultado.Enabled = True
        panelDatosResultado.Visible = True

        lblHeaderEmpty.Enabled = True
        lblHeaderEmpty.Visible = False
        lblHeaderEmpty.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderEmpty.Text = ""
        lblHeaderEmpty.BackColor = Color.FromArgb(235, 235, 235)
        'lblHeaderEmpty.Location = New Point(0, 0)
        'lblHeaderEmpty.Size = New Size(0, 0)

        lblHeaderEdad.Enabled = True
        lblHeaderEdad.Visible = False
        lblHeaderEdad.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderEdad.Text = "EDAD"
        lblHeaderEdad.BackColor = Color.FromArgb(235, 235, 235)
        'lblHeaderEdad.Location = New Point(0, 0)
        'lblHeaderEdad.Size = New Size(0, 0)

        lblHeaderValorDeReferencia.Enabled = True
        lblHeaderValorDeReferencia.Visible = False
        lblHeaderValorDeReferencia.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderValorDeReferencia.Text = "VALORES EN "
        lblHeaderValorDeReferencia.BackColor = Color.FromArgb(235, 235, 235)
        'lblHeaderValorDeReferencia.Location = New Point(0, 0)
        'lblHeaderValorDeReferencia.Size = New Size(0, 0)

        iniciarDgvReferencias()

        numResultado.Enabled = False
        numResultado.ReadOnly = False
        numResultado.Font = New Font("Microsoft Sans Serif", 10)
        numResultado.Text = "0.000"
        numResultado.Maximum = 999999.999


        chboxResVacio.Enabled = True
        chboxResVacio.Visible = True
        chboxResVacio.Checked = False
        chboxResVacio.Font = New Font("Microsoft Sans Serif", 9)
        'chboxResVacio.Text = ""

        cboxProcesador.Enabled = True
        cboxProcesador.Visible = True
        cboxProcesador.Font = New Font("Microsoft Sans Serif", 9)
        cboxProcesador.Items.Clear()
        cboxProcesador.DropDownStyle = ComboBoxStyle.DropDownList

        hintProcesador.Enabled = True
        hintProcesador.Visible = True
        hintProcesador.Font = New Font("Microsoft Sans Serif", 9)
        hintProcesador.Text = "SELECCIONAR"
        hintProcesador.BackColor = Color.Transparent
    End Sub

    Public Sub iniciarDgvReferencias()
        'propiedades encabezados columnas (labels)
        lblHeaderEmpty.Visible = False
        lblHeaderEmpty.Text = ""

        lblHeaderEdad.Visible = False
        lblHeaderEdad.Text = "EDAD"

        lblHeaderValorDeReferencia.Visible = False
        lblHeaderValorDeReferencia.Text = "VALORES EN"


        'propiedades base
        dgvReferencias.Enabled = True
        dgvReferencias.Font = New Font("Microsoft Sans Serif", 9)


        'propiedades permisos editar
        dgvReferencias.EditMode = DataGridViewEditMode.EditOnEnter
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False
        dgvReferencias.AllowUserToResizeRows = False
        dgvReferencias.AllowUserToOrderColumns = False
        dgvReferencias.AllowUserToResizeColumns = False
        dgvReferencias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvReferencias.MultiSelect = False
        dgvReferencias.ReadOnly = True


        'propiedades estilos selección
        dgvReferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        'propiedades estilos color encabezados columnas
        dgvReferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvReferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black


        'propiedades estilos color seleccion encabezados filas
        dgvReferencias.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)


        'propiedaes estilos color celdas
        dgvReferencias.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.DefaultCellStyle.ForeColor = Color.Black


        'propiedaes estilos color celdas seleccionadas
        dgvReferencias.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)


        'propiedades otras celdas
        dgvReferencias.ScrollBars = ScrollBars.Both
        dgvReferencias.EnableHeadersVisualStyles = False


        'columnas -- agregar columnas
        dgvReferencias.Columns.Clear()

        dgvReferencias.Columns.Add(clmSexoDgvReferencias, "SEXO")
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmEdadDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmEdadHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmValorDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmValorHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'centrar columnas
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'configurar ancho columnas
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaBnf).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreBnf).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmFechaCreacion).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreEstado).FillWeight = 15
        'dgvAvisos.Columns(dgvBajaNomClmFecPres).FillWeight = 15

        'filas
        dgvReferencias.Rows.Clear()
    End Sub

    Private Sub iniciarInterfazSegunTipoUsuario()

        If negocio.modoTipoUsuario = 3 Then

            cboxProcesador.Enabled = False
            hintProcesador.Enabled = False
            hintProcesador.Text = Usuario.nameUserLoggedSystem
        End If
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Int16 = 1050
        'Dim ejeY As Int16 = 530

        'Size = New Size(ejeX, ejeY)
        'MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        'MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub

    Private Sub cerrarFormlarioFaltaDatos(_mensaje As String)
        intMostrarMensaje(_mensaje)
        formIniciado = False
        Close()
    End Sub








    'METODOS LOGICOS G3

    Private Sub seleccionarProcesador()
        Dim index As Short = cboxProcesador.SelectedIndex
        negocio.procesadorSeleccionado = negocio.procesadores(index)
    End Sub

    Private Sub hayObservacion()
        Dim valorIngresado As Double

        valorIngresado = numResultado.Value

        negocio.observacion = negocio.hayObservacion(negocio.referenciaDelPaciente, valorIngresado)
    End Sub

    Private Sub buscarIndexObservacion()
        negocio.buscarIndexObservacion(negocio.referenciaDelPaciente)
    End Sub

    'METODOS LOGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then
                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    If negocio.esFormHijo Then

                        If negocio.observacion Then
                            Dim result As DialogResult
                            result = preguntarGuardarConObservacion()

                            If result = vbYes Then
                                guardarEstadoResultado()
                                ocultarFormulario()
                            End If

                        Else
                            guardarEstadoResultado()
                            ocultarFormulario()
                        End If

                    Else
                        enviarDatosDatabase()
                    End If
                End If

            Else
                intMostrarMensaje(mensajeValidacion)
            End If
        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim proveedor As ProveedorKitEquipoInput, kitequipo As KitEquipoLaboratorioInput, inputProcesador As UsuarioInput,
            valorResultado As Double, kit As KitEquipoLaboratorio

            kit = negocio.kitPredeterminado

            kitequipo = New KitEquipoLaboratorioInput()
            kitequipo.codigo = kit.getCodigo()

            inputProcesador = New UsuarioInput()
            If negocio.modoTipoUsuario = 3 Then
                inputProcesador = New UsuarioInput()
                inputProcesador.codigo = Usuario.codUserLoggedSystem
                inputProcesador.nombres = Usuario.nameUserLoggedSystem

            ElseIf negocio.modoTipoUsuario = 4 Then
                inputProcesador = New UsuarioInput()
                inputProcesador.codigo = negocio.procesadorSeleccionado.getCodigo()
                inputProcesador.nombres = negocio.procesadorSeleccionado.getNombres()
            End If
            valorResultado = numResultado.Value


            negocio.nuevoInputResultado = New ResultadoLaboratorioInput()
            negocio.nuevoInputResultado.kitequipo = kitequipo
            negocio.nuevoInputResultado.valorTipoComun = valorResultado
            negocio.nuevoInputResultado.procesador = inputProcesador
            Return True

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = negocio.validarEntradas(negocio.nuevoInputResultado, negocio.modoTipoUsuario)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim procesador As Usuario, codProcesador As Long, nomProcesador As String, valorResultado As Double,
                kit As KitEquipoLaboratorio, observacion As String, referencia As ReferenciaResultadoLaboratorio

            kit = negocio.kitPredeterminado

            codProcesador = negocio.nuevoInputResultado.procesador.codigo
            nomProcesador = negocio.nuevoInputResultado.procesador.nombres
            observacion = txtObservacion.Text.Trim()
            referencia = negocio.referenciaDelPaciente


            procesador = New Usuario()
            procesador.setCodigo(codProcesador)
            procesador.setNombres(nomProcesador)
            valorResultado = negocio.nuevoInputResultado.valorTipoComun
            kit.setProveedor(negocio.proveedorSeleccionado)


            If negocio.resultadoVacio Then
                negocio.pResultado.setVacio(True)
            Else
                negocio.pResultado.setVacio(False)
            End If

            negocio.pResultado.setKitEquipo(kit)
            negocio.pResultado.setProcesador(procesador)
            negocio.pResultado.setValorTipoComun(valorResultado)
            negocio.pResultado.setObservacion(observacion)
            negocio.pResultado.setReferenccia(referencia)
            Return True

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub guardarEstadoResultado()
        negocio.pResultado.setAsignado(True)
    End Sub

    Private Sub ocultarFormulario()
        Me.Hide()
    End Sub

    Private Sub enviarDatosDatabase()
        'registro.insertReferencias(tipoReferenciaSeleccionada, nuevasReferencias)

        'Dim mensajeInsercion As String = registro.generarMensajeInsercion()
        'mostrarMensaje(mensajeInsercion)
    End Sub

    Private Sub descartarResultado()
        negocio.pResultado.setAsignado(False)
    End Sub




    'METODOS INTERFAZ G1
    Private Sub intMostrarDatosExamen()
        Dim examen As ExamenLaboratorio
        Dim nombreExamen As String, nombreArea As String, descripcionUnidad As String

        examen = negocio.pExamen
        nombreExamen = examen.getNombre()
        nombreArea = examen.getArea().getNombre()
        descripcionUnidad = negocio.pResultado.getUnidad().getNombre() + " " + negocio.pResultado.getUnidad().getAbreviacion()


        txtExamen.Text = nombreExamen
        txtArea.Text = nombreArea
        txtUnidad.Text = descripcionUnidad
    End Sub


    'METODOS INTERFAZ G2
    Private Sub intMostrarDatosAsegurado()
        Dim asegurado As Asegurado
        Dim nombre As String, matricula As String, sexo As String,
            edad As String

        asegurado = negocio.pAsegurado

        nombre = asegurado.getApellidoPaterno() + " " + asegurado.getApellidoMaterno() + " " + asegurado.getNombres()
        matricula = asegurado.getMatricula()
        sexo = asegurado.getSexo()
        If sexo = "M" Then sexo = "MASCULINO" Else If sexo = "F" Then sexo = "FEMENINO"

        edad = asegurado.getEdad()
        edad = Utilitarios.calcularEdad(asegurado.getFechaNacimiento()).ToString()


        txtAsegurado.Text = nombre
        txtMatricula.Text = matricula
        txtSexo.Text = sexo
        txtEdad.Text = edad
    End Sub


    'METODOS INTERFAZ G3
    Private Sub intMostrarKitPredeterminado()
        Dim nombre As String

        nombre = negocio.kitPredeterminado.getMarca().getNombre
        txtKit.Text = nombre
    End Sub

    Private Sub poblarCboxProcesador()
        For Each procesador As Usuario In negocio.procesadores
            Dim apPaterno As String, apMaterno As String, nombres As String, nombreCompleto As String

            apPaterno = procesador.getApellidoPaterno()
            apMaterno = procesador.getApellidoMaterno()
            nombres = procesador.getNombres()
            nombreCompleto = apPaterno + " " + apMaterno + " " + nombres

            cboxProcesador.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub mostrarHintProcesador()
        hintProcesador.Visible = True
    End Sub

    Private Sub ocultarHintProcesador()
        hintProcesador.Visible = False
    End Sub

    Private Sub intPoblarDgvReferencias()
        Dim tipoReferencia As Short

        dgvReferencias.Rows.Clear()

        tipoReferencia = negocio.kitPredeterminado.getTipoReferencia.getCorrelativo()

        For Each referencia As ReferenciaResultadoLaboratorio In negocio.referencias
            Dim index As Short = dgvReferencias.Rows.Add()
            Dim rowActual As DataGridViewRow = dgvReferencias.Rows(index)


            If tipoReferencia = 1 Then
                Dim valorDesde As Double, valorHasta As Double

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta


            ElseIf tipoReferencia = 2 Then
                Dim valorDesde As Double, valorHasta As Double, sexo As String

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()
                sexo = referencia.getSexo()
                If sexo = "M" Then sexo = "MASCULINO"
                If sexo = "F" Then sexo = "FEMENINO"

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta
                rowActual.Cells(clmSexoDgvReferencias).Value = sexo


            ElseIf tipoReferencia = 3 Then
                Dim valorDesde As Double, valorHasta As Double, edadInicio As Short, edadFin As Short

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()
                edadInicio = referencia.getEdadInicio()
                edadFin = referencia.getEdadFin()

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta
                rowActual.Cells(clmEdadDesdeDgvReferencias).Value = edadInicio
                rowActual.Cells(clmEdadHastaDgvReferencias).Value = edadFin


            ElseIf tipoReferencia = 4 Then
                Dim valorDesde As Double, valorHasta As Double, sexo As String,
                    edadInicio As Short, edadFin As Short

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()
                sexo = referencia.getSexo()
                If sexo = "M" Then sexo = "MASCULINO"
                If sexo = "F" Then sexo = "FEMENINO"
                edadInicio = referencia.getEdadInicio()
                edadFin = referencia.getEdadFin()

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta
                rowActual.Cells(clmSexoDgvReferencias).Value = sexo
                rowActual.Cells(clmEdadDesdeDgvReferencias).Value = edadInicio
                rowActual.Cells(clmEdadHastaDgvReferencias).Value = edadFin
            End If
        Next

    End Sub

    Private Sub intAjustarInterfazDgvReferencias()
        Dim tipoReferencia As Short

        tipoReferencia = negocio.kitPredeterminado.getTipoReferencia().getCorrelativo()

        If tipoReferencia = 1 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False
            lblHeaderEdad.Visible = False
            lblHeaderValorDeReferencia.Visible = False
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False


            'MOSTRAR CULUMAS
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


        ElseIf tipoReferencia = 2 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False
            lblHeaderEdad.Visible = False
            lblHeaderValorDeReferencia.Visible = False
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False


            'MOSTRAR CULUMAS
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


            'AJUSTAR TAMAÑO HEADERS
            'lblHeaderEmpty.Location = New Point(0, 0)
            'lblHeaderEmpty.Size = New Size(0, 0)
            lblHeaderEdad.Location = New Point(139, 74)
            lblHeaderEdad.Size = New Size(161, 18)
            lblHeaderValorDeReferencia.Location = New Point(299, 74)
            lblHeaderValorDeReferencia.Size = New Size(164, 18)


        ElseIf tipoReferencia = 3 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False


            'MOSTRAR CULUMAS
            lblHeaderEdad.Visible = True
            lblHeaderValorDeReferencia.Visible = True
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


            'AJUSTAR TAMAÑO HEADERS
            'lblHeaderEmpty.Location = New Point(0, 0)
            'lblHeaderEmpty.Size = New Size(0, 0)
            lblHeaderEdad.Location = New Point(58, 74)
            lblHeaderEdad.Size = New Size(203, 18)
            lblHeaderValorDeReferencia.Location = New Point(261, 74)
            lblHeaderValorDeReferencia.Size = New Size(202, 18)


        ElseIf tipoReferencia = 4 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False


            'MOSTRAR CULUMAS
            lblHeaderEdad.Visible = True
            lblHeaderValorDeReferencia.Visible = True
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


            'AJUSTAR TAMAÑO HEADERS
            'lblHeaderEmpty.Location = New Point(0, 0)
            'lblHeaderEmpty.Size = New Size(0, 0)
            lblHeaderEdad.Location = New Point(139, 74)
            lblHeaderEdad.Size = New Size(161, 18)
            lblHeaderValorDeReferencia.Location = New Point(299, 74)
            lblHeaderValorDeReferencia.Size = New Size(164, 18)
        End If
    End Sub

    Private Sub intDeseleccionarEnDgvReferencias()
        dgvReferencias.ClearSelection()
    End Sub

    Private Sub pintarObservacionControlesInterfaz()
        pintarObservacionFilDgv()
        pintarObservacionNumResultado()
    End Sub

    Private Sub pintarObservacionFilDgv()
        Dim index As Short = negocio.observacionIndex

        dgvReferencias.Rows(index).DefaultCellStyle.BackColor = Color.FromArgb(255, 46, 46)
    End Sub

    Private Sub pintarObservacionNumResultado()
        numResultado.BackColor = Color.FromArgb(255, 46, 46)
    End Sub

    Private Sub despintarObservacionControlesInterfaz()
        intDespintarObservacionFilaDgv()
        intDespintarObersvacionNumResultado()
    End Sub

    Private Sub intDespintarObservacionFilaDgv()
        For Each row As DataGridViewRow In dgvReferencias.Rows
            row.DefaultCellStyle.BackColor = Color.White
        Next
    End Sub

    Private Sub intDespintarObersvacionNumResultado()
        numResultado.BackColor = Color.White
    End Sub

    Private Sub intHabilitarNumResultado()
        numResultado.Enabled = True
    End Sub

    Private Sub deshabilitarNumResultado()
        numResultado.Enabled = False
    End Sub

    Private Sub intReiniciarNumResultado()
        numResultado.Value = 0.000
        numResultado.BackColor = Color.White
    End Sub

    Private Sub intHabilitarInputResultado()
        lblResultado.Visible = True

        numResultado.Visible = True
        numResultado.Enabled = True

    End Sub

    Private Sub intDeshabilitarInputResultado()
        lblResultado.Visible = False

        numResultado.Visible = False
        numResultado.Enabled = False
    End Sub



    'METODOS INTERFAZ G9
    Private Sub intMostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub

    Private Function preguntarGuardarConObservacion() As DialogResult
        Dim dialogResult As DialogResult

        dialogResult = MessageBox.Show("´¿El resultado actual se encuentra fuera del rango de los valores de referencia. Desea confirmar este resultado?", "Mensaje.", MessageBoxButtons.YesNo)

        If dialogResult = vbYes Then Return vbYes Else Return vbNo
    End Function









    'EVENTOS G3
    Private Sub cboxProcesador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProcesador.SelectionChangeCommitted
        Try
            seleccionarProcesador()
            ocultarHintProcesador()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub numResultado_ValueChanged(sender As Object, e As EventArgs) Handles numResultado.ValueChanged
        Try
            hayObservacion()

            If negocio.observacion Then
                buscarIndexObservacion()
                pintarObservacionControlesInterfaz()
            Else
                despintarObservacionControlesInterfaz()
            End If

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub chboxResVacio_CheckedChanged(sender As Object, e As EventArgs) Handles chboxResVacio.CheckedChanged
        Try
            Dim estado As Boolean

            estado = chboxResVacio.Checked
            negocio.actualizarEstadoResultadoVacio(estado)

            If negocio.resultadoVacio Then
                intDeshabilitarInputResultado()
            Else
                intHabilitarInputResultado()
            End If

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub


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

    'EVENTOS G9
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub FormRegistrarResultadoLabTipoValorComun_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If e.CloseReason = CloseReason.UserClosing Then
                descartarResultado()
            End If

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub



End Class