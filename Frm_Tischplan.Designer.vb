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
<<<<<<< HEAD
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
=======
      Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Tischplan))
      Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
      tlp_Funktion = New TableLayoutPanel()
      tlp_FunktionButton = New TableLayoutPanel()
      GBtn_Reservierung = New Guna.UI2.WinForms.Guna2Button()
      GBtn_TSEInfo = New Guna.UI2.WinForms.Guna2Button()
      GBtn_Setup = New Guna.UI2.WinForms.Guna2Button()
      Tlp_KellnerFarben = New TableLayoutPanel()
      GBtn_Kellner4 = New Guna.UI2.WinForms.Guna2Button()
      GBtn_Kellner3 = New Guna.UI2.WinForms.Guna2Button()
      GBtn_Kellner1 = New Guna.UI2.WinForms.Guna2Button()
      GBtn_Kellner2 = New Guna.UI2.WinForms.Guna2Button()
      tlp_Funktion.SuspendLayout()
      tlp_FunktionButton.SuspendLayout()
      Tlp_KellnerFarben.SuspendLayout()
      SuspendLayout()
      ' 
      ' tlp_Funktion
      ' 
      tlp_Funktion.BackColor = SystemColors.Control
      tlp_Funktion.ColumnCount = 3
      tlp_Funktion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
      tlp_Funktion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
      tlp_Funktion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
      tlp_Funktion.Controls.Add(tlp_FunktionButton, 0, 0)
      tlp_Funktion.Controls.Add(Tlp_KellnerFarben, 1, 0)
      tlp_Funktion.Dock = DockStyle.Top
      tlp_Funktion.Location = New Point(0, 0)
      tlp_Funktion.Name = "tlp_Funktion"
      tlp_Funktion.RowCount = 1
      tlp_Funktion.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
      tlp_Funktion.Size = New Size(1401, 79)
      tlp_Funktion.TabIndex = 0
      ' 
      ' tlp_FunktionButton
      ' 
      tlp_FunktionButton.BackColor = SystemColors.Control
      tlp_FunktionButton.ColumnCount = 5
      tlp_FunktionButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
      tlp_FunktionButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
      tlp_FunktionButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
      tlp_FunktionButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
      tlp_FunktionButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
      tlp_FunktionButton.Controls.Add(GBtn_Reservierung, 0, 0)
      tlp_FunktionButton.Controls.Add(GBtn_TSEInfo, 1, 0)
      tlp_FunktionButton.Controls.Add(GBtn_Setup, 0, 0)
      tlp_FunktionButton.Dock = DockStyle.Fill
      tlp_FunktionButton.Location = New Point(3, 3)
      tlp_FunktionButton.Name = "tlp_FunktionButton"
      tlp_FunktionButton.RowCount = 1
      tlp_FunktionButton.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
      tlp_FunktionButton.Size = New Size(484, 73)
      tlp_FunktionButton.TabIndex = 0
      ' 
      ' GBtn_Reservierung
      ' 
      GBtn_Reservierung.BorderRadius = 12
      GBtn_Reservierung.CustomImages.ImageAlign = HorizontalAlignment.Center
      GBtn_Reservierung.CustomizableEdges = CustomizableEdges1
      GBtn_Reservierung.DisabledState.BorderColor = Color.DarkGray
      GBtn_Reservierung.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_Reservierung.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_Reservierung.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_Reservierung.Dock = DockStyle.Fill
      GBtn_Reservierung.FillColor = Color.Transparent
      GBtn_Reservierung.Font = New Font("Microsoft JhengHei UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_Reservierung.ForeColor = Color.White
      GBtn_Reservierung.Image = CType(resources.GetObject("GBtn_Reservierung.Image"), Image)
      GBtn_Reservierung.ImageSize = New Size(100, 100)
      GBtn_Reservierung.ImeMode = ImeMode.NoControl
      GBtn_Reservierung.Location = New Point(99, 3)
      GBtn_Reservierung.Name = "GBtn_Reservierung"
      GBtn_Reservierung.ShadowDecoration.CustomizableEdges = CustomizableEdges2
      GBtn_Reservierung.Size = New Size(90, 67)
      GBtn_Reservierung.TabIndex = 2
      ' 
      ' GBtn_TSEInfo
      ' 
      GBtn_TSEInfo.BorderRadius = 12
      GBtn_TSEInfo.CustomImages.ImageAlign = HorizontalAlignment.Center
      GBtn_TSEInfo.CustomizableEdges = CustomizableEdges3
      GBtn_TSEInfo.DisabledState.BorderColor = Color.DarkGray
      GBtn_TSEInfo.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_TSEInfo.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_TSEInfo.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_TSEInfo.Dock = DockStyle.Fill
      GBtn_TSEInfo.FillColor = Color.Transparent
      GBtn_TSEInfo.Font = New Font("Microsoft JhengHei UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_TSEInfo.ForeColor = Color.White
      GBtn_TSEInfo.Image = CType(resources.GetObject("GBtn_TSEInfo.Image"), Image)
      GBtn_TSEInfo.ImageSize = New Size(60, 60)
      GBtn_TSEInfo.ImeMode = ImeMode.NoControl
      GBtn_TSEInfo.Location = New Point(195, 3)
      GBtn_TSEInfo.Name = "GBtn_TSEInfo"
      GBtn_TSEInfo.ShadowDecoration.CustomizableEdges = CustomizableEdges4
      GBtn_TSEInfo.Size = New Size(90, 67)
      GBtn_TSEInfo.TabIndex = 1
      ' 
      ' GBtn_Setup
      ' 
      GBtn_Setup.BorderRadius = 12
      GBtn_Setup.CustomizableEdges = CustomizableEdges5
      GBtn_Setup.DisabledState.BorderColor = Color.DarkGray
      GBtn_Setup.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_Setup.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_Setup.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_Setup.Dock = DockStyle.Fill
      GBtn_Setup.FillColor = Color.Transparent
      GBtn_Setup.Font = New Font("Microsoft JhengHei UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_Setup.ForeColor = Color.White
      GBtn_Setup.Image = CType(resources.GetObject("GBtn_Setup.Image"), Image)
      GBtn_Setup.ImageSize = New Size(60, 60)
      GBtn_Setup.Location = New Point(3, 3)
      GBtn_Setup.Name = "GBtn_Setup"
      GBtn_Setup.ShadowDecoration.CustomizableEdges = CustomizableEdges6
      GBtn_Setup.Size = New Size(90, 67)
      GBtn_Setup.TabIndex = 0
      ' 
      ' Tlp_KellnerFarben
      ' 
      Tlp_KellnerFarben.BackColor = Color.Transparent
      Tlp_KellnerFarben.ColumnCount = 10
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
      Tlp_KellnerFarben.Controls.Add(GBtn_Kellner2, 0, 0)
      Tlp_KellnerFarben.Controls.Add(GBtn_Kellner4, 2, 0)
      Tlp_KellnerFarben.Controls.Add(GBtn_Kellner3, 1, 0)
      Tlp_KellnerFarben.Controls.Add(GBtn_Kellner1, 0, 0)
      Tlp_KellnerFarben.Dock = DockStyle.Fill
      Tlp_KellnerFarben.Location = New Point(493, 3)
      Tlp_KellnerFarben.Name = "Tlp_KellnerFarben"
      Tlp_KellnerFarben.RowCount = 1
      Tlp_KellnerFarben.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
      Tlp_KellnerFarben.Size = New Size(624, 73)
      Tlp_KellnerFarben.TabIndex = 1
      ' 
      ' GBtn_Kellner4
      ' 
      GBtn_Kellner4.BorderRadius = 12
      GBtn_Kellner4.CustomizableEdges = CustomizableEdges9
      GBtn_Kellner4.DisabledState.BorderColor = Color.DarkGray
      GBtn_Kellner4.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_Kellner4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_Kellner4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_Kellner4.Dock = DockStyle.Fill
      GBtn_Kellner4.FillColor = Color.Lime
      GBtn_Kellner4.Font = New Font("Microsoft JhengHei UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_Kellner4.ForeColor = Color.Black
      GBtn_Kellner4.Location = New Point(189, 3)
      GBtn_Kellner4.Name = "GBtn_Kellner4"
      GBtn_Kellner4.ShadowDecoration.CustomizableEdges = CustomizableEdges10
      GBtn_Kellner4.Size = New Size(56, 67)
      GBtn_Kellner4.TabIndex = 2
      GBtn_Kellner4.Text = "4"
      ' 
      ' GBtn_Kellner3
      ' 
      GBtn_Kellner3.BorderRadius = 12
      GBtn_Kellner3.CustomizableEdges = CustomizableEdges11
      GBtn_Kellner3.DisabledState.BorderColor = Color.DarkGray
      GBtn_Kellner3.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_Kellner3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_Kellner3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_Kellner3.Dock = DockStyle.Fill
      GBtn_Kellner3.FillColor = Color.Yellow
      GBtn_Kellner3.Font = New Font("Microsoft JhengHei UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_Kellner3.ForeColor = Color.Black
      GBtn_Kellner3.Location = New Point(127, 3)
      GBtn_Kellner3.Name = "GBtn_Kellner3"
      GBtn_Kellner3.ShadowDecoration.CustomizableEdges = CustomizableEdges12
      GBtn_Kellner3.Size = New Size(56, 67)
      GBtn_Kellner3.TabIndex = 1
      GBtn_Kellner3.Text = "3"
      ' 
      ' GBtn_Kellner1
      ' 
      GBtn_Kellner1.BorderRadius = 12
      GBtn_Kellner1.CustomizableEdges = CustomizableEdges13
      GBtn_Kellner1.DisabledState.BorderColor = Color.DarkGray
      GBtn_Kellner1.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_Kellner1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_Kellner1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_Kellner1.Dock = DockStyle.Fill
      GBtn_Kellner1.FillColor = Color.Red
      GBtn_Kellner1.Font = New Font("Microsoft JhengHei UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_Kellner1.ForeColor = Color.Black
      GBtn_Kellner1.Location = New Point(3, 3)
      GBtn_Kellner1.Name = "GBtn_Kellner1"
      GBtn_Kellner1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
      GBtn_Kellner1.Size = New Size(56, 67)
      GBtn_Kellner1.TabIndex = 0
      GBtn_Kellner1.Text = "1"
      ' 
      ' GBtn_Kellner2
      ' 
      GBtn_Kellner2.BorderRadius = 12
      GBtn_Kellner2.CustomizableEdges = CustomizableEdges7
      GBtn_Kellner2.DisabledState.BorderColor = Color.DarkGray
      GBtn_Kellner2.DisabledState.CustomBorderColor = Color.DarkGray
      GBtn_Kellner2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
      GBtn_Kellner2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
      GBtn_Kellner2.Dock = DockStyle.Fill
      GBtn_Kellner2.FillColor = Color.Cyan
      GBtn_Kellner2.Font = New Font("Microsoft JhengHei UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
      GBtn_Kellner2.ForeColor = Color.Black
      GBtn_Kellner2.Location = New Point(65, 3)
      GBtn_Kellner2.Name = "GBtn_Kellner2"
      GBtn_Kellner2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
      GBtn_Kellner2.Size = New Size(56, 67)
      GBtn_Kellner2.TabIndex = 3
      GBtn_Kellner2.Text = "2"
>>>>>>> Tischplan
      ' 
      ' Frm_Tischplan
      ' 
      AutoScaleDimensions = New SizeF(8.0F, 20.0F)
      AutoScaleMode = AutoScaleMode.Font
      ClientSize = New Size(1401, 764)
<<<<<<< HEAD
      Controls.Add(TabControl1)
      Name = "Frm_Tischplan"
      Text = "Frm_Tischplan"
      TabControl1.ResumeLayout(False)
      ResumeLayout(False)
   End Sub

   Friend WithEvents TabControl1 As TabControl
   Friend WithEvents TabPage1 As TabPage
   Friend WithEvents TabPage2 As TabPage
=======
      Controls.Add(tlp_Funktion)
      ForeColor = Color.Red
      FormBorderStyle = FormBorderStyle.None
      KeyPreview = True
      Name = "Frm_Tischplan"
      Text = "Frm_Tischplan"
      WindowState = FormWindowState.Maximized
      tlp_Funktion.ResumeLayout(False)
      tlp_FunktionButton.ResumeLayout(False)
      Tlp_KellnerFarben.ResumeLayout(False)
      ResumeLayout(False)
   End Sub

   Private Sub Frm_Tischplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Friend WithEvents tlp_Funktion As TableLayoutPanel
   Friend WithEvents tlp_FunktionButton As TableLayoutPanel
   Friend WithEvents GBtn_Setup As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents GBtn_TSEInfo As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents GBtn_Reservierung As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents Tlp_KellnerFarben As TableLayoutPanel
   Friend WithEvents GBtn_Kellner4 As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents GBtn_Kellner3 As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents GBtn_Kellner1 As Guna.UI2.WinForms.Guna2Button
   Friend WithEvents GBtn_Kellner2 As Guna.UI2.WinForms.Guna2Button
>>>>>>> Tischplan
End Class
