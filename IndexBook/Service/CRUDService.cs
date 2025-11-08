using IndexBook.Model;

namespace IndexBook.Service;

public class CRUDService
{
    public BookEntry Create(string name, string number)
    {
        BookEntry be = new BookEntry();
        //Code will be here
        be.Name = name;
        be.Number = number;

        return be;
    }
    public List<BookEntry> ReadAll(string name, string number)
    {
        List<BookEntry> bookEntries = new List<BookEntry>();

        //Code will be here
        
        return bookEntries;
    }
    public BookEntry Update(string name)
    {
        BookEntry be = new BookEntry();
        //Code will be here
        

        return be;
    }
    public bool Delete(string name)
    {
        bool result = false;

        return result;
    }
}
