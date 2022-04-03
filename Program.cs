using System;

public static class Program {
    [STAThread]
    static void Main() {
        using (var dummy = new Playground()) {
            dummy.Run();
        }
    }
}
