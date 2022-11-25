Public Class AreaLaboratorio

    Private codigo As Long
    Private nombre As String
    Private examenesSolicitables As ExamenSolicitableLaboratorio()

    Public Sub New()
        codigo = 0
        nombre = ""
        examenesSolicitables = New ExamenSolicitableLaboratorio(-1) {}
    End Sub

    Public Sub New(_codigo As Long, ByVal _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub




    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub



    Public Function getNombre() As String
        Return nombre
    End Function

    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub



    Public Sub setExamenesSolicitables(ByRef _examenesSolicitables As ExamenSolicitableLaboratorio())
        examenesSolicitables = _examenesSolicitables
    End Sub

    Public Function getExamenesSolicitables() As ExamenSolicitableLaboratorio()
        Return examenesSolicitables
    End Function



End Class
