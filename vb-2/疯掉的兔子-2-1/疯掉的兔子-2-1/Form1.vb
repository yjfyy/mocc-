Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '定义
        Dim m As Integer, n As Integer

        '赋值
        If IsNumeric(TextBox_m.Text) And IsNumeric(TextBox_n.Text) Then
            m = Val(TextBox_m.Text)
            n = Val(TextBox_n.Text)
        End If

        '计算并输出
        If m <= 999999999 And m > 0 And n <= 999999999 And n > 0 Then
            '输出
            TextBox3.Text = TextBox3.Text & m & Space(10 - Len(CStr(m))) & n & Space(10 - Len(CStr(n))) & gcd(m, n) & vbCrLf
        Else
            MsgBox("请输入1-999999999之间的数字 ")
        End If

    End Sub

    Function gcd(m As Integer, n As Integer)
        '定义
        Dim t As Integer
        Dim r As Integer

        '计算
        If m < n Then
            t = m
            n = m
            m = t
        End If
        r = m Mod n
        Do While (r <> 0)
            m = n
            n = r
            r = m Mod n
        Loop

        '得到返回值
        gcd = n
    End Function
End Class
