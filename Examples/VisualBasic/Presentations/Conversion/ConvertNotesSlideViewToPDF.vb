﻿Imports System
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Presentations.Conversion
    Class ConvertNotesSlideViewToPDF
        Public Shared Sub Run()
			'ExStart:ConvertNotesSlideViewToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Conversion()

            ' Instantiate a Presentation object that represents a presentation file
            Using presentation As New Presentation(dataDir & Convert.ToString("NotesFile.pptx"))
                ' Saving the presentation to PDF notes
                presentation.Save(dataDir & Convert.ToString("Pdf_Notes_out.tiff"), SaveFormat.PdfNotes)
            End Using
			'ExEnd:ConvertNotesSlideViewToPDF
        End Sub
    End Class
End Namespace
