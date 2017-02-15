﻿Imports System
Imports Aspose.Slides.SmartArt
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.SmartArts
    Class ChangeSmartArtLayout
        Public Shared Sub Run()
            ' ExStart:ChangeSmartArtLayout
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_SmartArts()

            Using presentation As New Presentation()
                ' Add SmartArt BasicProcess 
                Dim smart As ISmartArt = presentation.Slides(0).Shapes.AddSmartArt(10, 10, 400, 300, SmartArtLayoutType.BasicBlockList)

                ' Change LayoutType to BasicProcess
                smart.Layout = SmartArtLayoutType.BasicProcess

                ' Saving Presentation
                presentation.Save(dataDir & Convert.ToString("ChangeSmartArtLayout_out.pptx"), SaveFormat.Pptx)
            End Using
            ' ExEnd:ChangeSmartArtLayout
        End Sub
    End Class
End Namespace