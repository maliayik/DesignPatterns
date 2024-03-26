namespace DesignPattern.Iterator.IteratorPattern
{
    public interface IMover<T>
    {
        //buradaki metot bize yeni bir ıterator(yineleyici) olusturmamıza yarıyacak.
        IIterator<T> CreateIterator();
    }
}
