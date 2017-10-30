Public Class Arrow
    Dim xPos As Integer = 580
    Dim yPos As Integer = 437
    Dim Width As Integer = 512
    Dim Length As Integer = 512
    Dim Direction As Char

    Public Sub FindArrowDirection()
        Dim Random As New Random
        Dim num As Integer
        num = Random.Next(1, 5)
        If num = 1 Then
            Direction = "U"
        ElseIf num = 2 Then
            Direction = "D"
        ElseIf num = 3 Then
            Direction = "L"
        ElseIf num = 4 Then
            Direction = "R"
        Else
            Direction = "U"
        End If

    End Sub

    Public Function GetArrowDirection()

        Return Direction
    End Function
    Public Function GetLength()
        Return Width
    End Function
    Public Function GetWidth()
        Return Width
    End Function
    Public Function GetX()
        Return xPos
    End Function
    Public Function GetY()
        Return yPos
    End Function
    
End Class
