Imports DAL

Public Class AdministracionExamenLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public areas As AreaLaboratorio()
    Public examenes As ExamenLaboratorio()
    Public grupos As GrupoExamenLaboratorio()

    'ATRIBUTOS G9
    Public estadoInsercion As Short



    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        areas = New AreaLaboratorio(-1) {}
        examenes = New ExamenLaboratorio(-1) {}
        grupos = New GrupoExamenLaboratorio(-1) {}

        'ATRIBUTOS G9
        estadoInsercion = 0
    End Sub



    'METODOS FUNCIONALES G1
    Public Sub traerAreas()
        Dim datatable As DataTable = traerAreasBD(), index As Short = 0
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nombre = "" Else nombre = row("NOMARE ARE").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerExamenes(ByRef _area As AreaLaboratorio)
        Dim datatable As DataTable = traerExamenesBD(_area), index As Short = 0
        examenes = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, codigoIndividual As Short

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()
            If IsDBNull(row("CODPETIND EXA")) Then codigoIndividual = 0 Else codigoIndividual = Short.Parse(row("CODPETIND EXA"))

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim examen As New ExamenLaboratorio()
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setArea(_area)
            examen.setCodigoIndividual(codigoIndividual)

            examenes(index) = examen
            index += 1
        Next
    End Sub

    Public Sub traerGrupos(ByRef _examen As ExamenLaboratorio)
        Dim datatable As DataTable = traerGruposBD(_examen), index As Short = 0
        grupos = New GrupoExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODGRU GRUEXA_EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODGRU GRUEXA_EXA"))
            If IsDBNull(row("NOMGRU GRU")) Then nombre = "" Else nombre = row("NOMGRU GRU").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim grupo As New GrupoExamenLaboratorio()
            grupo.setCodigo(codigo)
            grupo.setNombre(nombre)

            grupos(index) = grupo
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G9
    Public Sub updateExamen(ByRef _examen As ExamenLaboratorio)
        Dim respuesta As Short = updateExamenBD(_examen)
        estadoInsercion = respuesta
    End Sub

    Public Function generarMensajeInsercion()
        If estadoInsercion > 0 Then Return "Los cambios se aplicarón correctamente."
        If estadoInsercion <= 0 Then Return "Error. No se pudo guardar los cambios."
        Return ""
    End Function


    'METODOS BD G1 -
    Private Function traerAreasBD() As DataTable
        Return dal.TraerDataTable("SPtraerAreas_AdminsitrarExamenLaboratorio")
    End Function

    Private Function traerExamenesBD(ByRef _area As AreaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _area.getCodigo()

        Return dal.TraerDataTable("SPtraerExamenes_AdminsitrarExamenLaboratorio", P)
    End Function

    Private Function traerGruposBD(ByRef _examen As ExamenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _examen.getCodigo()
        Return dal.TraerDataTable("SPtraerGrupos_AdminsitrarExamenLaboratorio", P)
    End Function

    Private Function updateExamenBD(ByRef _examen As ExamenLaboratorio) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _examen.getCodigoIndividual()
        P(2) = _examen.getCodigo()

        Return dal.Ejecutar("SPactualizarExamen_AdminsitrarExamenLaboratorio", P)
    End Function



    'METODOS VALIDACIÓN
    Public Function validarEntradas(_inputExamen As ExamenLaboratorioInput) As String
        Dim mensaje As String

        mensaje = validarArea(_inputExamen.area)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarExamen(_inputExamen)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarArea(_area As AreaLaboratorioInput) As String
        If _area.codigo = "0" Then Return "Error. Seleccione un area."
        Return ""
    End Function

    Private Function validarExamen(_examen As ExamenLaboratorioInput) As String
        If _examen.codigo = "0" Then Return "Error. Seleccione un examen."
        Return ""
    End Function

End Class
