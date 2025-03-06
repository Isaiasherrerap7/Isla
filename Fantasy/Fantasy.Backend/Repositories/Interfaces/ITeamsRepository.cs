﻿using Fantasy.Shared.DTOs;
using Fantasy.Shared.Entities;
using Fantasy.Shared.Responses;

namespace Fantasy.Backend.Repositories.Interfaces;

public interface ITeamsRepository
{
    // Es la clave foránea que relaciona un equipo con un país.
    Task<IEnumerable<Team>> GetComboAsync(int countryId);

    Task<ActionResponse<Team>> AddAsync(TeamDTO teamDTO);

    Task<ActionResponse<Team>> UpdateAsync(TeamDTO teamDTO);

    Task<ActionResponse<Team>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Team>>> GetAsync();

    Task<ActionResponse<IEnumerable<Team>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}