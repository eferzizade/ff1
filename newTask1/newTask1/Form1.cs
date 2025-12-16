namespace newTask1
{
    public partial class Form1 : Form
    {
        bool isXTurn = true;
        Button[] cells;
        int scoreX = 0;
        int scoreO = 0;
        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        void InitGame()
        {
            cells = new Button[]
            {
                btn0, btn1, btn2,
                btn3, btn4, btn5,
                btn6, btn7, btn8
            };

            foreach (Button b in cells)
            {
                b.Text = "";
                b.Enabled = true;
            }

            isXTurn = true;
            lblActivePlayer.Text = "Player 1 - X";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitGame();
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button secilen = sender as Button;

            if (secilen.Text != "") return;

            secilen.Text = isXTurn ? "X" : "O";
            secilen.ForeColor = isXTurn ? Color.Blue : Color.Red;

            if (CheckWinner())
            {
                if (isXTurn)
                {
                    scoreX++;
                    lblScoreX.Text = "Player 1 : " + scoreX;
                    MessageBox.Show("Player 1 (X) qalib gəldi!");
                }
                else
                {
                    scoreO++;
                    lblScoreO.Text = "Player 2 : " + scoreO;
                    MessageBox.Show("Player 2 (O) qalib gəldi!");
                }

                InitGame();
                return;
            }

            // Heç-heçə
            if (cells.All(b => b.Text != ""))
            {
                MessageBox.Show("Heç-heçə!");
                InitGame();
                return;
            }

            isXTurn = !isXTurn;
            lblActivePlayer.Text = isXTurn ? "Player 1 - X" : "Player 2 - O";
        }
        bool CheckWinner()
        {
            int[,] win =
            {
                {0,1,2},{3,4,5},{6,7,8},
                {0,3,6},{1,4,7},{2,5,8},
                {0,4,8},{2,4,6}
            };

            for (int i = 0; i < win.GetLength(0); i++)
            {
                if (cells[win[i, 0]].Text != "" &&
                    cells[win[i, 0]].Text == cells[win[i, 1]].Text &&
                    cells[win[i, 1]].Text == cells[win[i, 2]].Text)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
