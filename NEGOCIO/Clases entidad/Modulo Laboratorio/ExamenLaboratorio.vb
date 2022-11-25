Public Class ExamenLaboratorio
    Inherits ExamenSolicitableLaboratorio

    Private subarea As SubareaLaboratorio

    Private grupoExamen As GrupoExamenLaboratorio
    Private codigoIndividual As Short
    Private tipoResultado As Concepto

    Private conjuntoOpcionesResultado As ConjuntoOpcionesResultadosLaboratorio
    Private unidad As UnidadMedidaLaboratorio
    Private kitPredeterminado As KitEquipoLaboratorio


    Public Sub New()
        codigo = 0
        nombre = ""
        area = New AreaLaboratorio()
        subarea = New SubareaLaboratorio()

        grupoExamen = New GrupoExamenLaboratorio()
        codigoIndividual = 0
        tipoResultado = New Concepto()

        conjuntoOpcionesResultado = New ConjuntoOpcionesResultadosLaboratorio()
        unidad = New UnidadMedidaLaboratorio()
        kitPredeterminado = Nothing
    End Sub

    Public Sub New(_kitPredeterminado As KitEquipoLaboratorio)
        codigo = 0
        kitPredeterminado = _kitPredeterminado
    End Sub


    Public Sub New(_codigo As Short, _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub

    Public Sub New(_codigo As Long, _nombre As String, ByRef _area As AreaLaboratorio, ByRef _subarea As SubareaLaboratorio)
        codigo = _codigo
        nombre = _nombre
        area = _area
        subarea = _subarea
    End Sub




    Public Function getSubarea() As SubareaLaboratorio
        Return subarea
    End Function

    Public Sub setSubarea(ByRef _subarea As SubareaLaboratorio)
        subarea = _subarea
    End Sub



    Public Sub setGrupoExamen(ByRef _grupoExamen As GrupoExamenLaboratorio)
        grupoExamen = _grupoExamen
    End Sub

    Public Function getGrupoExamen() As GrupoExamenLaboratorio
        Return grupoExamen
    End Function



    Public Sub setCodigoIndividual(_codigoIndividual As Short)
        codigoIndividual = _codigoIndividual
    End Sub

    Public Function getCodigoIndividual() As Short
        Return codigoIndividual
    End Function



    Public Function getTipoResultado() As Concepto
        Return tipoResultado
    End Function

    Public Sub setTipoResultado(ByRef _tipoResultado As Concepto)
        tipoResultado = _tipoResultado
    End Sub



    Public Sub setConjuntoOpcionesResultado(ByRef _conjuntoOpcionesResultado As ConjuntoOpcionesResultadosLaboratorio)
        conjuntoOpcionesResultado = _conjuntoOpcionesResultado
    End Sub

    Public Function getConjuntoOpcionesResultado() As ConjuntoOpcionesResultadosLaboratorio
        Return conjuntoOpcionesResultado
    End Function



    Public Sub setUnidad(ByRef _unidad As UnidadMedidaLaboratorio)
        unidad = _unidad
    End Sub

    Public Function getUnidad() As UnidadMedidaLaboratorio
        Return unidad
    End Function



    Public Sub setKitPredeterminado(ByRef _kitPredeterminado As KitEquipoLaboratorio)
        kitPredeterminado = _kitPredeterminado
    End Sub

    Public Function getKitPredeterminado() As KitEquipoLaboratorio
        Return kitPredeterminado
    End Function


End Class


Public Class ExamenLaboratorioInput
    Public Property codigo As String
    Public Property nombre As String
    Public Property area As AreaLaboratorioInput
    Public Property subarea As SubareaLaboratorioInput
    Public Property grupoExamen As GrupoExamenLaboratorioInput
    Public Property codigoIndividual As String
    Public Property tipoResultado As ConceptoInput
    Public Property conjuntoOpcionesResultado As ConjuntoOpcionesResultadosLabInput
    Public Property unidad As UnidadMedidaLaboratorioInput

    Public Sub New()
        codigo = "0"
        nombre = ""
        area = New AreaLaboratorioInput()
        subarea = New SubareaLaboratorioInput()

        grupoExamen = New GrupoExamenLaboratorioInput()
        codigoIndividual = "0"
        tipoResultado = New ConceptoInput()
        conjuntoOpcionesResultado = New ConjuntoOpcionesResultadosLabInput()
        unidad = New UnidadMedidaLaboratorioInput()
    End Sub

End Class

