Imports NEGOCIO

Public Class FormRegistrarExamenGrupoLaboratorio

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroExamenGrupoLab

    'ATRIBUTOS LÓGICOS MODO FORMHIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private areaSeleccionada As AreaLaboratorio

    'ATRIBUTOS G9
    Private nuevoGrupoExamen As GrupoExamenLaboratorio
    Private nuevoInputGrupoExamen As GrupoExamenLaboratorioInput


    'METODOS INICIO -
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

    Private Sub FormRegistrarExamenGrupoLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        poblarCboxArea()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroExamenGrupoLab()

        'ATRIBUTOS LÓGICOS MODO FORMHIJO
        'Private esFormHijo As Boolean

        'ATRIBUTOS G0
        tituloFormulario = "Registrar examen grupal de laboratorio"

        'ATRIBUTOS G1
        areaSeleccionada = New AreaLaboratorio()

        'ATRIBUTOS G9
        nuevoGrupoExamen = New GrupoExamenLaboratorio()
        nuevoInputGrupoExamen = New GrupoExamenLaboratorioInput()
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

        txtExamen.Enabled = True
        txtExamen.Visible = True
        txtExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtExamen.Text = ""
        txtExamen.CharacterCasing = CharacterCasing.Upper

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

        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
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



    'MÉTODOS LÓGICOS G1
    Private Sub seleccionarArea()
        Dim index As Short = cboxArea.SelectedIndex
        areaSeleccionada = registro.areas(index)
    End Sub


    'MÉTODOS LÓGICOS G9 
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then
                Dim objetosCargados As Boolean = cargarObjetos()
                If objetosCargados Then enviarDatosDatabase()
            Else
                mostrarMensaje(mensajeValidacion)
            End If
        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim nombre As String, inputArea As AreaLaboratorioInput

            nombre = txtExamen.Text.Trim()
            inputArea = New AreaLaboratorioInput()
            inputArea.codigo = areaSeleccionada.getCodigo()
            inputArea.nombre = areaSeleccionada.getNombre()

            nuevoInputGrupoExamen = New GrupoExamenLaboratorioInput()
            nuevoInputGrupoExamen.nombre = nombre
            nuevoInputGrupoExamen.area = inputArea
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevoInputGrupoExamen)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim nombre As String

            nombre = nuevoInputGrupoExamen.nombre

            nuevoGrupoExamen.setNombre(nombre)
            nuevoGrupoExamen.setArea(areaSeleccionada)

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatabase()
        Dim mensaje As String, estadoInsercion As Short

        registro.insertarGrupoExamen(nuevoGrupoExamen)
        mensaje = registro.generarMensajeInsercion()
        estadoInsercion = registro.estadoInsercion

        If Not mensaje = "" Then
            mostrarMensaje(mensaje)
            If estadoInsercion > 0 Then reiniciarFormulario()
        End If
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub




    'METODOS INTERFAZ
    Private Sub poblarCboxArea()
        cboxArea.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            cboxArea.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub mostrarHintArea()
        hintArea.Visible = True
    End Sub

    Private Sub ocultarHintArea()
        hintArea.Visible = False
    End Sub





    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub


    'EVENTOS G0
    Private Sub tsmItemMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles tsmItemMenuLaboratorio.Click
        Dim formMenuLaboratorio As New FormMenuLaboratorio()
        formMenuLaboratorio.Show()
        Me.Close()
    End Sub

    'EVENTOS G1
    Private Sub cboxArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxArea.SelectionChangeCommitted
        Try
            seleccionarArea()
            ocultarHintArea()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class



