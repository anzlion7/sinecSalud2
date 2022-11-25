Public Class ListaEnlazadaDetalleLaboratorio

    Public raiz As NodoDetalleLaboratorio

    Public Sub agregarNodo(ByRef _nuevoDetalle As DetalleLaboratorio)
        If raiz Is Nothing Then
            raiz = New NodoDetalleLaboratorio()
            raiz.detalle = _nuevoDetalle
        Else
            Dim ultimoNodo As NodoDetalleLaboratorio
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoDetalleLaboratorio()
            ultimoNodo.siguiente.detalle = _nuevoDetalle
        End If
    End Sub

    Public Function encontrarUltimoNodo() As NodoDetalleLaboratorio
        Dim nodoAcutal As NodoDetalleLaboratorio
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function encontrarDimension() As Short
        Dim nodoAcutal As NodoDetalleLaboratorio = raiz, contador As Short = 0

        If nodoAcutal IsNot Nothing Then contador = 1 Else Return 0

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
            contador += 1
        End While

        Return contador
    End Function



End Class
