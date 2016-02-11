using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MethodClassList {
    class Program {
        static void NameAgeState(string name, string age, string state) {
            Console.WriteLine("Name: {0} Age: {1} State: {2}", name, age, state);
        }

        static string[] AlphaSplitter(string words) {
            Regex rgx = new Regex("[^a-zA-Z ]");
            words = rgx.Replace(words, "");

            string[] wordsArray = words.Split();
            Array.Sort(wordsArray);
            return wordsArray;
        }

        static void TopStudent() {
            Console.Write("Enter the first Student's name: ");
            string student1 = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades in a range of A+ and F.");
            string[] student1Grades = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };

            Console.Write("Enter the second Student's name: ");
            string student2 = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades in a range of A+ and F.");
            string[] student2Grades = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };

            double[] student1NumGrade = new double[3];
            double[] student2NumGrade = new double[3];

            for (int i = 0; i < 3; i++) {
                switch (student1Grades[i]) {
                    case "A+":
                        student1NumGrade[i] = 4.0;
                        break;
                    case "A":
                        student1NumGrade[i] = 4.0;
                        break;
                    case "A-":
                        student1NumGrade[i] = 3.75;
                        break;
                    case "B+":
                        student1NumGrade[i] = 3.5;
                        break;
                    case "B":
                        student1NumGrade[i] = 3.0;
                        break;
                    case "B-":
                        student1NumGrade[i] = 2.75;
                        break;
                    case "C+":
                        student1NumGrade[i] = 2.50;
                        break;
                    case "C":
                        student1NumGrade[i] = 2.0;
                        break;
                    case "C-":
                        student1NumGrade[i] = 1.75;
                        break;
                    case "D+":
                        student1NumGrade[i] = 1.5;
                        break;
                    case "D":
                        student1NumGrade[i] = 1.0;
                        break;
                    case "D-":
                        student1NumGrade[i] = 0.75;
                        break;
                    case "F":
                        student1NumGrade[i] = 0.0;
                        break;
                    default:
                        Console.WriteLine("Invalid grade entered. Press any key to continue.");
                        Console.ReadKey();
                            return;
                }
            }

            for (int i = 0; i < 3; i++) {
                switch (student2Grades[i]) {
                    case "A+":
                        student2NumGrade[i] = 4.0;
                        break;
                    case "A":
                        student2NumGrade[i] = 4.0;
                        break;
                    case "A-":
                        student2NumGrade[i] = 3.75;
                        break;
                    case "B+":
                        student2NumGrade[i] = 3.5;
                        break;
                    case "B":
                        student2NumGrade[i] = 3.0;
                        break;
                    case "B-":
                        student2NumGrade[i] = 2.75;
                        break;
                    case "C+":
                        student2NumGrade[i] = 2.50;
                        break;
                    case "C":
                        student2NumGrade[i] = 2.0;
                        break;
                    case "C-":
                        student2NumGrade[i] = 1.75;
                        break;
                    case "D+":
                        student2NumGrade[i] = 1.5;
                        break;
                    case "D":
                        student2NumGrade[i] = 1.0;
                        break;
                    case "D-":
                        student2NumGrade[i] = 0.75;
                        break;
                    case "F":
                        student2NumGrade[i] = 0.0;
                        break;
                    default:
                        Console.WriteLine("Invalid grade entered. Press any key to continue.");
                        Console.ReadKey();
                        return;
                }
                double student1Average = (student1NumGrade[0] + student1NumGrade[1] + student1NumGrade[2]) / 3;
                double student2Average = (student2NumGrade[0] + student2NumGrade[1] + student2NumGrade[2]) / 3;
                if (student1Average > student2Average) {
                    Console.WriteLine("{0} has the better grade with a grade average of {1}",student1,student1Average);
                } else {
                    Console.WriteLine("{0} has the better grade with a grade average of {1}", student2, student2Average);
                }

            }
        }

        static string SobrietyTest() {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            for (int i = alphabet.Length - 1; i >= 0; i--) {
                sb.Append(alphabet[i]);
            }

            string reverseAlphabet = sb.ToString();
            return reverseAlphabet;
        }

        static string Username(string name, string phone) {
            string username = name + "" + phone;
            return username;
        }

        static string ValidName(string firstName, string lastName) {
            Regex regex = new Regex(@"^[A-Za-z]+$");
            Match matchFirstName = regex.Match(firstName);
            Match matchLastName = regex.Match(lastName);
        
            if (matchFirstName.Success && matchLastName.Success) {
                return firstName + " " + lastName;
            } else {
                Console.WriteLine("Please try again.");
                Console.WriteLine(ValidName(Console.ReadLine(), Console.ReadLine()));
                return "";
            }
        
        }

        static double LostMyTeeth(double age) {
            double avgTeethLostPerYear = 52 / 78; //US life expectancy divided by 20 childhood teeth plus 32 adult teeth
            double teethLost = age * avgTeethLostPerYear; //average amount of teeth lost by age given... Note: this is some ghetto math. I'm not a data scientist :'( (Maybe one day)
            return teethLost;
        }

        static double CircleArea(double r) {
            double area = Math.PI * r * r;
            return area;
        }

        static int? numberCheck(string intCheck) {
            int checkNum;
            bool result = int.TryParse(intCheck, out checkNum);
            if (result) {
                return checkNum;
            } else {
                Console.WriteLine("Invalid Number");
                return null;
            }
        }

        static void CountdownTimer() {
            Console.WriteLine("Set the countdown timer using only seconds\nAlternatively use a day:hour:minute:second format.\nFor example: 01:23:06:59, 00:00:00:05 or 5234:00:00:01\n(Yes, five thousand two hundred thirty four days)");
            string stringTimer = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            long days = 0;
            long hours = 0;
            long minutes = 0;
            long seconds= 0;
            long userTimer = 0;
            Console.WriteLine($"Console: stringTimer: {stringTimer} days: {days} hours: {hours} minutes: {minutes} seconds: {seconds}");
            bool result = long.TryParse(stringTimer, out userTimer);
            if (result) {
                if (userTimer >= 86400) {
                    days = userTimer / 86400;
                    userTimer %= 86400;
                    hours = userTimer / 3600;
                    userTimer %= 3600;
                    minutes = userTimer / 60;
                    seconds = userTimer % 60;
                } else if (userTimer >= 3600) {
                    days = 0;
                    hours = userTimer / 3600;
                    userTimer %= 3600;
                    minutes = userTimer / 60;
                    seconds = userTimer % 60;
                } else if (userTimer >= 60) {
                    days = 0;
                    hours = 0;
                    minutes = userTimer / 60;
                    seconds = userTimer % 60;
                } else {
                    days = 0;
                    hours = 0;
                    minutes = 0;
                    seconds = userTimer;
                }
                //Formatting unformatted timer entry
                stringTimer = formattingForCountdown(days, hours, minutes, seconds);
            } else { //Moar validation to see if you used the (00)?:00:00:00 format
                Regex regex = new Regex(@"^\d+:\d\d:\d\d:\d\d$");
                Match match = regex.Match(stringTimer);
                if (match.Success) {
                    //Cool, you passed validation.
                } else {
                    Console.WriteLine("Invalid format. Please try again. Press any key to continue. . ."); //You didn't pass :'(
                    Console.ReadKey();
                    Console.Clear();
                    CountdownTimer();
                }
            }
            string[] timerFormat = stringTimer.Split(':'); //Spliting the timer string into an array for easy parsing. Index 0 being days and so on
            days = long.Parse(timerFormat[0]);
            hours = long.Parse(timerFormat[1]);
            minutes = long.Parse(timerFormat[2]);
            seconds = long.Parse(timerFormat[3]);
            Console.WriteLine($"Console: stringTimer: {stringTimer} days: {days} hours: {hours} minutes: {minutes} seconds: {seconds}");
            if (seconds >= 60) { //possible formatting cleanup. 60 seconds converted to 1 minute, 60 minutes to 1 hours, etc.
                minutes++;
                seconds %= 60;
            }
            if (minutes >= 60) {
                hours++;
                minutes %= 60;
            }
            if (hours >= 24) { //ugh... have to do this one differently. Some user (and i know it'll happen) will enter 99 hours
                days += hours/24;
                hours %= 24;
            }
            Console.WriteLine($"Console: {days}{hours}{minutes}{seconds}");
            stringTimer = formattingForCountdown(days, hours, minutes, seconds);
            Console.WriteLine(stringTimer);
            Console.WriteLine("Press any key to begin the countdown");
            Console.ReadKey();
            for (long i = seconds; seconds >= 0; seconds--) { //Here we go
                if (seconds == -1) {
                    if(minutes != 0) {
                        seconds = 59;
                        minutes--;
                    } else if (hours != 0) {
                        minutes = 59;
                        seconds = 59;
                        hours--;
                    } else if (days != 0) {
                        hours = 23;
                        minutes = 59;
                        seconds = 59;
                        days--;
                    } else {
                        break;
                    }
                }
                Console.Clear();
                stringTimer = formattingForCountdown(days, hours, minutes, seconds);
                Console.WriteLine(stringTimer);
                Thread.Sleep(1000);
            }
        }
        static string formattingForCountdown(long days, long hours, long minutes, long seconds) { //I broke down and made a method for my method
            StringBuilder sb = new StringBuilder();
            sb.Append(days);
            sb.Append(':');
            if (hours >= 10) {
                sb.Append(hours);
                sb.Append(':');
            } else {
                sb.Append('0');
                sb.Append(hours);
                sb.Append(':');
            }

            if (minutes >= 10) {
                sb.Append(minutes);
                sb.Append(':');
            } else {
                sb.Append('0');
                sb.Append(minutes);
                sb.Append(':');
            }

            if (seconds >= 10) {
                sb.Append(seconds);
            } else {
                sb.Append('0');
                sb.Append(seconds);
            }
            return sb.ToString();
        }

        static void FamilyGuy() {
            string[] characters = { "Peter", "Lois", "Meg", "Brian", "Stewie", "Chris", "Glenn", "Cleveland", "Loretta", "God", "Jesus", "Hewbert" };
            foreach(string character in characters) {
                Console.WriteLine(character);
            }
        }

        static void PrintArray(string[] arr) {
            foreach(string arrays in arr) {
                Console.WriteLine(arrays);
            }
        }

        static void BuildHouse() {

        }

        static string ProperName(string name) {
            string[] nameSplit = name.Split();
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            foreach (string names in nameSplit) {
                sb.Append(char.ToUpper(names[0]));
                for (int i = 1; i < names.Length; i++) {
                    sb.Append(names[i]);
                }
                if (counter == 0)
                    sb.Append(" ");
                counter++;
            }
            return sb.ToString();
        }

        static void Main(string[] args) {
            CountdownTimer();
        }
    }
}
