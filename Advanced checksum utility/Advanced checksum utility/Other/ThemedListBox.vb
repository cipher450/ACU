Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomListBox
    Inherits ListBox

    Sub New()
        Me.Font = New Font("Segoe UI", 9, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

    Public Enum MyTypes
        [Default] = 0
        ImageView = 1
    End Enum

    Private _ListBoxType As MyTypes
    Public Property ListBoxType As MyTypes
        Get
            Return _ListBoxType
        End Get
        Set(value As MyTypes)
            If value = MyTypes.Default Then
                Me.DrawMode = Windows.Forms.DrawMode.Normal
            Else
                Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
                Me.ItemHeight = 36
            End If
            _ListBoxType = value
        End Set
    End Property

    Private ListItems As New List(Of ListBoxItem)

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        If ListItems.Count > 0 Then
            If _ListBoxType = MyTypes.ImageView Then
                e.DrawBackground()
                If ListItems(e.Index).Image IsNot Nothing Then
                    e.Graphics.DrawImage(ListItems(e.Index).Image, e.Bounds.Left + 3, e.Bounds.Top + 3, 30, 30)
                End If

                If ListItems(e.Index).Name IsNot Nothing Then
                    e.Graphics.DrawString(ListItems(e.Index).Name, e.Font, Brushes.Black, e.Bounds.Left + 36, e.Bounds.Top + 4)
                End If

                If ListItems(e.Index).Size IsNot Nothing Then
                    e.Graphics.DrawString(ListItems(e.Index).Size & " - " & ListItems(e.Index).Directory, e.Font, Brushes.RoyalBlue, e.Bounds.Left + 36, e.Bounds.Top + 17)
                End If
                e.DrawFocusRectangle()
            End If
        End If
        MyBase.OnDrawItem(e)
    End Sub

    Public Sub AddItem(ByVal Text As String, ByVal img As Image, ByVal Dir As String)
        Dim NewItem As New ListBoxItem
        NewItem.Image = img
        NewItem.Name = Text
        NewItem.Size = Nothing
        NewItem.Directory = Dir
        ListItems.Add(NewItem)
        Me.Items.Add(Name)
    End Sub

    Public Sub AddItem(ByVal MyItem As ListBoxItem)
        ListItems.Add(MyItem)
        Me.Items.Add(MyItem.Name)
    End Sub

    Public Sub AddItem(ByVal Image As Image, ByVal Name As String, ByVal Size As String, ByVal Directory As String)
        Dim NewItem As New ListBoxItem
        NewItem.Image = Image
        NewItem.Name = Name
        NewItem.Size = Size
        NewItem.Directory = Directory
        ListItems.Add(NewItem)
        Me.Items.Add(Name)
    End Sub

    Public Sub ClearItems()
        ListItems.Clear()
        Me.Items.Clear()
    End Sub

    ''' <summary>
    ''' Remove Items in ListBox
    ''' </summary>
    ''' <param name="Index">Index of Item</param>
    ''' <remarks></remarks>
    Public Sub RemoveItemAt(ByVal Index As Integer)
        If Index <= Me.Items.Count - 1 Then
            ListItems.RemoveAt(Index)
            Me.Items.RemoveAt(Index)
        End If
    End Sub

    Public Function MyItems() As List(Of ListBoxItem)
        Return ListItems
    End Function
End Class

Public Class ListBoxItem
    Sub New()

    End Sub

    Sub New(ByVal Image As Image, ByVal Name As String, ByVal Size As String, ByVal Directory As String)
        _Image = Image
        _Name = Name
        _Size = Size
        _Directory = Directory
    End Sub

    Private _Image As Image
    Public Property Image As Image
        Get
            Return _Image
        End Get
        Set(value As Image)
            _Image = value
        End Set
    End Property

    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Private _Size As String
    Public Property Size As String
        Get
            Return _Size
        End Get
        Set(value As String)
            If value IsNot Nothing Then
                _Size = FileSize(value)
            Else
                _Size = value
            End If
        End Set
    End Property

    Private _Directory As String
    Public Property Directory As String
        Get
            Return _Directory
        End Get
        Set(value As String)
            _Directory = value
        End Set
    End Property

    Private Function FileSize(ByVal Tamanho As Double) As String
        Dim Tipos As String() = {"B", "KB", "MB", "GB"}
        Dim TamanhoDouble As Double = Tamanho
        Dim CSA As Integer = 0
        While TamanhoDouble >= 1024 AndAlso CSA + 1 < Tipos.Length
            CSA += 1
            TamanhoDouble = TamanhoDouble / 1024
        End While
        Return [String].Format("{0:0.##} {1}", TamanhoDouble, Tipos(CSA))
    End Function
End Class
