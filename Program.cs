using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTTSASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[100];
            string fname = null, lname = null;
            string[] dob = new string[100];
            string[] regNo = new string[100];
            string[] course = new string[100];
            float[] adFee = new float[100];
            int[] mNum = new int[100];
            int[] adId = new int[100];
            int admFee, adNum = 1000;
            float tFee = 0.0F;
            string Course = null;
            string uname = null;
            string password = null;
            string reg = null;
            bool stats = true;
            int status = 1, choice, i;
            do
            {
                Console.Write("\nEnter the user name: ");
                uname = Console.ReadLine();
                Console.Write("Enter the password: ");
                password = Console.ReadLine();
                if (uname != "ABC" || password != "123")
                {
                    Console.WriteLine("Validating.......");
                    Thread.Sleep(500);
                    Console.WriteLine("Invalid username and password");
                    status++;
                }
            } while (status <= 3 && password != "password");
            if (uname == "ABC" && password == "abc@")
            {
                Console.WriteLine("\n\t----------> Student Information <----------");
                Console.Write("\n\tEnter no of Students: ");
                int n = int.Parse(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n\t\t\t\tStudent.{i + 1} details: ");
                    Console.Write("\n\tEnter the First Name: ");
                    fname = Console.ReadLine();
                    Console.Write("\tEnter the Last Name: ");
                    lname = Console.ReadLine();
                    name[i] = fname + " " + lname;
                    Console.Write("\tEnter DOB(DD-MM-YYYY): ");
                    dob[i] = Console.ReadLine();
                    if (i == 0)
                    {
                        Console.Write("\tEnter REG NO.: ");
                        reg = Console.ReadLine();
                        regNo[i] = reg;
                    }
                    else
                    {
                        do
                        {
                            Console.Write("\tEnter REG NO.: ");
                            reg = Console.ReadLine();
                            for (int j = 0; j < i; j++)
                            {
                                if (reg != regNo[j])
                                    { regNo[i] = reg; stats = true; break;}
                                else
                                    Console.WriteLine("\tREG NO is already in exist...!!"); stats = false;
                            }
                        } while (!stats);
                    }
                    Console.Write("\tEnter Course: ");
                    course[i] = Console.ReadLine();
                    Console.Write("\tEnter admission Fee: ");
                    admFee = int.Parse(Console.ReadLine());
                    adFee[i] = admFee + (admFee * 0.18F);
                    Console.Write("\tEnter Your Mobile Number: ");
                    mNum[i] = int.Parse(Console.ReadLine());
                    adId[i] = adNum + 1;

                }
                do
                {
                    Console.WriteLine("\n\t\t******* Student Information ******");
                    Console.WriteLine("\n\t1.Display all Students names");
                    Console.WriteLine("\t2.Show total admission fees");
                    Console.WriteLine("\t3.Search student by course");
                    Console.WriteLine("\t4.EXIT");
                    Console.Write("\nEnter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\n  StudentName | DOB | REG No | Course | AdmissionFees | MobileNumber | Admission-ID\n");
                            for (i = 0; i < n; i++)
                            {
                                Console.WriteLine($"  {name[i]}\t| {dob[i]} |\t {regNo[i]}\t|\t {course[i]}\t|\t {adFee[i]} \t| {mNum[i]} \t|\t {adId[i]}");
                            }
                            break;
                        case 2:
                            for (i = 0; i < n; i++)
                            {
                                tFee = tFee + adFee[i];
                            }
                            Console.WriteLine($"\n------------- Total admission fee: {tFee}");
                            break;
                        case 3:
                            Console.Write("\n\tEnter course: ");
                            Course = Console.ReadLine();
                            for (i = 0; i < n; i++)
                            {
                                if (course[i] == Course)
                                {
                                    Console.WriteLine($"\t\t{i + 1}. {name[i]}");
                                }
                            }
                            break;
                        case 4: Console.WriteLine("\n\t\t\t.............Exiting Application............."); break;
                        default: Console.WriteLine("\n\t...........Invalid Input, Returning to main menu............."); Thread.Sleep(1000); break;
                    }

                } while (choice != 4);
            }
            else
                Console.WriteLine("\n\t------------->>> PLEASE TRY AGAIN LATER <<<-------------");
        }
    }
}
