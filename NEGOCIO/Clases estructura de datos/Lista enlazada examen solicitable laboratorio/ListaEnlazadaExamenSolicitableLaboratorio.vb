Public Class ListaEnlazadaExamenSolicitableLaboratorio

    Public raiz As NodoExamenSolicitableLaboratorio

    Public Sub agregarNodo(ByRef _nuevoExamen As ExamenSolicitableLaboratorio)
        If raiz Is Nothing Then
            raiz = New NodoExamenSolicitableLaboratorio()
            raiz.examenSolicitable = _nuevoExamen
        Else
            Dim ultimoNodo As NodoExamenSolicitableLaboratorio
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoExamenSolicitableLaboratorio()
            ultimoNodo.siguiente.examenSolicitable = _nuevoExamen
        End If
    End Sub

    Public Function encontrarUltimoNodo() As NodoExamenSolicitableLaboratorio
        Dim nodoAcutal As NodoExamenSolicitableLaboratorio
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function encontrarDimension() As Short
        Dim nodoAcutal As NodoExamenSolicitableLaboratorio = raiz, contador As Short = 0

        If nodoAcutal IsNot Nothing Then contador = 1 Else Return 0

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
            contador += 1
        End While

        Return contador
    End Function

    Public Sub eliminarNodoExamenIndividual(_codigo As Long)
        'eliminar al principio
        Dim codigo As Long = raiz.examenSolicitable.getCodigo()

        If codigo = _codigo And TypeOf raiz.examenSolicitable Is ExamenLaboratorio Then
            raiz = raiz.siguiente
        End If




        'eliminar al medio y al final
        Dim nodoAnterior As NodoExamenSolicitableLaboratorio = encontrarNodoAnteriorExamenIndividual(_codigo)
        If nodoAnterior IsNot Nothing Then
            nodoAnterior.siguiente = nodoAnterior.siguiente.siguiente
        End If
    End Sub

    Private Function encontrarNodoAnteriorExamenIndividual(_codigo As Long) As NodoExamenSolicitableLaboratorio
        Dim nodoActual As NodoExamenSolicitableLaboratorio = raiz
        Dim nodoAnterior As NodoExamenSolicitableLaboratorio = nodoActual


        While nodoActual IsNot Nothing
            Dim codigoActual As Long = nodoActual.examenSolicitable.getCodigo()

            If codigoActual = _codigo And TypeOf nodoActual.examenSolicitable Is ExamenLaboratorio Then
                Return nodoAnterior
            Else
                nodoAnterior = nodoActual
                nodoActual = nodoActual.siguiente
            End If

        End While


        Return Nothing
    End Function


    Public Sub eliminarNodoExamenGrupal(_codigo As Long)
        'eliminar al principio
        Dim codigo As Long = raiz.examenSolicitable.getCodigo()

        If codigo = _codigo And TypeOf raiz.examenSolicitable Is GrupoExamenLaboratorio Then
            raiz = raiz.siguiente
        End If




        'eliminar al medio y al final
        Dim nodoAnterior As NodoExamenSolicitableLaboratorio = encontrarNodoAnteriorExamenGrupal(_codigo)
        If nodoAnterior IsNot Nothing Then
            nodoAnterior.siguiente = nodoAnterior.siguiente.siguiente
        End If
    End Sub

    Private Function encontrarNodoAnteriorExamenGrupal(_codigo As Long) As NodoExamenSolicitableLaboratorio
        Dim nodoActual As NodoExamenSolicitableLaboratorio = raiz
        Dim nodoAnterior As NodoExamenSolicitableLaboratorio = nodoActual


        While nodoActual IsNot Nothing
            Dim codigoActual As Long = nodoActual.examenSolicitable.getCodigo()

            If codigoActual = _codigo And TypeOf nodoActual.examenSolicitable Is GrupoExamenLaboratorio Then
                Return nodoAnterior
            Else
                nodoAnterior = nodoActual
                nodoActual = nodoActual.siguiente
            End If

        End While


        Return Nothing
    End Function






End Class
