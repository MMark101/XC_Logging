using StravaSharp;
using StravaSharp.Clients;
using StravaSharp.OAuth;


public class StravaController{
    
    private readonly StravaAuthService = _stravaAuthService;
    
    public StravaController(StravaAuthService stravaAuthService)
    {
        _stravaAuthService = stravaAuthService;
    }

    public IActionResult Authorize()
    {
        var redirectUri = "https://www.strava.com/oauth/authorize"; // Replace with your actual redirect URI
        var state = "some_state_value"; // You can generate a unique state value

        var authorizationUrl = _stravaAuthService.GetAuthorizationUrl(redirectUri, state);
        return Redirect(authorizationUrl);
    }

    public async Task<IActionResult> Callback(string code, string state)
    {
        // Ensure the state matches what you provided during authorization initiation
        // Handle errors, if any

        var accessTokenResponse = await _stravaAuthService.HandleCallbackAsync(code);

        // Use accessTokenResponse to interact with Strava API

        return View();
    }

        public async Task<IActionResult> GetAthleteData()
    {
        var athleteData = await _stravaApiService.GetAthleteDataAsync();

        // Process and display athlete data in the view or take other actions

        return View(athleteData);
    }

}