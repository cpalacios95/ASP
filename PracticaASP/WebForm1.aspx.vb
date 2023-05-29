Public Class WebForm1
    Inherits System.Web.UI.Page

#Region "Propiedades"

    Property objetoSeleccionado As Entidades.Departamento
        Get
            Return Session("objetoSeleccionado")
        End Get
        Set(value As Entidades.Departamento)
            Session("objetoSeleccionado") = value
        End Set
    End Property

#End Region


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        obtenerDepartamentos()

    End Sub

    Private Sub btnGuardarNuevoDepartamento_Click(sender As Object, e As EventArgs) Handles btnGuardarNuevoDepartamento.Click
        guardarDepartamento()
    End Sub


    Private Sub gridDepartamentos_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles gridDepartamentos.SelectedIndexChanging

        Try
            objetoSeleccionado = sender.DataSource(e.NewSelectedIndex)
            txtboxNombreDepartament.Text = objetoSeleccionado.nombreDepartamento
        Catch ex As Exception

        End Try

    End Sub

    Private Sub guardarDepartamento()

        Dim departamento As New Entidades.Departamento

        Try

            departamento.nombreDepartamento = txtboxNombreDepartament.Text
            Negocio.Departamento.guardarDepartamento(departamento)
            lblMensaje.Text = "Se guardo el nuevo departamento"
            lblMensaje.Visible = True
        Catch ex As Exception
            lblMensaje.Text = "Hubo un error al guardar el nuevo departamento"
            lblMensaje.Visible = True
        End Try
    End Sub

    Private Sub obtenerDepartamentos()

        Dim listaDeptos As New List(Of Entidades.Departamento)

        listaDeptos = Negocio.Departamento.obtenerDepartamentos()

        If listaDeptos.Count > 0 Then
            gridDepartamentos.DataSource = listaDeptos
            gridDepartamentos.AutoGenerateSelectButton = True
            gridDepartamentos.DataBind()
            gridDepartamentos.Visible = True
        End If

    End Sub

End Class