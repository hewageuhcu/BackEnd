using BackEnd.Repositories;

namespace BackEnd.Services
{
    public class FormService : IFormService
    {
        private readonly IFormRepository _formRepository;

        public FormService(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<IEnumerable<Form>> GetAllFormsAsync()
        {
            return await _formRepository.GetAllFormsAsync();
        }

        public async Task<Form?> GetFormByIdAsync(int id)
        {
            return await _formRepository.GetFormByIdAsync(id);
        }

        public async Task AddFormAsync(Form form)
        {
            await _formRepository.AddFormAsync(form);
        }

        public async Task UpdateFormAsync(Form form)
        {
            await _formRepository.UpdateFormAsync(form);
        }

        public async Task DeleteFormAsync(int id)
        {
            await _formRepository.DeleteFormAsync(id);
        }
    }
}
