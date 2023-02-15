
using System.Linq;

public class Scripture 
{
    private String _scriptureText;

    public Scripture(String scripText) 
    {
        _scriptureText = scripText;
    }


    

    // String[] example = _scriptureWords.ToString().Split(" ").ToList();


    

// I'll serve up the word class through this method. I'll use this to feed words to the Word class. 

    public String getScriptureText() 
    {
        return _scriptureText;
    }
    // public String[] getScriptureWords() 
    // {
    //     String[] newScriptureList = {};
    //     for (int i = 0; i < _scriptureWords.Length;i++) {
    //         String indexString = i.ToString();
    //         String separator = ":";
    //         String concatinated = String.Concat(_scriptureWords[i],separator, indexString);
    //         newScriptureList = newScriptureList.Append(concatinated).ToArray();
    //     }
    //     return newScriptureList;
    // }

 
}