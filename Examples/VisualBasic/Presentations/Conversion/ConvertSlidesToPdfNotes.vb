﻿Imports System
Imports System.Drawing
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Presentations.Conversion
    Class ConvertSlidesToPdfNotes
        Public Shared Sub Run()
			'ExStart:ConvertSlidesToPdfNotes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Conversion()

            ' Instantiate a Presentation object that represents a presentation file 
            Dim presentation As New Presentation(dataDir & Convert.ToString("SelectedSlides.pptx"))
            Dim auxPresentation As New Presentation()

            Dim slide As ISlide = presentation.Slides(0)

            auxPresentation.Slides.InsertClone(0, slide)

            ' Setting Slide Type and Size 
            auxPresentation.SlideSize.Type = SlideSizeType.[Custom]
            auxPresentation.SlideSize.Size = New SizeF(612.0F, 792.0F)

            auxPresentation.Save(dataDir & Convert.ToString("PDFnotes_out.pdf"), SaveFormat.PdfNotes)
			'ExEnd:ConvertSlidesToPdfNotes
		End Sub
    End Class
End Namespace
