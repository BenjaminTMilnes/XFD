
Public Class Particle
    Inherits Element

    Public Property Interaction1 As Interaction
    Public Property Interaction2 As Interaction

    Public Property LineStyle As LineStyleAttribute
    Public Property LineWidth As LengthAttribute
    Public Property LineColour As ColourAttribute

    Public Property Annotations As List(Of Annotation)

    Public Sub New()

        LineStyle = New LineStyleAttribute
        LineWidth = New LengthAttribute
        LineColour = New ColourAttribute

        Annotations = New List(Of Annotation)

    End Sub

End Class
