Imports system.data.OleDb.OleDbConnection
Imports System.Data.OleDb


Public Class Form2
    Dim cn As New OleDbConnection
    Dim da As New OleDbDataAdapter



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("vas a conectar a la Base de datos")

        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
      "Data Source=C:\Users\Gorka\Documents\xtreme.mdb;"

            cn.Open()
        Console.WriteLine("Conexion esta a" & cn.State)
            MsgBox(cn.State)
        MsgBox("se ha abierto la conexion")
        MsgBox("Se va a cerrar la conexion")

        cn.Close()
        Console.WriteLine("Conexion esta a" & cn.State)
        MsgBox(cn.State)
       

    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

