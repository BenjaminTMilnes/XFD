Public Class Diagram

    Public Property Width As Integer
    Public Property Height As Integer

    Public Property Particles As List(Of Particle)

    Public Property Annotations As List(Of Annotation)

    Public Sub New()

        Particles = New List(Of Particle)

        Annotations = New List(Of Annotation)

    End Sub

End Class
