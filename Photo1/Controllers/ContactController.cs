﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Photo1.Models;

namespace Photo1.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if(ModelState.IsValid)
            {
                _contactRepository.AddContact(contact);
                return RedirectToAction("ContactComplete");
            }
            return View(contact);
        }

        public IActionResult ContactComplete()
        {
            return View();
        }
    }
}