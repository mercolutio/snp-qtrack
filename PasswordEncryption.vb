Imports System.Security.Cryptography
Imports System.Text

''' <summary>
''' Klasse zur sicheren Verschlüsselung von Passwörtern mit DPAPI
''' </summary>
Public Class PasswordEncryption

    ''' <summary>
    ''' Verschlüsselt einen String mit DPAPI (Windows Data Protection API)
    ''' </summary>
    ''' <param name="plainText">Der zu verschlüsselnde Text</param>
    ''' <returns>Verschlüsselter Base64-String</returns>
    Public Shared Function Encrypt(plainText As String) As String
        If String.IsNullOrEmpty(plainText) Then
            Return String.Empty
        End If

        Try
            ' String in Bytes konvertieren
            Dim plainBytes As Byte() = Encoding.UTF8.GetBytes(plainText)

            ' Mit DPAPI verschlüsseln (nur für aktuellen User)
            Dim encryptedBytes As Byte() = ProtectedData.Protect(
                plainBytes,
                Nothing,
                DataProtectionScope.CurrentUser
            )

            ' In Base64 String konvertieren für Speicherung
            Return Convert.ToBase64String(encryptedBytes)

        Catch ex As Exception
            Throw New Exception("Verschlüsselung fehlgeschlagen: " & ex.Message, ex)
        End Try
    End Function

    ''' <summary>
    ''' Entschlüsselt einen mit DPAPI verschlüsselten String
    ''' </summary>
    ''' <param name="encryptedText">Der verschlüsselte Base64-String</param>
    ''' <returns>Entschlüsselter Klartext</returns>
    Public Shared Function Decrypt(encryptedText As String) As String
        If String.IsNullOrEmpty(encryptedText) Then
            Return String.Empty
        End If

        Try
            ' Base64 String zurück in Bytes konvertieren
            Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedText)

            ' Mit DPAPI entschlüsseln
            Dim decryptedBytes As Byte() = ProtectedData.Unprotect(
                encryptedBytes,
                Nothing,
                DataProtectionScope.CurrentUser
            )

            ' Bytes zurück in String konvertieren
            Return Encoding.UTF8.GetString(decryptedBytes)

        Catch ex As Exception
            Throw New Exception("Entschlüsselung fehlgeschlagen: " & ex.Message, ex)
        End Try
    End Function

End Class
