public class Word 
{
    private String[] _scriptureWords = {};

    private String _scriptRef;
    // private Dictionary<String, bool> _wordStateList = new Dictionary<String, bool>();

    // Reference _scriptureRef = new Reference();


    public void setReference(String scriptureRef) 
    {
        _scriptRef = scriptureRef;
    }

   
    public void setScriptureWords(String[] scriptureWords) 
    {
        foreach (String oneWord in scriptureWords) 
        {
            _scriptureWords = _scriptureWords.Append(oneWord).ToArray();
           
        }
    }

    // public Dictionary<String, bool> getDictionary() {
    //     return _wordStateList;
    // }
    // public void setWords(String[] words) {

        
    //     foreach (String word in words) {
    //         _wordStateList.Add(word, true);
    //     }
        
    // }

       public void hideWords() 
    {
        String[] wordsToShow = _scriptureWords;
        Random randNum = new Random();
        int[] randList = {};
        // Console.WriteLine(_scriptureRef);
        Console.Clear();
        Console.WriteLine(_scriptRef);
        Console.Write("");
        for (int i = 0; i < wordsToShow.Length; i++) {
                Console.Write(wordsToShow[i]);
                Console.Write(" ");
                
                
            }
        Console.WriteLine("");


        
        // This first for loop is to keep removing words as the user presses enter. 
        for (int j = 0; j < wordsToShow.Length; j++) {
            List<int> possible = Enumerable.Range(1, wordsToShow.Length).ToList();
            

            int randomInt = randNum.Next(wordsToShow.Length);
            int searchElement = randomInt;
            bool isContained = Array.Exists(randList, element => element == searchElement);
            if (isContained) {
                
                while (isContained) 
                {   
                    randomInt = randNum.Next(wordsToShow.Length);
                    searchElement = randomInt;
                    isContained = Array.Exists(randList, element => element == searchElement);
                }

                

                
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
            foreach (char c in wordsToShow[j]) {
                replacement += "_";
            
                
              
            }

            wordsToShow[randomInt] = replacement;
            
            Console.Clear();
            Console.Write(_scriptRef);
            Console.WriteLine("");

            // This for loop is to print out each word with the hidden words now gone. 
            for (int i = 0; i < wordsToShow.Length; i++) {
                Console.Write(wordsToShow[i]);
                Console.Write(" ");
                
                
            }

            


        }
        // Scripture neoOne = new Scripture();

        // String[] scriptContainer = neoOne.getScriptureWords();
        // String[] splitScript = scriptContainer


    //     // This will start by displaying "AAA" and waiting for the user to press the enter key
    //     Console.WriteLine("AAA");
    //     Console.ReadLine();

    //     // This will clear the console
    //     Console.Clear();

    //     // This will show "BBB" in the console where "AAA" used to be
    //     Console.WriteLine("BBB");
    // }



}


}