using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sozler
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, Username = "Admin", Password = "1" };
        public static List<Note> Notes = new List<Note>()
        {
            new Note{Id=1, Description="Bilindiği gibi, yeryüznde hiçbir şey" +
                "insan ruhuna hiçlik kadar baskı yapamaz"},
            new Note{Id=2, Description="Yarınki güne umutla bak." +
                "Gecenin ne doğuracağını tahmin bile edemezsin"},
              new Note{Id=2, Description="Ektiğimiz yeri sulamalıyız"},
                new Note{Id=2, Description="Cevizin kabuğunu kırıp özüne inmeyen cevizin hepsini kabuk zanneder."},

        };
    }
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
}
    public class AppUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
    }