using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms;

namespace Bibliothouris.Source.User
{
    public class UserController
    {
        internal IUserView view { get; }
        private IUserAddView addView;
        private IUserService service;

        public UserController(IUserView userView, IUserAddView addView, IUserService service)
        {
            this.view = userView;
            this.addView = addView;
            this.service = service;
            this.view.SetController(this);
            this.addView.SetController(this);
        }

        public void LoadAllUsers()
        {
            foreach (User user in service.GetAllUsers())
            {
                view.AddUser(user);
            }
        }

        public void AddUser(string userName)
        {
            service.AddUser(userName);
            addView.Close();
            ClearAllUsers();
            LoadAllUsers();                 
        }

        private void ClearAllUsers()
        {
            view.ClearAllUsers();
        }

        public void addUserView()
        {
            addView.Clear();
            addView.ShowDialog();
        }
    }
}
