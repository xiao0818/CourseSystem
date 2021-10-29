﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class CourseInfo
    {
        public CourseInfo(string number , string name, string stage, string credit, string hour, string courseType, string teacher,
            string classTime0, string classTime1, string classTime2, string classTime3, string classTime4, string classTime5, string classTime6, string classroom,
            string numberOfStudent, string numberOfDropStudent, string teachingAssistant, string language, string outline, string note, string attachStudent, string experiment)
        {
            this.Number = number;
            this.Name = name;
            this.Stage = stage;
            this.Credit = credit;
            this.Hour = hour;
            this.CourseType = courseType;
            this.Teacher = teacher;
            this.ClassTime0 = classTime0;
            this.ClassTime1 = classTime1;
            this.ClassTime2 = classTime2;
            this.ClassTime3 = classTime3;
            this.ClassTime4 = classTime4;
            this.ClassTime5 = classTime5;
            this.ClassTime6 = classTime6;
            this.Classroom = classroom;
            this.NumberOfStudent = numberOfStudent;
            this.NumberOfDropStudent = numberOfDropStudent;
            this.TeachingAssistant = teachingAssistant;
            this.Language = language;
            this.Outline = outline;
            this.Note = note;
            this.AttachStudent = attachStudent;
            this.Experiment = experiment;
        }

        //GetCourseInfoString
        public string[] GetCourseInfoString
        {
            get
            {
                return new string[]
                {
                    Number, Name, Stage, Credit, Hour, CourseType, Teacher,
                    ClassTime0, ClassTime1, ClassTime2, ClassTime3, ClassTime4, ClassTime5, ClassTime6, Classroom,
                    NumberOfStudent, NumberOfDropStudent, TeachingAssistant, Language, Outline, Note, AttachStudent, Experiment
                };
            }
        }

        //GetCourseClassTime
        public List<Tuple<int, string>> GetCourseClassTime()
        {
            const int DAY_PER_WEEK = 7;
            List<Tuple<int, string>> classTime = new List<Tuple<int, string>>();
            for (int day = 0; day < DAY_PER_WEEK; day++)
            {
                string[] dayToClassString = new string[] { ClassTime0, ClassTime1, ClassTime2, ClassTime3, ClassTime4, ClassTime5, ClassTime6 };
                string classString = dayToClassString[day];
                if (classString != "")
                {
                    const char SEPARATOR = ' ';
                    string[] classTimeChars = classString.Split(SEPARATOR);
                    foreach (string classTimeChar in classTimeChars)
                    {
                        classTime.Add(new Tuple<int, string>(day, classTimeChar));
                    }
                }
            }
            return classTime;
        }

        public string Number
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Stage
        {
            get; set;
        }

        public string Credit
        {
            get; set;
        }

        public string Hour
        {
            get; set;
        }

        public string CourseType
        {
            get; set;
        }

        public string Teacher
        {
            get; set;
        }

        public string ClassTime0
        {
            get; set;
        }

        public string ClassTime1
        {
            get; set;
        }

        public string ClassTime2
        {
            get; set;
        }

        public string ClassTime3
        {
            get; set;
        }

        public string ClassTime4
        {
            get; set;
        }

        public string ClassTime5
        {
            get; set;
        }

        public string ClassTime6
        {
            get; set;
        }

        public string Classroom
        {
            get; set;
        }

        public string NumberOfStudent
        {
            get; set;
        }

        public string NumberOfDropStudent
        {
            get; set;
        }

        public string TeachingAssistant
        {
            get; set;
        }

        public string Language
        {
            get; set;
        }

        public string Outline
        {
            get; set;
        }

        public string Note
        {
            get; set;
        }

        public string AttachStudent
        {
            get; set;
        }

        public string Experiment
        {
            get; set;
        }
    }
}
