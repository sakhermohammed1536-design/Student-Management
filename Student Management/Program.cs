using System;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        // تأكد من تشغيل الفورم الرئيسي هنا
        Application.Run(new Form1());
    }
}