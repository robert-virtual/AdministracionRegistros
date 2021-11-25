Public Class Form1
    Dim Personas As List(Of String()) = New List(Of String())



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_nacionalidad.Items.Add("Honduras")
        cb_nacionalidad.Items.Add("Estado Unidense")
        cb_nacionalidad.Items.Add("Estado Unidense")
        cb_nacionalidad.Items.Add("Español")

        'depto
        cb_depto.Items.Add("El Paraiso")
        cb_depto.Items.Add("Francisco Morazan")

        'municipio
        cb_municipio.Items.Add("Danli")
        cb_municipio.Items.Add("El Paraiso")
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim persona = New String() {
            txt_name.Text,
            cb_nacionalidad.Text,
            cb_depto.Text,
            cb_municipio.Text
        }

        Personas.Add(persona)
        CargarDatos()
        Restablacer()
    End Sub
    Private Sub Restablacer()
        txt_name.Clear()

    End Sub


    Private Sub CargarDatos()
        For Each persona As String() In Personas
            dgv_registros.Rows.Add(persona)

        Next

    End Sub


End Class
