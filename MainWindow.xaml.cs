﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LectureDatePickerTime
{//EDNA LYNN LAXA
 //MARCH 3, 2023 
 //CSI PROGRAMMING II 
 //DATE PICKER & DATE TIME LECTURE 


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int ageToDrive = 16;
        const int ageToVote = 18;
        const int ageToDrink = 21; 
        public MainWindow()
        {
            InitializeComponent();

            BlogPost bp = new BlogPost("Header 1", "Body 1");
            runDisplay.Text = bp.ToString(); 
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime bday = BirthdayObject(); 

            runDisplay.Text = $"Your Birthday is {bday}";

        }
        public DateTime BirthdayObject()
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);

            DateTime birthday = new DateTime(year, month, day);

            return new DateTime(year, month, day);

            
            

        }
        
        public void examples()
        {
            DateTime date = new DateTime();
            DateTime now = DateTime.Now;

            string shortTime = now.ToShortTimeString();
            string longTime = now.ToLongTimeString();

            string formatString = $"" +
                $"Short Time: {shortTime} \n" +
                $"Long Time: {longTime}\n" +
                $"Short Day: {now.ToShortDateString()}\n" +
                $"Long Date: {now.ToLongDateString()}\n" +
                $"Year: {now.Year}\n" +
                $"Day of the week: {now.DayOfWeek}";

            DateTime add7months = now.AddMonths(7);

            TimeSpan differenceInDaysfor7Months = add7months - now;

            runDisplay.Text = (differenceInDaysfor7Months.Days / 365.0).ToString();

            //runDisplay.Text = formatString;
        }

        private void btnEligibility_Click(object sender, RoutedEventArgs e)
        {
            DateTime bday = BirthdayObject();
            DateTime now = DateTime.Now;

            TimeSpan ageInDays = now - bday;

            int age = (int)(ageInDays.Days / 365.0);

            runDisplay.Text = $"You are {age.ToString()} years old\n ";

            if (age >= ageToDrive)
            {
                runDisplay.Text += "*You are old enough to drive \n";
            }
            if (age >= ageToVote)
            {
                runDisplay.Text += "*You are old enough to vote \n";
            }
            if (age >= ageToDrink)

            {
                runDisplay.Text += "*You are old enough to drink \n";
            }
        }

        private void btnResults_Click(object sender, RoutedEventArgs e)
        {
            //DateTime selectedDate = dpDate.SelectedDate.Value; //For date picker 
            //DateTime selectedDate = CalDate.SelectedDate.HasValue;//<-- Redlined. 

            bool calendarDateSelected = CalDate.SelectedDate.HasValue;
            DateTime timeSelected = DateTime.Now; 

            //If a time is selected, replace time now with selected time. 
           if (calendarDateSelected)
            {
                //runDisplay.Text = CalDate.SelectedDate.Value.ToShortDateString();
                timeSelected = CalDate.SelectedDate.Value;
            }
            runDisplay.Text = timeSelected.ToString();


            //else
            //{
            //    runDisplay.Text = "Please select a date"; 
            //}


            //runDisplay.Text = selectedDate.ToString();
        }
    }
    //QUESTIONS: 
    //What does a DateTime object represent(in terms of time )
    //ANSWER : Present an instant of time which will present itself in date & time of day . 

    //What does TimeSpan describe(in terms of time )
    //ANSWER: TimeSpan represents a time interval (duration of time). 

    //How do you get the time RIGHT NOW with DateTime?
    //ANSWER: DateTime.Now 

    //What kind of math do you have to do to get the result in years with TimeSpan?
    //ANSWER: /365.0 
    
    //If given a DateTime object of 01/01/2023 and another with 01/01/2023, get a TimeSpan and do the math to get a result of 13
    //ANSWER: 

    //What is the key difference between the DatePicker and the Calander(similar to the combo box and list box)
    //ANSWER: DatePicker allows to display calendar and pick date by selecting the drop menu. Calendar is an image of the calendar itself and just like date picker, you can select a date. 

    //DatePicker and Calander have two important properties, which are they
    //Property 1: You use it to get the users selected value from the time picker
    //Property 2: You use this to make sure the time picker has a selected value

    //ANSWER: 
}
