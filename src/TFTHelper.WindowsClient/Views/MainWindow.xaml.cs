using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace TFTHelper.WindowsClient
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public const string WINDOW_NAME = "Project2019";
        //public const string WINDOW_NAME = "League of Legends (TM) Client";
        //IntPtr handle = FindWindow(null, WINDOW_NAME);

        public MainWindow()
        {
            InitializeComponent();

            //SetWindowPos(new WindowInteropHelper(this).Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }


        //private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        //private const UInt32 SWP_NOSIZE = 0x0001;
        //private const UInt32 SWP_NOMOVE = 0x0002;
        //private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    }
}
