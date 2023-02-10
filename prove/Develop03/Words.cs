public class Word 
{
    private Dictionary<String, bool> _wordStateList = new Dictionary<String, bool>();

   


    public Dictionary<String, bool> getDictionary() {
        return _wordStateList;
    }
    public void setWords(String[] words) {

        
        foreach (String word in words) {
            _wordStateList.Add(word, true);
        }
        
    }
}