using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class EmployeeImportance
    {

        int id;
        Employee[] employees;
        public EmployeeImportance()
        {
            employees = new Employee[3];
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            employees[0] = e1;
            employees[1] = e2;
            employees[2] = e3;
            e1.id = 1;
            e1.importance = 5;
            e1.subordinates.Add(2);
            e1.subordinates.Add(3);

            e2.id = 2;
            e2.importance = 3;

            e3.id = 3;
            e3.importance = 3;

            id = 1;
        }

        public int GetImportance()
        {
            int sum = 0;

            Dictionary<int, Employee> dict = new Dictionary<int, Employee>();
            HashSet<int> addedIds = new HashSet<int>();
            for (int i = 0; i < employees.Length; i++)
            {
                Employee ce = employees[i];
                dict.Add(ce.id, ce);
            }

            Queue<Employee> qu = new Queue<Employee>();

            qu.Enqueue(dict[id]);
            while (qu.Count() > 0)
            {
                Employee ce = qu.Dequeue();
                if (addedIds.Contains(ce.id))
                    continue;
                sum += ce.importance;

                for (int i = 0; i < ce.subordinates.Count; i++)
                {
                    Employee subEmp = dict[ce.subordinates[i]];
                    if (!addedIds.Contains(subEmp.id))
                        qu.Enqueue(subEmp);
                }
            }

            return sum;
        }

        class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
            public Employee()
            {
                subordinates = new List<int>();
            }
        }
    }
}
