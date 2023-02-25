
using System.Linq;

public class Scripture 
{
    private String _scriptureText = "Jesus said unto him, If thou canst believe, all things are possible to him that believeth. And straightway the father of the child cried out, and said with tears, Lord, I believe; help thou mine unbelief.";

    private List<Word> _wordList = new List<Word>();
    public List<Word> GetScriptureText() 
    {
        String[] scriptureList = _scriptureText.Split(" ");
        foreach (String word in scriptureList) 
        {
            _wordList.Add(new Word(word, false));
        }
        return _wordList;
    }
   
}