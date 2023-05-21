using Desktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models.Repository
{
  public class DataFileRepository : IDataFileRepository
  {
    private readonly PlanetConfigContext _context;

    public DataFileRepository(PlanetConfigContext context)
    {
      _context = context;
    }
    public IEnumerable<Planet> GetPlanets()
    {
      return _context.Planets;
    }
    
    public IEnumerable<DataFile> GetAllDataFiles()
    {
      return _context.DataFiles;
    }

    public IEnumerable<DataFile> GetDataFilesByPlanetId(long planetId)
    {
      return _context.DataFiles.Where(d => d.PlanetId == planetId);
    }
  }
}
