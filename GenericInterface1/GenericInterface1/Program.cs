//generic interface is used to deal with datatype
//problem in generic datattype by allowing with 
//using any datatype in list,stack,queue,etc

using System.Collections.Generic;
namespace GenericInterface
{
    public interface IStorage<T>//T is the data type
    {
        void add(T item);
        IEnumerable<T> GetAll();//ienumerable is used to iterate like foreachloop
    }
    public class Storage : IStorage<int>
    {
        List<int> list = new List<int>();
        public void add(int item)
        {
            list.Add(item);
        }
        public IEnumerable<int> GetAll()
        {
            return list;

        }
    }
    public class Storage2 : IStorage<string>
    {
        List<string> list = new List<string>();
        public void add(string name)
        {
            list.Add(name);
        }
        public IEnumerable<string> GetAll()
        {
            return list;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            IStorage<int> str = new Storage();
            IStorage<string> str2 = new Storage2();
            str.add(100);
            str.add(200);
            str2.add("hemanth");
            str2.add("reddy");
            foreach(int n in str.GetAll())
            {
                Console.WriteLine(n);

            }
            //Console.WriteLine(str.GetAll());
            //Console.WriteLine(str2.GetAll());
            foreach (string n in str2.GetAll())
            {
                Console.Write(n+" ");

            }
        }
    }
}