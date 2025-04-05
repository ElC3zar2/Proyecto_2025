Imports System.Data.SqlClient
Imports System.Data
Public Class Form3
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ads As New DataSet
    Dim conectar As New SqlConnection("Data Source=FERNANDO;Initial Catalog=proyecto;Integrated Security=True;Encrypt=False")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PlaceholderText = "Ingrese el nombre de sus alimentos"
        TextBox2.PlaceholderText = "Ingrese la cantidad de alimentos"
        TextBox3.PlaceholderText = "Ingrese las calorías"
        TextBox4.PlaceholderText = "Ingrese las carbohidratos"
        TextBox5.PlaceholderText = "Ingrese las proteínas"
        TextBox6.PlaceholderText = "Ingrese las grasas"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idUsuario As Integer

        Try
            Dim consulta As New SqlCommand("SELECT IDENT_CURRENT('usuario')", conectar)
            conectar.Open()
            idUsuario = Convert.ToInt32(consulta.ExecuteScalar())
            conectar.Close()
        Catch ex As Exception
            MsgBox("Error al obtener el ID del usuario: " & ex.Message)
            conectar.Close()
            Exit Sub
        End Try

        ' Insertar datos en la tabla alimento_usuario
        Dim comandos As New SqlCommand("sp_InsertarAlimentoUsuario", conectar)
        comandos.CommandType = CommandType.StoredProcedure
        comandos.Parameters.AddWithValue("@id_usuario", idUsuario)
        comandos.Parameters.AddWithValue("@nombre_comida", TextBox1.Text)
        comandos.Parameters.AddWithValue("@cantidad_consumida", TextBox2.Text)
        comandos.Parameters.AddWithValue("@caloria", TextBox3.Text)
        comandos.Parameters.AddWithValue("@carbohidrato", TextBox4.Text)
        comandos.Parameters.AddWithValue("@proteina", TextBox5.Text)
        comandos.Parameters.AddWithValue("@grasa", TextBox6.Text)

        Try
            conectar.Open()
            comandos.ExecuteNonQuery()
            MsgBox("Datos registrados con éxito!", vbInformation, "Guardar")
            Me.Hide()
            Form1.Show()
        Catch ex As Exception
            MsgBox("Error al guardar el alimento: " & ex.Message)
        Finally
            conectar.Close()
        End Try
    End Sub
End Class