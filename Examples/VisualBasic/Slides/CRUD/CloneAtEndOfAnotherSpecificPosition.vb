Imports System
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Slides.CRUD
    Public Class CloneAtEndOfAnotherSpecificPosition
        Public Shared Sub Run()
            'ExStart:CloneAtEndOfAnotherSpecificPosition
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations_CRUD()

            ' Instantiate Presentation class to load the source presentation file
            Using srcPres As New Presentation(dataDir & Convert.ToString("CloneAtEndOfAnotherSpecificPosition.pptx"))
                ' Instantiate Presentation class for destination presentation (where slide is to be cloned)
                Using destPres As New Presentation()
                    ' Clone the desired slide from the source presentation to the end of the collection of slides in destination presentation
                    Dim slds As ISlideCollection = destPres.Slides

                    ' Clone the desired slide from the source presentation to the specified position in destination presentation
                    slds.InsertClone(1, srcPres.Slides(1))

                    ' Write the destination presentation to disk
                    destPres.Save(dataDir & Convert.ToString("Aspose1_out.pptx"), SaveFormat.Pptx)
                End Using
            End Using
            'ExEnd:CloneAtEndOfAnotherSpecificPosition
        End Sub
    End Class
End Namespace
