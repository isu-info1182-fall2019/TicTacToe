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

namespace TicTacToe {
    /// <summary>
    /// Jon Holmes
    /// INFO 1182
    /// Prof. Holmes
    /// Description: Plays Tic-Tac-Toe
    /// </summary>
    public partial class MainWindow : Window {

        char[,] sheet = new char[3,3];

        public MainWindow()
        {
            InitializeComponent();
            SetButtonClicks();
        }
        /// <summary>
        /// Set the click events for all of the buttons in 
        /// the grid. Made by Professor Holmes. 
        /// </summary>
        private void SetButtonClicks()
        {
            btn_0_0.Click += btnCell_Click;
            btn_0_1.Click += btnCell_Click;
            btn_0_2.Click += btnCell_Click;
            btn_1_0.Click += btnCell_Click;
            btn_1_1.Click += btnCell_Click;
            btn_1_2.Click += btnCell_Click;
            btn_2_0.Click += btnCell_Click;
            btn_2_1.Click += btnCell_Click;
            btn_2_2.Click += btnCell_Click;
        }

        /// <summary>
        /// Click event for handling all of the buttons in the grid.
        /// </summary>
        /// <param name="sender">Button that was clicked.</param>
        /// <param name="e"></param>
        private void btnCell_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Content = "X";
            //btn.Name = btn_0_1
            string[] parts = btn.Name.Split('_');
            string row = parts[1];
            string col = parts[2];
            int rowIndex = int.Parse(row);
            int colIndex = int.Parse(col);
            sheet[rowIndex,colIndex] = 'X';
            //MessageBox.Show("You clicked " + btn.Name);
            

            ShowGrid(sheet);
        }

        private void ShowGrid(char[,] board)
        {
            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < board.GetLength(1); colIndex++)
                {
                    // rowIndex 0
                    // colIndex 0
                    string name = "tb_" + rowIndex + "_" + colIndex;
                    TextBlock tb = (TextBlock)FindName(name);
                    //tb.Text = name;
                    tb.Text = board[rowIndex, colIndex].ToString();

                }
            }
        }

    }
}
