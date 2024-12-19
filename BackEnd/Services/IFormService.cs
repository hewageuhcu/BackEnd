namespace BackEnd.Services
{
    public interface IFormService
    {
        Task<IEnumerable<Form>> GetAllFormsAsync();
        Task<Form?> GetFormByIdAsync(int id);
        Task AddFormAsync(Form form);
        Task UpdateFormAsync(Form form);
        Task DeleteFormAsync(int id);
    }

}

