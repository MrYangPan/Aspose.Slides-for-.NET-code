Imports System
Imports System.Drawing
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Slides.Background
    Public Class SetSlideBackgroundMaster
        Public Shared Sub Run()
            'ExStart:SetSlideBackgroundMaster
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations_Background()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If Not IsExists Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate the Presentation class that represents the presentation file
            Using pres As New Presentation()

                ' Set the background color of the Master ISlide to Forest Green
                pres.Masters(0).Background.Type = BackgroundType.OwnBackground
                pres.Masters(0).Background.FillFormat.FillType = FillType.Solid
                pres.Masters(0).Background.FillFormat.SolidFillColor.Color = Color.ForestGreen

                ' Write the presentation to disk
                pres.Save(dataDir & Convert.ToString("SetSlideBackgroundMaster_out.pptx"), SaveFormat.Pptx)
            End Using
            'ExEnd:SetSlideBackgroundMaster
        End Sub
    End Class
End Namespace
