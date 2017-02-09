using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.User;

namespace Bibliothouris.Forms
{
    public interface IUserView
    {
        void SetController(UserController userController);
        void AddUser(User user);
        void ClearAllUsers();
        DialogResult ShowDialog();   
    }

    public partial class UsersForm : Form, IUserView
    {
        private UserController userController;
        
        public UsersForm()
        {
            InitializeComponent();
        }

        public void SetController(UserController userController)
        {
            this.userController = userController;
        }

        public void AddUser(User user)
        {
            userListView.Items.Add(CreateUserListViewItem(user));
        }

        private ListViewItem CreateUserListViewItem(User user)
        {
            ListViewItem userItem = new ListViewItem(user.ID.ToString());
            userItem.SubItems.Add(user.Name);
            return userItem;  
        }

        public void ClearAllUsers()
        {
            userListView.Items.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            userController.addUserView();
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e) {

        }
    }
}
