using System.Collections.Generic;

namespace CRAP
{

    class Render_Content
    {
        public List<char> Data = new List<char>();
        public int Lines = 0;

        private int _Width = 0;
        private int _Height = 0;

        public string Get_Data()
        {
            string _Data = "";

            foreach (var c in Data) { _Data += c; }

            return _Data;
        }

        public void Update(int Width = 1, int Height = 1)
        {
            Data.Clear();

            while (Data.Count <= Width * Height) { Data.Add('*'); }

            Lines = Height;
            _Width = Width;
            _Height = Height;
        }

        public void Load(string New_Data)
        {
            Data.Clear();

            foreach (var c in New_Data.ToCharArray()) Data.Add(c);
            while (Data.Count <= _Width * _Height) { Data.Add('*'); }
        }
    }
}
