using System;

namespace CRAP
{

    class Render_View
    {
        Render_View_Propeties Properties = new Render_View_Propeties();
        Render_Content Content = new Render_Content();
        
        public void Set_Properties(int Width, int Height)
        {
            Properties.Width = Width;
            Properties.Height = Height;
            if (Properties.Initialised) Properties.Ticks = 0;
        }

        public String Render_Setup()
        {
            Content.Update(Properties.Width, Properties.Height);
            string Render_String = "";

            foreach (var item in Content.Data)
            {
                Render_String += item.ToString();
            };

            return Render_String;
        }

        public void Render()
        {
            string To_Render = Render_Setup();
            Properties.Ticks += 1;

            Console.Clear();
            Console.WriteLine($"--- Console-Rendering Ascii Project (CRAP) --- Frame: {Properties.Ticks}");

            for (int x = 0; x < Content.Lines; x++)
            {
                Console.WriteLine(To_Render.ToString().Substring(0,Properties.Width));
                To_Render = To_Render.Substring(Properties.Width).ToString();
            }
        }
    }
}
