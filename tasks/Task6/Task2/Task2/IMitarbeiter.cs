namespace Task2
{
    interface IMitarbeiter
    {
        string Firstname { get; }
        string Lastname { get; }
        int Svn { get; }
        double Salary { get; }
        double Popularity { get; }

        void changeFirstname();
        void changeLastname();
        void promote(double salary);
        void popularityRate(double value);
    }
}