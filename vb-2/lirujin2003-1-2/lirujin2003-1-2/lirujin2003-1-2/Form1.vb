Public Class Form1
    Dim shuzu(8) As String
    Dim Istr As String
    Dim Imin As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        shuzu(0) = "C/C++程序设计"
        shuzu(1) = "VB程序设计"
        shuzu(2) = "数据库技术与应用"
        shuzu(3) = "硬件技术基础"
        shuzu(4) = "Web程序设计"
        shuzu(5) = "多媒体技术与应用"
        shuzu(6) = "网络技术与应用"
        shuzu(7) = "软件技术基础"
        shuzu(8) = "大学计算机基础"

        For i = 0 To UBound(shuzu)
            Imin = i
            For j = i + 1 To UBound(shuzu)
                If shuzu(j) < shuzu(Imin) Then
                    Imin = j
                End If
                Istr = shuzu(i) : shuzu(i) = shuzu(Imin) : shuzu(Imin) = Istr
            Next
        Next
        For i = 0 To UBound(shuzu)
            ListBox1.Items.Add(shuzu(i))

        Next
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        If ListBox2.Items.Count < 5 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Else
            MsgBox("选课超过5门，不能再选")
        End If
    End Sub

    Private Sub ListBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.Click
        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
End Class
