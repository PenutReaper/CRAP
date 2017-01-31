using System.Collections.Generic;

namespace CRAP
{

    class Render_Content
    {
        public List<char> Data = new List<char>();
        public int Lines = 0;

        public void Update(int Width = 1, int Height = 1)
        {
            Data.Clear();

            while (Data.Count <= Width * Height)
            {
                //  @Temp Replace with proper default case expression.
                Data.Add('*');
            }

            Lines = Height;
        }
    }
}
