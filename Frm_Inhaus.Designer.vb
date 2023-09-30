<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inhaus
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
      Pnl_Control = New Panel()
      Tb_Form = New TextBox()
      Tb_Control = New TextBox()
      SuspendLayout()
      ' 
      ' Pnl_Control
      ' 
      Pnl_Control.BackColor = SystemColors.AppWorkspace
      Pnl_Control.Dock = DockStyle.Top
      Pnl_Control.Location = New Point(0, 0)
      Pnl_Control.Name = "Pnl_Control"
      Pnl_Control.Size = New Size(1006, 81)
      Pnl_Control.TabIndex = 0
      ' 
      ' Tb_Form
      ' 
      Tb_Form.Location = New Point(379, 286)
      Tb_Form.Name = "Tb_Form"
      Tb_Form.Size = New Size(125, 27)
      Tb_Form.TabIndex = 0
      ' 
      ' Tb_Control
      ' 
      Tb_Control.Location = New Point(379, 361)
      Tb_Control.Name = "Tb_Control"
      Tb_Control.Size = New Size(125, 27)
      Tb_Control.TabIndex = 1
      ' 
      ' Frm_Inhaus
      ' 
      AutoScaleDimensions = New SizeF(120.0F, 120.0F)
      AutoScaleMode = AutoScaleMode.Dpi
      ClientSize = New Size(1006, 721)
      Controls.Add(Tb_Control)
      Controls.Add(Tb_Form)
      Controls.Add(Pnl_Control)
      FormBorderStyle = FormBorderStyle.None
      KeyPreview = True
      Name = "Frm_Inhaus"
      Text = "Frm_Inhaus"
      WindowState = FormWindowState.Maximized
      ResumeLayout(False)
      PerformLayout()
   End Sub

   Friend WithEvents Pnl_Control As Panel
   Friend WithEvents Tb_Form As TextBox
   Friend WithEvents Tb_Control As TextBox
End Class
