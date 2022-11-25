Public Class ListaEnlazadaExamenLaboratorio

    Public raiz As NodoExamenLaboratorio

    Public Sub agregarNodo(ByRef _nuevoExamen As ExamenLaboratorio)
        If raiz Is Nothing Then
            raiz = New NodoExamenLaboratorio()
            raiz.examen = _nuevoExamen
        Else
            Dim ultimoNodo As NodoExamenLaboratorio
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoExamenLaboratorio()
            ultimoNodo.siguiente.examen = _nuevoExamen
        End If
    End Sub

    Public Function encontrarUltimoNodo() As NodoExamenLaboratorio
        Dim nodoAcutal As NodoExamenLaboratorio
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function encontrarDimension() As Short
        Dim nodoAcutal As NodoExamenLaboratorio = raiz, contador As Short = 0

        While nodoAcutal IsNot Nothing
            contador += 1
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return contador
    End Function

    Public Sub eliminarNodo(_codigo As Long)
        'ELIMINAR AL PRINCIPIO
        Dim codigo As Long
        codigo = raiz.examen.getCodigo()

        If codigo = _codigo Then
            raiz = raiz.siguiente
        End If



        'ELIMINAR AL MEDIO Y AL FINAL
        Dim nodoAnterior As NodoExamenLaboratorio
        nodoAnterior = encontrarNodoAnterior(_codigo)

        If nodoAnterior IsNot Nothing Then
            nodoAnterior.siguiente = nodoAnterior.siguiente.siguiente
        End If
    End Sub

    Private Function encontrarNodoAnterior(_codigp As Long) As NodoExamenLaboratorio
        Dim nodoActual As NodoExamenLaboratorio, nodoAnterior As NodoExamenLaboratorio
        nodoActual = raiz
        nodoAnterior = nodoActual

        While nodoActual IsNot Nothing
            Dim codigoActual As Long
            codigoActual = nodoActual.examen.getCodigo()

            If codigoActual = _codigp Then
                Return nodoAnterior
            Else
                nodoAnterior = nodoActual
                nodoActual = nodoActual.siguiente
            End If
        End While


        Return Nothing
    End Function

    Public Sub vaciarLista()
        raiz = Nothing
    End Sub

End Class
