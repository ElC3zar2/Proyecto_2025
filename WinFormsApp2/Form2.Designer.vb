<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(-1, 1)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(620, 37)
        Label1.TabIndex = 5
        Label1.Text = "DATOS PERSONALES"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(311, 114)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(154, 23)
        ComboBox4.TabIndex = 10
        ComboBox4.Text = "Genero"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(311, 85)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(154, 23)
        ComboBox3.TabIndex = 9
        ComboBox3.Text = "Actividad_física"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(311, 56)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(154, 23)
        ComboBox2.TabIndex = 8
        ComboBox2.Text = "Municipio"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(311, 27)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(154, 23)
        ComboBox1.TabIndex = 7
        ComboBox1.Text = "Departamento"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(73, 146)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(159, 23)
        TextBox6.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(73, 114)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(159, 23)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(73, 85)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(159, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(73, 56)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(159, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(73, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(159, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(319, 146)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 23)
        Button1.TabIndex = 0
        Button1.Text = "Continuar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox4)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(9, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(599, 191)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(44), CByte(34))
        ClientSize = New Size(617, 232)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
