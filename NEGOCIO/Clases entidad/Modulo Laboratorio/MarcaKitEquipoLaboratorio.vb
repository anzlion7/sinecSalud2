Public Class MarcaKitEquipoLaboratorio

    Private codigo As Long
    Private nombre As String

    Public Sub New()
        codigo = 0
        nombre = ""
    End Sub

    Public Sub New(_codigo As Long, _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub





    Public Sub setCodigo()
        codigo = 0
    End Sub

    Public Function getCodigo()
        Return codigo
    End Function

    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function



End Class
