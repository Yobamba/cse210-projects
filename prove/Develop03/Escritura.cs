
using System.Linq;

public class Scripture 
{
    private String[] _scriptureWords = {"Jesus", "said", "unto", "him,", "If", "thou", "canst", "believe,", "all", "things", "are", "possible", "to", "him", "that", "believeth;", "And", "straightway", "the", "father", "of", "the", "child", "cried", "out,", "and", "said", "with", "tears,", "Lord,", "I", "believe,", "help", "thou", "mine", "unbelief."};
    
  
    String _scriptureRef = "Mark 9:23-24";
    

    // String[] example = _scriptureWords.ToString().Split(" ").ToList();


    

// I'll serve up the word class through this method. I'll use this to feed words to the Word class. 
    public String[] getScriptureWords() 
    {
        String[] newScriptureList = {};
        for (int i = 0; i < _scriptureWords.Length;i++) {
            String indexString = i.ToString();
            String separator = ":";
            String concatinated = String.Concat(_scriptureWords[i],separator, indexString);
            newScriptureList = newScriptureList.Append(concatinated).ToArray();
        }
        return newScriptureList;
    }

    public void hideWords() 
    {
        String[] wordsToShow = _scriptureWords;
        Random randNum = new Random();
        int[] randList = {};
        Console.WriteLine(_scriptureRef);
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