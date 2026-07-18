using DevTrack.DTOs;

namespace DevTrack.Interfaces;

public interface ITechnologyService
{
    Task<IEnumerable<TechnologyResponseDto>> GetAllAsync();

    Task<TechnologyResponseDto?> GetByIdAsync(int id);

    Task<TechnologyResponseDto> CreateAsync(TechnologyCreateDto technologyDto);

    Task<bool> UpdateAsync(int id, TechnologyUpdateDto technologyDto);

    Task<bool> DeleteAsync(int id);
}
