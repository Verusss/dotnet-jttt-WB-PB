using System;
using System.ComponentModel;

namespace JTTT
{
    class DbManager
    {
        public void AddTask(Task t)
        {
            using (var ctx = new JTTTDbContext())
            {
                ctx.Task.Add(t);
                ctx.SaveChanges();
            }
        }
        public void DelTask(Task t)
        {
            using (var ctx = new JTTTDbContext())
            {
                t = ctx.Task.Find(t.Id);
                if (t != null)
                {
                    ctx.Task.Remove(t);
                    ctx.SaveChanges();
                }
            }
        }

        public BindingList<Task> GetBindingList()
        {
            BindingList<Task> list = new BindingList<Task>();
            using (var ctx = new JTTTDbContext())
            {
                foreach (var t in ctx.Task)
                {
                    list.Add(t);
                }
            }
            return list;
        }

        public void AddExamples()
        {
            using (var ctx = new JTTTDbContext())
            {
                Task t = new Task();

                t.Create("https://www.demotywatory.pl/", "kot", " ", "Wyświetl obraz", "demokoty");
                ctx.Task.Add(t);
                ctx.SaveChanges();

                t.Create("https://www.demotywatory.pl/", "psy", " ", "Wyświetl obraz", "demopsy");
                ctx.Task.Add(t);
                ctx.SaveChanges();

                //t.Create("https://www.demotywatory.pl/", "cykl", " ", "Wyświetl obraz", "aktualny1");
                //ctx.Task.Add(t);
                //ctx.SaveChanges();
            }
        }
    }
}