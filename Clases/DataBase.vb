Imports System.Data.OleDb
Imports DB_Access.FDBC
Public Class DataBase

    Public Sub obtenerListaTablas(ruta_db As String, lista As ListBox)
        Try
            'Módulo que llena un control listbox  con los nombres de las tabla que contiene la BD seleccionada
            Dim bbdd = FDBC.conectarDB(ruta_db)


            Dim dt As DataTable
            dt = bbdd.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim intCount As Integer
            lista.Items.Clear()

            For intCount = 0 To dt.Rows.Count - 1
                If Not dt.Rows(intCount)(dt.Columns(2).ColumnName).ToString.StartsWith("MSys") Then
                    lista.Items.Add(dt.Rows(intCount)(dt.Columns(2).ColumnName).ToString)
                End If
            Next
        Catch ex As Exception
            MsgBox("Notificación: [DataBase.obtenerListaTablas]" + Chr(13) + ex.Message.ToString(), vbApplicationModal + vbInformation, "Ayuda del sistema")
        End Try
    End Sub
    Public Sub obtenerListaCampos(ruta_db As String, tabla As String, lista As ListBox)
        Try
            Dim bbdd = FDBC.conectarDB(ruta_db)
            Dim ds = FDBC.selectSQL("SELECT * FROM " & tabla & " WHERE 1=2", bbdd) 'obtiene los campos de la tabla indicada

            Dim i As Integer
            lista.Items.Clear()

            For i = 0 To ds.Tables(0).Columns.Count - 1
                lista.Items.Add(ds.Tables(0).Columns(i).ColumnName)
            Next
            bbdd.Close()
        Catch ex As Exception
            MsgBox("Notificación: [DataBase.obtenerListaCampos]" + Chr(13) + ex.Message.ToString(), vbApplicationModal + vbInformation, "Ayuda del sistema")
        End Try
    End Sub
    Public Sub ejecutarSelectSqlDg(ruta_db As String, tableName As String, querySQL As String, dgv As DataGridView)
        Dim time = Now()
        Try
            If tableName <> Nothing Or tableName <> "" Then
                Dim bbdd = New OleDbConnection()
                bbdd = FDBC.conectarDB(ruta_db)
                Dim oda As New OleDbDataAdapter
                Dim ods As New DataSet
                Dim consulta As String
                consulta = querySQL
                oda = New OleDbDataAdapter(consulta, bbdd.ConnectionString.ToString())

                ods.Tables.Add(tableName)
                oda.Fill(ods.Tables(tableName))
                dgv.DataSource = ods.Tables(tableName)
                Form1.TabResultado.SelectedTab = Form1.TabGrid
                bbdd.Close()
                Form1.txtMSG.Text = "Notificación: " & time & " [DataBase.ejecutarSelectSqlDg]" + Chr(13) + "La consulta se ejecutó:" + Chr(13) + querySQL + Chr(13) & Chr(13) & Chr(13) & Form1.txtMSG.Text

            Else
                Form1.TabResultado.SelectedTab = Form1.TabMSG
                Form1.txtMSG.Text = "Notificación: " & time & " [DataBase.ejecutarSelectSqlDg]" + Chr(13) + "No suministró el nombre de la tabla o existe un error de sintaxis en la consulta: " & Chr(13) & querySQL & Chr(13) & Chr(13) & Form1.txtMSG.Text
            End If

        Catch ex As Exception
            Form1.TabResultado.SelectedTab = Form1.TabMSG
            Form1.txtMSG.Text = "Notificación: " & time & " [DataBase.ejecutarSelectSqlDg]" + Chr(13) + querySQL + Chr(13) + ex.Message.ToString() & Chr(13) & Chr(13) & Form1.txtMSG.Text
        End Try
    End Sub
    Public Sub ejecutarNonQuery(ruta_db As String, tableName As String, querySQL As String)
        Dim comando As New OleDbCommand
        Dim bbdd = New OleDbConnection
        Dim time = Now()
        Dim cantReg = 0
        Try
            comando.CommandText = querySQL
            bbdd = FDBC.conectarDB(ruta_db)
            comando.Connection = bbdd
            cantReg = comando.ExecuteNonQuery
            Form1.TabResultado.SelectedTab = Form1.TabMSG
            Form1.txtMSG.Text = "Notificación: " & time & " [DataBase.ejecutarNonQuery]" + Chr(13) + "La consulta se realizó CORRECTAMENTE, registros afectados (" & cantReg & ")" & Chr(13) & querySQL & Chr(13) & Chr(13) & Form1.txtMSG.Text
        Catch ex As Exception
            Form1.TabResultado.SelectedTab = Form1.TabMSG
            Form1.txtMSG.Text = "Notificación: " & time & " [DataBase.ejecutarSelectSqlDg]" + Chr(13) + ex.Message.ToString() & Chr(13) & Chr(13) & Form1.txtMSG.Text
        Finally
            'si la conexion esta abierta la cierro
            If bbdd.State = 1 Then
                bbdd.Close()
            End If
            'descargo memoria de comandos y consultas usadas para que el sistema no se vuelva lento e inestable
            comando.Dispose()
            bbdd.Dispose()
        End Try

    End Sub
End Class
