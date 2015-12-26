Imports System.Xml

Public Class XMLExporter

    Private XMLWriter1 As XmlWriter

    Public Sub New(Stream1 As System.IO.Stream)

        XMLWriter1 = XmlWriter.Create(Stream1)

    End Sub

    Public Sub Export(Diagram1 As Diagram)

        WriteDiagram(Diagram1)

    End Sub

    Protected Sub WriteDiagram(Diagram1 As Diagram)

        XMLWriter1.WriteStartDocument()

        XMLWriter1.WriteStartElement("diagram")

        XMLWriter1.WriteAttributeString("width", Diagram1.Width.ToString())
        XMLWriter1.WriteAttributeString("height", Diagram1.Height.ToString())

        WriteParticles(Diagram1.Particles)

        XMLWriter1.WriteEndElement()

        XMLWriter1.WriteEndDocument()

    End Sub

    Protected Sub WriteParticles(Particles1 As IEnumerable(Of Particle))

        XMLWriter1.WriteStartElement("particles")

        For Each Particle1 As Particle In Particles1
            WriteParticle(Particle1)
        Next

        XMLWriter1.WriteEndElement()

    End Sub

    Protected Sub WriteParticle(Particle1 As Particle)

        XMLWriter1.WriteStartElement("particle")

        WriteLineStyleAttribute(Particle1.LineStyle)
        WriteLineWidthAttribute(Particle1.LineWidth)

        XMLWriter1.WriteEndElement()

    End Sub

    Protected Sub WriteLineStyleAttribute(LineStyleAttribute1 As LineStyleAttribute)

        If LineStyleAttribute1.Content = LineStyles.Linear Then
            XMLWriter1.WriteAttributeString("line-style", "linear")
        ElseIf LineStyleAttribute1.Content = LineStyles.Sinusoidal
            XMLWriter1.WriteAttributeString("line-style", "sinusoidal")
        ElseIf LineStyleAttribute1.Content = LineStyles.Cycloidal
            XMLWriter1.WriteAttributeString("line-style", "cycloidal")
        ElseIf LineStyleAttribute1.Content = LineStyles.Circular
            XMLWriter1.WriteAttributeString("line-style", "circular")
        ElseIf LineStyleAttribute1.Content = LineStyles.Epicycloidal
            XMLWriter1.WriteAttributeString("line-style", "epicycloidal")
        End If

    End Sub

    Protected Sub WriteLineWidthAttribute(LengthAttribute1 As LengthAttribute)

        XMLWriter1.WriteAttributeString("line-width", LengthAttribute1.Content)

    End Sub

End Class
