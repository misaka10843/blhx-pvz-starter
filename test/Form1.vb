
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles qq.Click
        Dim haveFile = Dir(Application.StartupPath + "\ShipgirlsVSSirens\SVS.exe")
        If haveFile = "SVS.exe" Then
            Shell("cmd /c start " + Application.StartupPath + "\ShipgirlsVSSirens\map\code.png")
        Else
            MsgBox("诶呀！您好像没有把启动器放在游戏文件夹的同级目录下呢" & Chr(13) & "而且应该在压缩包中直接解压的话启动器是不会不在游戏文件夹的同级目录下的哦", vbOK, "发生错误啦！")
        End If
    End Sub

    Private Sub startgame_Click(sender As Object, e As EventArgs) Handles startgame.Click
        Dim haveFile = Dir(Application.StartupPath + "\ShipgirlsVSSirens\SVS.exe")
        If haveFile = "SVS.exe" Then
            Shell("cmd /c cd " + Application.StartupPath + "\ShipgirlsVSSirens\ && start SVS.exe")
        Else
            MsgBox("诶呀！您好像没有把启动器放在游戏文件夹的同级目录下呢" & Chr(13) & "而且应该在压缩包中直接解压的话启动器是不会不在游戏文件夹的同级目录下的哦", vbOK, "发生错误啦！")
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)
        Shell("explorer ""https://space.bilibili.com/41356186""")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim haveFile = Dir(Application.StartupPath + "\ShipgirlsVSSirens\SVS.exe")
        If haveFile = "SVS.exe" Then
            MsgBox("start " + Application.StartupPath + "\ShipgirlsVSSirens\Help.mhtml", vbOK, "test")
            Shell("cmd /c start " + Application.StartupPath + "\ShipgirlsVSSirens\Help.mhtml")
        Else
            MsgBox("诶呀！您好像没有把启动器放在游戏文件夹的同级目录下呢" & Chr(13) & "而且应该在压缩包中直接解压的话启动器是不会不在游戏文件夹的同级目录下的哦", vbOK, "发生错误啦！")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("explorer ""https://www.bilibili.com/video/BV16X4y157hW""")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim haveFile = Dir(Application.StartupPath + "\ShipgirlsVSSirens\SVS.exe")
        If haveFile = "SVS.exe" Then
            Shell("cmd /c start " + Application.StartupPath + "\ShipgirlsVSSirens\map\notice.txt")
        Else
            MsgBox("诶呀！您好像没有把启动器放在游戏文件夹的同级目录下呢" & Chr(13) & "而且应该在压缩包中直接解压的话启动器是不会不在游戏文件夹的同级目录下的哦", vbOK, "发生错误啦！")
        End If
    End Sub

    Private Sub 求关注qwqToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 求关注qwqToolStripMenuItem.Click
        Shell("explorer ""https://space.bilibili.com/41356186""")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class
