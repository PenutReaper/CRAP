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
                if(System.DateTime.Now.Millisecond % 16 == 0)
                Primary_Renderer.Render();
            }
        }

        static void Init_Console_Renderer(int Width, int Height)
        {
            Primary_Renderer.Set_Properties(Width, Height);
        }
    }
}
