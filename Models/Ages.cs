namespace WebAgeApp.Models
{
    public class Ages
    {
        public DateTime? Birthdate { get; set; }
        public string Age
        {
            get
            {
                string result = string.Empty;
                if (Birthdate != null)
                {
                    //TimeSpan age = DateTime.Now.Subtract(Birthdate.Value);
                    //int Totaldays = age.Days;
                    //int years = Totaldays / 365;
                    //Totaldays = Totaldays % 365;
                    //int months = Totaldays / 30;
                    //Totaldays = Totaldays % 30;

                    DateTime current = DateTime.Now;
                    int days = current.Day - Birthdate.Value.Day;
                    if (days > 0)
                        current = current.AddDays(-Birthdate.Value.Day);

                    int months = current.Month - Birthdate.Value.Month;
                    if (months > 0)
                        current = current.AddMonths(-Birthdate.Value.Month);

                    int years = current.Year - Birthdate.Value.Year;

                    if (days < 0)
                    {
                        days = 31 + days;
                        months-=1;
                    }
                    if (months < 0)
                    {
                        months = 12 + months;
                        years -= 1;
                    }

                    result = string.Format("{0} years {1} months {2} days", years, months, days);
                }
                return result;
            }
        }
    }
}
