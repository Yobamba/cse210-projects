public class Word 
{
    private List<Word> _wordList;
    private Scripture _scripture = new Scripture();
    private String _wordStr;

    private bool _isHidden;
    public Word() 
    {

    }

    public Word(String word, bool isHidden)  
    {
        _wordStr = word;
       _isHidden = isHidden;
    }

    private Reference _scriptRef = new Reference();
       public void HideWords() 
    {
        _wordList = _scripture.GetScriptureText();
        List<Word> wordsToShow = _wordList;
        Random randNum = new Random();
        int[] randList = {};
      
        Console.Clear();
        Console.WriteLine(_scriptRef.ShowReference());
        Console.Write("");

        for (int i = 0; i < wordsToShow.Count; i++) {
                Console.Write(wordsToShow[i]._wordStr);
                Console.Write(" ");

            }

        Console.WriteLine("");
        for (int j = 0; j < wordsToShow.Count; j++) {
            List<int> possible = Enumerable.Range(1, wordsToShow.Count).ToList();
            int randomInt = randNum.Next(wordsToShow.Count);
            int searchElement = randomInt;
            bool isContained = Array.Exists(randList, element => element == searchElement);
            while (isContained) {
                randomInt = randNum.Next(wordsToShow.Count);
                searchElement = randomInt;
                isContained = Array.Exists(randList, element => element == searchElement);
            }

            Console.WriteLine("Press enter to hide words. ");
            String userSays = Console.ReadLine();

            if (userSays == "quit") {
                Console.WriteLine("");
                Console.WriteLine("Keep treasuring up in your mind. ");
                Console.WriteLine("");
                break;
            }

            randList.Append(j);
            randList = randList.Append(randomInt).ToArray();
            
            String replacement = "";
            foreach (char c in wordsToShow[j]._wordStr) {
                replacement += "_";          
            }

            wordsToShow[randomInt]._wordStr = replacement;
            wordsToShow[randomInt]._isHidden = true; 

            Console.Clear();
            Console.Write(_scriptRef.ShowReference());
            Console.WriteLine("");

            // This for loop is to print out each word with the hidden words now gone. 
            for (int i = 0; i < wordsToShow.Count; i++) {
                Console.Write(wordsToShow[i]._wordStr);
                Console.Write(" ");             
            }
            
        }
}

}

