using System;
using System.Collections.Generic;
using csharp_burgershack.Models;
using csharp_burgershack.Repositories;


namespace csharp_burgershack.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _burgersRepository;
    public BurgersService(BurgersRepository burgersRepository)
    {
      _burgersRepository = burgersRepository;
    }

    internal IEnumerable<Burger> Get()
    {
      return _burgersRepository.GetAll();
    }

    internal Burger Get(int burgerId)
    {
      Burger burger = _burgersRepository.GetById(burgerId);
      if (burger == null)
      {
        throw new Exception("Invalid Id");
      }
      return burger;
    }

    internal Burger Create(Burger newBurger)
    {
      return _burgersRepository.Create(newBurger);
    }

    internal Burger Edit(Burger editedBurger)
    {
      Burger burger = Get(editedBurger.Id);
      burger.Name = editedBurger.Name != null ? editedBurger.Name : burger.Name;
      burger.Description = editedBurger.Description != null ? editedBurger.Description : burger.Description;
      burger.Price = editedBurger.Price > 0 ? editedBurger.Price : burger.Price;
      return _burgersRepository.Edit(burger);

    }

    internal string Delete(int burgerId)
    {
      Get(burgerId);
      _burgersRepository.Delete(burgerId);
      return "Successfully Deleted";
    }
  }
}