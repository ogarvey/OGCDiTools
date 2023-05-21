using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Interfaces
{
  public interface IDataFileRepository
  {
    IEnumerable<Planet> GetPlanets();
    IEnumerable<DataFile> GetAllDataFiles();
    IEnumerable<DataFile> GetDataFilesByPlanetId(long planetId);
  }
}
