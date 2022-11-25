Imports DAL

Public Class RegistroResultadosEnValoresReferencia

    'ATRIBUTOS LOGICOS -----
    Private dal As TDatosSql

    'ATRIBUTOS FORM MODO HIJO
    Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean
    Public modoTipoUsuario As Short

    'ATRIBUTOS PARAMETOS RECIBIDOS
    Public pResultado As ResultadoLaboratorio
    Public pAsegurado As Asegurado
    Public pExamen As ExamenLaboratorio

    'ATRIBUTOS PROPERTIES G3
    Public proveedorSeleccionado As ProveedorKitEquipo
    Public procesadorSeleccionado As Usuario
    Public observacion As Boolean

    'ATRIBUTOS PROPERTIES G9
    Public nuevoInputResultado As ResultadoLaboratorioInput
    Public nuevoResultado As ResultadoLaboratorio

    'ATRIBUTOS G3
    Public kitPredeterminado As KitEquipoLaboratorio
    Public referenciaDelPaciente As ReferenciaResultadoLaboratorio
    Public resultadoVacio As Boolean



    Public referencias As ReferenciaResultadoLaboratorio()
    Public proveedores As ProveedorKitEquipo()
    Public kits As KitEquipoLaboratorio()
    Public procesadores As Usuario()
    Public observacionIndex As Short

    Public Sub New()
        'ATRIBUTOS LOGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G3
        kitPredeterminado = Nothing
        referenciaDelPaciente = Nothing
        resultadoVacio = False




        referencias = New ReferenciaResultadoLaboratorio(-1) {}
        proveedores = New ProveedorKitEquipo(-1) {}
        kits = New KitEquipoLaboratorio(-1) {}
        procesadores = New Usuario(-1) {}
        observacionIndex = -1
    End Sub

    Public Sub iniciarProcesos()

    End Sub





    'METODOS FUNCIONALES G3
    Public Sub traerKitPredeterminado(_codigoExamen As Long)
        Dim datatable As DataTable = traerKitPredeterminadoBD(_codigoExamen), index As Short = 0
        Dim kit As KitEquipoLaboratorio, marca As MarcaKitEquipoLaboratorio

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, codigoTipoReferencia As Short
            Dim tipoReferencia As Concepto

            If IsDBNull(row("CODKIT KITEQU")) Then codigo = 0 Else codigo = Long.Parse(row("CODKIT KITEQU"))
            If IsDBNull(row("NOMKIT MARKIT")) Then nombre = "" Else nombre = row("NOMKIT MARKIT").ToString()
            If IsDBNull(row("CODTIPREF KITEQU")) Then codigoTipoReferencia = 0 Else codigoTipoReferencia = Short.Parse(row("CODTIPREF KITEQU"))

            If codigo = 0 Then
                Exit For
            End If

            marca = New MarcaKitEquipoLaboratorio()
            marca.setNombre(nombre)

            tipoReferencia = New Concepto()
            tipoReferencia.setCorrelativo(codigoTipoReferencia)

            kit = New KitEquipoLaboratorio()
            kit.setCodigo(codigo)
            kit.setMarca(marca)
            kit.setTipoReferencia(tipoReferencia)
        Next

        kitPredeterminado = kit
    End Sub

    Public Function revisarKitPredeterminadoSinAsignar() As Boolean
        If IsNothing(kitPredeterminado) Then
            Return True
        End If

        Return False
    End Function

    Public Sub traerReferencias(ByVal _codigoKit As Short)
        Dim datatable As DataTable = traerReferenciasBD(_codigoKit), index As Short = 0
        referencias = New ReferenciaResultadoLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, codTipo As Short, codKitEquipo As Long, valorInicio As Double, valorFin As Double,
                sexo As Char, edadInicio As Short, edadFin As Short

            If IsDBNull(row("CODREF REF")) Then codigo = 0 Else codigo = Long.Parse(row("CODREF REF"))
            If IsDBNull(row("CODTIP REF")) Then codTipo = 0 Else codTipo = Long.Parse(row("CODTIP REF"))
            If IsDBNull(row("CODKEQ REF")) Then codKitEquipo = 0 Else codKitEquipo = Long.Parse(row("CODKEQ REF"))
            If IsDBNull(row("VALINI REF")) Then valorInicio = 0 Else valorInicio = Double.Parse(row("VALINI REF"))
            If IsDBNull(row("VALFIN REF")) Then valorFin = 0 Else valorFin = Double.Parse(row("VALFIN REF"))
            If IsDBNull(row("SEXO REF")) Then sexo = "" Else sexo = row("SEXO REF").ToString()
            If IsDBNull(row("EDADINI REF")) Then edadInicio = 0 Else edadInicio = Short.Parse(row("EDADINI REF"))
            If IsDBNull(row("EDADFIN REF")) Then edadFin = 0 Else edadFin = Short.Parse(row("EDADFIN REF"))


            Dim tipo As New Concepto()
            tipo.setPrefijo(0)
            tipo.setCorrelativo(codTipo)
            tipo.setDescripcion("")

            Dim kitequipo As New KitEquipoLaboratorio()
            kitequipo.setCodigo(codKitEquipo)

            Dim referencia As New ReferenciaResultadoLaboratorio()
            referencia.setCodigo(codigo)
            referencia.setTipo(tipo)
            referencia.setKitEquipo(kitequipo)
            referencia.setValorInicio(valorInicio)
            referencia.setValorFin(valorFin)
            referencia.setSexo(sexo)
            referencia.setEdadInicio(edadInicio)
            referencia.setEdadFin(edadFin)

            referencias(index) = referencia
            index += 1
        Next
    End Sub

    Public Sub asignarReferenciaAsegurado(ByRef _tipoReferencia As Short, ByRef _asegurado As Asegurado)
        Dim referenciaEncontrada As ReferenciaResultadoLaboratorio


        If _tipoReferencia = 1 Then
            referenciaEncontrada = traerReferenciaTipoComun()

        ElseIf _tipoReferencia = 2 Then
            referenciaEncontrada = traerReferenciaTipoSexo(_asegurado)

        ElseIf _tipoReferencia = 3 Then
            referenciaEncontrada = traerReferenciaTipoEdad(_asegurado)

        ElseIf _tipoReferencia = 4 Then
            referenciaEncontrada = traerReferenciaTipoSexoYEdad(_asegurado)
        Else
            referenciaEncontrada = Nothing
        End If


        referenciaDelPaciente = referenciaEncontrada
    End Sub

    Public Function traerReferenciaTipoComun() As ReferenciaResultadoLaboratorio
        Dim referencia As ReferenciaResultadoLaboratorio = referencias(0)

        Return referencia
    End Function

    Public Function traerReferenciaTipoSexo(ByRef _asegurado As Asegurado) As ReferenciaResultadoLaboratorio
        Dim sexoAsegurado As Char, referenciaEncontrada As ReferenciaResultadoLaboratorio

        sexoAsegurado = _asegurado.getSexo()
        referenciaEncontrada = New ReferenciaResultadoLaboratorio()


        For Each referencia As ReferenciaResultadoLaboratorio In referencias
            Dim sexoReferencia As Char = referencia.getSexo()
            If sexoReferencia = sexoAsegurado Then referenciaEncontrada = referencia
        Next

        Return referenciaEncontrada
    End Function

    Public Function traerReferenciaTipoEdad(ByRef _asegurado As Asegurado) As ReferenciaResultadoLaboratorio
        Dim edadAsegurado As Short, referenciaEncontrada As ReferenciaResultadoLaboratorio

        edadAsegurado = Utilitarios.calcularEdad(_asegurado.getFechaNacimiento())
        referenciaEncontrada = New ReferenciaResultadoLaboratorio()


        For Each referencia As ReferenciaResultadoLaboratorio In referencias
            Dim edadInicioReferencia As Short, edadFinReferencia As Short

            edadInicioReferencia = referencia.getEdadInicio()
            edadFinReferencia = referencia.getEdadFin()

            If (edadAsegurado >= edadInicioReferencia) And (edadAsegurado < edadFinReferencia) Then referenciaEncontrada = referencia
        Next

        Return referenciaEncontrada
    End Function

    Public Function traerReferenciaTipoSexoYEdad(ByRef _asegurado As Asegurado) As ReferenciaResultadoLaboratorio
        Dim sexoAsegurado As Char, edadAsegurado As Short, referenciaEncontrada As ReferenciaResultadoLaboratorio

        sexoAsegurado = _asegurado.getSexo()
        edadAsegurado = Utilitarios.calcularEdad(_asegurado.getFechaNacimiento())
        referenciaEncontrada = New ReferenciaResultadoLaboratorio()


        For Each referencia As ReferenciaResultadoLaboratorio In referencias
            Dim sexoReferencia As Char

            sexoReferencia = referencia.getSexo()

            If sexoReferencia = sexoAsegurado Then
                Dim edadInicioReferencia As Short, edadFinReferencia As Short

                edadInicioReferencia = referencia.getEdadInicio()
                edadFinReferencia = referencia.getEdadFin()

                If (edadAsegurado >= edadInicioReferencia) And (edadAsegurado < edadFinReferencia) Then referenciaEncontrada = referencia
            End If
        Next

        Return referenciaEncontrada
    End Function

    Public Function hayObservacion(ByRef _referencia As ReferenciaResultadoLaboratorio, valorIngresado As Double) As Boolean
        Dim valorInicio As Double, valorFin As Double


        valorInicio = _referencia.getValorInicio()
        valorFin = _referencia.getValorFin()


        If (valorIngresado < valorInicio) Or (valorIngresado > valorFin) Then
            Return True
        End If


        Return False
    End Function

    Public Sub buscarIndexObservacion(ByRef _referencia As ReferenciaResultadoLaboratorio)
        Dim index As Short

        index = 0
        For Each referencia As ReferenciaResultadoLaboratorio In referencias
            If referencia.getCodigo() = _referencia.getCodigo() Then Exit For
            index += 1
        Next

        observacionIndex = index
    End Sub

    Public Sub traerProcesadores()
        Dim datatable As DataTable = traerProcesadoresBD(), index As Short = 0
        procesadores = New Usuario(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, codTipo As Short, apPaterno As String, apMaterno As String, nombres As String

            If IsDBNull(row("CODUSU USU")) Then codigo = 0 Else codigo = Long.Parse(row("CODUSU USU"))
            If IsDBNull(row("CODTIP USU")) Then codTipo = 0 Else codTipo = Short.Parse(row("CODTIP USU"))
            If IsDBNull(row("APEPAT USU")) Then apPaterno = "" Else apPaterno = row("APEPAT USU").ToString()
            If IsDBNull(row("APEMAT USU")) Then apMaterno = "" Else apMaterno = row("APEMAT USU").ToString()
            If IsDBNull(row("NOM USU")) Then nombres = "" Else nombres = row("NOM USU").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim tipo As New Concepto()
            tipo.setCorrelativo(codTipo)

            Dim procesador As New Usuario()
            procesador.setCodigo(codigo)
            procesador.setTipo(tipo)
            procesador.setApellidoPaterno(apPaterno)
            procesador.setApellidoMaterno(apMaterno)
            procesador.setNombres(nombres)

            procesadores(index) = procesador
            index += 1
        Next
    End Sub

    Public Sub actualizarEstadoResultadoVacio(_estado As Boolean)
        resultadoVacio = _estado
    End Sub






    'METODOS BD ----
    Private Function traerKitPredeterminadoBD(_codigoExamen As Long)
        Dim P As Object() = New Object(0) {}

        P(0) = _codigoExamen
        Return (dal.TraerDataTable("SPtraerKitPredeterminado_RegResultadosTipoComun", P))
    End Function

    Private Function traerReferenciasBD(_codigoKit As Long)
        Dim P As Object() = New Object(1) {}
        P(0) = _codigoKit
        Return (dal.TraerDataTable("SPtraerReferenciasResultado_RegResultadosTipoComun", P))
    End Function

    Private Function traerProcesadoresBD() As DataTable
        Return (dal.TraerDataTable("SPtraerProcesadores_RegResultadosTipoComun"))
    End Function










    'METODOS VALIDACIÓN G9
    Public Function validarEntradas(ByRef _inputResultado As ResultadoLaboratorioInput, _modoTipoUsuario As Short)
        Dim mensaje As String

        mensaje = validarKitEquipo(_inputResultado.kitequipo)
        If Not mensaje = "" Then Return mensaje

        If _modoTipoUsuario = 4 Then
            mensaje = validarProcesador(_inputResultado.procesador)
            If Not mensaje = "" Then Return mensaje
        End If

        If Not resultadoVacio Then
            mensaje = validarResultado(_inputResultado.valorTipoComun)
            If Not mensaje = "" Then Return mensaje
        End If

        Return ""
    End Function

    Public Function validarProveedor(ByRef _proveedor As ProveedorKitEquipoInput)
        If Long.Parse(_proveedor.codigo) = 0 Then Return "Error. Seleccione un proveedor."
        Return ""
    End Function

    Public Function validarKitEquipo(ByRef _kitEquipo As KitEquipoLaboratorioInput)
        If Long.Parse(_kitEquipo.codigo) = 0 Then Return "Error. Seleccione un kit-equipo."
        Return ""
    End Function

    Public Function validarProcesador(ByRef _procesador As UsuarioInput)
        If Long.Parse(_procesador.codigo) = 0 Then Return "Error. Seleccione un procesador."
        Return ""
    End Function

    Public Function validarResultado(_valorResutlado As String)
        If _valorResutlado = "" Then Return "Error. Ingrese un resultado"
        Return ""
    End Function


End Class