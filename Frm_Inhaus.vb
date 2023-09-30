Public Class Frm_Inhaus
   Private Const Faktor = 0.15
   Private Sub Frm_Inhaus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'Dim instance = New Frm_Inhaus()
      'instance.WindowState = FormWindowState.Maximized

      Pnl_Control.Height = Me.Height * Faktor
      Tb_Form.Text = Me.Height
      Tb_Control.Text = Pnl_Control.Height

   End Sub

   Private Sub Frm_Inhaus_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
      Pnl_Control.Height = Me.Height * Faktor
      Tb_Form.Text = Me.Height
      Tb_Control.Text = Pnl_Control.Height
   End Sub


End Class