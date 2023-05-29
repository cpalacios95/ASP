Imports System.Data.SqlClient

Public Class ConexionBD

#Region "Propiedades"

    Private Shared cadenaConexionBD As String = "Data Source=DESKTOP-G3VA22R;Initial Catalog=PruebaASP;Integrated Security=True"

#End Region

#Region "Propiedades"

    Public Shared Sub guardarModificarYOEliminar(comando As SqlCommand)
        Dim conexion As New SqlConnection
        conexion.ConnectionString = cadenaConexionBD
        comando.Connection = conexion
        comando.Connection.Open()
        comando.ExecuteNonQuery()
        comando.Connection.Close()
    End Sub

    Public Shared Function obtenerDepartamentos(query As String) As DataTable
        Dim tabla As New DataTable

        Dim conexion As New SqlConnection
        conexion.ConnectionString = cadenaConexionBD

        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = query

        Dim adaptador As New SqlDataAdapter
        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection.Open()
        adaptador.Fill(tabla)
        adaptador.SelectCommand.Connection.Close()

        comando.Connection.Close()

        Return tabla

    End Function

#End Region


End Class
