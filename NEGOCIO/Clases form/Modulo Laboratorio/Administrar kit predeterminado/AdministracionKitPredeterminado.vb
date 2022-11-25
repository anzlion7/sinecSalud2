Imports DAL

Public Class AdministracionKitPredeterminado

    'ATRIBUTOS LÓGICOS -----
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public examenes() As ExamenLaboratorio
    Public examenSeleccionado As ExamenLaboratorio
    Public kits() As KitEquipoLaboratorio
    Public kitSeleccionado As KitEquipoLaboratorio
    Public referencias() As ReferenciaResultadoLaboratorio

    'ATRIBUTOS SUBMIT   
    Public entradasValidadas As Boolean
    Public respuestaSubmitActualizarKit As Short


    'METODOS INICIO -----
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        examenes = New ExamenLaboratorio(-1) {}
        examenSeleccionado = Nothing
        kits = New KitEquipoLaboratorio(-1) {}
        kitSeleccionado = Nothing
        referencias = New ReferenciaResultadoLaboratorio(-1) {}


        'ATRIBUTOS SUBMIT   
        entradasValidadas = False
        respuestaSubmitActualizarKit = 0
    End Sub











    'METODOS FUNCIONALES G1
    Public Sub traerExamenes(_nombreExamen As String)
        Dim datatable As DataTable = traerExamenesBD(_nombreExamen), index As Short = 0
        examenes = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, nombreMarca As String
            Dim examen As ExamenLaboratorio, kitPredeterminado As KitEquipoLaboratorio

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()
            If IsDBNull(row("NOMMAR MARKIT")) Then nombreMarca = "" Else nombreMarca = row("NOMMAR MARKIT").ToString()

            kitPredeterminado = New KitEquipoLaboratorio(Nothing)
            kitPredeterminado.setCodigo(0)
            kitPredeterminado.setNombre(nombreMarca)

            examen = New ExamenLaboratorio(Nothing)
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setKitPredeterminado(kitPredeterminado)

            examenes(index) = examen
            index += 1
        Next
    End Sub

    Public Sub traerKits(_codigoExamen As Long)
        Dim datatable As DataTable = traerKitsBD(_codigoExamen), index As Short = 0
        kits = New KitEquipoLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String
            Dim kit As KitEquipoLaboratorio

            If IsDBNull(row("CODKIT KITEQU")) Then codigo = 0 Else codigo = Long.Parse(row("CODKIT KITEQU"))
            If IsDBNull(row("NOMMAR MAR")) Then nombre = "" Else nombre = row("NOMMAR MAR").ToString()

            kit = New KitEquipoLaboratorio(Nothing)
            kit.setCodigo(codigo)
            kit.setNombre(nombre)

            kits(index) = kit
            index += 1
        Next
    End Sub

    Public Sub traerReferencias(_codigoKit As Long)
        Dim datatable As DataTable = traerReferenciasBD(_codigoKit), index As Short = 0
        referencias = New ReferenciaResultadoLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, codigoTipo As Short, valorInicial As Double,
                valorFinal As Double, sexo As Char, edadInicial As Short,
                edadFinal As Short
            Dim referencia As ReferenciaResultadoLaboratorio

            If IsDBNull(row("CODREF REF")) Then codigo = 0 Else codigo = Long.Parse(row("CODREF REF"))
            If IsDBNull(row("CODTIP REF")) Then codigoTipo = 0 Else codigoTipo = Short.Parse(row("CODTIP REF"))
            If IsDBNull(row("VALINI REF")) Then valorInicial = 0 Else valorInicial = Double.Parse(row("VALINI REF"))
            If IsDBNull(row("VALFIN REF")) Then valorFinal = 0 Else valorFinal = Double.Parse(row("VALFIN REF"))
            If IsDBNull(row("SEX REF")) Then sexo = "" Else sexo = Char.Parse(row("SEX REF"))
            If IsDBNull(row("EDA INI")) Then edadInicial = 0 Else edadInicial = Double.Parse(row("EDA INI"))
            If IsDBNull(row("EDA FIN")) Then edadFinal = 0 Else edadFinal = Double.Parse(row("EDA FIN"))

            referencia = New ReferenciaResultadoLaboratorio()
            referencia.setCodigo(codigo)
            referencia.setTipo(New Concepto(0, codigoTipo, ""))
            referencia.setValorInicio(valorInicial)
            referencia.setValorFin(valorFinal)
            referencia.setSexo(sexo)
            referencia.setEdadInicio(edadInicial)
            referencia.setEdadFin(edadFinal)

            referencias(index) = referencia
            index += 1
        Next
    End Sub

    'METODOS FUNCIONALES SUBMIT
    Public Function validarEntradasSubmit(ByRef _kit As KitEquipoLaboratorio)
        Dim mensaje As String

        mensaje = validarNuevoKitPredeterminado(_kit)
        If Not mensaje = "" Then
            entradasValidadas = False
            Return mensaje
        End If


        entradasValidadas = True
        Return ""
    End Function

    Private Function validarNuevoKitPredeterminado(ByRef _kit As KitEquipoLaboratorio) As String
        If IsNothing(_kit) Then Return "Error. Seleccione un nuevo kit predeterminado"

        Return ""
    End Function

    Public Function cargarObjetosParaSubmit() As ExamenLaboratorio
        Dim examenSubmit As ExamenLaboratorio

        examenSubmit = examenSeleccionado
        examenSubmit.setKitPredeterminado(kitSeleccionado)

        Return examenSubmit
    End Function

    Public Sub updateKitPredeterminado(_codigoKit As Long, _codigoExamen As Long)
        Dim respuesta As Short

        respuesta = updateKitPredeterminadoBD(_codigoKit, _codigoExamen)
        respuestaSubmitActualizarKit = respuesta
    End Sub











    'METODOS BD G1 ----
    Private Function traerExamenesBD(_nombreExamen As String) As DataTable
        Dim P As Object() = New Object(0) {}

        P(0) = _nombreExamen
        Return dal.TraerDataTable("SPtraerExamen_AdministrarKitPredeterminado", P)
    End Function

    Private Function traerKitsBD(_codigoExamen As Long) As DataTable
        Dim P As Object() = New Object(0) {}

        P(0) = _codigoExamen
        Return dal.TraerDataTable("SPtraerKits_AdministrarKitPredeterminado", P)
    End Function

    Private Function traerReferenciasBD(_codigoKit As Long) As DataTable
        Dim P As Object() = New Object(0) {}

        P(0) = _codigoKit
        Return dal.TraerDataTable("SPtraerReferenciasResultado_AdministrarKitPredeterminado", P)
    End Function

    'METODOS BD SUBMIT
    Private Function updateKitPredeterminadoBD(_codigoKit As Long, _codigoExamen As Long) As Short
        Dim P As Object() = New Object(1) {}

        P(0) = _codigoKit
        P(1) = _codigoExamen
        Return dal.Ejecutar("SPactualizarKitPredeterminado_AdministrarKitPredeterminado", P)
    End Function


End Class
