Imports TheArtOfDevHtmlRenderer.Adapters.Entities

Public Class Frm_Tischplan
    Dim rs As New Resizer
    Private Sub Frm_Tischplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rs.FindAllControls(Me)
    End Sub

    Private Sub Frm_Tischplan_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'rs.ResizeAllControls(Me)
    End Sub

    Private Sub Frm_Tischplan_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        rs.FindAllControls(Me)
        rs.ResizeAllControls(Me)
    End Sub
End Class