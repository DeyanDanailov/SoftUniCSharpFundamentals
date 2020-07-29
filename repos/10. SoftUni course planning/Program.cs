using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_course_planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> SoftUniSchedule = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "course start")
            {
                List<string> command = input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "Add")
                {
                    string lesson = command[1];
                    AddLesson(SoftUniSchedule, lesson);
                }
                else if (command[0] == "Insert")
                {
                    string lesson = command[1];
                    int index = int.Parse(command[2]);
                    InsertLesson(SoftUniSchedule, lesson, index);
                }
                else if (command[0] == "Remove")
                {
                    string lesson = command[1];
                    RemoveLesson(SoftUniSchedule, lesson);
                }
                else if (command[0] == "Swap")
                {
                    string lesson1 = command[1];
                    string lesson2 = command[2];
                    SwapLessons(SoftUniSchedule, lesson1, lesson2);
                } 
                else if(command[0] == "Exercise")
                {
                    string lesson = command[1];
                    AddExercise(SoftUniSchedule, lesson);
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < SoftUniSchedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{SoftUniSchedule[i]}");
            }


        }
        static List<string> AddLesson(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                return schedule;
            }
            else
            {
                schedule.Add(lesson);
                return schedule;
            }            
        }
        static List<string> InsertLesson(List<string> schedule, string lesson, int index)
        {
            if (schedule.Contains(lesson))
            {
                return schedule;
            }
            else
            {
                schedule.Insert(index, lesson);
                return schedule;
            }
        }
        static List<string> RemoveLesson(List<string> schedule, string lesson)
        {
            int index = schedule.IndexOf(lesson);
            if (schedule.Contains(lesson))
            {
                if (schedule[index+1]==($"{lesson}-Exercise"))
                {
                    schedule.Remove(lesson);
                    schedule.RemoveAt(index + 1);
                    return schedule;
                }
                else
                {
                    schedule.Remove(lesson);
                    return schedule;
                }
            }
            else
            {
                return schedule;
            }
        }
        static List<string> SwapLessons(List<string> schedule, string lesson1, string lesson2)
        {
            if (schedule.Contains(lesson1) && schedule.Contains(lesson2))
            {
                int index1 = schedule.IndexOf(lesson1);
                int index2 = schedule.IndexOf(lesson2);
                if (index1 < index2)
                {                   
                    schedule.Insert(index2, lesson1);
                    schedule.RemoveAt(index1);
                    schedule.Insert(index1, lesson2);
                    schedule.RemoveAt(index2 + 1);
                    if (schedule[index1 + 1] == ($"{lesson1}-Exercise"))
                    {
                        schedule.Insert(index2 + 1, ($"{lesson1}-Exercise"));
                        schedule.RemoveAt(index1 + 1);
                    }
                    if ((index2 + 1 <= schedule.Count - 1) && (schedule[index2 + 1] == ($"{lesson2}-Exercise")))
                    {
                        schedule.Insert(index1 + 1, ($"{lesson2}-Exercise"));
                        schedule.RemoveAt(index2 + 2);
                    }
                }
                else
                {
                    schedule.Insert(index1, lesson2);
                    schedule.RemoveAt(index2);
                    schedule.Insert(index2, lesson1);
                    schedule.RemoveAt(index1 + 1);
                    if (schedule[index2 + 1] == ($"{lesson2}-Exercise"))
                    {
                        schedule.Insert(index1 + 1, ($"{lesson2}-Exercise"));
                        schedule.RemoveAt(index2 + 1);
                    }
                    if ((index1 + 1 <= schedule.Count - 1) && (schedule[index1 + 1] == ($"{lesson1}-Exercise")))
                    {
                        schedule.Insert(index2 + 1, ($"{lesson1}-Exercise"));
                        schedule.RemoveAt(index1 + 2);
                    }
                }
                return schedule;
            }
            else
            {
                return schedule;
            }
        }
        static List<string> AddExercise(List<string> schedule, string lesson)
        {
            int index = schedule.IndexOf(lesson);
            if (schedule.Contains(lesson))
            {
                if (schedule.Contains($"{lesson}-Exercise"))
                {
                    return schedule;
                }
                else
                {
                    schedule.Insert(index + 1, ($"{lesson}-Exercise"));
                    return schedule;
                }
            }
            else
            {
                schedule.Add(lesson);
                schedule.Add($"{lesson}-Exercise");
                return schedule;
            }
        }
    }
}
