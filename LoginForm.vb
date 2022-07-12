Imports MySql.Data.MySqlClient
Public Class LoginForm
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbUsername.Text = "" Or tbPassword.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call ambilKoneksi()
            cmd = New MySqlCommand("select * from tbl_user where username='" + tbUsername.Text + "' and password = '" + AES_Encrypt(tbPassword.Text, tbPassword.Text) + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MessageBox.Show("Username atau password salah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MsgBox("Login berhasil", MsgBoxStyle.Information, "Informasi")
                HalamanUtama.Show()
                tbPassword.Clear()
                Me.Hide()
            End If
        End If
    End Sub
End Class
