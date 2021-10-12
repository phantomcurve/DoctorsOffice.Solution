using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;

namespace DoctorsOffice.Controllers
{
  public class SpecialtiesController : Controller
  {
    private readonly DoctorsOfficeContext _db;

    public SpecialtiesController(DoctorsOfficeContext db)
    {
      _db = db;
    }

   public ActionResult Index()
  {
      return View(_db.Specialties.ToList());
  }

  public ActionResult Create()
  {
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View();
  }

  [HttpPost]
  public ActionResult Create(Specialty specialty, int DoctorId)
  {
    _db.Specialties.Add(specialty);
    _db.SaveChanges();
    if (DoctorId != 0)
    {
        _db.DoctorSpecialty.Add(new DoctorSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
    }
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Details(int id)
  {
    var thisSpecialties = _db.Specialties
      .Include(Specialties => Specialties.JoinEntities)
      .ThenInclude(join => join.Doctor)
      .FirstOrDefault(specialty => specialty.SpecialtyId == id);
    return View(thisSpecialties);
  }

  public ActionResult Edit(int id)
  {
    var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View(thisSpecialty);
  }

  [HttpPost]
  public ActionResult Edit(Specialty specialty, int DoctorId)
  {
    if (DoctorId != 0)
    {
      _db.DoctorSpecialty.Add(new DoctorSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
    }
    _db.Entry(specialty).State = EntityState.Modified;
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult AddDoctor(int id)
  {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisSpecialty);
  }

  [HttpPost]
  public ActionResult AddDoctor(Specialty specialty, int DoctorId)
  {
    if (DoctorId != 0)
    {
    _db.DoctorSpecialty.Add(new DoctorSpecialty() { DoctorId = DoctorId, SpecialtyId = specialty.SpecialtyId });
    }
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
    public ActionResult Delete(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteDoctor(int joinId)
    {
      var joinEntry = _db.DoctorSpecialty.FirstOrDefault(entry => entry.DoctorSpecialtyId == joinId);
      _db.DoctorSpecialty.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}