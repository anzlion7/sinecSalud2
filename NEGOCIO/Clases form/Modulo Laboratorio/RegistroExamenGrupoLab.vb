Imports DAL

Public Class RegistroExamenGrupoLab

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public areas As AreaLaboratorio()

    'ATRIBUTOS G9
    Public estadoInsercion As Short


    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        areas = New AreaLaboratorio(-1) {}

        'ATRIBUTOS G9
        estadoInsercion = 0
    End Sub



    'METODOS FUNCIONALES G2 
    Public Sub traerAreas()
        Dim datatable As DataTable = traerAreasBD(), index As Short = 0
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nombre = "" Else nombre = row("NOMARE ARE").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub


    Private Function traerGrupoExamenRepetido(_nombreGrupoExamen As String)
        Dim datatable As DataTable = traerGrupoExamenRepetidoBD(_nombreGrupoExamen), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function



    'METODOS FUNCIONALES G9
    Public Sub insertarGrupoExamen(ByRef _grupoExamen As GrupoExamenLaboratorio)
        Dim respuesta As Short

        respuesta = insertarGrupoExamenBD(_grupoExamen)
        estadoInsercion = respuesta
    End Sub

    Public Function generarMensajeInsercion()
        If estadoInsercion > 0 Then Return "El examen grupal se guardó correctamente."
        If estadoInsercion < 0 Then Return "Ocurrió un error al guardar el examen grupal."
        Return ""
    End Function





    'METODOS BD G1 -
    Private Function traerAreasBD() As DataTable
        Return dal.TraerDataTable("SPtraerAreas_RegistrarGrupoExamenLaboratorio")
    End Function

    Private Function traerGrupoExamenRepetidoBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerGrupoExamenRepetido_RegistrarGrupoExamenLaboratorio", P)
    End Function

    'METODOS BD G9
    Private Function insertarGrupoExamenBD(ByRef _grupoExamen As GrupoExamenLaboratorio) As Short
        Dim P As Object() = New Object(2) {}

        P(0) = Usuario.codUserLoggedSystem
        P(1) = _grupoExamen.getNombre()
        P(2) = _grupoExamen.getArea().getCodigo()

        'If String.IsNullOrEmpty() Then P(11) = DBNull.Value Else P(11) = _beneficiario.getNroLibro()

        Return dal.Ejecutar("SPregistrarGrupoExamen_RegistrarGrupoExamenLaboratorio", P)
    End Function





    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _grupoExamen As GrupoExamenLaboratorioInput)
        Dim mensaje As String

        mensaje = validarNombre(_grupoExamen.nombre)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarArea(_grupoExamen.area)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarNombre(ByRef _nombre As String) As String
        Dim nroRepetidos As Short

        If String.IsNullOrEmpty(_nombre) Then Return "Error. Ingrese el nombre del examen grupal."

        nroRepetidos = traerGrupoExamenRepetido(_nombre)
        If nroRepetidos > 0 Then Return "Error. El examen grupal  " + _nombre + " ya existe en el sistema."

        Return ""
    End Function

    Private Function validarArea(ByRef _area As AreaLaboratorioInput) As String
        If _area.codigo = "0" Then Return "Error. Seleccione un area."
        Return ""
    End Function

End Class
