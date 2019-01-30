using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xClusiveGames
{
	class Account
	{
		string accountName;
		string accountPassword;

		public Account(string accountName, string accountPassword)
		{
			accountName = AccountName;
			accountPassword = AccountPassword;
		}

		public string AccountName
		{
			get => accountName;
			set => accountName = value;
		}

		public string AccountPassword
		{
			get => accountPassword;
			set => accountPassword = value;
		}
	}
}
