﻿Imports MySql.Data.MySqlClient
Public Class LogIn
    Dim MySqlConn As New MySqlConnection("Server=localhost;Port=3306;Database=database;Uid=root;Pwd=root;")
    Dim COMMAND As MySqlCommand


    Public Connected As Boolean
    Private ReadOnly e As EventArgs


    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Application.Exit()
    End Sub

    'Check Username and Password to log in
    Private Sub LogInB_Click(sender As Object, e As EventArgs) Handles LogInB.Click


        Connected = False

        If UsernameTB.Text = "" Then
            Me.XError.SetError(Me.UsernameTB, "Please enter a Username.")
        Else
            Me.XError.SetError(Me.UsernameTB, "")
        End If

        If PasswordTB.Text = "" Then
            Me.XError.SetError(Me.PasswordTB, "Please enter Password.")
        Else
            Me.XError.SetError(Me.PasswordTB, "")
        End If

        If UsernameTB.Text <> "" Or PasswordTB.Text <> "" Then
            If UsernameTB.Text <> "Admin" Then
                ErrorLabel.Text = "Username not found."
                UsernameTB.Text = ""
                PasswordTB.Text = ""
            Else
                If PasswordTB.Text = "Admin" Then
                    Connected = True
                    Main.Show()
                    Me.Close()
                    ErrorLabel.Text = ""
                Else
                    ErrorLabel.Text = "Wrong Password."
                    PasswordTB.Text = ""
                End If
            End If
        End If
    End Sub

    'Close Log in and open Register form 
    Private Sub RegisterLink_Click(sender As Object, e As EventArgs) Handles RegisterLink.Click
        Register.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MySqlConn.Open()
            MessageBox.Show("Connection Succesfull")
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim createSql As String
        Try
            MySqlConn = MySqlConn
            MySqlConn.Open()
            Dim tblname = "test"
            createSql = "CREATE TABLE " & tblname & " (id INT(6) NOT NULL AUTO_INCREMENT,otherField TEXT NOT NULL,PRIMARY KEY (id));"
            Dim cmd As New MySqlCommand(createSql, MySqlConn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySqlConn.Close()
        End Try

    End Sub
End Class
