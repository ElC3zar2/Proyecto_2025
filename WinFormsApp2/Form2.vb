Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ads As New DataSet
    Dim conectar As New SqlConnection("Data Source=FERNANDO;Initial Catalog=proyecto;Integrated Security=True;Encrypt=False")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(departamentosYmunicipios.Keys.ToArray())
        ComboBox3.Items.AddRange(New String() {"Ninguno", "Poco", "Moderado", "Intenso"})
        ComboBox4.Items.AddRange(New String() {"Masculino", "Femenino"})
        TextBox1.Focus()
        TextBox1.PlaceholderText = "Ingrese su nombre completo"
        TextBox2.PlaceholderText = "Ingrese su edad"
        TextBox4.PlaceholderText = "Ingrese su peso (lb)"
        TextBox5.PlaceholderText = "Ingrese su altura (cm)"
        TextBox6.PlaceholderText = "Ingrese su ocupación"
    End Sub

    Sub nuevo()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = "Departamento"
        ComboBox2.Text = "Municipio"
        ComboBox3.Text = "Actividad_física"
        ComboBox4.Text = "Genero"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comandos As New SqlCommand("sp_InsertarUsuario", conectar)
        comandos.CommandType = CommandType.StoredProcedure
        comandos.Parameters.AddWithValue("@nombre_completo", TextBox1.Text)
        comandos.Parameters.AddWithValue("@edad", TextBox2.Text)
        comandos.Parameters.AddWithValue("@genero", ComboBox4.Text)
        comandos.Parameters.AddWithValue("@departamento", ComboBox1.Text)
        comandos.Parameters.AddWithValue("@municipio", ComboBox2.Text)
        comandos.Parameters.AddWithValue("@peso", TextBox4.Text)
        comandos.Parameters.AddWithValue("@altura", TextBox5.Text)
        comandos.Parameters.AddWithValue("@actividad_fisica", ComboBox3.Text)
        comandos.Parameters.AddWithValue("@ocupacion", TextBox6.Text)

        Try
            conectar.Open()
            comandos.ExecuteNonQuery()
            MsgBox("Datos guardados con éxito!!! :D", vbInformation, "Guardar")
            nuevo()
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conectar.Close()
        End Try
    End Sub

    Private departamentosYmunicipios As New Dictionary(Of String, List(Of String)) From {
        {"Guatemala", New List(Of String) From {"Guatemala", "Santa Catarina Pinula", "San José Pinula", "San José del Golfo", "Palencia", "Chinautla", "San Pedro Ayampuc", "Mixco", "San Pedro Sacatepéquez", "San Juan Sacatepéquez", "San Raymundo", "Chuarrancho", "Fraijanes", "Amatitlán", "Villa Nueva", "Villa Canales", "San Miguel Petapa"}},
        {"Sacatepéquez", New List(Of String) From {"Antigua Guatemala", "Jocotenango", "Pastores", "Sumpango", "Santo Domingo Xenacoj", "Santiago Sacatepéquez", "San Bartolomé Milpas Altas", "San Lucas Sacatepéquez", "Santa Lucía Milpas Altas", "Magdalena Milpas Altas", "Santa María de Jesús", "Ciudad Vieja", "San Miguel Dueñas", "San Juan Alotenango", "San Antonio Aguas Calientes"}},
        {"Chimaltenango", New List(Of String) From {"Chimaltenango", "San José Poaquil", "San Martín Jilotepeque", "San Juan Comalapa", "Santa Apolonia", "Tecpán Guatemala", "Patzún", "San Miguel Pochuta", "Patzicía", "Santa Cruz Balanyá", "Acatenango", "Yepocapa", "San Andrés Itzapa", "Parramos", "Zaragoza", "El Tejar"}},
        {"Escuintla", New List(Of String) From {"Escuintla", "Santa Lucía Cotzumalguapa", "La Democracia", "Siquinalá", "Masagua", "Tiquisate", "La Gomera", "Guanagazapa", "San José", "Iztapa", "Palín", "San Vicente Pacaya", "Nueva Concepción"}},
        {"Santa Rosa", New List(Of String) From {"Cuilapa", "Barberena", "Santa Rosa de Lima", "Casillas", "San Rafael Las Flores", "Oratorio", "San Juan Tecuaco", "Chiquimulilla", "Taxisco", "Santa María Ixhuatán", "Guazacapán", "Santa Cruz Naranjo", "Pueblo Nuevo Viñas", "Nueva Santa Rosa"}},
        {"Jalapa", New List(Of String) From {"Jalapa", "San Pedro Pinula", "San Luis Jilotepeque", "San Manuel Chaparrón", "San Carlos Alzatate", "Monjas", "Mataquescuintla"}},
        {"Jutiapa", New List(Of String) From {"Jutiapa", "El Progreso", "Santa Catarina Mita", "Agua Blanca", "Asunción Mita", "Yupiltepeque", "Atescatempa", "Jerez", "El Adelanto", "Zapotitlán", "Comapa", "Jalpatagua", "Conguaco", "Moyuta", "Pasaco", "San José Acatempa", "Quesada"}},
        {"Suchitepéquez", New List(Of String) From {"Mazatenango", "Cuyotenango", "San Francisco Zapotitlán", "San Bernardino", "San José El Ídolo", "Santo Domingo Suchitepéquez", "San Lorenzo", "Samayac", "San Pablo Jocopilas", "San Antonio Suchitepéquez", "San Miguel Panán", "San Gabriel", "Chicacao", "Patulul", "Santa Bárbara", "San Juan Bautista", "Santo Tomás La Unión", "Zunilito"}},
        {"Retalhuleu", New List(Of String) From {"Retalhuleu", "San Sebastián", "Santa Cruz Muluá", "San Martín Zapotitlán", "San Felipe", "San Andrés Villa Seca", "Champerico", "Nuevo San Carlos", "El Asintal"}},
        {"Sololá", New List(Of String) From {"Sololá", "San José Chacayá", "Santa María Visitación", "Santa Lucía Utatlán", "Nahualá", "Santa Catarina Ixtahuacán", "Santa Clara La Laguna", "Concepción", "San Andrés Semetabaj", "Panajachel", "Santa Catarina Palopó", "San Antonio Palopó", "San Lucas Tolimán", "Santa Cruz La Laguna", "San Pablo La Laguna", "San Marcos La Laguna", "San Juan La Laguna", "San Pedro La Laguna", "Santiago Atitlán"}},
        {"Quetzaltenango", New List(Of String) From {"Quetzaltenango", "Salcajá", "Olintepeque", "San Carlos Sija", "Sibilia", "Cabricán", "Cajolá", "San Miguel Sigüilá", "San Juan Ostuncalco", "San Mateo", "Concepción Chiquirichapa", "San Martín Sacatepéquez", "Almolonga", "Cantel", "Huitán", "Zunil", "Colomba", "San Francisco La Unión", "El Palmar", "Coatepeque", "Génova", "Flores Costa Cuca", "La Esperanza", "Palestina de Los Altos"}},
        {"Huehuetenango", New List(Of String) From {"Huehuetenango", "Chiantla", "Malacatancito", "Cuilco", "Nentón", "San Pedro Necta", "Jacaltenango", "San Pedro Soloma", "San Ildefonso Ixtahuacán", "Santa Bárbara", "La Libertad", "La Democracia", "San Miguel Acatán", "San Rafael La Independencia", "Todos Santos Cuchumatán", "San Juan Atitán", "Santa Eulalia", "San Mateo Ixtatán", "Colotenango", "San Sebastián Huehuetenango", "Tectitán", "Concepción Huista", "San Juan Ixcoy", "San Antonio Huista", "San Sebastián Coatán", "Barillas", "Aguacatán", "San Rafael Petzal", "San Gaspar Ixchil", "Santiago Chimaltenango", "Santa Ana Huista"}},
        {"Petén", New List(Of String) From {"Flores", "San José", "San Benito", "San Andrés", "La Libertad", "San Francisco", "Santa Ana", "Dolores", "San Luis", "Sayaxché", "Melchor de Mencos", "Poptún"}},
        {"Izabal", New List(Of String) From {"Puerto Barrios", "Livingston", "El Estor", "Morales", "Los Amates"}},
        {"Zacapa", New List(Of String) From {"Zacapa", "Estanzuela", "Río Hondo", "Gualán", "Teculután", "Usumatlán", "Cabañas", "San Diego", "La Unión", "Huité"}},
        {"Chiquimula", New List(Of String) From {"Chiquimula", "San José La Arada", "San Juan Ermita", "Jocotán", "Camotán", "Olopa", "Esquipulas", "Concepción Las Minas", "Quezaltepeque"}}
}

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim departamentoSeleccionado As String = ComboBox1.SelectedItem.ToString()
            ComboBox2.Items.Clear()
            If departamentosYmunicipios.ContainsKey(departamentoSeleccionado) Then
                ComboBox2.Items.AddRange(departamentosYmunicipios(departamentoSeleccionado).ToArray())
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox3_Enter(sender As Object, e As EventArgs) Handles ComboBox3.Enter
        If ComboBox3.Text = "Actividad física" Then
            ComboBox3.Text = ""
        End If
    End Sub


End Class