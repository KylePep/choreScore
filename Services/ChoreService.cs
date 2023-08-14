
namespace choreScore.Services
{
    public class ChoresService
    {
        private readonly ChoresRepository _choresRepository;

        public ChoresService(ChoresRepository choresRepository){
            _choresRepository = choresRepository;
        }

        internal Chore ChangeChore(string choreTitle, Chore choreData)
        {
            Chore chore = _choresRepository.ChangeChore(choreTitle, choreData);
            return chore;
        }

        internal Chore createChore(Chore choreData)
        {
            Chore chore = _choresRepository.CreateChore(choreData);
            return chore;
        }

        internal Chore GetChoreByName(string choreTitle)
        {
            Chore chore = _choresRepository.GetChoreByName(choreTitle);
            
            if (chore == null)
            {
                throw new Exception($"No chore with the title of {choreTitle}");

            }
                return chore;

        }

        internal List<Chore> GetChores()
        {
            List<Chore> chores = _choresRepository.GetChores();
            return chores;
        }

        internal Chore Removechore(string choreTitle)
        {
            Chore chore = _choresRepository.RemoveChore(choreTitle);

            if (chore == null)
            {
                throw new Exception($"No chore with the title of {choreTitle}");

            }
                return chore;
        }
    }
}