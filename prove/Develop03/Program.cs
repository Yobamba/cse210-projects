using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture escritura = new Scripture();
        escritura.hideWords();

        String[] passedList = escritura.getScriptureWords();

        Word palabra = new Word();

        palabra.setWords(passedList);

        Dictionary<String, bool> sampleDictionary = palabra.getDictionary();

        
        for (int i = 0; i < sampleDictionary.Count;i++) {
      
            Console.WriteLine("{0} and {1}", sampleDictionary.Keys.ElementAt(i), sampleDictionary[sampleDictionary.Keys.ElementAt(i)]);
        }




       
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