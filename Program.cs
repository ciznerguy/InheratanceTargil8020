namespace InheratanceTargil8020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CEO c1 = new CEO("John Doe", DateTime.Now, 20000, "CEO", 100);

            //מחלקת זמן
            // מחלקה המאפשרת ניהול ושימוש בתאריכים ושעות 

            //DateTime d1 = new DateTime(2019, 6, 1);
            //DateTime d2 = new DateTime(2022, 8, 1);
            //Console.WriteLine(d2.Year - d1.Year);
            //Console.WriteLine(DateTime.Now);

            //// יצירת עובד בעזרת הבנאי הראשון
            //Employee employee1 = new Employee("David", new DateTime(2020, 5, 1), 15000);
            //Console.WriteLine(employee1);

            //// יצירת עובד בעזרת אחד הבנאים האחרים
            //Employee employee2 = new Employee("Sarah");
            //Console.WriteLine(employee2);

            // יצירת עובד בעזרת הבנאי הריק
            Employee employee3 = new Employee();
            Console.WriteLine(employee3);
            // יצירת מנהל בעזרת הבנאי של Manager

            // יצירת מנכ"ל (CEO)
            CEO ceo = new CEO("John Doe", DateTime.Now, 20000, "CEO", 100); // כאן הוספנו ערך עבור stockOptions

            // יצירת מנהל
            Manager manager = new Manager("Jane Smith", DateTime.Now, 15000, "Operations Manager");

            // יצירת שומר
            Guard guard = new Guard("Mike Brown", DateTime.Now, 8000, "Night");


            // יצירת מערך של עובדים (Employee)
            Employee[] employees = new Employee[3];

            // הוספת העובדים למערך
            employees[0] = ceo;      // CEO נחשב גם כן לעובד
            employees[1] = manager;  // Manager גם כן יורש מ-Employee
            employees[2] = guard;    // Guard גם כן יורש מ-Employee


            foreach (Employee employee in employees)
            {
                if (employee is CEO)
                {
                    Console.WriteLine($"CEO: {employee}");
                }
                else if (employee is Manager)
                {
                    Console.WriteLine($"Manager: {employee}");
                }
                else if (employee is Guard)
                {
                    Console.WriteLine($"Guard: {employee}");
                }
                else
                {
                    Console.WriteLine($"Employee: {employee}");
                }
            }






        }
    }
}
