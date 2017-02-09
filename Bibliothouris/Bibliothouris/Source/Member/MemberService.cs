using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.User
{
    public interface IMemberService
    {
        List<Member> GetAllMembers();
        void AddMember(string firstName, string street, string number, string postalCode,
            string city, string INSS, string lastName);
    }

    public class MemberService : IMemberService
    {
       
        private MemberRepository repository;

        public MemberService() : this(new MemberRepository())
        {

        }

        public MemberService(MemberRepository repository)
        {
            this.repository = repository;
        }

        public List<Member> GetAllMembers()
        {
            return repository.GetAllMembers();
        }

        public void AddMember(string firstName, string street, string number, string postalCode,
            string city, string INSS, string lastName)
        {
            repository.AddMember(new Member(firstName, street, number, postalCode, city, INSS, lastName));
        }
    }
}