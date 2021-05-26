﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMarketPlace.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
        public ViewResult SellerProfileView()
        {
            return View("SellerProfileView");
        }
        public ViewResult BuyerProfileView()
        {
            return View("BuyerProfileView");
        }
        public ViewResult Search()
        {
            return View("Search");
        }
        public ViewResult SellerItems()
        {
            return View("SellerItems");
        }
        public ViewResult AddItem()
        {
            return View("ItemDetailsForm");
        }
        public ViewResult UpdateItem()
        {
            return View("ItemUpdateForm");
        }
        public ViewResult LogIn()
        {
            return View();
        }
        public ViewResult Choice()
        {
            return View();
        }
        public ViewResult Signup_Buyer()
        {
            return View();
        }
        public ViewResult SignUp_Seller()
        {
            return View();
        }
        public ViewResult ItemView()
        {
            return View();
        }
    }
}
