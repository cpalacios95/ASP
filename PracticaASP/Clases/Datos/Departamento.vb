Imports System.Data.SqlClient

Namespace Datos

    Public Class Departamento

#Region "Metodos"

        Public Shared Sub guardarDepartamento(nuevoDepartamento As Entidades.Departamento)

            Dim comando As New SqlCommand
            comando.CommandText = "INSERT INTO PruebaASP.dbo.Departamento (dep_nombre) VALUES (@dep_nombre);"
            comando.Parameters.Add(New SqlParameter("dep_nombre", nuevoDepartamento.nombreDepartamento))

            ConexionBD.guardarModificarYOEliminar(comando)

        End Sub

        Public Shared Function obtenerDepartamentos() As DataTable
            Return ConexionBD.obtenerDepartamentos("SELECT dep_id, dep_nombre FROM PruebaASP.dbo.Departamento;")
        End Function


#End Region





    End Class

End Namespace