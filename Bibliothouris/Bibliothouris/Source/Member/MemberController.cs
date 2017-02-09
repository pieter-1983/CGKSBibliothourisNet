using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms;

namespace Bibliothouris.Source.User
{
    public class MemberController
    {
        internal IMemberView view { get; }
        private IMemberAddView addView;
        private IMemberService service;

        public MemberController(IMemberView memberView, IMemberAddView addView, IMemberService service)
        {
            this.view = memberView;
            this.addView = addView;
            this.service = service;
            this.view.SetController(this);
            this.addView.SetController(this);
        }

       

        public void LoadAllMembers()
        {
            foreach (Member member in service.GetAllMembers())
            {
                view.AddMember(member);
            }
        }

        public void AddMember(string firstName, string street, string number, string postalCode,
            string city, string INSS, string lastName)
        {
            service.AddMember(firstName, lastName, INSS, street, number, city, postalCode);
            addView.Close();
            ClearAllMembers();
            LoadAllMembers();
        }

        private void ClearAllMembers()
        {
            view.ClearAllMembers();
        }

        public void addMemberView()
        {
            addView.Clear();
            addView.ShowDialog();
        }
    }
}
