using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RandomUserLibrary;
using RandomUserLibrary.Entities;

namespace DemoRandomUser.Model.Repositories
{
	public class UserRepository
	{
		private const int CountUsers = 150;

		private readonly SynchronizationContext _context;

		private readonly ObservableCollection<UserInfo> _users;

		public ObservableCollection<UserInfo> Users
		{
			get
			{
				LoadUsers(CountUsers);
				return _users;
			}
		}

		public UserRepository()
		{
			_context = SynchronizationContext.Current;

			_users = new ObservableCollection<UserInfo>();
		}

		private void LoadUsers(int countUsers)
		{
			RandomerUserHelper randomerUserHelper = new RandomerUserHelper();
			var users = randomerUserHelper.GetUsers(countUsers).ToList();
			users.ForEach(user => _users.Add(user));
		}

		public void LoadUsersAsync(int countUsers)
		{
			RandomerUserHelper randomerUserHelper = new RandomerUserHelper();
			var users = randomerUserHelper.GetUsersAsync(countUsers);
			users.ContinueWith(p =>
			{
				var items = p.Result.ToList();
				_context.Post(result =>
				{
					items.ForEach(user => _users.Add(user));
				}, null);
			});
		}

	}
}
