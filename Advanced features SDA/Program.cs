using Advanced_features_SDA;

//Person personi1 = new Person
//{
//       Name = "Filan",
//       Surname = "Fisteku",
//       Birthday = new DateTime(2000, 2, 16),
//       Gender = 'M'
//};


////Console.WriteLine($"Full Name: {personi1.FullName}");
////Console.WriteLine($"Age is: {personi1.Age}");



//Student studenti1 = new Student
//{
//    AverageGrade = 8.7,
//    Name = "John",
//    Surname = "Doe",
//    //me pas e zem se teacher1 esht primary teacher i student1-- lidhjen e bejm si m posht
//    PrimaryTeacher = new Teacher
//    {
//        Name = "Jane",
//        Surname = "Doe",
//        Subject = "Physics"
//    }
//};


////Console.WriteLine($"Full name: {studenti1.FullName}"); // edhe pse esht read only mund t "aksesohet" edhe nga klasat qe e kan inheritance
////Console.WriteLine($"Fullname of Primary Teacher: {studenti1.PrimaryTeacher.FullName}");

//Teacher teacher1 = new Teacher
//{
//    Name = "Jane",
//    Surname = "Doe",
//    Subject = "Physics"
//};

//studenti1.Study();
//studenti1.Greet();
//studenti1.PrimaryTeacher.Explain();
//studenti1.PrimaryTeacher.Greet();










//Ushtrimi dita 2 kur shtuam grades dhe llogaritjen e avg grade
//testojm each case
//Student studenti1 = new Student
//{
//    Grades = {7 , 8 , 10 , 5 ,6}
//};
//Console.WriteLine("Mesatarja e studenti1 eshte: " +studenti1.AverageGrade);

//Student studenti2 = new Student
//{
//    Grades = { 7, 4, 10, 5, 6 }
//};
//Console.WriteLine("Mesatarja e studenti2 eshte: " + studenti2.AverageGrade);

//Student studenti3 = new Student
//{
//    Grades = { 4, 4, 4 ,4, 4}
//};
//Console.WriteLine("Mesatarja e studenti3 eshte: " + studenti3.AverageGrade);

//Student studenti4 = new Student
//{
//    Grades = { }
//};
//Console.WriteLine("Mesatarja e studenti4 eshte: " + studenti4.AverageGrade);


//Pasi kemi krijuar 2 klasa SubjectBase dhe StudentSubject qe trashegon nga ajo dhe kete te fundit
//e vendosim si property te klasa Student
Student studenti1 = new Student()
{
    Name = "Andi"
};

var subject = new StudentSubject()
{
    Name = "Hyrje ne Informatike",
    Credits = 7,
    Grade = 9
};
studenti1.AddGrade(subject);

foreach (var item in studenti1.SubjectData)
{
    Console.WriteLine(studenti1.Name +" " +subject.Name + " " + subject.Credits + " " + subject.Grade);
}






