Imports TheArtOfDevHtmlRenderer.Adapters.Entities

Public Class Frm_Tischplan
   Dim rs As New Resizer
   Private Sub Frm_Tischplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'rs.FindAllControls(Me)
   End Sub

   Private Sub Frm_Tischplan_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
      'rs.ResizeAllControls(Me)
   End Sub

   Private Sub Frm_Tischplan_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
      'rs.FindAllControls(Me)
      'rs.ResizeAllControls(Me)
   End Sub

   Private Sub Frm_Tischplan_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
      Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
      Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
      'Sets the scaling mode
      Me.AutoScaleMode = AutoScaleMode.Dpi
      ''Enables appearance settings
      'Me.gridControl1.DpiAware = True
      'Dim Bildschirm = New Frm_Tischplan()
      Me.Height = screenHeight
      Me.Width = screenWidth

   End Sub

   Private Sub Pnl_Mobile_Info_Paint(sender As Object, e As PaintEventArgs)

   End Sub
End Class