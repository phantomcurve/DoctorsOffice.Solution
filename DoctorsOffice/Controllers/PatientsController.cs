using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;

namespace DoctorsOffice.Controllers
{
  public class PatientsController : Controller
  {
    private readonly DoctorsOfficeContext _db;

    public PatientsController(DoctorsOfficeContext db)
    {
      _db = db;
    }

   public ActionResult Index()
  {
      return View(_db.Patients.ToList());
  }

  public ActionResult Create()
  {
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View();
  }

  [HttpPost]
  public ActionResult Create(Patient patient, int DoctorId)
  {

     bool isUnique = true;
      List<Patient> PatientList = _db.Patients.ToList();
      foreach(Patient iteration in PatientList)
      {
        if (patient.Name == iteration.Name) 
        {
          isUnique = false;
          ModelState.AddModelError("DuplicateName", patient.Name + " Is already enrolled");
          ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
          return View();
        }
      }
      if (isUnique)
      {
        _db.Patients.Add(patient);
        _db.SaveChanges();
        if (DoctorId != 0)
        {
          _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
        }
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    // if (ModelState.IsValid) {
    // _db.Patients.Add(patient);
    // _db.SaveChanges();
    // if (DoctorId != 0)
    // {
    //     _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
    // }
    // }
    // _db.SaveChanges();
    // return RedirectToAction("Index");
    
  }

  public ActionResult Details(int id)
  {
    var thisPatients = _db.Patients
      .Include(Patients => Patients.JoinEntities)
      .ThenInclude(join => join.Doctor)
      .FirstOrDefault(patient => patient.PatientId == id);
    return View(thisPatients);
  }

  public ActionResult Edit(int id)
  {
    var thisPatient = _db.Patients.FirstOrDefault(patient => patient.PatientId == id);
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View(thisPatient);
  }

  [HttpPost]
  public ActionResult Edit(Patient patient, int DoctorId)
  {
    if (DoctorId != 0)
    {
      _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
    }
    _db.Entry(patient).State = EntityState.Modified;
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult AddDoctor(int id)
  {
      var thisPatient = _db.Patients.FirstOrDefault(patient => patient.PatientId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisPatient);
  }

  [HttpPost]
  public ActionResult AddDoctor(Patient patient, int DoctorId)
  {
    if (DoctorId != 0)
    {
      if(_db.DoctorPatient.Any(dp => dp.DoctorId == DoctorId && dp.PatientId == patient.PatientId) == false)
      {
        _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
        ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      }
      return View();
    }
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
    public ActionResult Delete(int id)
    {
      var thisPatient = _db.Patients.FirstOrDefault(patient => patient.PatientId == id);
      return View(thisPatient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPatient = _db.Patients.FirstOrDefault(patient => patient.PatientId == id);
      _db.Patients.Remove(thisPatient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteDoctor(int joinId)
    {
      var joinEntry = _db.DoctorPatient.FirstOrDefault(entry => entry.DoctorPatientId == joinId);
      _db.DoctorPatient.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}