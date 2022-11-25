Public Class OrdenLaboratorio

    Private codigo As Long
    Private fecha As Date
    Private medico As Medico
    Private asegurado As Asegurado
    Private nroExamenes As Short
    Private nroResultados As Short
    Private detalles As DetalleLaboratorio()
    Private nota As String

    Public Sub New()
        codigo = 0
        fecha = New Date()
        medico = New Medico()
        asegurado = New Asegurado()
        nroExamenes = 0
        nroResultados = 0
        detalles = New DetalleLaboratorio(-1) {}
        nota = ""
    End Sub




    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub



    Public Function getFecha() As Date
        Return fecha
    End Function

    Public Sub setFecha(ByVal _fecha As Date)
        fecha = _fecha
    End Sub



    Public Sub setMedico(ByRef _medico As Medico)
        medico = _medico
    End Sub

    Public Function getMedico() As Medico
        Return medico
    End Function



    Public Sub setAsegurado(ByRef _asegurado As Asegurado)
        asegurado = _asegurado
    End Sub

    Public Function getAsegurado() As Asegurado
        Return asegurado
    End Function



    Public Sub setNroExamenes(_nroExamenes As Short)
        nroExamenes = _nroExamenes
    End Sub

    Public Function getNroExamenes() As Short
        Return nroExamenes
    End Function




    Public Sub setNroResultados(_nroResultados As Short)
        nroResultados = _nroResultados
    End Sub

    Public Function getNroResultados() As Short
        Return nroResultados
    End Function




    Public Sub setDetalles(_detalles As DetalleLaboratorio())
        detalles = _detalles
    End Sub

    Public Function getDetalles() As DetalleLaboratorio()
        Return detalles
    End Function




    Public Sub setNota(_nota As String)
        nota = _nota
    End Sub

    Public Function getNota() As String
        Return nota
    End Function




End Class
