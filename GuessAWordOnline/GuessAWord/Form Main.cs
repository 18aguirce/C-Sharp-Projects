// Exercise : GuessAwWord with dictionary 648
// Author: Cesar Vicente
// Date  : Dec 2, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media; // Need for SoundPlayer
using System.IO; // Need for file I/O Handling
using System.Net; // Need for WebClient

namespace GuessAWord
{
    public partial class FrmMain : Form
    {

        //string[] words = {"ambidextrous", "keyboard", "intelligence", "philosophy", "message",
        //              "massage", "dexterity", "flamboyant", "acceleration", "realization"};

        List<string> words = new List<string>();

        Random randomNumber = new Random();

        SoundPlayer audio = new SoundPlayer(GuessAWord.Properties.Resources.CHIMES); // resources must be added in properties.resources


        string word;
        string hiddenWord;
        int countTries;
        int h = 0,
            m = 0,
            s = 0;
        string timerStamp;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            string myLetter;
            char[] arrayHiddenWord = hiddenWord.ToCharArray(); // converts a string into an array
            //myLetter = txtLetterGuess.Text;
            try
            {
                myLetter = GetLetter(txtLetterGuess.Text);
                if (lblUsedLetters.Text.Contains(myLetter))
                {
                    lblStatus.Text = "You have already used that letter!";
                }
                else
                {// Letter has not been used yet.
                    lblUsedLetters.Text += myLetter;
                    countTries++;

                    bool found = false;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word.Substring(i, 1) == myLetter)
                        {// A match was found. Replace the * with the letter.
                            arrayHiddenWord[i] = Convert.ToChar(myLetter);
                            found = true;
                        }
                    }

                    if (found)
                    {
                        lblStatus.Text = "Clap Clap Clap";
                        if(chkSound.Checked) audio.Play();
                    }
                    else
                    {
                        lblStatus.Text = "Sign :-(";
                    }

                    hiddenWord = new string(arrayHiddenWord);
                    lblHiddenWord.Text = hiddenWord;
                    txtNumTries.Text = Convert.ToString(countTries);

