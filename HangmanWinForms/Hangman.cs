namespace HangmanWinForms
{
    public partial class Hangman : Form
    {
        private SecretWord secretWord;

        public Hangman()
        {
            InitializeComponent();

            secretWord = new SecretWord();

            RegisterEvents();

            GetParcialWord();

            lblMessage.Text = "";

            SetTip();
        }

        private void RegisterEvents()
        {
            foreach (Button button in pnlButtons.Controls)
            {
                button.Click += TakeGuess;
                button.Click += UpdateButton;
            }

            btnRESET.Click += ResetGame;
        }

        private void TakeGuess(object? sender, EventArgs e)
        {
            Button button = (Button)sender;

            char guess = button.Text[0];

            // Management of guesses
            if (secretWord.Victory(guess) || secretWord.GameOver())
                End();

            else { GetParcialWord(); UpdateNoose(); }

            // Update button color
            if (secretWord.foundLetters.Contains(guess))
                button.BackColor = Color.LightGreen;

            else
                button.BackColor = Color.IndianRed;

        }

        private void ResetGame(object? sender, EventArgs e)
        {
            secretWord = new SecretWord();

            SetTip();
            GetParcialWord();
            UpdateNoose();
            lblMessage.Text = "";
            pnlButtons.Enabled = true;

            foreach (Button button in pnlButtons.Controls)
            {
                button.Enabled = true;
                button.BackColor = Color.White;
            }
        }

        private void UpdateButton(object? sender, EventArgs e)
        {
            Button buttonClick = (Button)sender;

            buttonClick.Enabled = false;
        }

        private void End()
        {
            bool lose = secretWord.GameOver();

            if (lose)
            {
                pbNoose.Image = Properties.Resources.henryFail;
                lblMessage.ForeColor = Color.IndianRed;
            }
            else
            {
                pbNoose.Image = Properties.Resources.henryWin;
                lblMessage.ForeColor = Color.LightGreen;
            }

            pnlButtons.Enabled = false;
            btnRESET.Enabled = true;
            GetParcialWord();

            lblMessage.Text = secretWord.finalMessage;
        }

        private void UpdateNoose()
        {
            switch (secretWord.Errors)
            {
                case 1: pbNoose.Image = Properties.Resources.henryError1; break;
                case 2: pbNoose.Image = Properties.Resources.henryError2; break;
                case 3: pbNoose.Image = Properties.Resources.henryError3; break;
                case 4: pbNoose.Image = Properties.Resources.henryError4; break;
                case 5: pbNoose.Image = Properties.Resources.henryError5; break;
                case 6: pbNoose.Image = Properties.Resources.henryError6; break;

                default: pbNoose.Image = Properties.Resources.noose; break;
            }
        }

        private void SetTip()
        {
            lblTip.Text = secretWord.QuantityLetters.ToString() + " letters here:";
        }

        private void GetParcialWord()
        {
            lblSecretWord.Text = secretWord.ParcialWord;
        }
    }
}