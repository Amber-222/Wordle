namespace prjWordleApi.Factory
{
    public interface iWord
    {
        string GenerateWord(); //method that will select a word from the array
        string CheckWord(string word); //take in user guess and compare to wordle and list
    }
}
