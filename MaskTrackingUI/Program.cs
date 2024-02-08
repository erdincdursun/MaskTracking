using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "ERDİNÇ";
person1.LastName = "DURSUN";
person1.DateOfBirthYear = 1993;
person1.NationalIdentity = 123;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);