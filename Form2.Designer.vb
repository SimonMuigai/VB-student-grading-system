<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblRan1 = New Label()
        lblRan2 = New Label()
        cboGrade = New ComboBox()
        Label2 = New Label()
        lblOp = New Label()
        btnGen = New Button()
        Label6 = New Label()
        txtOp = New TextBox()
        Label7 = New Label()
        txtAns = New TextBox()
        btnExit = New Button()
        lblStatus = New Label()
        btnSubmit = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        lblRanOne = New Label()
        lblRanTwo = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(194, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 0
        Label1.Text = "Grade"' 
        ' lblRan1
        ' 
        lblRan1.AutoSize = True
        lblRan1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblRan1.Location = New Point(277, 386)
        lblRan1.Name = "lblRan1"
        lblRan1.Size = New Size(34, 32)
        lblRan1.TabIndex = 3
        lblRan1.Text = "__" ' 
        ' lblRan2
        ' 
        lblRan2.AutoSize = True
        lblRan2.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRan2.Location = New Point(378, 386)
        lblRan2.Name = "lblRan2"
        lblRan2.Size = New Size(34, 32)
        lblRan2.TabIndex = 4
        lblRan2.Text = "__" ' 
        ' cboGrade
        ' 
        cboGrade.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        cboGrade.FormattingEnabled = True
        cboGrade.Location = New Point(325, 90)
        cboGrade.Name = "cboGrade"
        cboGrade.Size = New Size(276, 40)
        cboGrade.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(171, 386)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 32)
        Label2.TabIndex = 6
        Label2.Text = "What is " ' 
        ' lblOp
        ' 
        lblOp.AutoSize = True
        lblOp.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOp.Location = New Point(324, 386)
        lblOp.Name = "lblOp"
        lblOp.Size = New Size(46, 32)
        lblOp.TabIndex = 7
        lblOp.Text = "Op" ' 
        ' btnGen
        ' 
        btnGen.BackColor = Color.PeachPuff
        btnGen.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnGen.Location = New Point(325, 162)
        btnGen.Name = "btnGen"
        btnGen.Size = New Size(206, 44)
        btnGen.TabIndex = 8
        btnGen.Text = "Generate"
        btnGen.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(194, 324)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 32)
        Label6.TabIndex = 9
        Label6.Text = "Operation" ' 
        ' txtOp
        ' 
        txtOp.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtOp.Location = New Point(325, 324)
        txtOp.Name = "txtOp"
        txtOp.Size = New Size(276, 39)
        txtOp.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(506, 386)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 32)
        Label7.TabIndex = 11
        Label7.Text = "Answer" ' 
        ' txtAns
        ' 
        txtAns.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtAns.Location = New Point(622, 386)
        txtAns.Name = "txtAns"
        txtAns.Size = New Size(100, 39)
        txtAns.TabIndex = 12
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.DarkRed
        btnExit.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.ForeColor = SystemColors.ButtonFace
        btnExit.Location = New Point(812, 572)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(166, 48)
        btnExit.TabIndex = 13
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStatus.Location = New Point(367, 474)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(78, 32)
        lblStatus.TabIndex = 14
        lblStatus.Text = "Status" ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Green
        btnSubmit.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmit.ForeColor = SystemColors.ButtonHighlight
        btnSubmit.Location = New Point(191, 466)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(152, 48)
        btnSubmit.TabIndex = 15
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(450, 389)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 32)
        Label4.TabIndex = 16
        Label4.Text = "=" ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(191, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 32)
        Label3.TabIndex = 17
        Label3.Text = "Num 1" ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(367, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 32)
        Label5.TabIndex = 18
        Label5.Text = "Num 2" ' 
        ' lblRanOne
        ' 
        lblRanOne.AutoSize = True
        lblRanOne.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRanOne.Location = New Point(292, 241)
        lblRanOne.Name = "lblRanOne"
        lblRanOne.Size = New Size(34, 32)
        lblRanOne.TabIndex = 19
        lblRanOne.Text = "__" ' 
        ' lblRanTwo
        ' 
        lblRanTwo.AutoSize = True
        lblRanTwo.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRanTwo.Location = New Point(493, 241)
        lblRanTwo.Name = "lblRanTwo"
        lblRanTwo.Size = New Size(34, 32)
        lblRanTwo.TabIndex = 20
        lblRanTwo.Text = "__" ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkTurquoise
        ClientSize = New Size(1042, 626)
        Controls.Add(lblRanTwo)
        Controls.Add(lblRanOne)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(btnSubmit)
        Controls.Add(lblStatus)
        Controls.Add(btnExit)
        Controls.Add(txtAns)
        Controls.Add(Label7)
        Controls.Add(txtOp)
        Controls.Add(Label6)
        Controls.Add(btnGen)
        Controls.Add(lblOp)
        Controls.Add(Label2)
        Controls.Add(cboGrade)
        Controls.Add(lblRan2)
        Controls.Add(lblRan1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Arithimetic Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRan1 As Label
    Friend WithEvents lblRan2 As Label
    Friend WithEvents cboGrade As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOp As Label
    Friend WithEvents btnGen As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAns As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRanOne As Label
    Friend WithEvents lblRanTwo As Label
End Class
