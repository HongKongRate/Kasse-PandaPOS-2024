Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data.SqlClient ' Oder: Imports MySql.Data.MySqlClient für MySQL


Public Class Login
   Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
      Frm_Tischplan.Show()
      'Frm_Inhaus.Show()
   End Sub

   Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ' Rufe die Funktion zum Erstellen der Buttons auf
      CreateButtons(5) ' Hier kannst du die Anzahl der Buttons festlegen
   End Sub

   Private Sub CreateButtons(numButtons As Integer)
      For i As Integer = 1 To numButtons
         ' Erstelle einen neuen guna2Button
         Dim newButton As New Guna2Button()

         ' Setze die Eigenschaften des Buttons
         newButton.Height = 50
         newButton.Width = 200
         newButton.Text = "Button " & i
         newButton.Name = "Button" & i
         newButton.Top = i * 100 ' Verändere die Position der Buttons nach Bedarf
         newButton.Left = 10
         newButton.BorderRadius = 10

         ' Füge einen Eventhandler für den Button-Klick hinzu
         AddHandler newButton.Click, AddressOf Button_Click

         ' Füge den Button zur Form hinzu
         Panel1.Controls.Add(newButton)
      Next
   End Sub

   Private Sub Button_Click(sender As Object, e As EventArgs)
      ' Behandle den Button-Klick hier
      Dim clickedButton As Guna2Button = DirectCast(sender, Guna2Button)
      MessageBox.Show("Button " & clickedButton.Text & " wurde geklickt.")
   End Sub
   Private Function BonNummer() As Integer
      Dim connection As MySqlConnection = DatabaseConnection.GetConnection()

      '' Führe deine Datenbankabfragen hier aus
      Dim SQL As String
      SQL = "SELECT Max(Belegung) AS Maximum From Bon"
      SQL = SQL & "WHERE Bon.Z_Bericht_Nummer = 0"
      SQL = SQL & "AND Bon.Tisch  BETWEEN 901 AND 930 "


      Using command As New MySqlCommand(SQL, connection)

      End Using

      DatabaseConnection.CloseConnection(connection)
   End Function
   Private Sub Datenlesen()
      'Dim connectionString As String = "Deine_Connection_String"
      'Dim query As String = "SELECT Spalte1, Spalte2 FROM DeineTabelle"

      Dim dataSet As New DataSet()
      Dim connection As MySqlConnection = DatabaseConnection.GetConnection()
      Dim SQL As String
      SQL = "SELECT Max(Belegung) AS Maximum From Bon"
      SQL = SQL & "WHERE Bon.Z_Bericht_Nummer = 0"
      SQL = SQL & "AND Bon.Tisch  BETWEEN 901 AND 930 "




      ' Fülle das DataSet mit Daten, z.B., aus einer Datenbank


      ' Du kannst auf die DataTabels im DataSet zugreifen
      If dataSet.Tables.Count > 0 Then
         ' Hier nehmen wir an, dass das DataSet mindestens eine DataTable enthält
         Dim dataTable As DataTable = dataSet.Tables(0) ' Zugriff auf die erste Tabelle im DataSet

         ' Du kannst dann auf die Daten in der DataTable zugreifen
         For Each row As DataRow In dataTable.Rows
            Dim value As Integer = row("maxinum")

            ' Verarbeite die Daten nach Bedarf
            Console.WriteLine($"Bonnummer ist: {value}")
         Next
         End Using
      End Using

   End Sub
End Class