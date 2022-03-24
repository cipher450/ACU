﻿Public Class ThemedTabControl
    Inherits TabControl
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(120, 30)
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Left
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        G.Clear(Color.Gainsboro)

        For i = 0 To TabCount - 1
            Dim TabRectangle As Rectangle = GetTabRect(i)

            If i = SelectedIndex Then
                'Tab geselecteerd
                G.FillRectangle(Brushes.White, TabRectangle)
            Else
                'Tab niet geseltecteerd
                G.FillRectangle(Brushes.Transparent, TabRectangle)
            End If

            G.DrawString(TabPages(i).Text, Font, Brushes.White, TabRectangle, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        Next

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
        MyBase.OnPaint(e)
    End Sub

End Class
