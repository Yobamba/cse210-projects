public class Reference 
{
    private String _book;
    private String _chapter;
    private String _verse;
    private String _endVerse;

    public Reference() 
    {
        _book = "Mark";
        _chapter = "9";
        _verse = "23";
        _endVerse = "24";
    }

    public Reference(String book, String chapter, String verse, String endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public String ShowReference() {
        return $"{_book} {_chapter}:{_verse}-{_endVerse} ";
    }
}