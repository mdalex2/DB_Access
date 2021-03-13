Imports System.Data.OleDb
Module FDBC
    Public Function conectarDB(ruta_db As String)
        Try
            Dim bbdd As OleDbConnection
            Dim sConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ruta_db
            bbdd = New OleDb.OleDbConnection(sConnString)
            bbdd.Open()
            Return bbdd
        Catch ex As Exception
            MsgBox("Notificación: [FDBC.conectarDB]" + Chr(13) + ex.Message.ToString(), vbApplicationModal + vbInformation, "Ayuda del sistema")
            Return ex
        End Try
    End Function
    Public Function selectSQL(SQLText As String, bbdd As OleDbConnection)
        Try
            Dim ds As DataSet
            ds = New DataSet()
            Dim cm As OleDbCommand
            cm = New OleDbCommand(SQLText, bbdd)
            Dim da As OleDbDataAdapter
            da = New OleDbDataAdapter(cm)
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            MsgBox("Notificación: [FDBC.selectSQL]" + Chr(13) + ex.Message.ToString(), vbApplicationModal + vbInformation, "Ayuda del sistema")
            Return ex
        End Try
    End Function

End Module
