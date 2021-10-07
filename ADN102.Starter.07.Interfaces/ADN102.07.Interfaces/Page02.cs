using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page2
{

    public class Record
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }
        public override string ToString()
        {
            return $"Record> Name: {Name} Phone: {Phone} Birth: {BirthDate}";
        }
    }

    public interface ICursor
    {
        Record Current { get; }
        bool Next();
        bool Previous();
        bool Reset();
    }

    class RecordArrayCursor : ICursor
    {
        public RecordArrayCursor(Record[] data)
        {
            this.data = data;
            if (data.Length > 0)
            {
                index = 0;   // set index to first element
            }
            else
            {
                index = -1;  // no elements in the array
            }
        }
        private int index;
        Record[] data;

        public Record Current
        {
            get
            {
                if (index == -1) // index is pointing before the first record
                { return null; }  // no record to return
                if (index > data.Length) // index is pointing after the last record
                { return null; }  // no record to return
                return data[index];  // index is pointing to one of the records in the array of records
            }
        }
        public bool Next()
        {
            if (index < data.Length - 1)  // index has a next record to go to
            {
                index++; return true;
            }
            return false;                 // index does not have a next record to go to

        }
        public bool Previous()
        {
            if (index > 0)               // index has a previous record to go to
            {
                index--; return true;
            }
            return false;                // index does not have a previous record to go to  
        }
        public bool Reset()
        {
            if (data.Length > 0)           // there are records in the array
            {
                index = 0;
                return true;
            }
            return false;                // there are no records in the array, so you cannot reset to the first one.
        }
    }

    class Program
    {
        public static void Main()
        {
            Record[] records = new Record[] {
                 new Record () {Name="One", Phone="111-111-1111", BirthDate= new DateTime(2011,1,1)},
                new Record () { Name="Two", Phone="222-222-2222", BirthDate= new DateTime(2012,2,2)},
                 new Record () { Name="Three", Phone="333-333-3333", BirthDate= new DateTime(2013,3,3)},
            };

            RecordArrayCursor rc = new RecordArrayCursor(records);

            ICursor c = rc;
            do
            {
                Console.WriteLine(c.Current);
            } while (c.Next());

        }
}

}
