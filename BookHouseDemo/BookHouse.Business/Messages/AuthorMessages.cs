using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.Business.Messages
{
    public class AuthorMessages
    {
        public static string AddAuthorMessage()
        {
            return "Yazar bilgileri eklendi";
        }
        public static string UpdateAuthorMessage()
        {
            return "Yazar bilgileri güncellendi";
        }
        public static string DeleteAuthorMessage()
        {
            return "Yazar bilgileri silindi";
        }
    }
}
