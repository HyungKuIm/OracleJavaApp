using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OracleJavaViews.ViewModels
{
    public class ViewCalendarViewModel : BindableBase
    {
        private int lastDate;  // 그달의 마지막날
        private int startYoil;  // 시작하는 요일(0:일, 1:월... 6:토)
        //private List<int> _days = Enumerable.Range(1, 30).ToList(); // 6월은 30일까지라고 했지!
        private List<int> _days;

        private int year;  // 현재 년도
        private int month; // 현재 월

        public List<int> Days
        { 
            get { return _days; } 
            set { SetProperty(ref _days, value); }
        }

        public int StartYoil
        {
            get { return startYoil; }
            set { SetProperty(ref startYoil, value); }
        }

        public ViewCalendarViewModel()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;

            DateTime firstDayInMonth = new DateTime(year, month, 1);
            startYoil = (int)firstDayInMonth.DayOfWeek; //(0:일, 1:월... 6:토)
            lastDate = DateTime.DaysInMonth(year, month);
            Days = Enumerable.Range(1, lastDate).ToList();
        }
    }
}
