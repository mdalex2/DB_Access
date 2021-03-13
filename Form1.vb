
Imports System
Imports System.Data.OleDb

Public Class Form1
    Dim opcion As String = ""
    Private Sub list_tablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTablas.SelectedIndexChanged
        If listTablas.SelectedItem.ToString() <> "" Then
            Dim DBA = New DataBase()
            DBA.obtenerListaCampos(txt_db.Text, listTablas.SelectedItem.ToString(), listCampos)
        Else
            ToolTip1.Show("Debe elegir una tabla", listTablas)
        End If
    End Sub

    Private Sub btn_conectar_Click(sender As Object, e As EventArgs) Handles btn_conectar.Click
        If txt_db.Text = "" Then
            Beep()
            ToolTip1.Show("Debe seleccionar una Base de Datos de Access", btn_abrir)
        Else
            Dim DBA = New DataBase()
            DBA.obtenerListaTablas(txt_db.Text.ToString(), listTablas)
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btn_abrir_Click(sender As Object, e As EventArgs) Handles btn_abrir.Click
        Dim result = dlg_open.ShowDialog()
        If (result = vbOK) Then
            ToolTip1.SetToolTip(txt_db, dlg_open.FileName.ToString()) 'asigna path al pasar el mouse sobre textbos del path BD
            txt_db.Text = dlg_open.FileName.ToString()
            btn_conectar.PerformClick()
            btnEjecutar.Enabled = True
        End If
    End Sub

    Private Sub listTablas_DoubleClick(sender As Object, e As EventArgs) Handles listTablas.DoubleClick
        If listTablas.SelectedItem.ToString() <> "" Then
            My.Computer.Clipboard.SetText(listTablas.SelectedItem.ToString())
            txtSQL.Paste()
        End If
    End Sub

    Private Sub listCampos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCampos.SelectedIndexChanged

    End Sub

    Private Sub listCampos_DoubleClick(sender As Object, e As EventArgs) Handles listCampos.DoubleClick
        If listCampos.SelectedItem.ToString() <> "" Then
            My.Computer.Clipboard.SetText(listCampos.SelectedItem.ToString())
            txtSQL.Paste()
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim tbl, campo As String
        If IsNothing(listTablas.SelectedItem) Then tbl = "" Else tbl = listTablas.SelectedItem
        If IsNothing(listCampos.SelectedItem) Then campo = "" Else campo = listCampos.SelectedItem


        Select Case opcion
            Case "S"
                'intruccion selec
                campo = IIf(campo <> "", " WHERE " & campo & " = VALOR", "")
                txtSQL.Text = "SELECT TOP 1000 * from " & tbl & campo
            Case "I"
                'intruccion Insert
                txtSQL.Text = "INSERT INTO " & tbl & " (" & campo & ") VALUES (VALOR)"
            Case "U"
                'intruccion Insert
                campo = IIf(campo <> "", " SET " & campo & " = VALOR WHERE CAMPO = VALOR", "")
                txtSQL.Text = "UPDATE " & tbl & campo
            Case "D"
                'intruccion Insert
                campo = IIf(campo <> "", " WHERE " & campo & " = VALOR ", "")
                If campo <> "" Then
                    txtSQL.Text = "DELETE FROM " & tbl & campo
                Else
                    txtSQL.Text = ""
                End If
            Case Else
                txtSQL.Text = ""
        End Select
    End Sub

    Private Sub opcSelect_CheckedChanged(sender As Object, e As EventArgs) Handles opcSelect.CheckedChanged
        opcion = "S" 'select
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim time = Now()
        Dim dba = New DataBase
        Dim operacion As String = ""
        operacion = Trim(Strings.Left(txtSQL.Text, 1))
        Select Case UCase(operacion)
            Case "S"
                'instrucciones de select
                dba.ejecutarSelectSqlDg(txt_db.Text, listTablas.SelectedItem, txtSQL.Text, dgResult)
            Case "I", "U", "D"
                'instrucciones de update
                dba.ejecutarNonQuery(txt_db.Text, listTablas.SelectedItem, txtSQL.Text)
            Case Else
                TabResultado.SelectedTab = TabMSG
                txtMSG.Text = "Notificación: " & time & " [Ejecutar Consultas]" + Chr(13) + "Comando no reconocido, solo se permiten acciones de tipo: Select, Insert, Update, Delete" & Chr(13) & Chr(13) & txtMSG.Text

        End Select

    End Sub

    Private Sub opcInsert_CheckedChanged(sender As Object, e As EventArgs) Handles opcInsert.CheckedChanged
        opcion = "I" 'insert
    End Sub

    Private Sub opcUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles opcUpdate.CheckedChanged
        opcion = "U" 'update
    End Sub

    Private Sub opcDelete_CheckedChanged(sender As Object, e As EventArgs) Handles opcDelete.CheckedChanged
        opcion = "D" 'delete
    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            dgResult.DataSource = ""
            dgResult.DataMember = ""
            dgResult.Refresh()
            dgResult.Columns.Clear()
            While (dgResult.RowCount > 1)
                dgResult.Rows.Remove(dgResult.CurrentRow)
            End While

            txtMSG.Text = ""
            txtSQL.Text = ""
            txt_db.Text = ""
            listCampos.Items.Clear()
            listTablas.Items.Clear()
        Catch ex As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        dgResult.RefreshEdit()
    End Sub
End Class