                    // Determine if the entire word has been guessed.
                    if (!hiddenWord.Contains("*")) // checks if the hiddenWord DOES NOT contain a "*"
                    {
                        lblStatus.Text = "You solved the word! \r\nYour time: " + timerStamp;
                        btnGuess.Enabled = false;
                        btnPlayAgain.Visible = true;
                        lblTimer.Enabled = false;
                        tmrTimer.Enabled = false;

                        //for timestamp
                        DateTime time = DateTime.Now;
                        string timeStamp = Convert.ToString(time.ToString("mm/dd hh:mm:ss tt"));

                        const string FILENAME = "scores.csv";

                        if (!File.Exists(FILENAME))
                        {
                            FileStream scoreFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                            StreamWriter writer = new StreamWriter(scoreFile);

                            writer.WriteLine("Words, Tries, Timer, Time");
                            writer.WriteLine(word + ", " +
                                             countTries + ", " +
                                             timerStamp + ", " +
                                             timeStamp);

                            writer.Close();
                            scoreFile.Close();
                        }
                        else
                        {
                            FileStream scoreFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                            StreamWriter writer = new StreamWriter(scoreFile);

                            writer.WriteLine(word + ", " +
                                             countTries + ", " +
                                             timerStamp + ", " +
                                             timeStamp);

                            writer.Close();
                            scoreFile.Close();
                        }
                    }


                } // end else letter has not been used yet
            }
            catch (NonLetterException ex)
            {
                lblStatus.Text = ("You have a bad character: " + ex.OffendingCharacter);
            }

            

            txtLetterGuess.Text = "";
            txtLetterGuess.Focus();
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //chkSound.Checked = false;

            // Read In our words...
            words.Add("ambidextrous");
            words.Add("keyboard");
            words.Add("intelligence");
            words.Add("philosophy");
            words.Add("message");
            words.Add("massage");
            words.Add("dexterity");
            words.Add("flamboyant");
            words.Add("acceleration");
            words.Add("realization");

            // Read in our setup preferences...
            // const names are usually capitalized
            const string FILENAMEPREF = "preferences.txt";

            try
            {
                FileStream preferencesFile = new FileStream(FILENAMEPREF, FileMode.Open, FileAccess.Read);
                StreamReader readerPref = new StreamReader(preferencesFile);

                preferencesFile.Position = 0;

                chkSound.Checked = Convert.ToBoolean(readerPref.ReadLine());
                txtPlayerName.Text = readerPref.ReadLine();

                readerPref.Close();
                preferencesFile.Close();
            }
            catch
            {
                MessageBox.Show("Preferences not set.",
                                "Preferences Error.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            NewGame();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Write user preferences to file...
            const string FILENAMEPREF = "preferences.txt";

            FileStream preferencesFile = new FileStream(FILENAMEPREF, FileMode.Create, FileAccess.Write);
            StreamWriter writerPref = new StreamWriter(preferencesFile);

            writerPref.WriteLine(Convert.ToString(chkSound.Checked));
            writerPref.WriteLine(txtPlayerName.Text);

            writerPref.Close();
            preferencesFile.Close();
        }

        private void NewGame()
        {
            word = words[randomNumber.Next(0, words.Count)];

            string content;
            string definition;

            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = "https://randomwordgenerator.org/Word/generate/quantity/1";
                    content = client.DownloadString(url);

                    //Console.WriteLine(content);

                    // <p class='result'><b>Beslave</b>
                    string randomWordStart = @"<p class='result'><b>";
                    int startWord = content.IndexOf(randomWordStart) + 21; //start after the 21 characters
                    int stopWord = content.IndexOf("</b>", startWord);
                    //Console.WriteLine("startWord = " + startWord + "stopWord = " + stopWord);

                    if (content.IndexOf(randomWordStart) != -1)
                    {// String was found...
                        word = content.Substring(startWord, stopWord - startWord).ToLower();
                        Console.WriteLine("word=" + word);
                    }
                    else
                    {// word was not found...
                        lblDefinition.ForeColor = System.Drawing.Color.DarkRed;
                        lblDefinition.Text = "Error with finding online word.";
                    }

                    // <div id="random_word_definition">ship's crewmember in charge of equipment and maintenance  </div>
                    //<p class='mean'>Meaning:1. (v.t.) To enslave.</ p >

                    string randomDefinitionStart = @"<p class='mean'>"; //case sensative
                    int startDefinition = content.IndexOf(randomDefinitionStart) + 16; //start after the 16 characters
                    int stopDefinition = content.IndexOf("</p>", startDefinition);
                    //Console.WriteLine("starDefinition = " + startDefinition + "stopDefinition = " + stopDefinition);

                    if (content.IndexOf(randomDefinitionStart) != -1)
                    {// String was found...
                        definition = content.Substring(startDefinition, stopDefinition - startDefinition);
                        definition = definition.Replace("&nbsp;&nbsp;", "\r\n");
                        Console.WriteLine("Definition=" + definition);
                        lblDefinition.ForeColor = System.Drawing.Color.ForestGreen;
                        lblDefinition.Text = definition;
                    }
                    else
                    {// definition was not found...
                        lblDefinition.ForeColor = System.Drawing.Color.DarkRed;
                        lblDefinition.Text = "Error with finding online definition.";
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(Convert.ToString(ex));
                lblDefinition.Text = "Online dictionary not found.";
            }

            // Temporarily use for testing.
            //word = "Mother-in-law";

            hiddenWord = "";
            for (int i = 0; i < word.Length; i++)
                hiddenWord += "*";

            // Prefill all hyphens
            string myLetter;
            char[] arrayHiddenWord = hiddenWord.ToCharArray();
            myLetter = "-";
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i, 1) == myLetter)
                {// A match was found. Replace the * with the letter.
                    arrayHiddenWord[i] = Convert.ToChar(myLetter);
                }
            }

            hiddenWord = new string(arrayHiddenWord);
            lblHiddenWord.Text = hiddenWord;

            lblStatus.Text = "";
            txtLetterGuess.Text = "";
            countTries = 0;

            lblUsedLetters.Text = "";

            btnPlayAgain.Visible = false;
            btnGuess.Enabled = true;

            lblTimer.Enabled = true;
            tmrTimer.Enabled = true;
            h = 0;
            m = 0;
            s = 0;
        }

        private string GetLetter(string myString)
        {
            char letter;
            if (char.TryParse(myString, out letter))
            {// We have exacly one character
                letter = char.ToLower(letter);
                if (letter < 'a' || letter > 'z')
                {// problem
                    string badLetter = Convert.ToString(letter);
                    throw (new NonLetterException(badLetter));
                }

                string goodLetter = Convert.ToString(letter);
                return goodLetter;
            }
            else
            {// TryParse Failed
                throw (new NonLetterException("null or multiple charaters."));
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                m += 1;
                s = 0;
            }
            if (m == 60)
            {
                h += 1;
                m = 0;
            }

            timerStamp = Convert.ToString(h.ToString("D2")) + ":" + 
                         Convert.ToString(m.ToString("D2")) + ":" + 
                         Convert.ToString(s.ToString("D2"));

            lblTimer.Text = "Timer: " + timerStamp;
        }
    } // end public partion class frmMain:Form

    // This is the custom exception class that the book exercise is asking us to create. 
    public class NonLetterException : Exception
    {
        private string offendingCharacter;//This is lower class ltrs

        public NonLetterException() : base("A non-letter was entered.")
        {
        }

        public NonLetterException(string nonletter) : base("The non-letter '" + nonletter + "' was entered.")
        {
            offendingCharacter = nonletter;
        }

        public string OffendingCharacter //This is upper class lttrs
        {
            get
            {
                return offendingCharacter;
            }
        }
    }// end custome exeption class NonLetterExection
}
