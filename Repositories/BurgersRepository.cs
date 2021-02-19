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

    internal Burger GetById(int burgerId)
    {
      string sql = "SELECT * FROM burgers WHERE Id = @burgerId;";
      return _db.QueryFirstOrDefault<Burger>(sql, new { burgerId });
    }

    internal Burger Create(Burger newBurger)
    {
      string sql = @"
        INSERT INTO burgers
        (name, description, price)
        VALUES
        (@Name, @Description, @Price);
        SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newBurger);
      newBurger.Id = id;
      return newBurger;
    }

    internal Burger Edit(Burger burger)
    {
      string sql = @"
        UPDATE burgers
        SET description = @Description, price = @Price
        WHERE id = @Id;
        SELECT * FROM burgers WHERE id = @Id;";
      return _db.QueryFirstOrDefault<Burger>(sql, burger);
    }

    internal void Delete(int burgerId)
    {
      string sql = "DELETE FROM burgers WHERE id = @burgerId LIMIT 1";
      _db.Execute(sql, new { burgerId });
    }
  }
}