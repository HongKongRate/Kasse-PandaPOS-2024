Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data.SqlClient

Public Class Login
   Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
      Frm_Tischplan.Show()
      'Frm_Inhaus.Show()
   End Sub

   Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ' Rufe die Funktion zum Erstellen der Buttons auf
      CreateButtons(10) ' Hier kannst du die Anzahl der Buttons festlegen


      ' Panel erstellen und zur Form hinzufügen
      Dim panel As New Panel()
      panel.Dock = DockStyle.Top
      Me.Controls.Add(panel)
      panel.BackColor = Color.Aqua

      panel.Height = Me.Height * 0.2

      ' Funktion zum Erstellen und Positionieren der Buttons aufrufen
      CreateAndPositionButtons(panel)
   End Sub
   Private Sub CreateAndPositionButtons(panel As Panel)
      For i As Integer = 1 To 5
         ' Button erstellen
         Dim button As New Button()
         button.Text = "Button " & i

         ' Größe und Position anpassen
         button.Width = 100
         button.Height = 30
         button.Left = 10
         button.Top = (i - 1) * (button.Height + 10)

         ' Button dem Panel hinzufügen
         panel.Controls.Add(button)
      Next
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



   Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
      SQL = "SELECT Max(Menu.Menue) AS MaxMenue FROM Menu   WHERE Menu.isDelete <> 1 "

      Dim data As DataTable = DatabaseAccess.GetDataFromDatabase(SQL)

      For Each row As DataRow In data.Rows
         ' Zugriff auf die Daten in den Spalten der aktuellen Zeile
         Dim value As Object = row("MaxMenue")


         ' Verarbeite die Daten nach Bedarf
         MsgBox($"Max Nummer ist : {value}")
      Next



   End Sub
End Class