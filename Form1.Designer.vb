<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalcForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CalcForm))
        Key7 = New Button()
        Key8 = New Button()
        Key9 = New Button()
        KeyDiv = New Button()
        KeyMul = New Button()
        KeyLess = New Button()
        KeyPlus = New Button()
        Key6 = New Button()
        Key5 = New Button()
        Key4 = New Button()
        Key3 = New Button()
        Key2 = New Button()
        Key1 = New Button()
        KeyComma = New Button()
        Key0 = New Button()
        KeyReverse = New Button()
        KeyCalc = New Button()
        KeyPercent = New Button()
        KeyPartClear = New Button()
        KeyClearAll = New Button()
        ResultField = New TextBox()
        SuspendLayout()
        ' 
        ' Key7
        ' 
        Key7.Location = New Point(10, 144)
        Key7.Name = "Key7"
        Key7.Size = New Size(75, 57)
        Key7.TabIndex = 5
        Key7.Text = "7"
        Key7.UseVisualStyleBackColor = True
        ' 
        ' Key8
        ' 
        Key8.Location = New Point(91, 144)
        Key8.Name = "Key8"
        Key8.Size = New Size(75, 57)
        Key8.TabIndex = 7
        Key8.Text = "8"
        Key8.UseVisualStyleBackColor = True
        ' 
        ' Key9
        ' 
        Key9.Location = New Point(172, 144)
        Key9.Name = "Key9"
        Key9.Size = New Size(75, 57)
        Key9.TabIndex = 8
        Key9.Text = "9"
        Key9.UseVisualStyleBackColor = True
        ' 
        ' KeyDiv
        ' 
        KeyDiv.Location = New Point(253, 81)
        KeyDiv.Name = "KeyDiv"
        KeyDiv.Size = New Size(75, 57)
        KeyDiv.TabIndex = 4
        KeyDiv.Text = "/"
        KeyDiv.UseVisualStyleBackColor = True
        ' 
        ' KeyMul
        ' 
        KeyMul.BackColor = SystemColors.Control
        KeyMul.Location = New Point(253, 144)
        KeyMul.Name = "KeyMul"
        KeyMul.Size = New Size(75, 57)
        KeyMul.TabIndex = 9
        KeyMul.Text = "X"
        KeyMul.UseVisualStyleBackColor = True
        ' 
        ' KeyLess
        ' 
        KeyLess.BackColor = SystemColors.Control
        KeyLess.Location = New Point(253, 207)
        KeyLess.Name = "KeyLess"
        KeyLess.Size = New Size(75, 57)
        KeyLess.TabIndex = 13
        KeyLess.Text = "-"
        KeyLess.UseVisualStyleBackColor = True
        ' 
        ' KeyPlus
        ' 
        KeyPlus.BackColor = SystemColors.Control
        KeyPlus.Location = New Point(253, 270)
        KeyPlus.Name = "KeyPlus"
        KeyPlus.Size = New Size(75, 57)
        KeyPlus.TabIndex = 17
        KeyPlus.Text = "+"
        KeyPlus.UseVisualStyleBackColor = True
        KeyPlus.UseWaitCursor = True
        ' 
        ' Key6
        ' 
        Key6.Location = New Point(172, 207)
        Key6.Name = "Key6"
        Key6.Size = New Size(75, 57)
        Key6.TabIndex = 12
        Key6.Text = "6"
        Key6.UseVisualStyleBackColor = True
        ' 
        ' Key5
        ' 
        Key5.Location = New Point(91, 207)
        Key5.Name = "Key5"
        Key5.Size = New Size(75, 57)
        Key5.TabIndex = 11
        Key5.Text = "5"
        Key5.UseVisualStyleBackColor = True
        ' 
        ' Key4
        ' 
        Key4.Location = New Point(10, 207)
        Key4.Name = "Key4"
        Key4.Size = New Size(75, 57)
        Key4.TabIndex = 10
        Key4.Text = "4"
        Key4.UseVisualStyleBackColor = True
        ' 
        ' Key3
        ' 
        Key3.Location = New Point(172, 270)
        Key3.Name = "Key3"
        Key3.Size = New Size(75, 57)
        Key3.TabIndex = 16
        Key3.Text = "3"
        Key3.UseVisualStyleBackColor = True
        ' 
        ' Key2
        ' 
        Key2.Location = New Point(91, 270)
        Key2.Name = "Key2"
        Key2.Size = New Size(75, 57)
        Key2.TabIndex = 15
        Key2.Text = "2"
        Key2.UseVisualStyleBackColor = True
        ' 
        ' Key1
        ' 
        Key1.Location = New Point(10, 270)
        Key1.Name = "Key1"
        Key1.Size = New Size(75, 57)
        Key1.TabIndex = 14
        Key1.Text = "1"
        Key1.UseVisualStyleBackColor = True
        ' 
        ' KeyComma
        ' 
        KeyComma.Location = New Point(172, 333)
        KeyComma.Name = "KeyComma"
        KeyComma.Size = New Size(75, 57)
        KeyComma.TabIndex = 20
        KeyComma.Text = ","
        KeyComma.UseVisualStyleBackColor = True
        ' 
        ' Key0
        ' 
        Key0.Location = New Point(91, 333)
        Key0.Name = "Key0"
        Key0.Size = New Size(75, 57)
        Key0.TabIndex = 19
        Key0.Text = "0"
        Key0.UseVisualStyleBackColor = True
        ' 
        ' KeyReverse
        ' 
        KeyReverse.Location = New Point(10, 333)
        KeyReverse.Name = "KeyReverse"
        KeyReverse.Size = New Size(75, 57)
        KeyReverse.TabIndex = 18
        KeyReverse.Text = "+/-"
        KeyReverse.UseVisualStyleBackColor = True
        ' 
        ' KeyCalc
        ' 
        KeyCalc.Location = New Point(253, 333)
        KeyCalc.Name = "KeyCalc"
        KeyCalc.Size = New Size(75, 57)
        KeyCalc.TabIndex = 21
        KeyCalc.Text = "="
        KeyCalc.UseVisualStyleBackColor = True
        ' 
        ' KeyPercent
        ' 
        KeyPercent.Location = New Point(10, 81)
        KeyPercent.Name = "KeyPercent"
        KeyPercent.Size = New Size(75, 57)
        KeyPercent.TabIndex = 1
        KeyPercent.Text = "%"
        KeyPercent.UseVisualStyleBackColor = True
        ' 
        ' KeyPartClear
        ' 
        KeyPartClear.Location = New Point(91, 81)
        KeyPartClear.Name = "KeyPartClear"
        KeyPartClear.Size = New Size(75, 57)
        KeyPartClear.TabIndex = 2
        KeyPartClear.Text = "CE"
        KeyPartClear.UseVisualStyleBackColor = True
        ' 
        ' KeyClearAll
        ' 
        KeyClearAll.Location = New Point(172, 81)
        KeyClearAll.Name = "KeyClearAll"
        KeyClearAll.Size = New Size(75, 57)
        KeyClearAll.TabIndex = 3
        KeyClearAll.Text = "C"
        KeyClearAll.UseVisualStyleBackColor = True
        ' 
        ' ResultField
        ' 
        ResultField.BackColor = SystemColors.Control
        ResultField.BorderStyle = BorderStyle.None
        ResultField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ResultField.Location = New Point(12, 49)
        ResultField.Name = "ResultField"
        ResultField.Size = New Size(316, 26)
        ResultField.TabIndex = 20
        ResultField.TextAlign = HorizontalAlignment.Right
        ' 
        ' CalcForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 398)
        Controls.Add(ResultField)
        Controls.Add(KeyClearAll)
        Controls.Add(KeyPartClear)
        Controls.Add(KeyPercent)
        Controls.Add(KeyCalc)
        Controls.Add(KeyComma)
        Controls.Add(Key0)
        Controls.Add(KeyReverse)
        Controls.Add(Key3)
        Controls.Add(Key2)
        Controls.Add(Key1)
        Controls.Add(Key6)
        Controls.Add(Key5)
        Controls.Add(Key4)
        Controls.Add(KeyPlus)
        Controls.Add(KeyLess)
        Controls.Add(KeyMul)
        Controls.Add(KeyDiv)
        Controls.Add(Key9)
        Controls.Add(Key8)
        Controls.Add(Key7)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CalcForm"
        Text = "Calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Key7 As Button
    Friend WithEvents Key8 As Button
    Friend WithEvents Key9 As Button
    Friend WithEvents KeyDiv As Button
    Friend WithEvents KeyMul As Button
    Friend WithEvents KeyLess As Button
    Friend WithEvents KeyPlus As Button
    Friend WithEvents Key6 As Button
    Friend WithEvents Key5 As Button
    Friend WithEvents Key4 As Button
    Friend WithEvents Key3 As Button
    Friend WithEvents Key2 As Button
    Friend WithEvents Key1 As Button
    Friend WithEvents KeyComma As Button
    Friend WithEvents Key0 As Button
    Friend WithEvents KeyReverse As Button
    Friend WithEvents KeyCalc As Button
    Friend WithEvents KeyPercent As Button
    Friend WithEvents KeyPartClear As Button
    Friend WithEvents KeyClearAll As Button
    Friend WithEvents ResultField As TextBox
End Class
