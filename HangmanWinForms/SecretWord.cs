using System.Collections;

namespace HangmanWinForms
{
    public class SecretWord
    {
        public SecretWord()
        {
            SetWord();
            finalMessage = "";
            foundLetters = EncryptedWord(secretWord.Length);
            errors = 0;
        }

        private string[] words = 
        {
            "HEIST",
            "ESCAPE",
            "PRISON",
            "HACKER",
            "ROBBERY",
            "DIAMOND",
            "DISGUISE",
            "PARACHUTE",
            "INFILTRATE",
            "EXPLOSION",
            "JETPACK",
            "GADGET",
            "BRIBE",
            "CHAOS",
            "SNEAK",
            "FORGERY",
            "MASTERMIND",
            "CONSPIRACY",
            "CRIMINAL",
            "MUSEUM",
            "CHASE",
            "BANK",
            "TUNNEL",
            "VILLAIN",
            "DETECTIVE",
            "UNDERCOVER",
            "TAKEDOWN",
            "SABOTAGE",
            "FORGERY",
            "GIZMO",
            "RESCUE",
            "HIJACK",
            "VORTEX",
            "THRILLER",
            "INTERROGATE",
            "ESPIONAGE",
            "LOCKPICK",
            "FUGITIVE",
            "SUSPEND",
            "SCHEMER",
            "SLEUTH",
            "DARING",
            "SNIPER",
            "COVERT",
            "DECOY",
            "CAPER",
        };

        private int errors;
        public string secretWord;
        public string finalMessage;
        public char[] foundLetters;
        
        public int QuantityLetters
        {
            get { return secretWord.Length; }
        }

        public int Errors
        {
            get { return errors; }
        }

        public string ParcialWord
        {
            get { return new string(foundLetters); }
        }

        public void SetWord()
        {
            Random random = new Random();
            secretWord = words[random.Next(words.Length)];
        }

        private char[] EncryptedWord(int length)
        {
            char[] foundLetters = new char[length];

            for (int carectere = 0; carectere < foundLetters.Length; carectere++)
                foundLetters[carectere] = '_';

            return foundLetters;
        }

        public bool Victory(char guess)
        {
            bool found = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (guess == secretWord[i])
                {
                    foundLetters[i] = guess;
                    found = true;
                }
            }

            if (found == false)
                errors++;

            bool victory = new string(foundLetters).ToUpper() == secretWord;

            if (victory)
                finalMessage = "Congrats! \nYou got the secret word and saved Henry :)";

            else if (GameOver())
                finalMessage = $"You killed Henry :( \nThe word was \"{secretWord}\"!";

            return victory;
        }

        public bool GameOver()
        {
            return errors == 7;
        }
    }
}
