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
    Private Sub CargarComboBox(Deptos, combobox)
        combobox.Items.Clear()
        combobox.Items.AddRange(Deptos)

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
                CargarComboBox(DeptosHonduras, cb_depto)

            Case "Estado Unidense"
                Dim USADeptos As String() = New String() {
                    "Texas",
                    "California",
                    "Florida",
                    "Alabama"
                }
                CargarComboBox(USADeptos, cb_depto)

            Case "Español"
                Dim SpainDeptos As String() = New String() {
                    "Barcelona",
                    "Madrid",
                    "Almeria",
                    "Valencia"
                }
                CargarComboBox(SpainDeptos, cb_depto)
            Case Else

        End Select



    End Sub
    Private Sub CargarMunicipios(Municipios)

    End Sub
    Private Sub cb_depto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_depto.SelectionChangeCommitted
        '"El Paraiso",
        '           "Fracisco Morazan",
        '           "Atlántida",
        '           "Colón"

        Select Case cb_depto.Text
            Case "El Paraiso"
                Dim elParaisoMunicipios As String() = New String() {
                   "Danli",
                   "EL Paraiso",
                   "Yuscaran"
               }
                CargarComboBox(elParaisoMunicipios, cb_municipio)
            Case "Fracisco Morazan"
                Dim fraciscoMorazanMunicipios As String() = New String() {
                   "Tegucugalpa",
                   "Valle de Ángeles",
                   "Talanga"
               }
                CargarComboBox(fraciscoMorazanMunicipios, cb_municipio)
            Case "Atlántida"
                Dim elParaisoMunicipios As String() = New String() {
                   "Ceiba",
                   "Tela",
                   "Jutiapa"
               }
                CargarComboBox(elParaisoMunicipios, cb_municipio)
            Case "Colón"
                Dim colonMunicipios As String() = New String() {
                   "Trujillo",
                   "Balfate",
                   "Iriona"
               }
                CargarComboBox(colonMunicipios, cb_municipio)
            Case Else
                Dim colonMunicipios As String() = New String() {
                   "New York",
                   "Los Angeles",
                   "Barcelona",
                   "Madrid",
                   "Viginia"
               }
                CargarComboBox(colonMunicipios, cb_municipio)

        End Select
    End Sub
End Class
