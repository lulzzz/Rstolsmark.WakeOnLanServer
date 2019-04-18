# Rstolsmark.WakeOnLanServer

Asp.Net Core Http server to enable wake on lan for computers behind a firewall.

## Requirements

 - .NET core 2.2 runtime

## Usage

Download the zip file from the release tab.

### Hosting on IIS

Unzip the contents into a website

### Adding a password
1. Generate a salted hashed password using Rstolsmark.PasswordHashTool
    1. ```bash
       dotnet tool install -g Rstolsmark.PasswordHashTool
       ```
    1. ```bash
       passwordhasher yourpassword
       ```
1. Add appsettings.Production.json to the root of the site
1. Add the content
```json
{
  "PasswordAuthenticationOptions":{
    "Realm": "Wake on lan server",
    "HashedPassword": "A hashed password generated by Rstolsmark.PasswordHashTool"
  }
}
```



