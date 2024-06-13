using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_2024_task_2
{
    public abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public abstract void ShowInfo();
    }
}
