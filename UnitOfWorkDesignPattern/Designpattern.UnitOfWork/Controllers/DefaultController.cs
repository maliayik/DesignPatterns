using Designpattern.UnitOfWork.Models;
using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Designpattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {               
            return View();
        }

        /// <summary>
        /// Alıcı ve gönderici değerlerini modelden gelen değerleri update ediyoruz.
        /// </summary>       

        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            // Gönderen ve alıcı müşteri bilgilerini al
            var sender = _customerService.TGetByID(model.SenderID);
            var receiver = _customerService.TGetByID(model.ReceiverID);


            // Gönderenin bakiyesini güncelle
            sender.CustomerBalance -= model.Amount;
            // Alıcının bakiyesini güncelle
            receiver.CustomerBalance += model.Amount;

            // Güncellenmiş müşteri listesini oluştur
            List<Customer> modifiedCustomers = new List<Customer>()
            {
                  sender,
                 receiver
             };


            // Müşteri bilgilerini güncelle
            _customerService.TMultiUpdate(modifiedCustomers);

            // View'e yönlendir
            return View();
        }

    }
}
