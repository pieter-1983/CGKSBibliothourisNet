using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.Member;
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
            if (errorProvider1.GetError(this.INSS).Length == 0 && errorProvider1.GetError(this.lastName).Length == 0 &&
                errorProvider1.GetError(this.city).Length == 0)
            {
                try
                {
                    memberController.AddMember(firstName.Text, street.Text, number.Text, postalCode.Text, city.Text,
                        INSS.Text,
                        lastName.Text);
                }
                catch (ValidationException exception)
                {
                    MessageBox.Show(exception.GetMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                string str = "";
                if (errorProvider1.GetError(this.INSS).Length > 0)
                {
                    str += errorProvider1.GetError(this.INSS) + "\r\n";
                }
                if (errorProvider1.GetError(this.lastName).Length > 0)
                {
                    str += errorProvider1.GetError(this.lastName) + "\r\n";
                }
                if (errorProvider1.GetError(this.city).Length > 0)
                {
                    str += errorProvider1.GetError(this.city) + "\r\n";
                }
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void required_Validated(object sender, System.EventArgs e)
        {
            if (INSS.Text.Length > 0)
            {
                // Clear the error, if any, in the error provider.
                errorProvider1.SetError(this.INSS, string.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                errorProvider1.SetError(this.INSS, "INSS is required.");
            }
            if (lastName.Text.Length > 0)
            {
                // Clear the error, if any, in the error provider.
                errorProvider1.SetError(this.lastName, string.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                errorProvider1.SetError(this.lastName, "Lastname is required.");
            }
            if (city.Text.Length > 0)
            {
                // Clear the error, if any, in the error provider.
                errorProvider1.SetError(this.city, string.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                errorProvider1.SetError(this.city, "City is required.");
            }
        }

     
    }
}