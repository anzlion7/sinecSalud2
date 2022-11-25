Imports System.Windows.Forms
Imports DAL

Public Class AdministracionGrupoExamen

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public areas As AreaLaboratorio()

    'ATRIBUTOS G2
    Public grupos As GrupoExamenLaboratorio()

    'ATRIBUTOS G3A
    Public examenesDelGrupo As ExamenLaboratorio()
    Public examenesDelArea As ExamenLaboratorio()

    'ATRIBUTOS G9
    Public estadoInsercion As Short

    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        areas = New AreaLaboratorio(-1) {}

        'ATRIBUTOS G2
        grupos = New GrupoExamenLaboratorio(-1) {}

        'ATRIBUTOS G3A
        examenesDelGrupo = New ExamenLaboratorio(-1) {}
        examenesDelArea = New ExamenLaboratorio(-1) {}

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

    'METODOS FUNCIONALES G2
    Public Sub traerGrupos(ByRef _area As AreaLaboratorio)
        Dim datatable As DataTable = traerGruposBD(_area), index As Short = 0
        grupos = New GrupoExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODGRU GRU")) Then codigo = 0 Else codigo = Long.Parse(row("CODGRU GRU"))
            If IsDBNull(row("NOMGRU GRU")) Then nombre = "" Else nombre = row("NOMGRU GRU").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim grupo As New GrupoExamenLaboratorio()
            grupo.setCodigo(codigo)
            grupo.setNombre(nombre)
            grupo.setArea(_area)

            grupos(index) = grupo
            index += 1
        Next
    End Sub

    'METODOS FUNCIONALES G3A
    Public Sub traerExamenesDelGrupo(ByRef _grupo As GrupoExamenLaboratorio)
        Dim datatable As DataTable = traerExamenesDelGrupoBD(_grupo), index As Short = 0
        examenesDelGrupo = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, codTipoPeticionIndividual As Short

            If IsDBNull(row("CODEXA GRUEXA_EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA GRUEXA_EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()
            If IsDBNull(row("CODPETIND EXA")) Then codTipoPeticionIndividual = 0 Else codTipoPeticionIndividual = Short.Parse(row("CODPETIND EXA"))

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim examen As New ExamenLaboratorio()
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setCodigoIndividual(codTipoPeticionIndividual)
            examen.setGrupoExamen(_grupo)

            examenesDelGrupo(index) = examen
            index += 1
        Next
    End Sub

    Public Sub traerExamenesDelArea(ByRef _area As AreaLaboratorio)
        Dim datatable As DataTable = traerExamenesDelAreaBD(_area), index As Short = 0
        examenesDelArea = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim examen As New ExamenLaboratorio()
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setArea(_area)

            examenesDelArea(index) = examen
            index += 1
        Next
    End Sub

    Public Sub agregarExamenEnLista(ByRef _nuevosExamenes As ListaEnlazadaExamenLaboratorio, ByRef _examen As ExamenLaboratorio)
        _nuevosExamenes.agregarNodo(_examen)
    End Sub

    'METODOS FUNCIONALES G9A
    Public Sub insertNuevosExamenes(ByRef _grupo As GrupoExamenLaboratorio, _nuevosExamenes As ListaEnlazadaExamenLaboratorio)
        Dim codigoRelacionMax As Long, codigoRelacionNuevo As Long, nodo As NodoExamenLaboratorio

        actviarGrupoExamen(_grupo.codigo)
        codigoRelacionMax = traerUltimoCodigoRelacionGrupoExamen()
        codigoRelacionNuevo = generarNuevoCodigo()
        desactivarAntiguosExamenes(codigoRelacionMax, _grupo)


        For Each examen In examenesDelGrupo
            estadoInsercion = insertarExamen(codigoRelacionNuevo, _grupo, examen)
        Next

        nodo = _nuevosExamenes.raiz

        While nodo IsNot Nothing
            Dim examen As ExamenLaboratorio
            examen = nodo.examen
            estadoInsercion = insertarExamen(codigoRelacionNuevo, _grupo, examen)
            nodo = nodo.siguiente
        End While
    End Sub

    Private Function traerUltimoCodigoRelacionGrupoExamen() As Long
        Dim datatable As DataTable = traerUltimoCodigoRelacionGrupoExamenBD(), codigo As Long = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODREL GRUEXA_EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODREL GRUEXA_EXA"))
        Next

        Return codigo
    End Function

    Private Function generarNuevoCodigo()
        Dim nuevoCodigo As Long = traerUltimoCodigoRelacionGrupoExamen() + 1
        Return nuevoCodigo
    End Function

    Private Function desactivarAntiguosExamenes(_codigoRelacion As Long, _grupo As GrupoExamenLaboratorio)
        Return desactivarAntiguosExamenesBD(_codigoRelacion, _grupo)
    End Function

    Private Function insertarExamen(_codigoRelacion As Long, _grupo As GrupoExamenLaboratorio, _examen As ExamenLaboratorio) As Short
        Return insertarExameConGrupoBD(_codigoRelacion, _grupo, _examen)
    End Function

    Public Function generarMensajeInsercionAgregarExamen()
        If estadoInsercion > 0 Then Return "Los examenes se agregaron correctamente."
        If estadoInsercion <= 0 Then Return "Error. No se pudo agregar los examenes."
        Return ""
    End Function

    'METODOS FUNCIONALES G9B
    Public Sub updateExamenes(ByRef _examenesParaConservar As ExamenLaboratorio(), ByRef _grupo As GrupoExamenLaboratorio)
        Dim dimensionExamenesConservar As Short
        Dim codigoRelacionMax As Long, codigoRelacionNuevo As Long

        dimensionExamenesConservar = _examenesParaConservar.Count()
        If dimensionExamenesConservar = 0 Then desactviarGrupoExamen(_grupo.getCodigo)


        codigoRelacionMax = traerUltimoCodigoRelacionGrupoExamen()
        codigoRelacionNuevo = generarNuevoCodigo()
        estadoInsercion = desactivarAntiguosExamenes(codigoRelacionMax, _grupo)

        For Each examen In _examenesParaConservar
            estadoInsercion = insertarExamen(codigoRelacionNuevo, _grupo, examen)
        Next
    End Sub

    Private Sub actviarGrupoExamen(_codigoGrupo As Long)
        activarGrupoExamenBD(_codigoGrupo)
    End Sub

    Private Sub desactviarGrupoExamen(_codigoGrupo As Long)
        desactviarGrupoExamenBD(_codigoGrupo)
    End Sub


    Public Function generarListaExamenesMarcados(ByRef _rows As DataGridViewRowCollection, _clmCheckbox As String, _clmCodExamen As String)
        Dim dimension As Short, examenesMarcados As ExamenLaboratorio(), index As Short

        dimension = obtenerDimensionListaExamenesMarcados(_rows, _clmCheckbox)
        examenesMarcados = New ExamenLaboratorio(dimension - 1) {}
        index = 0


        For Each row As DataGridViewRow In _rows
            Dim cell As DataGridViewCheckBoxCell, codigo As Long

            cell = TryCast(row.Cells(_clmCheckbox), DataGridViewCheckBoxCell)

            If Not IsNothing(cell) Then
                If cell.Value Then
                    codigo = row.Cells(_clmCodExamen).Value
                    examenesMarcados(index) = obtenerExamenDeGrupo(codigo)
                    index += 1
                End If
            End If
        Next

        Return examenesMarcados
    End Function

    Private Function obtenerDimensionListaExamenesMarcados(ByRef _rows As DataGridViewRowCollection, _clmCheckbox As String)
        Dim nroExamenes As Short

        nroExamenes = 0

        For Each row As DataGridViewRow In _rows
            Dim cell As DataGridViewCheckBoxCell

            cell = TryCast(row.Cells(_clmCheckbox), DataGridViewCheckBoxCell)

            If Not IsNothing(cell) Then
                If cell.Value Then nroExamenes += 1
            End If
        Next

        Return nroExamenes
    End Function

    Private Function obtenerExamenDeGrupo(_codigo As Long) As ExamenLaboratorio
        For Each examen As ExamenLaboratorio In examenesDelGrupo
            If examen.getCodigo() = _codigo Then Return examen
        Next
    End Function

    Public Function generarListaExamenesParaConservar(ByRef _examesParaEliminar As ExamenLaboratorio()) As ExamenLaboratorio()
        Dim dimension As Short, examenesParaConservar As ExamenLaboratorio(), index As Short

        dimension = examenesDelGrupo.Count() - _examesParaEliminar.Count()
        examenesParaConservar = New ExamenLaboratorio(dimension - 1) {}
        index = 0

        For Each examenDelGrupo As ExamenLaboratorio In examenesDelGrupo
            Dim conservar As Boolean

            conservar = True

            For Each examenEliminar As ExamenLaboratorio In _examesParaEliminar
                If examenDelGrupo.getCodigo() = examenEliminar.getCodigo() Then
                    conservar = False
                    Exit For
                End If
            Next

            If conservar Then
                examenesParaConservar(index) = examenDelGrupo
                index += 1
            End If
        Next

        Return examenesParaConservar

    End Function

    Public Function generarMensajeInsercionEliminarExamen()
        If estadoInsercion > 0 Then Return "Los examenes se eliminaron del grupo correctamente."
        If estadoInsercion <= 0 Then Return "Error. No se pudo elimnar los examenes del grupo."
        Return ""
    End Function









    'METODOS BD G1 -
    Private Function traerAreasBD() As DataTable
        Return dal.TraerDataTable("SPtraerAreas_AdminsitrarGrupoExamenLaboratorio")
    End Function

    'METODOS BD G2
    Private Function traerGruposBD(ByRef _area As AreaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _area.getCodigo()
        Return dal.TraerDataTable("SPtraerGrupos_AdminsitrarGrupoExamenLaboratorio", P)
    End Function

    'METODOS BD G3A  
    Private Function traerExamenesDelGrupoBD(ByRef _grupo As GrupoExamenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _grupo.getCodigo()

        Return dal.TraerDataTable("SPtraerExamenes_AdminsitrarGrupoExamenLaboratorio", P)
    End Function

    Private Function traerExamenesDelAreaBD(ByRef _area As AreaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _area.getCodigo()

        Return dal.TraerDataTable("SPtraerExamenesDelArea_AdminsitrarGrupoExamenLaboratorio", P)
    End Function

    Public Sub eliminarExamen(_codigo As Long, _nuevosExamenes As ListaEnlazadaExamenLaboratorio)
        _nuevosExamenes.eliminarNodo(_codigo)
    End Sub

    'METODOS BD G9A
    Private Function traerUltimoCodigoRelacionGrupoExamenBD() As DataTable
        Return dal.TraerDataTable("SPtraerUltimoCodigo_AdminsitrarGrupoExamenLaboratorio")
    End Function

    Private Function desactivarAntiguosExamenesBD(_codigoRelacion As Long, _grupo As GrupoExamenLaboratorio) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _codigoRelacion
        P(2) = _grupo.getCodigo()

        Return dal.Ejecutar("SPdesactivarAntiguosExamenes_AdminsitrarGrupoExamenLaboratorio", P)
    End Function

    Private Function insertarExameConGrupoBD(_codigoGrupoExamen_Examen As Long, _grupo As GrupoExamenLaboratorio, _examen As ExamenLaboratorio) As Short
        Dim P As Object() = New Object(3) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _codigoGrupoExamen_Examen
        P(2) = _grupo.getCodigo()
        P(3) = _examen.getCodigo()

        Return dal.Ejecutar("SPinsertarExamen_AdminsitrarGrupoExamenLaboratorio", P)

    End Function


    'METODOS BD G9B
    Private Function activarGrupoExamenBD(_codigoGrupo As Long) As Short
        Dim P As Object() = New Object(3) {}
        P(0) = _codigoGrupo

        Return dal.Ejecutar("SPactivarGrupoExamen_AdminsitrarGrupoExamenLaboratorio", P)
    End Function

    Private Function desactviarGrupoExamenBD(_codigoGrupo As Long) As Short
        Dim P As Object() = New Object(3) {}
        P(0) = _codigoGrupo

        Return dal.Ejecutar("SPdesactivarGrupoExamen_AdminsitrarGrupoExamenLaboratorio", P)
    End Function







    'METODOS VALIDACIÓN
    Public Function validarEntradasDeLista(ByRef _examen As ExamenLaboratorio, _nuevosExamenes As ListaEnlazadaExamenLaboratorio)
        Dim mensaje As String

        mensaje = validarExamen(_examen)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarExamenRepetidoEnGrupo(_examen)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarExamenRepetidoEnListaNuevosExamenes(_examen, _nuevosExamenes)
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarExamen(ByRef _examen As ExamenLaboratorio) As String
        If _examen.getCodigo = 0 Then Return "Error. Seleccione un examen"
        Return ""
    End Function

    Private Function validarExamenRepetidoEnGrupo(ByRef _examen As ExamenLaboratorio) As String
        For Each examen As ExamenLaboratorio In examenesDelGrupo
            If examen.getCodigo() = _examen.getCodigo() Then Return "Error. El examen " + _examen.getNombre() + " ya pertenece a este grupo."
        Next

        Return ""
    End Function

    Private Function validarExamenRepetidoEnListaNuevosExamenes(ByRef _examen As ExamenLaboratorio, _nuevosExamenes As ListaEnlazadaExamenLaboratorio) As String
        Dim nodo As NodoExamenLaboratorio
        nodo = _nuevosExamenes.raiz

        While nodo IsNot Nothing
            Dim examen As ExamenLaboratorio
            examen = nodo.examen
            If examen.getCodigo() = _examen.getCodigo() Then Return "Error. El examen " + _examen.getNombre() + " ya pertenece a la lista de nuevos examenes."

            nodo = nodo.siguiente
        End While

        Return ""
    End Function

    Public Function validarEntradasAgregarExamen(ByRef _nuevosExamenes As ListaEnlazadaExamenLaboratorio)
        Dim mensaje As String

        mensaje = validarListaVacia(_nuevosExamenes)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarListaVacia(_nuevosExamenes As ListaEnlazadaExamenLaboratorio)
        Dim nroExamnes As Short
        nroExamnes = _nuevosExamenes.encontrarDimension()

        If nroExamnes = 0 Then Return "Error. Debe agregar como mínimo un examen a la lista de nuevos examenes."

        Return ""
    End Function

    Public Function validarEntradasEliminarExamenn(ByRef _examenes As ExamenLaboratorio())
        Dim mensaje As String

        mensaje = validarListaVaciaEliminarExamen(_examenes)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarListaVaciaEliminarExamen(ByRef _examenes As ExamenLaboratorio())
        Dim nroExamenes As Short

        nroExamenes = _examenes.Count()

        If nroExamenes = 0 Then Return "Error. Debe seleccionar como mínimo un examene para eliminar."
        Return ""
    End Function



End Class
