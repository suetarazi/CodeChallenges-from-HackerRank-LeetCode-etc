using System;
using System.IO;

/*
class IReader {
public:
   int read(char* buffer, int bytes_to_read) = 0;
};

class FileReader : public IReader {
...
};

class NetworkReader : public IReader {
...
};

class BufferReader : public IReader {
...
}

...

class CompositeReader : public IReader {

// For you to fill in
    
    private readonly _fileReader;

    public Object CompositeReadingMachine()
    //constructor
    CompositeReader({
    this.Name = name;
    this.Filepath = filepath;

    })
    compositeReader = _reader.Add(IReader);

    public void Add()
    {
    
    }

};

class LogViewer
{

    public:

    private:
        IReader* m_reader;

        void SelectFilesCallback(const list<string>& fileNames) {
        
        m_reader = new CompositeReader();

        foreach(string l in filenames)
        {
            var foo = fileReader(l);
            m_reader.Add(foo);            
            

            //read in files
            filereader(@"nameOfFirstFile");
        }

    }
};
 * 
 * 
 * 
 */
namespace InterviewChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StreamReader sb = new StreamReader();
        }
    }
}
