using System;
using System.Collections.Generic;
using System.Data;
using csharp_burgershack.Models;
using Dapper;

namespace csharp_burgershack.Repositories
{
  public class BurgersRepository
  {
    private readonly IDbConnection _db;

    public BurgersRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Burger> GetAll()
    {
      string sql = "SELECT * FROM burgers;";
      return _db.Query<Burger>(sql);
    }

    internal Burger GetById()
    {
      throw new NotImplementedException();
    }

    internal Burger Create(Burger newBurger)
    {
      throw new NotImplementedException();
    }

    internal Burger Edit(Burger burger)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int burgerId)
    {
      throw new NotImplementedException();
    }
  }
}