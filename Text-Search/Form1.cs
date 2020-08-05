using System;
using System.Windows.Forms;

namespace Text_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbSearchArea_TextChanged(object sender, EventArgs e)
        {
            //To Enable/Disable the Search button by checking if the Search Box is Empty.
            btnSearch.Enabled = tbSearchArea.Text != string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Declaring a Variable SelectionStartIndex that will keep the Index location of first character of Text to be Searched in TextArea (If found)
            int SelectionStartIndex;

            //retreiving the Text from Search box to search in Text Area and storing it in a variable.
            string str = tbSearchArea.Text;

            //retreving the Length of the Text to be seached in Text Area and storing it in a variable.
            int length = str.Length;


            /* 
             * ====================================================================================================================
             * 
             * Performing a direction check weather the Search flow have to be upwards or downwards by checking the toggle state of 
             * Direction Groupbox Radio Buttons. 
             * 
             * ====================================================================================================================
             */

            //if the direction to be searched Downwards. (Also By defaults)
            if (checkDown.Checked == true)
            {
                //Finding next location of caret to perform a Downward search by adding the current location with the Selection Length. 
                int startIndex = rtbTextArea.SelectionStart + rtbTextArea.SelectionLength;

                //Making a case sensitive Search by checking the state of Match case check box. [by default a string is searched case sensitively]
                SelectionStartIndex = cbMatchCase.Checked ?
                    rtbTextArea.Text.IndexOf(str, startIndex) :
                    rtbTextArea.Text.IndexOf(str, startIndex, StringComparison.CurrentCultureIgnoreCase);

                //Checking if the retreived Index Location of Text to be Searched in text area is valid or not. 
                if ((SelectionStartIndex > -1) && (SelectionStartIndex < (rtbTextArea.Text.Length - 1)))
                {
                    //performing the selection from indext location till the length of the Searched Text.
                    rtbTextArea.Select(SelectionStartIndex, length);
                }
            }

            //if the direction to be searched is set to Upwards.
            else if (checkUP.Checked == true)
            {
                //Making a case sensitive Search by checking the state of Match case check box. [by default a string is searched case sensitively]
                SelectionStartIndex = cbMatchCase.Checked ?
                    rtbTextArea.Text.LastIndexOf(str, rtbTextArea.SelectionStart) :
                    rtbTextArea.Text.LastIndexOf(str, rtbTextArea.SelectionStart, StringComparison.CurrentCultureIgnoreCase);

                //Checking if the retreived Index Location of Text to be Searched in text area is valid or not
                if ((SelectionStartIndex > -1) && (SelectionStartIndex < (rtbTextArea.Text.Length - 1)))
                {
                    //performing the selection from indext location till the length of the Searched Text.
                    rtbTextArea.Select(SelectionStartIndex, length);
                }
            }

        }

        private void rtbTextArea_TextChanged(object sender, EventArgs e)
        {
            //retreiving the caret location inside the Text Area and storing inside a variable.
            int sel = rtbTextArea.SelectionStart;

            //finding the line number by checking the line from the current character index inside the Text Area.
            int line = rtbTextArea.GetLineFromCharIndex(sel) + 1;       //Adding 1 as the retreived Line Number is Zero based

            /*
             *  STUCK HERE----SUCK HERE----SUCK HERE----SUCK HERE----SUCK HERE----SUCK HERE
             */
            
            //Printing the current Line number as string.
            lnsLabel.Text = line.ToString();

            //Printing the current Column number as string
        }

        private void rtbTextArea_SelectionChanged(object sender, EventArgs e)
        {
            //finding the last index of new line character(\n) in the rtbTextArea from the caret position.  
            int pos = rtbTextArea.Text.LastIndexOf("\n", rtbTextArea.SelectionStart);
            LIndexLabel.Text = rtbTextArea.SelectionStart.ToString();
            if(pos!=rtbTextArea.SelectionStart)
                colLabel.Text = String.Format("{0}", rtbTextArea.SelectionStart - pos);
            else
            {
                int LineBeginIndex = rtbTextArea.Text.LastIndexOf("\n", rtbTextArea.SelectionStart - 1);
                altcol.Text = "@" + LineBeginIndex.ToString();
                colLabel.Text = String.Format("{0}", pos - LineBeginIndex);
            }
            //coldebug.Text = rtbTextArea.SelectionStart.ToString();
            lioff.Text = pos.ToString();
            int column = rtbTextArea.SelectionStart - rtbTextArea.GetFirstCharIndexOfCurrentLine()+1;
                gcifcr.Text=column.ToString();
            ////altcol.Text = ((rtbTextArea.SelectionStart + 1)).ToString();
        }

        }

        

     
    }
}

