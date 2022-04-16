using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_GENERATE_EVENTHANLDER
{
    public class Person : object
    {
        public Person() : base()
        {
        }

        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void InsertPerson(Person person)
        {
            //کدهای مربوط به ذخیره ی اطلاعات در دیتابیس

            //var personEventArgs = new PersonEventArgs
            //{
            //    PersonId = person.PersonId
            //};

            // OnInsertPersonToDatabase(personEventArgs);

            //*********************************
            //Step 4
            //*********************************

            OnInsertPersonToDatabase(new EventArgs());
        }

        //        public delegate void InsertPersonEventHanler(object sender, PersonEventArgs e);

        //*********************************
        //Step 1
        //*********************************
        public delegate void InsertPersonEventHanler(object sender, EventArgs e);

        //*********************************
        //Step 2
        //*********************************

        public event InsertPersonEventHanler InsertPersonToDatabase;

        //*********************************
        //Step 3
        //*********************************

        virtual protected void OnInsertPersonToDatabase(EventArgs e)
        {
            //if(InsertPersonToDatabase != null)
            //{
            //    InsertPersonToDatabase.Invoke(this, e);
            //}

            InsertPersonToDatabase?.Invoke(this, e);
        }

        //virtual protected void OnInsertPersonToDatabase(PersonEventArgs e)
        //{
        //    InsertPersonToDatabase?.Invoke(this, e);
        //}



    }
}
