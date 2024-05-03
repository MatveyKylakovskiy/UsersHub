using UsersHub.Users;

namespace UsersHub.HUB
{
    public class RegistorByDictionary
    {
        private int _id = 1;
        private Dictionary<int, User> _usersDic = new Dictionary<int, User>();
        private Queue<int> _freeId= new Queue<int>();
        public RegistorByDictionary() { }

        public void AddUser(User user)
        {   
            if(!_usersDic.Select(u => u.Value).Contains(user))
            {
                AddNewUser(user);
                Console.WriteLine("The user was added successfully");
            }

            else
            {
                Console.WriteLine("The user has already been added");
            }
            
        }

        private void AddNewUser(User user)
        {
            if (_freeId.Count > 0)
            {
                _usersDic.Add(_freeId.Dequeue(), user);
            }

            else
            {
                _usersDic.Add(_id++, user);
            }
        }

        public void RemoveUser(int id)
        {
            _usersDic.Remove(id);
            _freeId.Enqueue(id);
        }
    }
}
