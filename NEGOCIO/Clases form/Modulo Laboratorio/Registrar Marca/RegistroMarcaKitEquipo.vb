Imports DAL

Public Class RegistroMarcaKitEquipo

    'ATRIBUTOS LÓGICOS -----
    Private dal As TDatosSql

    'ATRIBUTOS FORMHIJO
    Public esFormHijo As Boolean

    'ATRIBUTOS SUBMIT
    Public nombreMarcaInput As String
    Public entradasValidadas As Boolean
    Public nuevaMarca As MarcaKitEquipoLaboratorio
    Public codigoRespuestaInsercionMarca As Short




    'METODOS INICIO -----
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS SUBMIT
        nombreMarcaInput = Nothing
        entradasValidadas = False
        nuevaMarca = Nothing
        codigoRespuestaInsercionMarca = 0
    End Sub


    Public Sub iniciarProcesos()

    End Sub










    'METODOS FUNCIONALES G1 -----
    Private Function traerMarcaRepetida(_nombre As String)
        Dim datatable As DataTable = traerMarcaRepetidaBD(_nombre), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function

    Public Sub insertarMarca(ByRef _marca As MarcaKitEquipoLaboratorio)
        Dim respuesta As Short

        respuesta = insertarMarcaBD(_marca)

        codigoRespuestaInsercionMarca = respuesta
    End Sub


    'METODOS FUNCIONALES SUBMIT
    Public Sub cargarEntradasSubmit(_nombreMarca As String)
        Try
            nombreMarcaInput = _nombreMarca

        Catch ex As Exception
            nombreMarcaInput = Nothing
        End Try
    End Sub

    Public Function validarEntradasSubmit(_nombreMarca As String)
        Dim mensaje As String

        mensaje = validarNombreMarca(_nombreMarca)
        If Not mensaje = "" Then
            entradasValidadas = False
            Return mensaje
        End If


        entradasValidadas = True
        Return ""
    End Function

    Private Function validarNombreMarca(_nombre As String) As String
        Dim cantidadRepetidos As Short

        cantidadRepetidos = traerMarcaRepetida(_nombre)

        If cantidadRepetidos > 0 Then Return "Error. El la marca con nombre " + _nombre + " ya es encuentra registradad en el sistema."

        If IsNothing(_nombre) Then Return "Error. Ingrese un nombre."

        If _nombre = "" Then Return "Error. Ingrese un nombre."

        Return ""
    End Function

    Public Sub cargarObjetosParaSubmit()
        Try
            nuevaMarca = New MarcaKitEquipoLaboratorio()
            nuevaMarca.setNombre(nombreMarcaInput)

        Catch ex As Exception
            nuevaMarca = Nothing
        End Try
    End Sub









    'METODOS BD G1 ----
    Private Function traerMarcaRepetidaBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerMarcaRepetida_RegistrarExamenLab", P)
    End Function

    Private Function insertarMarcaBD(ByRef _marca As MarcaKitEquipoLaboratorio) As Short
        Dim P As Object() = New Object(1) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _marca.getNombre()

        Return dal.Ejecutar("SPinsertarMarca_RegistrarMarcaKitEquipoLaboratorio", P)
    End Function





End Class
