public class Reference 
{
    private String _book;
    private String _chapter;
    private String _verse;
    private String _endVerse;

    
    
    public Reference(String book, String chapter, String verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(String book, String chapter, String verse, String endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public String showReference() {
        return $"{_book} {_chapter}:{_verse}-{_endVerse} ";
    }

}