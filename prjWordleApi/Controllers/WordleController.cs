using Microsoft.AspNetCore.Mvc;
using prjWordleApi.Factory;

namespace prjWordleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordleController : Controller
    {
        public static WordleFactory factory = new WordleFactory();
        public iWord iword = factory.GenerateWord();
        public static Words w = new Words();
        

        [HttpGet("Generate Word")]
        public string GenerateWord()
        {
            w.SetWords();
            w.wordle = w.GenerateWord();
            return w.wordle;
        }

        [HttpPost("CheckWord")]
        public string CheckWord(string word)
        {
            w.SetWords();
            w.guess = word; //save the guess
            return w.CheckWord(word); //compare method called
        }
    }
}
