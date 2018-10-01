using System;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;
    namespace DojoSurvey.Controllers     
    {
        public class DojoController : Controller   
        {
            
            [HttpGet]       
            [Route("")]     
            public IActionResult Index()
            {
                Dojo info = new Dojo(){
                    dojo = new string[]{"San Jose", "Seattle", "Dallas"},
                    lang = new string[]{"python", "C#", "Javascript"}
                };


                return View("index", info);    
            }



            [HttpPost]       
            [Route("created")]     
            public IActionResult Created(string Language, string Location,string Name, string Comment)
            {
                Dojo final = new Dojo(){
                    name = Name,
                    comment = Comment,
                    language = Language,
                    location = Location
                };
                
                return View("created", final);   
            }
        }
    }
    