using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy_Excersize
{
    internal class DataItem
    {
        public string Brand { get; set; }
        public string BaseArtNo { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }


        public DataItem()
        {
        }

        public DataItem(string brand, string baseArtNo, string color, int size)
        {
            Brand = brand;
            BaseArtNo = baseArtNo;
            Color = color;
            Size = size;
        }


        public static DataItem[] GetDemoData()
        {
            List<DataItem> result = new List<DataItem>();

            result.Add(new DataItem(
                "Nike", "100", "Blå", 36));
            result.Add(new DataItem(
                "Nike", "100", "Blå", 37));
            result.Add(new DataItem(
                "Nike", "100", "Blå", 38));
            result.Add(new DataItem(
                "Nike", "100", "Blå", 39));
            result.Add(new DataItem(
                "Nike", "100", "Blå", 40));

            result.Add(new DataItem(
                "Nike", "100", "Gul", 36));
            result.Add(new DataItem(
                "Nike", "100", "Gul", 37));
            result.Add(new DataItem(
                "Nike", "100", "Gul", 38));
            result.Add(new DataItem(
                "Nike", "100", "Gul", 52));

            result.Add(new DataItem(
                "Ecco", "200", "Svart", 36));
            result.Add(new DataItem(
                "Ecco", "200", "Svart", 37));
            result.Add(new DataItem(
                "Ecco", "200", "Svart", 42));
            
            result.Add(new DataItem(
                "Ecco", "200", "Brun", 36));
            result.Add(new DataItem(
                "Ecco", "200", "Brun", 37));
            result.Add(new DataItem(
                "Ecco", "200", "Brun", 38));
            result.Add(new DataItem(
                "Ecco", "200", "Brun", 39));
            result.Add(new DataItem(
                "Ecco", "200", "Brun", 40));
            result.Add(new DataItem(
                "Ecco", "200", "Brun", 42   ));


            return result.ToArray();
        }
    }
}
