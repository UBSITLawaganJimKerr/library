using library.Data;
using library.Models;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers;

public class MembersController : Controller
{
    private readonly MemberRepository _members;

    // ASP.NET Core hands in the repository.
    public MembersController(MemberRepository members)
    {
        _members = members;
    }

    // GET /Members : the list of members.
    public async Task<IActionResult> Index()
    {
        var members = await _members.GetAllAsync();

        return View(members);
    }

    // GET /Members/Create : an empty form.
    public IActionResult Create()
    {
        return View(new Member());
    }

    // POST /Members/Create : the form was submitted.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Member member)
    {
        if (!ModelState.IsValid)
        {
            return View(member);
        }

        await _members.AddAsync(member);

        return RedirectToAction(nameof(Index));
    }

}