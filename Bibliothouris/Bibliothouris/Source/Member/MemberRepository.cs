using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.User
{
    public class MemberRepository
    {

        private List<Member> members;

        public MemberRepository()
        {
            members = new List<Member>();
        }

        public virtual List<Member> GetAllMembers()
        {
            return members;
        }

        public virtual void AddMember(Member member)
        {
            members.Add(member);
        }
    }
}