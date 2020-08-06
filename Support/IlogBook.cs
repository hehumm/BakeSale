using System;

namespace BakeSale.Support
{
    public interface ILogBook
    {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }
}