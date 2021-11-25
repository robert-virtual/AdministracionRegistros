Public Class Form1
    Dim Personas As List(Of String()) = New List(Of String())



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_nacionalidad.Items.Add("Honduras")
        cb_nacionalidad.Items.Add("Estado Unidense")
        cb_nacionalidad.Items.Add("Español")


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
    Private Sub CargarDeptos(Deptos)
        cb_depto.Items.Clear()
        cb_depto.Items.AddRange(Deptos)

    End Sub
    Private Sub cb_nacionalidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_nacionalidad.SelectionChangeCommitted

        Select Case cb_nacionalidad.Text
            Case "Honduras"
                Dim DeptosHonduras As String() = New String() {
                    "El Paraiso",
                    "Fracisco Morazan",
                    "Atlántida",
                    "Colón"
                }
                CargarDeptos(DeptosHonduras)

            Case "Estado Unidense"
                Dim USADeptos As String() = New String() {
                    "Texas",
                    "California",
                    "Florida",
                    "Alabama"
                }
                CargarDeptos(USADeptos)

            Case "Español"
                Dim SpainDeptos As String() = New String() {
                    "Barcelona",
                    "Madrid",
                    "Almeria",
                    "Valencia"
                }
                CargarDeptos(SpainDeptos)
            Case Else

        End Select



    End Sub
End Class
