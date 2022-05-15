using ScoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagementSystem.Dao
{
    interface ILoginDao
    {
        bool Login(User user);
    }
}
