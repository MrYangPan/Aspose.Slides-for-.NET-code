﻿Imports System
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Slides.Layout
    Class SetPDFPageSize
        Public Shared Sub Run()
            ' ExStart:SetPDFPageSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations_Layout()

            ' Instantiate a Presentation object that represents a presentation file 
            Dim presentation As New Presentation()

            ' Set SlideSize.Type Property 
            presentation.SlideSize.Type = SlideSizeType.A4Paper

            ' Set different properties of PDF Options
            Dim opts As New PdfOptions()
            opts.SufficientResolution = 600

            ' Save presentation to disk
            presentation.Save(dataDir & Convert.ToString("SetPDFPageSize_out.pdf"), SaveFormat.Pdf, opts)
            ' ExEnd:SetPDFPageSize
        End Sub
    End Class
End Namespace
