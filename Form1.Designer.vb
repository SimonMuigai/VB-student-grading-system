<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dtpOne = New DateTimePicker()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(406, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(164, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 86)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(189, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(164, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 32)
        Label4.TabIndex = 3
        Label4.Text = "Date Of Birth"' 
        ' dtpOne
        ' 
        dtpOne.Font = New Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        dtpOne.Location = New Point(358, 204)
        dtpOne.Name = "dtpOne"
        dtpOne.Size = New Size(461, 39)
        dtpOne.TabIndex = 5
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LimeGreen
        btnSubmit.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = SystemColors.ControlText
        btnSubmit.Location = New Point(374, 304)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(285, 63)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(1039, 608)
        Controls.Add(btnSubmit)
        Controls.Add(dtpOne)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpOne As DateTimePicker
    Friend WithEvents btnSubmit As Button
End Class
