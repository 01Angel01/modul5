using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302202095
{
    class SayaTubeUser
    {
        private int id { get; set; }
        private [] uploadedVideos;
        public string username { get; set; }

        public SayaTubeUser(string username, [] uploadedVideo)
        {
            this.username = username;
            this.uploadedVideos = uploadedVideos;
        }

        //public int GetTotalVideoPlayCount()
        //{
        //    return
        //}

        public void AddVideo(List<SayaTubeVideo> uploadedVideos)
        {
            uploadedVideos.Add();
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + username);
            Console.WriteLine("Video 1 judul: " + uploadedVideos.Count);
            Console.WriteLine("Video 2 judul: " + uploadedVideos.Count);
        }
        public static int DesignbyContrast(int username, List<SayaTubeVideo> uploadedVideos)
        {
            Debug.Assert(username <= int.MaxValue && username >= int.MinValue);

            int hasil;
            try
            {
                hasil = checked(username);
                Console.WriteLine("Pengecekan berjalan dengan lancar" + e.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Maaf, karena terjadi overflow pada program, maka output diganti dengan 0");
                hasil = 0;
            }
            return hasil;
        }
    }
}