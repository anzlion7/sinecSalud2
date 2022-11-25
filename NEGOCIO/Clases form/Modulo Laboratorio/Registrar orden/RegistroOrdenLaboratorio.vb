Imports DAL
Imports System.Windows.Forms

Public Class RegistroOrdenLaboratorio


    'ATRIBUTOS LÓGICOS ----
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public medicos As Medico()
    Public asegurados As Asegurado()

    'ATRIBUTOS G2
    Public areas As AreaLaboratorio()

    'ATRIBUTOS SUBMIT
    Public codigoNuevaOrdenInsertada As Long
    Public respuestaInsercionDetalles As Short


    'METODOS INICIO ----
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        medicos = New Medico(-1) {}
        asegurados = New Asegurado(-1) {}

        'ATRIBUTOS G2
        areas = New AreaLaboratorio(-1) {}

        'ATRIBUTOS SUBMIT
        codigoNuevaOrdenInsertada = 0
        respuestaInsercionDetalles = 0
    End Sub

    Public Sub iniciarProcesos()

    End Sub










    'METODOS FUNCIONALES G1 ----
    Public Sub traerMedicos(_nombre As String)
        Dim objDTable As DataTable = traerMedicosBD(_nombre), index As Short = 0
        medicos = New Medico(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Long, apPaterno As String, apMaterno As String,
                nombres As String, codEspecialidad As Long, nomEspecialidad As String

            Dim usuario As Usuario, especialidad As Especialidad, medico As Medico

            If IsDBNull(row("CODMED MED")) Then codigo = 0 Else codigo = Long.Parse(row("CODMED MED"))
            If IsDBNull(row("APAMED USU")) Then apPaterno = "" Else apPaterno = row("APAMED USU").ToString()
            If IsDBNull(row("AMAMED USU")) Then apMaterno = "" Else apMaterno = row("AMAMED USU").ToString()
            If IsDBNull(row("NOMMED USU")) Then nombres = "" Else nombres = row("NOMMED USU").ToString()

            If IsDBNull(row("CODESP ESP")) Then codEspecialidad = 0 Else codEspecialidad = Long.Parse(row("CODESP ESP"))
            If IsDBNull(row("NOMESP ESP")) Then nomEspecialidad = "" Else nomEspecialidad = row("NOMESP ESP").ToString()

            usuario = New Usuario()
            usuario.setApellidoPaterno(apPaterno)
            usuario.setApellidoMaterno(apMaterno)
            usuario.setNombres(nombres)

            especialidad = New Especialidad()
            especialidad.setCodigo(codEspecialidad)
            especialidad.setNombre(nomEspecialidad)

            medico = New Medico()
            medico.setCodigo(codigo)
            medico.setUsuario(usuario)
            medico.setEspecialidad(especialidad)

            medicos(index) = medico
            index += 1
        Next
    End Sub

    Public Sub traerAsegurados(_nombre As String)
        Dim objDTable As DataTable = traerAseguradosBD(_nombre), index As Short = 0
        asegurados = New Asegurado(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Long, apPaterno As String, apMaterno As String,
                nombres As String, matricula As String, fechaNac As Date
            Dim asegurado As Asegurado

            If IsDBNull(row("CODASE ASE")) Then codigo = 0 Else codigo = Long.Parse(row("CODASE ASE"))
            If IsDBNull(row("APEPAT ASE")) Then apPaterno = "" Else apPaterno = row("APEPAT ASE").ToString()
            If IsDBNull(row("APEMAT ASE")) Then apMaterno = "" Else apMaterno = row("APEMAT ASE").ToString()
            If IsDBNull(row("NOMASE ASE")) Then nombres = "" Else nombres = row("NOMASE ASE").ToString()
            If IsDBNull(row("MATASE ASE")) Then matricula = "" Else matricula = row("MATASE ASE").ToString()
            If IsDBNull(row("FECNACASE ASE")) Then fechaNac = Today Else fechaNac = Date.Parse(row("FECNACASE ASE"))
            If fechaNac.Year > Today.Year Then fechaNac = fechaNac.AddYears(-100)

            asegurado = New Asegurado()
            asegurado.setCodigo(codigo)
            asegurado.setApellidoPaterno(apPaterno)
            asegurado.setApellidoMaterno(apMaterno)
            asegurado.setNombres(nombres)
            asegurado.setMatricula(matricula)
            asegurado.setFechaNacimiento(fechaNac)

            asegurados(index) = asegurado
            index += 1
        Next
    End Sub

    'METODOS FUNCIONALES G2
    Public Sub traerAreas()
        Dim datatable As DataTable = traerAreasBD(), index As Short = 0
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nombre = "" Else nombre = row("NOMARE ARE").ToString()

            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerExamenesSolictablesPorArea()
        For Each area As AreaLaboratorio In areas
            Dim codigoArea As Long, examenesSolictables As ExamenSolicitableLaboratorio()

            codigoArea = area.getCodigo()
            examenesSolictables = traerExamenesSolictables(codigoArea)
            area.setExamenesSolicitables(examenesSolictables)
        Next
    End Sub

    Public Function traerExamenesSolictables(_codigoArea As Long) As ExamenSolicitableLaboratorio()
        Dim datatable As DataTable = traerExamenesSolictablesBD(_codigoArea), index As Short = 0,
            examenesSolicitables As ExamenSolicitableLaboratorio()

        examenesSolicitables = New ExamenSolicitableLaboratorio(datatable.Rows.Count - 1) {}


        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, codigoTipoExamen As Short
            Dim examenSolicitable As ExamenSolicitableLaboratorio

            'codigoTipoExamen = 1 -> REPRESENTA UN EXAMEN INDIVIDUAL
            'codigoTipoExamen = 2 -> REPRESENTA UN EXAMEN GRUPAL

            If IsDBNull(row("CODEXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA"))
            If IsDBNull(row("NOMEXA")) Then nombre = "" Else nombre = row("NOMEXA").ToString()
            If IsDBNull(row("TIPOEXA")) Then codigoTipoExamen = 0 Else codigoTipoExamen = Short.Parse(row("TIPOEXA"))

            If codigoTipoExamen = 1 Then examenSolicitable = crearExamenLaboratorio(codigo, nombre)
            If codigoTipoExamen = 2 Then examenSolicitable = crearExamenGrupoLaboratorio(codigo, nombre)

            examenesSolicitables(index) = examenSolicitable
            index += 1
        Next

        Return examenesSolicitables
    End Function

    Private Function crearExamenLaboratorio(_codigo As Short, _nombre As String) As ExamenLaboratorio
        Return New ExamenLaboratorio(_codigo, _nombre)
    End Function

    Private Function crearExamenGrupoLaboratorio(_codigo As Short, _nombre As String) As GrupoExamenLaboratorio
        Return New GrupoExamenLaboratorio(_codigo, _nombre)
    End Function

    Public Sub traerExamenesIndividualesPorGrupo()
        For Each area As AreaLaboratorio In areas
            Dim examenesSolictables As ExamenSolicitableLaboratorio(), dimension As Short

            examenesSolictables = area.getExamenesSolicitables()
            dimension = examenesSolictables.Length

            For index = 0 To dimension - 1
                Dim examen As Object

                examen = examenesSolictables(index)

                If TypeOf examen Is GrupoExamenLaboratorio Then
                    Dim codigoGrupo As Long, examenesIndividuales As ExamenLaboratorio()

                    codigoGrupo = examen.getCodigo()
                    examenesIndividuales = traerExamenesDelExamenGrupo(codigoGrupo)
                    examen.setExamenes(examenesIndividuales)
                End If
            Next
        Next
    End Sub

    Private Function traerExamenesDelExamenGrupo(_codigoGrupo As Long) As ExamenLaboratorio()
        Dim datatable As DataTable = traerExamenesDelExamenGrupoBD(_codigoGrupo), index As Short = 0, examenes As ExamenLaboratorio()
        examenes = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()

            examenes(index) = New ExamenLaboratorio(codigo, nombre)
            index += 1
        Next

        Return examenes
    End Function

    'METODOS FUNCIONALES G3
    Public Function validarExamenesMarcados(ByRef _examenesMarcados As ExamenSolicitableLaboratorio(),
                                            ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String
        Dim mensaje As String

        mensaje = validarListaExamenesMarcadosConListaExamenesAgregados(_examenesMarcados, _examenesAgregados)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarListaExamenesMarcadosConListaExamenesAgregados(ByRef _examenesMarcados As ExamenSolicitableLaboratorio(),
                                                                           ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String
        Dim mensaje As String, examen As Object, dimension As Short

        mensaje = validarHayEspacio(_examenesMarcados, _examenesAgregados)
        If Not mensaje = "" Then Return mensaje

        dimension = _examenesMarcados.Length

        For index = 0 To dimension - 1
            examen = _examenesMarcados(index)

            If TypeOf examen Is ExamenLaboratorio Then
                mensaje = validarMismoExamenIndividual(examen, _examenesAgregados)
                If Not mensaje = "" Then Return mensaje

            ElseIf TypeOf examen Is GrupoExamenLaboratorio Then
                mensaje = validarMismoExamenGrupal(examen, _examenesAgregados)
                If Not mensaje = "" Then Return mensaje
            End If
        Next

        Return ""
    End Function

    Private Function validarHayEspacio(ByRef _examenesMarcados As ExamenSolicitableLaboratorio(),
                                       ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String

        Dim dimensionExamenesMarcados As Short, dimensionExamenesAgregados As Short
        Const LIMITE As Short = 5

        dimensionExamenesMarcados = _examenesMarcados.Length
        dimensionExamenesAgregados = _examenesAgregados.encontrarDimension()

        If (dimensionExamenesAgregados + dimensionExamenesMarcados) > LIMITE Then
            Return "Error. El nro. de examenes marcados es mayor al límite de examenes que se pueden solicitar por orden. (LIMITE EXAMENES " + LIMITE.ToString() + ")"
        End If


        Return ""
    End Function

    Private Function validarMismoExamenIndividual(ByRef _examenMarcado As ExamenLaboratorio,
                                                  ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String

        Dim nodoActual As NodoExamenSolicitableLaboratorio
        nodoActual = _examenesAgregados.raiz


        While Not IsNothing(nodoActual)
            Dim examenLista As Object
            examenLista = nodoActual.examenSolicitable

            If TypeOf examenLista Is ExamenLaboratorio Then
                If _examenMarcado.getCodigo() = examenLista.getCodigo() Then
                    Dim nombreExamenMarcado As String

                    nombreExamenMarcado = _examenMarcado.getNombre()
                    Return "Error en examenes marcados ✓. El examen " + nombreExamenMarcado + " ya se encuentra agregado en la lista. Seleccione otro examen."
                End If
            End If

            nodoActual = nodoActual.siguiente
        End While

        Return ""
    End Function

    Private Function validarMismoExamenGrupal(ByRef _examenMarcado As GrupoExamenLaboratorio,
                                             ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String

        Dim nodoActual As NodoExamenSolicitableLaboratorio
        nodoActual = _examenesAgregados.raiz


        While Not IsNothing(nodoActual)
            Dim examenListaAgregados As Object
            examenListaAgregados = nodoActual.examenSolicitable

            If TypeOf examenListaAgregados Is GrupoExamenLaboratorio Then
                If _examenMarcado.getCodigo() = examenListaAgregados.getCodigo() Then
                    Dim nombreExamenMarcado As String

                    nombreExamenMarcado = _examenMarcado.getNombre()
                    Return "Error en examenes marcados ✓. El examen (grupal) " + nombreExamenMarcado + " ya se encuentra agregado en la lista. Seleccione otro examen."
                End If
            End If

            nodoActual = nodoActual.siguiente
        End While

        Return ""
    End Function

    Public Sub agregarExamenesMarcados(ByRef _examenesMarcados As ExamenSolicitableLaboratorio(),
                                        ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio)

        Dim examen As ExamenSolicitableLaboratorio, dimension As Short
        dimension = _examenesMarcados.Length


        For index = 0 To dimension - 1
            examen = _examenesMarcados(index)
            _examenesAgregados.agregarNodo(examen)
        Next
    End Sub


    'METODOS FUNCIONALES G4
    Public Sub eliminarExamenSolicitable(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio, _codigo As Long,
                                         _tipoExamen As Short)
        If _tipoExamen = 1 Then
            _examenesAgregados.eliminarNodoExamenIndividual(_codigo)
        ElseIf _tipoExamen = 2 Then
            _examenesAgregados.eliminarNodoExamenGrupal(_codigo)
        End If
    End Sub


    'METODOS FUNCIONALES SUBMIT
    Public Function validarEntradasFrontEnd(_medico As Medico, _asegurado As Asegurado) As String
        Dim mensaje As String

        mensaje = validarMedicoSeleccionado(_medico)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarAseguradoSeleccionado(_asegurado)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarMedicoSeleccionado(_medico As Medico) As String
        If _medico.getCodigo() = 0 Then Return "Error. Seleccione un médico"

        Return ""
    End Function

    Private Function validarAseguradoSeleccionado(_asegurado As Asegurado) As String
        If _asegurado.getCodigo() = 0 Then Return "Error. Seleccione un asegurado"

        Return ""
    End Function

    Public Function validarEntradasBackEnd(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String
        Dim mensaje As String

        mensaje = validarExamenesAgregados(_examenesAgregados)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarExamenesAgregados(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String
        Dim mensaje As String

        mensaje = validarListaVacia(_examenesAgregados)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarExamenIndividualEnExamenGrupal(_examenesAgregados)
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarListaVacia(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String
        Dim dimension As Short

        dimension = _examenesAgregados.encontrarDimension()
        If dimension = 0 Then Return "Error. La orden de laboratorio debe emitir al menos un examen. Agrege un examen."

        Return ""
    End Function

    Private Function validarExamenIndividualEnExamenGrupal(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As String
        Dim examenIndividual As ExamenLaboratorio, nodoExamenSolicitable As NodoExamenSolicitableLaboratorio

        examenIndividual = encontrarExamenSolicitableIndividual(_examenesAgregados)
        If IsNothing(examenIndividual) Then Return ""


        nodoExamenSolicitable = _examenesAgregados.raiz

        While Not IsNothing(nodoExamenSolicitable)
            Dim examenSolicitable As Object

            examenSolicitable = nodoExamenSolicitable.examenSolicitable

            If TypeOf examenSolicitable Is GrupoExamenLaboratorio Then
                Dim examenesDelGrupo As ExamenLaboratorio()

                examenesDelGrupo = examenSolicitable.getExamenes()
                For Each examenDelGrupo As ExamenLaboratorio In examenesDelGrupo
                    If examenDelGrupo.getCodigo() = examenIndividual.getCodigo() Then
                        Dim nombreExamenIndividual As String, nombreExamenGrupal As String

                        nombreExamenIndividual = examenIndividual.getNombre()
                        nombreExamenGrupal = examenSolicitable.getNombre()

                        Return "Error. El examen " + nombreExamenIndividual + " ya forma parte del examen grupal -> " + nombreExamenGrupal + ". Elimine el examen individual " + nombreExamenIndividual
                    End If
                Next
            End If

            nodoExamenSolicitable = nodoExamenSolicitable.siguiente
        End While


        Return ""
    End Function

    Private Function encontrarExamenSolicitableIndividual(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As ExamenSolicitableLaboratorio
        Dim nodoExamenSolicitable As NodoExamenSolicitableLaboratorio

        nodoExamenSolicitable = _examenesAgregados.raiz

        While Not IsNothing(nodoExamenSolicitable)
            Dim examenSolicitable As ExamenSolicitableLaboratorio

            examenSolicitable = nodoExamenSolicitable.examenSolicitable
            If TypeOf examenSolicitable Is ExamenLaboratorio Then Return examenSolicitable

            nodoExamenSolicitable = nodoExamenSolicitable.siguiente
        End While

        Return Nothing
    End Function

    Public Function generarListaDetalles(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As DetalleLaboratorio()
        Dim nodoExamenSolicitable As NodoExamenSolicitableLaboratorio, dimension As Short,
            nuevosDetallesLaboratorio As DetalleLaboratorio(), index As Short

        dimension = generarDimensionListaDetalles(_examenesAgregados)
        nuevosDetallesLaboratorio = New DetalleLaboratorio(dimension - 1) {}

        nodoExamenSolicitable = _examenesAgregados.raiz
        index = 0
        While Not IsNothing(nodoExamenSolicitable)
            Dim examenSolicitable As Object


            examenSolicitable = nodoExamenSolicitable.examenSolicitable
            If TypeOf examenSolicitable Is ExamenLaboratorio Then
                nuevosDetallesLaboratorio(index) = crearDetalleExamenIndividual(examenSolicitable)
                index += 1



            ElseIf TypeOf examenSolicitable Is GrupoExamenLaboratorio Then
                Dim examenesIndividuales As ExamenLaboratorio()

                examenesIndividuales = examenSolicitable.getExamenes()

                For Each examenIndividual As ExamenSolicitableLaboratorio In examenesIndividuales
                    nuevosDetallesLaboratorio(index) = crearDetalleExamenGrupal(examenIndividual, examenSolicitable)
                    index += 1
                Next
            End If


            nodoExamenSolicitable = nodoExamenSolicitable.siguiente
        End While


        Return nuevosDetallesLaboratorio
    End Function

    Private Function generarDimensionListaDetalles(ByRef _examenesAgregados As ListaEnlazadaExamenSolicitableLaboratorio) As Short
        Dim nodoExamenSolicitable As NodoExamenSolicitableLaboratorio, dimension As Short

        nodoExamenSolicitable = _examenesAgregados.raiz


        While Not IsNothing(nodoExamenSolicitable)
            Dim examenSolicitable As Object

            examenSolicitable = nodoExamenSolicitable.examenSolicitable
            If TypeOf examenSolicitable Is ExamenLaboratorio Then
                dimension = dimension + 1

            ElseIf TypeOf examenSolicitable Is GrupoExamenLaboratorio Then
                Dim examenes As ExamenLaboratorio(), cantidadExamenes As Short

                examenes = examenSolicitable.getExamenes()
                cantidadExamenes = examenes.Count()
                dimension = dimension + cantidadExamenes
            End If

            nodoExamenSolicitable = nodoExamenSolicitable.siguiente
        End While

        Return dimension
    End Function

    Private Function crearDetalleExamenIndividual(ByRef _examenSolicitable As ExamenSolicitableLaboratorio) As DetalleLaboratorio
        Dim tipoPeticion As Concepto, detallle As DetalleLaboratorio

        tipoPeticion = New Concepto(0, 1, "")

        detallle = New DetalleLaboratorio()
        detallle.setExamen(_examenSolicitable)
        detallle.setTipoPeticion(tipoPeticion)

        Return detallle
    End Function

    Private Function crearDetalleExamenGrupal(ByRef _examenSolicitableIndividual As ExamenSolicitableLaboratorio,
                                                    _examenSolicitableGrupal As ExamenSolicitableLaboratorio) As DetalleLaboratorio
        Dim tipoPeticion As Concepto, detallle As DetalleLaboratorio

        tipoPeticion = New Concepto(0, 2, "")

        detallle = New DetalleLaboratorio()
        detallle.setExamen(_examenSolicitableIndividual)
        detallle.setGrupo(_examenSolicitableGrupal)
        detallle.setTipoPeticion(tipoPeticion)

        Return detallle
    End Function

    Public Sub insertarOrden(ByRef _orden As OrdenLaboratorio)
        Dim datatable As DataTable = insertarOrdenBD(_orden)
        Dim codigoOrden As Long


        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODORD")) Then codigoOrden = 0 Else codigoOrden = Long.Parse(row("CODORD"))
        Next

        codigoNuevaOrdenInsertada = codigoOrden
    End Sub

    Public Sub insertarDetalles(ByRef _detalles As DetalleLaboratorio())
        asignarCodigoOrden(_detalles)

        Dim respuesta As Short, ocurrioError As Boolean

        ocurrioError = False

        For Each detalle As DetalleLaboratorio In _detalles
            respuesta = insertarDetalleBD(detalle)

            If respuesta <= 0 Then
                ocurrioError = True
            End If
        Next

        If Not ocurrioError Then respuestaInsercionDetalles = 1 Else respuestaInsercionDetalles = 0
    End Sub

    Private Sub asignarCodigoOrden(ByRef _detalles As DetalleLaboratorio())
        Dim nuevaOrden As New OrdenLaboratorio()

        nuevaOrden.setCodigo(codigoNuevaOrdenInsertada)

        For Each detalle As DetalleLaboratorio In _detalles
            detalle.setOrden(nuevaOrden)
        Next
    End Sub











    'METOODOS BD G1 -----
    Private Function traerMedicosBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return dal.TraerDataTable("SPtraerMedico_RegistrarOrdenLab", P)
    End Function

    Private Function traerAseguradosBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return (dal.TraerDataTable("SPtraerAsegurado_RegistrarOrdenLab", P))
    End Function

    'METOODOS BD G2
    Private Function traerAreasBD() As DataTable
        Return (dal.TraerDataTable("SPtraeAreasLab_RegistrarOrdenLaboratorio"))
    End Function

    Private Function traerExamenesSolictablesBD(_codigoArea As Long) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoArea
        Return (dal.TraerDataTable("SPtraerExamenesSolicitablbes_RegistrarOrdenLab", P))
    End Function

    Private Function traerExamenesDelExamenGrupoBD(_codigoGrupo As Long) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoGrupo
        Return (dal.TraerDataTable("SPtraerExamenesDeGrupo_RegistrarOrdenLab", P))
    End Function

    'METOODOS BD SUBMIT
    Private Function insertarOrdenBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(3) {}
        Dim nota As String

        nota = _orden.getNota()

        P(0) = Usuario.codUserLoggedSystem
        P(1) = _orden.getAsegurado().getMatricula()
        P(2) = _orden.getMedico().getCodigo()
        If String.IsNullOrEmpty(nota) Then P(3) = DBNull.Value Else P(3) = nota


        Return (dal.TraerDataTable("SPguardarOrden_RegistrarOrdenLab", P))
    End Function

    Private Function insertarDetalleBD(ByRef _detalle As DetalleLaboratorio) As Short
        Dim P As Object() = New Object(3) {}
        Dim codigoGrupo As Long


        P(0) = _detalle.getOrden().getCodigo()
        P(1) = _detalle.getTipoPeticion().getCorrelativo()
        P(2) = _detalle.getExamen().getCodigo()

        codigoGrupo = _detalle.getGrupo().getCodigo()
        If codigoGrupo = 0 Then P(3) = DBNull.Value Else P(3) = codigoGrupo


        Return (dal.Ejecutar("SPguardarDetalleOrdenLab_RegistrarOrdenLab", P))
    End Function




End Class


