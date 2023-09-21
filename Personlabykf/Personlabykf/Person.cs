namespace Personlabykf
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age
        {
            get { return age; }
            set
            {
                // Ensure age is valid
                if (value >= 0 && value <= 122)
                {
                    age = value;
                }
            }
        }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted += id + ": ";
            formatted += firstName + " ";
            formatted += lastName + "'s ";
            //formatted += "Age: " + age + "\n";
            formatted += "favorite color is " + favoriteColor + "\n";
            //formatted += "Is Working: " + isWorking + "\n";

            //formatted = string.Format("ID: {0}\nFirst name: {1}", id, firstName);

            //formatted = $"ID: {id}\n";

            return formatted;
        }
        public void ChangeFavoriteColor()
        {
            favoriteColor = "White";
        }
        public int GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;

            return ageInTenYears;
        }
        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonId:\t" + id + "\n";
            formatted += "FirstName:\t" + firstName + "\n";
            formatted += "LastName:\t" + lastName + "\n";
            formatted += "FavoriteColor:\t" + favoriteColor + "\n";
            formatted += "Age:\t" + age + "\n";
            formatted += "Isworking;" + isWorking + "\n";

            return formatted;
        }
    }
}