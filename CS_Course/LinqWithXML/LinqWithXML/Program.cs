using System.Xml.Linq;


// We simply apply our Student - Structure to XML

string studentXML =
    @" <Students>
<Student>
<Name>Toni</Name>
<Age>21</Age>
<University>Yale</University>
<Semester>VI</Semester>
</Student>
<Student>
<Name>Carla</Name>
<Age>17</Age>
<University>Yale</University>
<Semester>II</Semester>
</Student>
<Student>
<Name>Leyla</Name>
<Age>19</Age>
<University>Beijing Tech</University>
<Semester>IV</Semester>
</Student>
</Students>";

XDocument studentsXdoc = new XDocument();
studentsXdoc = XDocument.Parse(studentXML);


var students = from student in studentsXdoc.Descendants("Student")
               select new
               {
                   Name = student.Element("Name").Value,
                   Age = student.Element("Age").Value,
                   University = student.Element("University").Value,
                   Semester = student.Element("Semester").Value
               };

foreach (var student in students)
{
    Console.WriteLine("Student {0} of age {1} attends {2} semester on {3} semester", student.Name, student.Age, student.University, student.Semester);
}

var studentsSorted = from student in students
                     orderby student.Age select student;

foreach (var student in studentsSorted)
{
    Console.WriteLine("Student {0} of age {1} attends {2} on {3} semester", student.Name, student.Age, student.University, student.Semester);
}

Console.ReadKey();

