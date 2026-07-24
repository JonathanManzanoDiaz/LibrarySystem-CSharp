using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{
    class Member
    {
        private static int nextId = 1;
        public int ID { get; }
        public string FullName { get; }
        public static List<Member> members = new List<Member>();
        public Member(string fullName)
        {
            ID = nextId++;
            FullName = fullName;
        }
        public static void AddMember()
        {
            Console.WriteLine("What is the full name of the new member?: ");
            string fullName = Console.ReadLine();
            Member newMember = new Member(fullName);
            members.Add(newMember);
            Console.WriteLine("Member added succesfully!");
            Console.WriteLine("Press a key to continue...");

            Console.ReadKey();

        }
        public static void ListMembers()
        {
            foreach(var member in members)
            {
                Console.WriteLine($"{member.ID} | {member.FullName}");
            }
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();

        }
    }
}
