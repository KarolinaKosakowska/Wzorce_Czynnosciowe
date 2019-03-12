namespace Wzorce_Czynnosciowe.ITERATOR
{
    interface IIterator
    {
        object Current();
        object First();
        bool IsEnd();
        object Next();
    }
}