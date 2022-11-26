Imports NEGOCIO

Public Class FormRegistrarMarcaKitEquipo

    'ATRIBUTOS LÓGICOS
    Private negocio As RegistroMarcaKitEquipo

    'ATRIBUTOS MENU
    Private tituloFormulario As String




    'METODOS INICIO -
    Public Sub New(ByRef _esFormHijo As Boolean)
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        negocio = New RegistroMarcaKitEquipo()
        preIniciarAtributosFormHijo(_esFormHijo)
        iniciarFormulario(False)
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormRegistrarMarcaKitEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        negocio.esFormHijo = _esHijo

        If negocio.esFormHijo Then

        Else

        End If
    End Sub

    Private Sub iniciarFormulario(_reinicio As Boolean)
        iniciarAtributos(_reinicio)
        iniciarProcesosNegocio()
        iniciarInterfaz()
    End Sub

    Private Sub iniciarAtributos(_reinicio As Boolean)
        'ATRIBUTOS LÓGICOS
        If _reinicio = True Then
            negocio = New RegistroMarcaKitEquipo()
        End If

        'ATRIBUTOS MENU
        tituloFormulario = "Registrar area de laboratorio"
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


        If Not negocio.esFormHijo Then
            menuStrip.Enabled = True
        Else
            menuStrip.Enabled = False
        End If
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelMarca.Enabled = True
        panelMarca.Visible = True

        txtNombreMarca.Enabled = True
        txtNombreMarca.Visible = True
        txtNombreMarca.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreMarca.Text = ""
        txtNombreMarca.CharacterCasing = CharacterCasing.Upper

        btnRegistrarMarca.Enabled = True
        btnRegistrarMarca.Visible = True
        btnRegistrarMarca.Font = New Font("Microsoft Sans Serif", 9)
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
        iniciarFormulario(True)
    End Sub











    'METODOS LÓGICOS SUBTMIT
    Private Sub logCargarEntradas()
        Dim nombreMarca As String

        nombreMarca = txtNombreMarca.Text.Trim()

        negocio.cargarEntradasSubmit(nombreMarca)
    End Sub

    Private Sub logValidarEntradas()
        Dim mensaje As String

        mensaje = negocio.validarEntradasSubmit(negocio.nombreMarcaInput)

        If Not mensaje = "" Then
            intMostrarMensaje(mensaje)
        End If
    End Sub

    Private Sub logEnviarObjetosADatabase()
        Try
            negocio.cargarObjetosParaSubmit()
            negocio.insertarMarca(negocio.nuevaMarca)

        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub














    'METODOS INTERFAZ MENU -----
    Private Sub intMostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub




















    'EVENTOS MENU
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub


    'EVENTOS SUBMIT
    Private Sub btnRegistrarMarca_Click(sender As Object, e As EventArgs) Handles btnRegistrarMarca.Click
        Try
            logCargarEntradas()

            logValidarEntradas()

            If negocio.entradasValidadas Then
                logEnviarObjetosADatabase()

                If negocio.codigoRespuestaInsercionMarca > 0 Then
                    intMostrarMensaje("La marca se guardó correctamente.")
                    reiniciarFormulario()
                Else
                    intMostrarMensaje("Error. No se pudo guardar la marca.")
                End If
            End If


        Catch ex As Exception
            intMostrarMensaje(ex.Message)
        End Try
    End Sub


End Class