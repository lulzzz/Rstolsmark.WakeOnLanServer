﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Rstolsmark.WakeOnLanServer.Pages.WakeOnLan.ComputerService;

namespace Rstolsmark.WakeOnLanServer.Pages.WakeOnLan;

public class IndexModel : PageModel
{
    public Dictionary<string, Computer> Computers { get; set; }
    public async Task OnGetAsync()
    {
        Computers = GetComputerDictionary();
        await PingAllComputers();
    }

    private Task PingAllComputers()
    {
        return Task.WhenAll(Computers.Values.Select(c => c.Ping()));
    }

    public IActionResult OnPost(string computerToWake)
    {
        Computers = GetComputerDictionary();
        //Use a discard since we don't need to await the wake up since it will not start up fast enough to reply to the next ping anyway
        _ = Computers[computerToWake].WakeUp();
        TempData["Message"] = $"Magic packet sent to computer {@computerToWake}. It can take some time before it wakes up since it needs to boot first.";
        return RedirectToPage("/Index");
    }
}