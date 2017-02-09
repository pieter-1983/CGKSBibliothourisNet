using System;
using System.Collections.Generic;
using Bibliothouris.Source.Member;
using FileHelpers;

namespace Bibliothouris.Source.User
{
    public class MemberRepository
    {

        private List<Member> members;

        public MemberRepository()
        {
            members = new List<Member>();
            ReadFile();
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

        public void WriteToFile()
        {
            var memberHelper = new FileHelperEngine<Member>();
            var memberArray = members.ToArray();
            memberHelper.WriteFile("MemberRepo.txt",memberArray);
        }

        public void ReadFile()
        {
            var memberHelper = new FileHelperEngine<Member>();
            try
            {
                var memberArray = memberHelper.ReadFile("MemberRepo.txt");
                foreach (var member in memberArray)
                {
                    AddMember(new Member(member.firstName, member.street, member.number, member.postalCode, member.city,
                        member.INSS, member.lastName));
                }

            }
            catch (Exception e)
            {
                
            }
            

        }

        ~MemberRepository()
        {
            WriteToFile();
        }
    }
}