namespace BackEnd.Repositories
{
    public interface IFormRepository
    {
        Task<IEnumerable<Form>> GetAllFormsAsync();
        Task<Form?> GetFormByIdAsync(int id);
        Task AddFormAsync(Form form);
        Task UpdateFormAsync(Form form);
        Task DeleteFormAsync(int id);
    }
}
