using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repositories
{
    public class FormRepository : IFormRepository
    {
        private readonly AppDbContext _context;

        public FormRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Form>> GetAllFormsAsync()
        {
            return await _context.Forms.ToListAsync();
        }

        public async Task<Form?> GetFormByIdAsync(int id)
        {
            return await _context.Forms.FindAsync(id);
        }

        public async Task AddFormAsync(Form form)
        {
            await _context.Forms.AddAsync(form);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFormAsync(Form form)
        {
            _context.Forms.Update(form);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFormAsync(int id)
        {
            var form = await GetFormByIdAsync(id);
            if (form != null)
            {
                _context.Forms.Remove(form);
                await _context.SaveChangesAsync();
            }
        }
    }

}
