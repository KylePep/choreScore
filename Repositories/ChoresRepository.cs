using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScore.Repositories
{
    public class ChoresRepository
    {

        private List<Chore> dbChores;

        public ChoresRepository()
        {
            dbChores = new List<Chore>();
            dbChores.Add(new Chore("Trash", "Take out trash", true, .5));
            dbChores.Add(new Chore("Litter Box", "Clean the cats litter box", true, 1));
            dbChores.Add(new Chore("Lawn", "Rake, Mow and edge the lawn", false, 3));
            dbChores.Add(new Chore("Leak", "Theres like some kind of a leak in the basement", true, 100.5));
        }


        internal Chore ChangeChore(string choreTitle, Chore choreData)
        {
            Chore chore = GetChoreByName(choreTitle);
            if (choreData.Title == null) choreData.Title = chore.Title;
            if (choreData.Body == null) choreData.Body = chore.Body;
            if (choreData.Important == false) 
            {
                if(!chore.Important == true)choreData.Important = false;
                };
            if (choreData.Duration == 0) choreData.Duration = chore.Duration;

            // if (!chore.Title.Equals(choreData.Title)) chore.Title = choreData.Title;
            // if (choreData.Body.)

            chore = choreData;

                
            int changeChore = dbChores.FindIndex(chore => chore.Title.ToLower() == choreTitle.ToLower());
            Chore returnChore = dbChores[changeChore] = choreData;
            return returnChore;
        }

        internal Chore CreateChore(Chore choreData)
        {
            dbChores.Add(choreData);
            return choreData;
        }

        internal Chore GetChoreByName(string choreTitle)
        {
            Chore foundChore = dbChores.Find(chore => chore.Title.ToLower() == choreTitle.ToLower());
            return foundChore;
        }

        internal List<Chore> GetChores()
        {
            return dbChores;
        }


        internal Chore RemoveChore(string choreTitle)
        {
            Chore removeChore = GetChoreByName(choreTitle);
            dbChores.Remove(removeChore);
            return removeChore;
        }
    }
}