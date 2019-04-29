using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.IO;

namespace TestSibur
{
    class Employees
    {
        List<Employee> employees;

        public Employees()
        {
            employees = new List<Employee>();
        }

        public bool LoadFromXml(string path)
        {
            XDocument emp;           

            try
            {

                var sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
                emp = XDocument.Load(sr);
            }
            catch
            {
                return false;
            }

            foreach (var e in emp.Root.Elements())
            {
                employees.Add(new Employee
                    (
                    e.Element("FirstName").Value,
                    e.Element("LastName").Value,
                    e.Element("MiddleName").Value,
                    e.Element("Title").Value)
                    );
            }
            return true;
        }

        public override string ToString()
        {
            string res = "";
            foreach (var e in employees)
                res += e.ToString() + "\n";
            return res;
        }
    }
}
