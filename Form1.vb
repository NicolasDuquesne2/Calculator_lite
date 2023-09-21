Imports System.Text.RegularExpressions

Public Class CalcForm
    Private Sub KeyPercent_Click(sender As Object, e As EventArgs) Handles KeyPercent.Click
        Me.HandlekeyInput("%")
    End Sub

    Private Sub KeyPartClear_Click(sender As Object, e As EventArgs) Handles KeyPartClear.Click
        Me.ResetTextBox()
    End Sub

    Private Sub KeyClearAll_Click(sender As Object, e As EventArgs) Handles KeyClearAll.Click
        Me.ResetTextBox()
    End Sub

    Private Sub KeyDiv_Click(sender As Object, e As EventArgs) Handles KeyDiv.Click
        Me.HandlekeyInput("/")
    End Sub

    Private Sub Key7_Click(sender As Object, e As EventArgs) Handles Key7.Click
        Me.HandlekeyInput("7")
    End Sub

    Private Sub Key8_Click(sender As Object, e As EventArgs) Handles Key8.Click
        Me.HandlekeyInput("8")
    End Sub

    Private Sub Key9_Click(sender As Object, e As EventArgs) Handles Key9.Click
        Me.HandlekeyInput("9")
    End Sub

    Private Sub Key4_Click(sender As Object, e As EventArgs) Handles Key4.Click
        Me.HandlekeyInput("4")
    End Sub

    Private Sub Key5_Click(sender As Object, e As EventArgs) Handles Key5.Click
        Me.HandlekeyInput("5")
    End Sub

    Private Sub Key6_Click(sender As Object, e As EventArgs) Handles Key6.Click
        Me.HandlekeyInput("6")
    End Sub

    Private Sub Key1_Click(sender As Object, e As EventArgs) Handles Key1.Click
        Me.HandlekeyInput("1")
    End Sub

    Private Sub Key2_Click(sender As Object, e As EventArgs) Handles Key2.Click
        Me.HandlekeyInput("2")
    End Sub

    Private Sub Key3_Click(sender As Object, e As EventArgs) Handles Key3.Click
        Me.HandlekeyInput("3")
    End Sub

    Private Sub Key0_Click(sender As Object, e As EventArgs) Handles Key0.Click
        Me.HandlekeyInput("0")
    End Sub

    Private Sub KeyComma_Click_1(sender As Object, e As EventArgs) Handles KeyComma.Click
        Me.HandlekeyInput(",")
    End Sub

    Private Sub KeyReverse_Click(sender As Object, e As EventArgs) Handles KeyReverse.Click
        Dim expr = Me.ResultField.Text

        If Regex.IsMatch(expr, "^(\d+[,]?\d*){1}$") Then
            expr = Me.AddLessSign(expr)
        ElseIf Regex.IsMatch(expr, "^-(\d+[,]?\d*){1}$") Then
            expr = Me.DeleteLessSign(expr)
        End If

        Me.ResetTextBox()
        Me.DisplayOnTextBox(expr)
    End Sub

    Private Sub KeyCalc_Click(sender As Object, e As EventArgs) Handles KeyCalc.Click
        Dim expr = Me.ResultField.Text
        Dim result As Double

        If String.IsNullOrEmpty(expr) Then
            Exit Sub
        End If

        If IsSinglePercent(expr) Then
            expr = "0"
        End If


        expr = Me.ReplacePercentSignByCalculable(expr)
        expr = Me.ReplaceCommasByDots(expr)
        expr = Me.ReplaceXByStarChar(expr)


        result = Calculate(expr)
        Me.ResetTextBox()
        Me.DisplayOnTextBox(result)

    End Sub

    Private Sub KeyPlus_Click(sender As Object, e As EventArgs) Handles KeyPlus.Click
        Me.HandlekeyInput("+")
    End Sub

    Private Sub KeyLess_Click(sender As Object, e As EventArgs) Handles KeyLess.Click
        Me.HandlekeyInput("-")
    End Sub

    Private Sub KeyMul_Click(sender As Object, e As EventArgs) Handles KeyMul.Click
        Me.HandlekeyInput("x")
    End Sub
    Private Sub HandlekeyInput(input As String)

        Dim concatText = Me.ResultField.Text & input


        If IsEquationWithOptions(concatText) Then
            Me.DisplayOnTextBox(concatText)
            Exit Sub
        End If

    End Sub

    Private Function Calculate(expression As String) As Double
        Dim result = New DataTable().Compute(expression, Nothing)
        Calculate = result
    End Function

    Private Sub DisplayOnTextBox(input As String)
        Me.ResultField.Text = input
    End Sub

    Private Sub ResetTextBox()
        Me.ResultField.ResetText()
    End Sub

    Private Function IsEquationWithOptions(text As String)
        IsEquationWithOptions = Regex.IsMatch(text, "^[-]?(\d+[,]?\d*)?[-+\/x]?[-]?(\d+[,]?\d*[%]?)?$")
    End Function


    Private Function IsSinglePercent(Text As String)
        IsSinglePercent = Regex.IsMatch(Text, "^[-]?(\d+[,]?\d*){1}%$")
    End Function


    Private Function ReplaceCommasByDots(text As String)

        If Regex.IsMatch(text, ",") Then
            ReplaceCommasByDots = Regex.Replace(text, ",", ".")
            Exit Function
        End If

        ReplaceCommasByDots = text
    End Function


    Private Function ReplaceXByStarChar(text As String)
        If Regex.IsMatch(text, "x") Then
            ReplaceXByStarChar = Regex.Replace(text, "x", "*")
            Exit Function
        End If

        ReplaceXByStarChar = text
    End Function

    Private Function ReplacePercentSignByCalculable(text As String)
        Dim exprMatch As Match
        Dim persNumber As Double
        Dim leftNumber As String
        Dim res As String

        If Regex.IsMatch(text, "%") Then
            exprMatch = Regex.Match(text, "^[-]?(\d+[,]?\d*)?[-+\/x]?[-]?(\d+[,]?\d*)([%]{1})$")

            If exprMatch.Success Then
                persNumber = CDbl(exprMatch.Groups(2).Value)
                leftNumber = exprMatch.Groups(1).Value
                res = CStr(leftNumber) & "*" & CStr(persNumber / 100)
                res = Regex.Replace(text, "(\d+[,]?\d*)([%]{1})$", res)
                ReplacePercentSignByCalculable = res
                Exit Function
            End If
        End If

        ReplacePercentSignByCalculable = text
    End Function


    Private Function AddLessSign(text As String)
        AddLessSign = Regex.Replace(text, "(\d+[,]?\d*)", "-$1")
    End Function


    Private Function DeleteLessSign(text As String)
        DeleteLessSign = Regex.Replace(text, "-(\d+[,]?\d*)", "$1")
    End Function

End Class
