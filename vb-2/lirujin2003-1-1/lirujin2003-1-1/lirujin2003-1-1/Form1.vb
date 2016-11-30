Public Class Form1
    Dim shuzu(100, 100) As Integer
    Dim n As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = Val(TextBox1.Text) - 1
        If n < 16 Then
            shuzu(0, 0) = 1
            shuzu(1, 0) = 1
            shuzu(1, 1) = 1
            Label1.Text = 1 & vbCrLf
            For i = 1 To n
                shuzu(i, 0) = 1
                Label1.Text = Label1.Text & 1 & Space(3)
                For j = 0 To i
                    If i > 0 And j > 0 Then
                        shuzu(i, j) = shuzu(i - 1, j - 1) + shuzu(i - 1, j)
                        Label1.Text = Label1.Text & shuzu(i, j) & Space(4 - Len(Trim(shuzu(i, j))))
                    End If
                Next
                Label1.Text = Label1.Text & vbCrLf
            Next
        Else
            MsgBox("可能会溢出！")

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
