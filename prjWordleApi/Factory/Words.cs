namespace prjWordleApi.Factory
{
    public class Words : iWord
    {
        public static string[] arrWords = new string[10]; //list of predefined words
        public static int counter = 0; //keeps track of user guesses
        public string wordle = ""; //store genrated word
        public string guess = ""; //store user guesses
        public string CheckWord(string word)
        {
            guess = word;
            bool isValid = false;
            bool isInList = false;
            bool guessed = false;
            string response = "";

            if (counter < 5) //loop for all 5 guesses
            {
                if (word.Equals(wordle))//if the guess is the word
                {
                    isValid = true;
                    isInList = true;
                    guessed = true;
                    response = "Congrats, you got it";
                    counter = 5; //reset the counter once the wordle is guessed
                }
                else
                {
                    if (word.Length > 5 || word.Length < 5) //word too short or long
                    {
                        isValid = false;
                        isInList = false;
                        response = "Word must be five letters in length";
                        counter++;
                    }
                    else
                    {
                        for (int x = 0; x < arrWords.Length; x++) //loop through array
                        {
                            if (arrWords[x].ToLower().Equals(word)) //if the word is not in the array
                            {
                                isInList = true;
                                counter++;
                                break;
                            }
                        }

                        if (isInList == false)
                        {
                            response = "Word is not in the list";
                        }
                        else if (isInList == true && guessed == false)
                        {
                            response = "Not the wordle";
                        }
                    }
                }
            }
            if (guessed == false && counter >= 5) //if the word is not guessed and guesses are used up
            {
                response = "You did not guess the wordle in under 5 tries. Wordle was: " + wordle;
                wordle = "";
                counter = 0;
            }
            return response;
        }

        public string[] SetWords()
        {
            arrWords[0] = "Mooed";
            arrWords[1] = "Bully";
            arrWords[2] = "Cowed";
            arrWords[3] = "Steer";
            arrWords[4] = "Heifer";
            arrWords[5] = "Grazn";
            arrWords[6] = "Bison";
            arrWords[7] = "Milks";
            arrWords[8] = "Munch";
            arrWords[9] = "Lasso";
            return arrWords;
        }

        //returns the random wordle word
        public string GenerateWord()
        {
            Random rnd = new Random();
            wordle = arrWords[rnd.Next(arrWords.Length - 1)]; //selects a random word from this array
            return wordle;
        }
    }
}
