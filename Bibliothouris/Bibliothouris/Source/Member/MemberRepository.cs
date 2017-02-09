using System;
using System.Collections.Generic;
using Bibliothouris.Source.Member;

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
            CheckUniqueINSS(member.INSS);
            members.Add(member);

        }

        public void CheckUniqueINSS(string INSS)
        {
            foreach (Member member in members)
            {
                if (INSS.Equals(member.INSS))
                {
                    throw new ValidationException("INSS already exists");

                }

            }
        }
    }
}