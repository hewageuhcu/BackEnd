using BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FormController : ControllerBase
{
    private readonly IFormService _formService;

    public FormController(IFormService formService)
    {
        _formService = formService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllForms()
    {
        var forms = await _formService.GetAllFormsAsync();
        return Ok(forms);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFormById(int id)
    {
        var form = await _formService.GetFormByIdAsync(id);
        if (form == null)
            return NotFound();
        return Ok(form);
    }

    [HttpPost]
    public async Task<IActionResult> AddForm([FromBody] Form form)
    {
        await _formService.AddFormAsync(form);
        return CreatedAtAction(nameof(GetFormById), new { id = form.Id }, form);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateForm(int id, [FromBody] Form form)
    {
        if (id != form.Id)
            return BadRequest();

        await _formService.UpdateFormAsync(form);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteForm(int id)
    {
        await _formService.DeleteFormAsync(id);
        return NoContent();
    }
}
