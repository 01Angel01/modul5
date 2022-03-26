using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302202095
{
    class SayaTubeVideo
    {
        private string id { get; set; }
        private string title { get; set; }
        private string playCount { get; set; }

        public SayaTubeVideo(string id, string playCount)
        {
            Debug.Assert(id.Length == 5, "Panjang id adalah 5 digit");
            this.id = id;

            Debug.Assert(playCount.Length == 0, "Panjang playCount adalah 0 karakter");
            this.playCount = playCount;
        }

        public void increasePlayCount()
        {
            int hasil = playCount.Length;
        }
        public void printVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("PlayCount : " + playCount);
        }
    }
}