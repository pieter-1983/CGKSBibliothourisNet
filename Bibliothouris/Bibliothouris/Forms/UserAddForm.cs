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
    public interface IUserAddView
    {
        void SetController(UserController userController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }

    public partial class UserAddForm : Form, IUserAddView
    {
        private UserController userController;

        public UserAddForm()
        {
            InitializeComponent();
        }

        public void SetController(UserController userController)
        {
           this.userController = userController;
        }

        private void add_Click(object sender, EventArgs e)
        {
            userController.AddUser(userName.Text);
        }

        public void Clear()
        {
            userName.Text = "";
        }
    }
}
