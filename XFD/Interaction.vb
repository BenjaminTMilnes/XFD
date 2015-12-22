
Public Class Interaction
    Inherits Element

    Public Property Position As Vector

    Public Property Particles As List(Of Particle)

    Public Property Colour As ColourAttribute
    Public Property LineWidth As LengthAttribute
    Public Property LineColour As ColourAttribute

    Public Property Annotations As List(Of Annotation)

    Public Sub New()

        Position = New Vector

        Particles = New List(Of Particle)

        Colour = New ColourAttribute
        LineWidth = New LengthAttribute
        LineColour = New ColourAttribute

        Annotations = New List(Of Annotation)

    End Sub

End Class
