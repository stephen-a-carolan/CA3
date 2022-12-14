namespace CA3.Server.Birth_day_info
{
    public interface IBirthdayServise
    {
        void AddBirthday(BirthdayItem birthdayItem);
        void DeleteBirthday(BirthdayItem birthdayItem);
        void UpdateBirthday(BirthdayItem birthdayItem);
        Task<List<BirthdayItem>> GetBirthdays();
    }
}
