using GolfStatsCosmosDB.Models;
using GolfStatsCosmosDB.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfStatsCosmosDB.Controllers
{
    public class ScoreController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;
        public ScoreController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetScoresAsync("SELECT * FROM c"));
        }

        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("Id, Hole1, Hole2, Hole3, Hole4, Hole5, Hole6, Hole7, Hole8, Hole9, Hole10, Hole11, Hole12, Hole13, Hole14, Hole15, Hole16, Hole17, Hole18, Total, Created")] Score score)
        {
            if (ModelState.IsValid)
            {
                score.Id = Guid.NewGuid().ToString();
                score.Created = DateTime.UtcNow;
                await _cosmosDbService.AddScoreAsync(score);
                return RedirectToAction("Index");
            }

            return View(score);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("Id,Name,Description,Completed")] Score score)
        {
            if (ModelState.IsValid)
            {
                await _cosmosDbService.UpdateScoreAsync(score.Id, score);
                return RedirectToAction("Index");
            }

            return View(score);
        }

        [ActionName("Edit")]
        public async Task<ActionResult> EditAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Score score = await _cosmosDbService.GetScoreAsync(id);
            if (score == null)
            {
                return NotFound();
            }

            return View(score);
        }

        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Score score = await _cosmosDbService.GetScoreAsync(id);
            if (score == null)
            {
                return NotFound();
            }

            return View(score);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync([Bind("Id")] string id)
        {
            await _cosmosDbService.DeleteScoreAsync(id);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {
            return View(await _cosmosDbService.GetScoreAsync(id));
        }
    }
}
