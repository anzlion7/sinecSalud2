Imports NEGOCIO

Public Class FormAdministrarExamenLab

    'ATRIBUTOS LÓGICOS
    Private registro As AdministracionExamenLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORMHIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private areaSeleccionada As AreaLaboratorio
    Private examenSeleccionado As ExamenLaboratorio


    'ATRIBUTOS G9
    Private nuevoExamen As ExamenLaboratorio
    Private nuevoInputExamen As ExamenLaboratorioInput

    'METODOS INICIO -
    Public Sub New(ByRef _esFormHijo As Boolean)
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(_esFormHijo)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormAdministrarExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        esFormHijo = _esHijo

        If esFormHijo Then

        Else

        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()

        registro.traerAreas()
        poblarCboxAreas()

    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New AdministracionExamenLaboratorio()

        'ATRIBUTOS LÓGICOS MODO FORMHIJO
        'Private esFormHijo As Boolean

        'ATRIBUTOS G0
        tituloFormulario = "Administrar examen de laboratorio"

        'ATRIBUTOS G1
        areaSeleccionada = New AreaLaboratorio()
        examenSeleccionado = New ExamenLaboratorio()

        'ATRIBUTOS G9
        nuevoExamen = New ExamenLaboratorio()
        nuevoInputExamen = New ExamenLaboratorioInput()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper

        If esFormHijo Then menuStrip.Enabled = False
        If Not esFormHijo Then menuStrip.Enabled = True
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelExamen.Enabled = True
        panelExamen.Visible = True

        cboxArea.Enabled = True
        cboxArea.Visible = True
        cboxArea.Font = New Font("Microsoft Sans Serif", 9)
        cboxArea.Items.Clear()
        cboxArea.DropDownStyle = ComboBoxStyle.DropDownList

        hintArea.Enabled = True
        hintArea.Visible = True
        hintArea.Font = New Font("Microsoft Sans Serif", 8)
        hintArea.Text = "SELECCIONAR"
        hintArea.BackColor = Color.Transparent

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

        chIndividual.Enabled = True
        chIndividual.Visible = True
        chIndividual.Checked = False
        chIndividual.Font = New Font("Microsoft Sans Serif", 9.5)
        'chIndividual.Text = "Se puede solicitar individualemente"

        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviarDatos.Text = "Aplicar cambios"
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



    'METODOS LOGICOS G1
    Private Sub seleccionarArea()
        Dim index As Short = cboxArea.SelectedIndex
        areaSeleccionada = registro.areas(index)
    End Sub

    Private Sub seleccionarExamen()
        Dim index As Short = cboxExamen.SelectedIndex
        examenSeleccionado = registro.examenes(index)
    End Sub


    'MÉTODOS LÓGICOS G9 
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean, mensajeValidacion As String, objetosCargados As Boolean

        entradasCargadas = cargarEntradas()

        If entradasCargadas Then
            mensajeValidacion = validarEntradas()

            If mensajeValidacion = "" Then
                objetosCargados = cargarObjetos()
                If objetosCargados Then enviarDatosDatanase()
            Else
                mostrarMensaje(mensajeValidacion)
            End If

        End If
    End Sub

    Private Function cargarEntradas()
        Try
            Dim codigo As Long, inputArea As AreaLaboratorioInput, codigoIndividual As Short

            codigo = examenSeleccionado.getCodigo()
            inputArea = New AreaLaboratorioInput()
            inputArea.codigo = areaSeleccionada.getCodigo()
            inputArea.nombre = areaSeleccionada.getNombre()
            If chIndividual.Checked = True Then codigoIndividual = 1
            If chIndividual.Checked = False Then codigoIndividual = 2

            nuevoInputExamen = New ExamenLaboratorioInput()
            nuevoInputExamen.codigo = codigo
            nuevoInputExamen.area = inputArea
            nuevoInputExamen.codigoIndividual = codigoIndividual
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevoInputExamen)
        Return mensaje
    End Function

    Private Function cargarObjetos() As Boolean
        Try
            Dim codigo As Long, codigoIndividual As Short

            codigo = examenSeleccionado.getCodigo()
            codigoIndividual = Short.Parse(nuevoInputExamen.codigoIndividual)

            nuevoExamen = New ExamenLaboratorio()
            nuevoExamen.setCodigo(codigo)
            nuevoExamen.setCodigoIndividual(codigoIndividual)
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatanase()
        Dim estadoInsercion As Short, mensajeInsercion As String

        registro.updateExamen(nuevoExamen)
        estadoInsercion = registro.estadoInsercion
        mensajeInsercion = registro.generarMensajeInsercion()
        mostrarMensaje(mensajeInsercion)

        If estadoInsercion > 0 Then reiniciarFormulario()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub








    'METODOS INTERFAZ G1
    Private Sub poblarCboxAreas()
        cboxArea.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            cboxArea.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub ocultarHintArea()
        hintArea.Visible = False
    End Sub

    Private Sub poblarCboxExamenes()
        cboxExamen.Items.Clear()

        For Each examen As ExamenLaboratorio In registro.examenes
            cboxExamen.Items.Add(examen.getNombre())
        Next
    End Sub

    Private Sub ocultarHintExamenes()
        hintExamen.Visible = False
    End Sub

    Private Sub poblarLboxGrupos()
        lboxGrupos.Items.Clear()

        For Each grupo As GrupoExamenLaboratorio In registro.grupos
            lboxGrupos.Items.Add(grupo.getNombre())
        Next
    End Sub

    Private Sub mostrarDatosExamenSeleccionado()
        Dim codigoIndividual As Short = examenSeleccionado.getCodigoIndividual()

        If codigoIndividual = 1 Then chIndividual.Checked = True
        If codigoIndividual = 2 Then chIndividual.Checked = False
    End Sub



    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub








    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub

    'EVENTOS G1
    Private Sub cboxArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxArea.SelectionChangeCommitted
        Try
            seleccionarArea()
            ocultarHintArea()

            registro.traerExamenes(areaSeleccionada)
            poblarCboxExamenes()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxExamen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxExamen.SelectionChangeCommitted
        Try
            seleccionarExamen()
            ocultarHintExamenes()

            registro.traerGrupos(examenSeleccionado)
            poblarLboxGrupos()

            mostrarDatosExamenSeleccionado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G9
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class