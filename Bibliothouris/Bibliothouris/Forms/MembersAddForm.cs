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
    public interface IMemberAddView
    {
        void SetController(MemberController memberController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }
    public partial class MembersAddForm : Form, IMemberAddView
    {
        private MemberController memberController;

        public MembersAddForm()
        {
            InitializeComponent();
        }

        public void SetController(MemberController memberController)
        {
            this.memberController = memberController;
        }
       
        public void Clear()
        {
            firstName.Text = "";
            lastName.Text = "";
            street.Text = "";
            number.Text = "";
            city.Text = "";
            postalCode.Text = "";
            INSS.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            memberController.AddMember(firstName.Text, street.Text,number.Text, postalCode.Text,city.Text,INSS.Text,lastName.Text );

        }

        private void MembersAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
