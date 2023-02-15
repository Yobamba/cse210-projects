using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference referencia = new Reference("Mark", "9", "23", "24");
        
        Scripture escritura = new Scripture("Jesus said unto him, If thou canst believe, all things are possible to him that believeth. And straightway the father of the child cried out, and said with tears, Lord, I believe; help thou mine unbelief.");
        

        // String[] passedList = escritura.getScriptureWords();

        Word palabra = new Word();

        String theReference = referencia.showReference();
        palabra.setReference(theReference);
  

        

        
        String wordString = escritura.getScriptureText();
        String[] wordArray = wordString.Split(" ");

        palabra.setScriptureWords(wordArray);

        palabra.hideWords();

       
       

        // palabra.setWords(passedList);

        // Dictionary<String, bool> sampleDictionary = palabra.getDictionary();

        
        // for (int i = 0; i < sampleDictionary.Count;i++) {
      
        //     Console.WriteLine("{0} and {1}", sampleDictionary.Keys.ElementAt(i), sampleDictionary[sampleDictionary.Keys.ElementAt(i)]);
        // }




       
        //* This was me testing the splite method. 
        // Scripture escritura = new Scripture();
        // String[] newOne = escritura.getScriptureWords();
        // String scriptLine = newOne[0];
        // String[] splitScript = scriptLine.Split(' ');
       
        // for (int i = 0; i < splitScript.Length; i++) {
        //     Console.Write(splitScript[i]);
        //     Console.Write(' ');
            
        // }
}

}