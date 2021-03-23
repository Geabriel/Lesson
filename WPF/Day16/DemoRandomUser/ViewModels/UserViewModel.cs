using System.Collections.ObjectModel;
using DemoRandomUser.Model.Repositories;
using RandomUserLibrary.Entities;

namespace DemoRandomUser.ViewModels
{
	public class UserViewModel
	{
		private readonly UserRepository _userRepository;

		public UserViewModel()
		{
			_userRepository=new UserRepository();
		}
		private ObservableCollection<UserInfo> _users;

		public ObservableCollection<UserInfo> Users
		{
			get
			{
				if (_users == null)
				{
					_users = _userRepository.Users;
				}
				return _users;
			}
		}


	}
}
