
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Final_Project_Games.Models;

namespace Final_Project_Games.Models
{
    public class GameModel : PageModel
    {
        private readonly GameContext _context;
        private readonly ILogger<GameModel> _logger;
        [BindProperty]
        public Game Game {get; set;}

        public GameModel(GameContext context, ILogger<GameModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {

        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Games.Add(Game);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}