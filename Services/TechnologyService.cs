using DevTrack.Data;
using DevTrack.DTOs;
using DevTrack.Interfaces;
using Microsoft.EntityFrameworkCore;
using DevTrack.Models;

namespace DevTrack.Services;

public class TechnologyService : ITechnologyService
{
    private readonly AppDbContext _context;

    public TechnologyService(AppDbContext context)
    {
        _context = context;
    }

    public Task<TechnologyResponseDto> CreateAsync(TechnologyCreateDto technologyDto)
    {
        throw new NotImplementedException();
    }

    public Task<TechnologyResponseDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(int id, TechnologyUpdateDto technologyDto)
    {
        throw new NotImplementedException();
    }
    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    // Implementa o método GetAllAsync para retornar todas as tecnologias
    public async Task<IEnumerable<TechnologyResponseDto>> GetAllAsync()
    {
        // _context.Technologies é a tabela de tecnologias no banco de dados, seria igual ao SELECT * FROM Technologies
        return await _context.Technologies
            // Select é usado para projetar cada entidade Technology em um objeto TechnologyResponseDto
            .Select(t => new TechnologyResponseDto
            {
                Id = t.Id,
                Name = t.Name,
                Category = t.Category,
                LearningStatus = t.LearningStatus,
                StartedAt = t.StartedAt
            })
            .ToListAsync();
    }
}