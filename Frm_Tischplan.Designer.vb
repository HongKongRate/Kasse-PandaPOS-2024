<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tischplan
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
   <System.Diagnostics.DebuggerNonUserCode()> _
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
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      TabControl1 = New TabControl()
      TabPage1 = New TabPage()
      TabPage2 = New TabPage()
      TabControl1.SuspendLayout()
      SuspendLayout()
      ' 
      ' TabControl1
      ' 
      TabControl1.Controls.Add(TabPage1)
      TabControl1.Controls.Add(TabPage2)
      TabControl1.Location = New Point(198, 65)
      TabControl1.Name = "TabControl1"
      TabControl1.SelectedIndex = 0
      TabControl1.Size = New Size(961, 605)
      TabControl1.TabIndex = 0
      ' 
      ' TabPage1
      ' 
      TabPage1.Location = New Point(4, 29)
      TabPage1.Name = "TabPage1"
      TabPage1.Padding = New Padding(3)
      TabPage1.Size = New Size(953, 572)
      TabPage1.TabIndex = 0
      TabPage1.Text = "TabPage1"
      TabPage1.UseVisualStyleBackColor = True
      ' 
      ' TabPage2
      ' 
      TabPage2.Location = New Point(4, 29)
      TabPage2.Name = "TabPage2"
      TabPage2.Padding = New Padding(3)
      TabPage2.Size = New Size(953, 572)
      TabPage2.TabIndex = 1
      TabPage2.Text = "TabPage2"
      TabPage2.UseVisualStyleBackColor = True
      ' 
      ' Frm_Tischplan
      ' 
      AutoScaleDimensions = New SizeF(8.0F, 20.0F)
      AutoScaleMode = AutoScaleMode.Font
      ClientSize = New Size(1401, 764)
      Controls.Add(TabControl1)
      Name = "Frm_Tischplan"
      Text = "Frm_Tischplan"
      TabControl1.ResumeLayout(False)
      ResumeLayout(False)
   End Sub

   Friend WithEvents TabControl1 As TabControl
   Friend WithEvents TabPage1 As TabPage
   Friend WithEvents TabPage2 As TabPage
End Class
