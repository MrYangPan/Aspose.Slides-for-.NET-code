﻿using Aspose.Slides.Export;
using Aspose.Slides.SlideShow;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Slides.Transitions
{
    class ManagingBetterSlideTransitions
    {
        public static void Run()
        {
            // ExStart:ManagingBetterSlideTransitions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Slides_Presentations_Transitions();

            // ExStart:ManagingBetterSlideTransitions
            // Instantiate Presentation class to load the source presentation file
            using (Presentation presentation = new Presentation(dataDir + "AccessSlides.pptx"))
            {
                // Apply circle type transition on slide 1
                presentation.Slides[0].SlideShowTransition.Type = TransitionType.Circle;

                // Set the transition time of 3 seconds
                presentation.Slides[0].SlideShowTransition.AdvanceOnClick = true;
                presentation.Slides[0].SlideShowTransition.AdvanceAfterTime = 3000;

                // Apply comb type transition on slide 2
                presentation.Slides[1].SlideShowTransition.Type = TransitionType.Comb;

                // Set the transition time of 5 seconds
                presentation.Slides[1].SlideShowTransition.AdvanceOnClick = true;
                presentation.Slides[1].SlideShowTransition.AdvanceAfterTime = 5000;

                // Write the presentation to disk
                presentation.Save("SampleTransition_out.pptx", SaveFormat.Pptx);
            
                // ExEnd:ManagingBetterSlideTransitions
                // Write the presentation to disk
                presentation.Save(dataDir + "BetterTransitions_out.pptx", SaveFormat.Pptx);
            }
            // ExEnd:ManagingBetterSlideTransitions
        }
    }
}