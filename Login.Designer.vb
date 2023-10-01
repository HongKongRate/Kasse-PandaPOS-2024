<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Wird vom Windows Form-Designer benötigt.
   Private components As System.ComponentModel.IContainer

   'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
   'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
   'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
      Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
      Panel1 = New Panel()
      SuspendLayout()
      ' 
      ' Guna2Button1
      ' 
      Guna2Button1.BorderRadius = 8
      Guna2Button1.CustomizableEdges = CustomizableEdges1
      Guna2Button1.DisabledState.BorderColor = Color.DarkGray
      Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
      Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      Guna2Button1.FillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
      Guna2Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
      Guna2Button1.ForeColor = Color.Black
      Guna2Button1.Location = New Point(1144, 523)
      Guna2Button1.Name = "Guna2Button1"
      Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
      Guna2Button1.Size = New Size(225, 146)
      Guna2Button1.TabIndex = 0
      Guna2Button1.Text = "Inhaus"
      ' 
      ' Guna2Button2
      ' 
      Guna2Button2.BorderRadius = 8
      Guna2Button2.CustomizableEdges = CustomizableEdges3
      Guna2Button2.DisabledState.BorderColor = Color.DarkGray
      Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
      Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      Guna2Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
      Guna2Button2.ForeColor = Color.Black
      Guna2Button2.Location = New Point(1144, 710)
      Guna2Button2.Name = "Guna2Button2"
      Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
      Guna2Button2.Size = New Size(225, 56)
      Guna2Button2.TabIndex = 1
      Guna2Button2.Text = "Get Bonnummer"
      ' 
      ' Panel1
      ' 
      Panel1.BackColor = SystemColors.ActiveCaption
      Panel1.Location = New Point(369, 332)
      Panel1.Name = "Panel1"
      Panel1.Size = New Size(378, 434)
      Panel1.TabIndex = 2
      ' 
      ' Login
      ' 
      AutoScaleDimensions = New SizeF(8.0F, 20.0F)
      AutoScaleMode = AutoScaleMode.Font
      ClientSize = New Size(1415, 798)
      Controls.Add(Panel1)
      Controls.Add(Guna2Button2)
      Controls.Add(Guna2Button1)
      Name = "Login"
      Text = "45"
      ResumeLayout(False)
   End Sub

   Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents Panel1 As Panel
End Class
