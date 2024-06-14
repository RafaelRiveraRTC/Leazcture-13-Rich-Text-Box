# Leazcture 13 Rich Text Box

Switch from gird to canvas so it's easier to work with

Make your rich text box

This time we name the rich text box it's self and not the run,we will name it rtbDisplay

If You go to properties you can change the font size of the document

Copy and paste the run so there is two of them



Each run is it's own object with it's oqn instance, the object has it's own properties.When you change a run the others are unnaffected.

When you edit the paragraph,however,it will apply the changes to everything that is inside.

Go ahead and copy the paragraph and paste it

Delete everyting insode of the flow document


   <FlowDocument>
            <Paragraph>
                <Run x:Name="runParagraphText" />
            </Paragraph>
            </FlowDocument>

            //This particular code bloxk doesn't seem to want to run no matter what i try