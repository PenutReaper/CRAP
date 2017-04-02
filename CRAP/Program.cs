using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAP
{
    class Program
    {
        static Render_View Primary_Renderer = new Render_View();
                
        static void Main(string[] args)
        {
            Init_Console_Renderer(80, 45);

            while (true)
            {
                // @Temp Need a better way of limiting fps???
                if(System.DateTime.Now.Millisecond % 100 == 0)
                Primary_Renderer.Render();

                if (Primary_Renderer.Ticks() >= 30)
                {
                    Primary_Renderer.Load_Content("TEST");
                }
            }
        }

        static void Init_Console_Renderer(int Width, int Height)
        {
            Primary_Renderer.Set_Properties(Width, Height);
        }
    }

    class Content_Loader
    {
        enum Load_Modes
        {
            Debug,
            Static,
            Dynamic
        };

        Load_Modes Load_Mode = Load_Modes.Debug;

        public void Load()
        {
            if (Load_Mode.Equals(Load_Modes.Debug)) Load_Debug();
            if (Load_Mode.Equals(Load_Modes.Static)) Load_Static();
            if (Load_Mode.Equals(Load_Modes.Dynamic)) Load_Dynamic();
            return;
        }

        private void Load_Dynamic()
        {
            throw new NotImplementedException();
        }

        private void Load_Static()
        {
            throw new NotImplementedException();
        }

        private void Load_Debug()
        {
            throw new NotImplementedException();
        }
    }
}
