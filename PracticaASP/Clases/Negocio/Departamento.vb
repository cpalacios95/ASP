Namespace Negocio

    Public Class Departamento

#Region "Metodos"

        Public Shared Sub guardarDepartamento(nuevoDepartamento As Entidades.Departamento)

            Datos.Departamento.guardarDepartamento(nuevoDepartamento)

        End Sub

        Public Shared Function obtenerDepartamentos() As List(Of Entidades.Departamento)

            Dim listaDeptos As New List(Of Entidades.Departamento)
            Dim tabla As DataTable = Datos.Departamento.obtenerDepartamentos

            If tabla IsNot Nothing AndAlso tabla.Rows.Count > 1 Then

                For Each fila In tabla.Rows
                    Dim depto As New Entidades.Departamento
                    depto.id = fila("dep_id")
                    depto.nombreDepartamento = fila("dep_nombre")
                    listaDeptos.Add(depto)
                Next

            End If

            Return listaDeptos

        End Function

#End Region

    End Class

End Namespace
