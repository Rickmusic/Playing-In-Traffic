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
        GridLength rectSize = new GridLength(30);
        SolidColorBrush greenBrush = new SolidColorBrush(System.Windows.Media.Colors.LawnGreen);
        SolidColorBrush brownBrush = new SolidColorBrush(System.Windows.Media.Colors.Brown);
        public GameWindow()
        {
            InitializeComponent();
            Startup();
        }

        private void Startup()
        {
            gameSpace = new GameSpace(50,50);
            House house = new House();
            gameSpace.add(20,20, house);
            initVisualSpace();
            populateGrid();
        }

        private void initVisualSpace()
        {
            MainBoard.Children.Clear();
            MainBoard.RowDefinitions.Clear();
            MainBoard.ColumnDefinitions.Clear();

            // Create Grid //
            for (int x = 0; x < gameSpace.gameBoard.GetLength(0); x++)
            {
                MainBoard.RowDefinitions.Add(new RowDefinition());
            }
            for (int x = 0; x < gameSpace.gameBoard.GetLength(0); x++)
            {
                MainBoard.RowDefinitions[x].Height = rectSize;
            }
            for (int y = 0; y < gameSpace.gameBoard.GetLength(1); y++)
            {
                MainBoard.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int x = 0; x < gameSpace.gameBoard.GetLength(0); x++)
            {
                MainBoard.ColumnDefinitions[x].Width = rectSize;
            }
        }

        private void populateGrid()
        {
            // Populate Grid // 
            for (int x = 0; x < gameSpace.gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameSpace.gameBoard.GetLength(1); y++)
                {
                    Rectangle rect = new Rectangle();
                    Grid.SetRow(rect, x);
                    Grid.SetColumn(rect, y);
                    rect.StrokeThickness = 0;
                    MainBoard.Children.Add(rect);
                    if (gameSpace.gameBoard[x, y] == null)
                    {
                        rect.Fill = greenBrush;

                    }
                    else
                    {
                        rect.Fill = brownBrush;
                    }
                }
            }
        }

        private void startTime(object sender, RoutedEventArgs e)
        {
            playBtn.Content = "Running";
            // Create turn thread // 
        }

        private void stopTime(object sender, RoutedEventArgs e)
        {
            playBtn.Content = "Start time";
            // Terminate turn thread // 
        }
    }
}
