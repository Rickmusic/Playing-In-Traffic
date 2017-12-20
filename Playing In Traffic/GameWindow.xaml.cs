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
using System.Windows.Shapes;

namespace Playing_In_Traffic
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        // Game space
        // Array of buildings
        // Array of active vehicals
        // Time or turns // 


        static GameSpace gameSpace;

        public GameWindow()
        {
            InitializeComponent();

            TestRun1();
           


        }

        private void TestRun1()
        {
            gameSpace = new GameSpace();
            gameSpace.add(100, 100, house);
        }
    }
}
