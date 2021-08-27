using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.IRepository
{
  public interface IRepository<T> where T : class
  {
    bool Insert(List<T> entry);

    T Update();

    List<T> Select();

    bool Delete();
  }
}