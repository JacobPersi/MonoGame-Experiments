using System;

namespace Playground {

    public static class Program {

        [STAThread]
        static void Main() {

            using (var game = new FirstPersonGame()) { 
                game.Run();
            }
        }
    }
}
