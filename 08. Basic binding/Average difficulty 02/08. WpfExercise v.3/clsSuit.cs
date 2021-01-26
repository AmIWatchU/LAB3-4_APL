using System;
using System.Collections.Generic;
using System.Text;

namespace _08._WpfExercise_v._3
{
    public class clsSuit
    {
        public string thisSuitName;   // name of suit
        public string ImageName;  // where image is

        // constructor requires name/image file name
        public clsSuit(
            string thisSuit, string thisImage)
        {
            thisSuitName = thisSuit;
            ImageName = thisImage;
        }

        // properties giving name and image
        public string SuitName
        {
            get
            {
                return thisSuitName;
            }
        }

        public string ImageUrl
        {
            get
            {
                return ImageName + ".jpg";
            }
        }


        // return string as the suit name with an S on the end
        public override string ToString()
        {
            return SuitName;
        }

    }
}
