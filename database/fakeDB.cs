using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.TP.Models;

namespace WebApplication1.database
{
    public class FakeDB
    {
        public List<Models.TP.Models.Chat> listeChat;
        private static readonly Lazy<FakeDB>
       lazy =
       new Lazy<FakeDB>
           (() => new FakeDB());

        public static FakeDB Instance { get { return lazy.Value; } }

        private FakeDB()
        {
            this.listeChat = init();
        }

        private List<Chat> init()
        {
            var i = 1;
            return new List<Chat>
            {
                new Chat{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new Chat{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new Chat{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new Chat{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new Chat{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new Chat{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new Chat{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }

        public List<Chat> GetMeuteDeChats()
        {
            return this.listeChat;
        }
    }
}