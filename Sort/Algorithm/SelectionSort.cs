using System;

namespace Sort.Algorithm
{
    public class SelectionSort
    {
        public void DoSort()
        {
            //Prepare Test data
            var _items = DataPrepare();

            for (int i = 0; i < _items.Length; i++/*move pointer to the right*/)
            {
                //identify index of minimum entry on right
                int min = i;
                for (int j = i + 1; j < _items.Length; j++)
                {
                    if (Less(_items[j], _items[min]))
                        min = j;
                }
                Exch(_items, i, min);
            }

            foreach (var item in _items)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, Salary: {item.Salary}, HiringDate: {item.HiringDate.ToString("MM/dd/yyyy")}");
            }
        }

        private Person[] DataPrepare()
        {
            var _data = new Person[5] {
                new Person(){CustomerId=1,Salary=1000,HiringDate=DateTime.Now.Date.AddMonths(-6)},
                new Person(){CustomerId=2,Salary=4000,HiringDate=DateTime.Now.Date.AddMonths(-1)},
                new Person(){CustomerId=4,Salary=2000,HiringDate=DateTime.Now.Date.AddMonths(-4)},
                new Person(){CustomerId=3,Salary=5000,HiringDate=DateTime.Now.Date.AddMonths(-2)},
                new Person(){CustomerId=6,Salary=3000,HiringDate=DateTime.Now.Date.AddMonths(-10)}
            };

            return _data;
        }

        public bool Less(Person p, Person q) => p.Salary.CompareTo(q.Salary) < 0;
        public void Exch(Person[] items, int index, int min)
        {
            var a = items[index];
            items[index] = items[min];
            items[min] = a;
        }
    }
    public class Person : IComparable<Person>
    {
        public int CustomerId { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }

        public Person()
        {
        }

        public int CompareTo(Person that)
        {
            if (this.CustomerId > that.CustomerId) return -1;
            if (this.CustomerId < that.CustomerId) return 1;
            if (this.Salary > that.Salary) return -1;
            if (this.Salary < that.Salary) return 1;
            if (this.HiringDate > that.HiringDate) return -1;
            if (this.HiringDate < that.HiringDate) return 1;

            return 0;
        }
    }
}