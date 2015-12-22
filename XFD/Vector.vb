Public Class Vector

    Public Property X As Double
    Public Property Y As Double

    Public ReadOnly Property M As Double
        Get
            Return Math.Sqrt(X ^ 2 + Y ^ 2)
        End Get
    End Property

    Public Shared Operator +(Vector1 As Vector, Vector2 As Vector) As Vector

        Dim Vector3 As New Vector

        Vector3.X = Vector1.X + Vector2.X
        Vector3.Y = Vector1.Y + Vector2.Y

        Return Vector3

    End Operator

    Public Shared Operator -(Vector1 As Vector, Vector2 As Vector) As Vector

        Dim Vector3 As New Vector

        Vector3.X = Vector1.X - Vector2.X
        Vector3.Y = Vector1.Y - Vector2.Y

        Return Vector3

    End Operator

    Public Sub New()

        X = 0
        Y = 0

    End Sub

    Public Sub New(X1 As Double, Y1 As Double)

        X = X1
        Y = Y1

    End Sub

End Class