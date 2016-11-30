Public Class Form1
    Dim shuzu(100) As Integer
    Dim imin%, min%, max%, imax%, t%

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i = 0 To ComboBox1.Items.Count - 1
            shuzu(i) = Val(ComboBox1.Items.Item(i))

        Next
        For i = 0 To ComboBox1.Items.Count - 1
            imin = 0
            imax = 0
            If shuzu(imin) > shuzu(i) Then
                imin = i
            End If
            t = shuzu(0) : shuzu(0) = shuzu(imin) : shuzu(imin) = t
        Next
        For i = 0 To ComboBox1.Items.Count - 1
            imin = 0
            imax = 0
            If shuzu(imax) < shuzu(i) Then
                imax = i
            End If
            t = shuzu(ComboBox1.Items.Count - 1) : shuzu(ComboBox1.Items.Count - 1) = shuzu(imax) : shuzu(imax) = t
        Next
        t = ComboBox1.Items.Count - 1
        ComboBox1.Items.Clear()
        For i = 0 To t
            ComboBox1.Items.Add(shuzu(i))
        Next
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ComboBox1.Items.Add(Trim(ComboBox1.Text))
        End If
    End Sub
End Class
