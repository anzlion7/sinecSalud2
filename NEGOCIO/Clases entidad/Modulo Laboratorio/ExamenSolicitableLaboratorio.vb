Public Class ExamenSolicitableLaboratorio

    Public Property codigo As Long
    Public Property nombre As String
    Protected area As AreaLaboratorio

    Public Sub New()

    End Sub

    Public Sub New(_codigo As Long, _nombre As String, _area As AreaLaboratorio)
        codigo = _codigo
        nombre = _nombre
        area = _area
    End Sub





    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Long
        Return codigo
    End Function



    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function



    Public Sub setArea(_area As AreaLaboratorio)
        area = _area
    End Sub

    Public Function getArea() As AreaLaboratorio
        Return area
    End Function













End Class
