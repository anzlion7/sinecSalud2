Public Class GrupoControlPrestaciones
    Private codigo As Int64
    Private nombre As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal _codigo As Int64, ByVal _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub




    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function

    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function


End Class
