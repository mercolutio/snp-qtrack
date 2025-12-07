Imports System.IO
Imports System.Xml.Serialization

' Klassen für die XML-Struktur des Form Builders
Public Class FormularKonfiguration
    Public Property FormularName As String
    Public Property Tabelle As String
    Public Property Breite As Integer = 600
    Public Property Hoehe As Integer = 500
    Public Property Felder As List(Of FeldKonfiguration)

    Public Sub New()
        Felder = New List(Of FeldKonfiguration)
    End Sub

    ' Speichern als XML
    Public Sub SpeichernAlsXml(dateipfad As String)
        Dim serializer As New XmlSerializer(GetType(FormularKonfiguration))
        Using writer As New StreamWriter(dateipfad)
            serializer.Serialize(writer, Me)
        End Using
    End Sub

    ' Laden von XML
    Public Shared Function LadenVonXml(dateipfad As String) As FormularKonfiguration
        Dim serializer As New XmlSerializer(GetType(FormularKonfiguration))
        Using reader As New StreamReader(dateipfad)
            Return DirectCast(serializer.Deserialize(reader), FormularKonfiguration)
        End Using
    End Function
End Class

Public Class FeldKonfiguration
    Public Property Id As String
    Public Property FeldTyp As String ' TextBox, DateTimePicker, ComboBox, CheckBox, Label
    Public Property LabelText As String
    Public Property FeldName As String
    Public Property X As Integer
    Public Property Y As Integer
    Public Property Breite As Integer = 200
    Public Property Hoehe As Integer = 25
    Public Property IstPflichtfeld As Boolean
    Public Property Standardwert As String
    Public Property ComboBoxItems As List(Of String)
    Public Property DatenbankSpalte As String

    Public Sub New()
        Id = Guid.NewGuid().ToString()
        ComboBoxItems = New List(Of String)
    End Sub
End Class
