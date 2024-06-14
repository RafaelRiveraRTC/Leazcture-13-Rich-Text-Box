using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Leazcture_13_Rich_Text_Box
{
    /// <summary>
    /// Interaction logic for RTBExample.xaml
    /// </summary>
    public partial class RTBExample : Window
    {
        public RTBExample()
        {
            InitializeComponent();
            //Flow Document -Full Page- Collection of paragraphs
            FlowDocument fd = new FlowDocument();
            rtbDisplay.Document = fd;// this is attaching the flow document to the rich text box
            //Paragraph - Collection of Sentences (Run)

            Paragraph firstParagraph = new Paragraph();
            //Run - Single Sentence
            Run singleSentence = new Run("Single Sentence");// This contructor will allow to display the message inside
            singleSentence.FontStyle = FontStyles.Italic;

            Run secondSentence = new Run("Single Sentence");
            secondSentence.FontWeight = FontWeights.Bold;


            //firstParagraph.InLines is a colelciotn you add a run to

            firstParagraph.Inlines.Add(singleSentence);
            firstParagraph.Inlines.Add(secondSentence);


            firstParagraph.Inlines.Add(singleSentence);

            //Flow document.Blocks is a collection you add a Paragraph to

            fd.Blocks.Add(firstParagraph);
        }
    }
}
