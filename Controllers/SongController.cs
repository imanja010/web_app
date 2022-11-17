﻿using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : Controller
    {
        private SongService _songService;

        public SongController(SongService  songService)
        {
            _songService = songService;
        }
        [HttpGet("{id:long}")]
        public Song Get(long id)
        {
           Song result = _songService.GetSong(id);
           return result;
        }
        [HttpGet()]
        public List<Song> Get()
        {
            List<Song> result = _songService.GetAll();
            return result;
        }
    }
}
