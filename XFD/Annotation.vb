Public Class Annotation
    Inherits Element

    Public Property Text As String

    Public Property Position As Vector
    Public Property Direction As Vector

    Public Property FontName As FontNameAttribute
    Public Property FontHeight As LengthAttribute
    Public Property Colour As ColourAttribute

    Public Sub New()

        Text = ""

        Position = New Vector
        Direction = New Vector

        FontName = New FontNameAttribute
        FontHeight = New LengthAttribute
        Colour = New ColourAttribute

    End Sub

End Class
