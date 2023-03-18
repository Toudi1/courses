

using CompanyDemo;

Employe employe1 = new Employe("Doe", "John", 40000);
Boss boss1 = new Boss("Smith", "Dick", 120000, true);
Trainees trainees1 = new Trainees("Nowak", "Jim", 12000, "16-18", "8-15");

employe1.Work();
boss1.Lead();
trainees1.Work();



Console.ReadKey();
