namespace prjWordleApi.Factory
{
    public class WordleFactory
    {
        public iWord returnInstance;

        public iWord GenerateWord()
        {
            returnInstance = new Words();
            returnInstance.GenerateWord();
            return returnInstance;
        }
    }
}
