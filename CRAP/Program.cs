using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAP
{
    class Program
    {
        static bool _exit_flag = false;
        static int _cur_tick = 1;

        static void Main(string[] args)
        {            
            while (!_exit_flag)
            {
                if (_cur_tick >= 10) { _exit_flag = true; }

                _cur_tick++;
            }

            InChar();
        }

        static char InChar()
        {
            return System.Console.ReadKey().KeyChar;
        }
    }
}
