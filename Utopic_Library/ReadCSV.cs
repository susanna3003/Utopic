using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using 

namespace Utopic_Library
{
    class ReadCSV
    {
        public static void ReadRooms()
        {
            using (var reader = new StreamReader("BedroomInfo.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>();
            }
        }
    }
}
