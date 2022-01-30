using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rstolsmark.WakeOnLanServer.Pages.PortForwarding.Model;

namespace Rstolsmark.WakeOnLanServer.Pages.PortForwarding;

public class CreatePortForwardingModel : PageModel
{
    private readonly IPortForwardingService _portForwardingService;

    public CreatePortForwardingModel(IPortForwardingService portForwardingService)
    {
        _portForwardingService = portForwardingService;
    }

    [BindProperty]
    public PortForwardingForm Form { get; set; }
    public void OnGet(string destinationIp)
    {
        Form = new PortForwardingForm
        {
            SourceIp = Request.HttpContext.Connection.RemoteIpAddress?.ToString(),
            DestinationIp = destinationIp
        };
    }
    public async Task<IActionResult> OnPostAsync()
    {
        await _portForwardingService.AddPortForwarding(new PortForwardingData(Form));
        return RedirectToPage("/PortForwarding/Index");
    }
}