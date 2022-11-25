Public Class GrupoExamenLaboratorio
    Inherits ExamenSolicitableLaboratorio

    Private examenes As ExamenLaboratorio()

    Public Sub New()
        codigo = 0
        nombre = ""
        area = New AreaLaboratorio()
        examenes = New ExamenLaboratorio(-1) {}
    End Sub

    Public Sub New(_codigo As Long, _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub


    Public Sub setExamenes(_examenes As ExamenLaboratorio())
        examenes = _examenes
    End Sub

    Public Function getExamenes() As ExamenLaboratorio()
        Return examenes
    End Function


End Class


Public Class GrupoExamenLaboratorioInput

    Public Property codigo As String
    Public Property nombre As String
    Public Property area As AreaLaboratorioInput
    Public Property nroExamenes As String

    Public Sub New()
        codigo = "0"
        nombre = ""
        area = New AreaLaboratorioInput()
        nroExamenes = "0"
    End Sub

End Class