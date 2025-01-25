using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_features_SDA
{
    internal class Student : Person
    {
        public DateTime? StartDate { get; set; } 
        public DateTime? EndDate { get; set; } // shtojm ? qe data type t pranoj vleren null
        //public double AverageGrade {  get; set; }
        
        public double? AverageGrade { get; }
        public string PersonalNumber { get; set; }

        public bool HasGraduated
        {
            get
            {

                if (EndDate == null)
                {
                   return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public Teacher PrimaryTeacher { get; set; }
        public void Study()
        {
            Console.WriteLine("I am studying");
        }

        //day 2 excercises for adv features
        public List<StudentSubject> SubjectData { get; private set; } = []; //sa her t krijohet nje instance do inicializohet dhe lista
        public double? GetAverageGrade( List <StudentSubject> SubjectData)
        {
            try
            {
                if (SubjectData.Count == 0)
                {
                    return null;  //mqs kemi vendosur ? tek double? me siper kompilatori e pranon vleren null 
                }

                double sum = 0;
                int counter = 0;
                foreach (StudentSubject subjectData in SubjectData)
                {
                    if (subjectData.Grade < 4 || subjectData.Grade > 10 || subjectData.Grade == null)
                    {
                        throw new Exception("Inconsistent grade");
                    }
                    if (subjectData.Grade > 4)
                    {
                        sum += subjectData.Grade;
                        counter++;
                    }

                }
                if (counter == 0)
                {
                    return null;
                }
                double averageGrade = sum / counter;
                return averageGrade;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<StudentSubject> PassedSubjects()
        {
            var passingSubjects = new List<StudentSubject>(); //nuk mund t jet null sepse e inicializuam ... dmth lista ekziston edhe pse bosh 
            //nqs do ishte me deklarim ateher mund t ishte null
            foreach (StudentSubject studentSubject in SubjectData)
            {
                if (studentSubject.Grade > 4)
                {
                    passingSubjects.Add(studentSubject);
                }
            }
            return passingSubjects;
        }

        public StudentSubject? GetStudentSubject(string subject)
        {
            foreach (StudentSubject studentSubject in SubjectData)
            {
                if (studentSubject.Name == subject)
                {
                    return studentSubject;
                }
            }
            return null;
        }

        public void AddGrade (StudentSubject subjectData)
        {
            if (subjectData.Grade < 4 || subjectData.Grade > 10 || subjectData == null)
            {
                throw new Exception("Invalid grade");
            }
            else if (subjectData.Name == null || subjectData.Credits < 0)
            {
                throw new Exception("Empty subject name or credits");
            }
            var found = false;
            foreach (StudentSubject studentSubject in SubjectData)
            {
                if (studentSubject.Name == subjectData.Name)
                {
                    found = true;
                    Console.WriteLine("Lenda eshte ne liste ");
                    break;
                }
            }
            if (!found)
            {
                SubjectData.Add(subjectData);
            }


        }
    }
}
