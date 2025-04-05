<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 0)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(409, 37)
        Label1.TabIndex = 6
        Label1.Text = "DATOS ALIMENTICIOS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(12, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(410, 187)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(148, 128)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 25)
        Button1.TabIndex = 0
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(229, 90)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(119, 23)
        TextBox6.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(53, 90)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(119, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(229, 61)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(119, 23)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(229, 32)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(119, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(53, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(119, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(53, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(119, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(44), CByte(34))
        ClientSize = New Size(434, 238)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "Form3"
        Text = "Form3"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
