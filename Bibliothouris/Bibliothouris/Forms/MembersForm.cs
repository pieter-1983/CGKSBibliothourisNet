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
    public interface IMemberView
    {
        void SetController(MemberController memberController);
        void AddMember(Member member);
        void ClearAllMembers();
        DialogResult ShowDialog();

    }
    public partial class MembersForm : Form, IMemberView
    {
        private MemberController memberController;
        public MembersForm()
        {
            InitializeComponent();
        }
        public void SetController(MemberController memberController)
        {
            this.memberController = memberController;
        }

        public void AddMember(Member member)
        {
            memberListView.Items.Add(CreateMemberListViewItem(member));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MembersForm_Load(object sender, EventArgs e)
        {

        }
        public void ClearAllMembers()
        {
            memberListView.Items.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            memberController.addMemberView();
        }
    }
}
